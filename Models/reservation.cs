//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace termProj.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Table_no_ { get; set; }
        public System.DateTime Time { get; set; }
        public int UserId { get; set; }
    
        public virtual User2 User2 { get; set; }
    }
}
