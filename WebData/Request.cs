//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int ID { get; set; }
        public Nullable<int> SenderID { get; set; }
        public Nullable<int> RecieverID { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
        public virtual UserInfo UserInfo1 { get; set; }
    }
}
