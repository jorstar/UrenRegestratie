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
    
    public partial class Project
    {
        public Project()
        {
            this.Regestraties = new HashSet<Regestratie>();
            this.taaks = new HashSet<taak>();
            this.user_taak = new HashSet<user_taak>();
        }
    
        public int ID { get; set; }
        public string naam { get; set; }
        public string omschrijving { get; set; }
        public System.DateTime beginDatum { get; set; }
        public Nullable<System.DateTime> eindDatum { get; set; }
        public bool afgesloten { get; set; }
    
        public virtual ICollection<Regestratie> Regestraties { get; set; }
        public virtual ICollection<taak> taaks { get; set; }
        public virtual ICollection<user_taak> user_taak { get; set; }
    }
}
