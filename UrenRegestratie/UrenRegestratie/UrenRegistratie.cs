using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrenRegestratie
{
    public class UrenRegistratie
    {

        public int UserId { get; set; }

        public int ProjectId { get; set; }

        public int TaakID { get; set; }

        public DateTime Datum { get; set; }

        public int UrenID { get; set; }

        public string Verantwoording { get; set; }

        public int AantalUren { get; set; }

    }
}
