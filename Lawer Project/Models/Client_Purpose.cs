//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lawer_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client_Purpose
    {
        public int Purpose_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Reason { get; set; }
        public Nullable<int> Client_ID { get; set; }
    
        public virtual Individual_Client Individual_Client { get; set; }
    }
}
