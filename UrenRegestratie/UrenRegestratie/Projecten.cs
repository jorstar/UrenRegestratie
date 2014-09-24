using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrenRegestratie
{
    public class Projecten
    {

        public int ProjectID { get; set; }

        public string Projectnaam { get; set; }

        public string Projectomschrijving { get; set; }

        public DateTime Begindatum { get; set; }

        public DateTime Einddatum { get; set; }

        public bool Afgesloten { get; set; }

    }
}
