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
    
    public partial class tb_DIADIEM_DULICH
    {
        public string ID { get; set; }
        public string IDTOUR { get; set; }
        public string IDDIADIEM { get; set; }
    
        public virtual DIADIEM DIADIEM { get; set; }
        public virtual TOUR TOUR { get; set; }
    }
}