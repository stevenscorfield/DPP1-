//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookCollection
{
    using System;
    using System.Collections.Generic;
    
    public partial class ISBN
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public Nullable<int> TitleID { get; set; }
    
        public virtual Title Title { get; set; }
    }
}
