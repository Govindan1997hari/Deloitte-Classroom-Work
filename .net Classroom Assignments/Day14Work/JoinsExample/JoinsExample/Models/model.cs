//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JoinsExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class model
    {
        public int modelid { get; set; }
        public string modelname { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> prodid { get; set; }
    
        public virtual product product { get; set; }
    }
}
