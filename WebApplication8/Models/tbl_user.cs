//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication8.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_user
    {
        public tbl_user()
        {
            this.tbl_product = new HashSet<tbl_product>();
        }
    
        public int u_id { get; set; }
        public string u_name { get; set; }
        public string u_email { get; set; }
        public string u_password { get; set; }
        public string u_image { get; set; }
        public string u_contact { get; set; }
    
        public virtual ICollection<tbl_product> tbl_product { get; set; }
    }
}
