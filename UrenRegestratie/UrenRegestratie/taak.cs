//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UrenRegestratie
{
    using System;
    using System.Collections.Generic;
    
    public partial class taak
    {
        public taak()
        {
            this.user_taak = new HashSet<user_taak>();
        }
    
        public int taakID { get; set; }
        public int projectID { get; set; }
        public string naam { get; set; }
        public string omschrijving { get; set; }
    
        public virtual Project Project { get; set; }
        public virtual ICollection<user_taak> user_taak { get; set; }
    }
}
