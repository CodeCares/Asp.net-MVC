//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Work_Shedule
    {
        public int Shedule_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Operator_Name { get; set; }
        public string Reason { get; set; }
        public string Cost { get; set; }
        public Nullable<int> Client_ID { get; set; }
    
        public virtual Individual_Client Individual_Client { get; set; }
    }
}
