//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class setsLog
    {
        public int ID { get; set; }
        public int setID { get; set; }
        public Nullable<int> setReps { get; set; }
        public Nullable<int> setWeight { get; set; }
    
        public virtual workoutLog workoutLog { get; set; }
    }
}