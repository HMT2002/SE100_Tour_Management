//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tour.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_KHACHSAN
    {
        public string ID { get; set; }
        public string IDDOAN { get; set; }
        public string IDKHACHSAN { get; set; }
    
        public virtual DOAN DOAN { get; set; }
        public virtual KHACHSAN KHACHSAN { get; set; }
    }
}
