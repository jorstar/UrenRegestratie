using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrenRegestratie
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //programma sluiten
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            //connection string ophalen uit web.config
            string cs = ConfigurationManager.ConnectionStrings["urenRegestratieEntities"].ConnectionString;

            //connectie maken
            SqlConnection conn = new SqlConnection(cs);

            //bereken hash voor wachtwoord
            string spw2 = CalculateHashedPassword(tbPassword.Text, tbUsername.Text);

            //maak een sql command
            //gebruik maken van stored procedure
            SqlCommand cmd = new SqlCommand("logincheck", conn);
            //type veranderen naar stored procedure
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //parameters vullen
            cmd.Parameters.AddWithValue("@u", tbUsername.Text);
            cmd.Parameters.AddWithValue("@p", spw2);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        lblError.Text = "Onjuiste inloggegevens";
                        tbPassword.Text = "";
                        tbPassword.Focus();
                    }
                    else
                    {
                        reader.Read();


                    }
                }

            }
            catch (SqlException sqlEx)
            {
                lblError.Text = sqlEx.Message;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }

        }

        private static string CalculateHashedPassword(string clearpwd, string loginnaam)
        {

            using (var sha = SHA256.Create())
            {

                var computedHash = sha.ComputeHash(Encoding.Unicode.GetBytes(clearpwd + loginnaam.ToUpper()));

                return Convert.ToBase64String(computedHash);

            }

        }
    }
}
