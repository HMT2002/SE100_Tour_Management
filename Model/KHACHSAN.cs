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
    
    public partial class KHACHSAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHSAN()
        {
            this.tb_KHACHSAN = new HashSet<tb_KHACHSAN>();
        }
    
        public string ID { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public byte[] PICBI { get; set; }
        public string CHITIET { get; set; }
        public Nullable<decimal> GIA { get; set; }
        public string IDTINH { get; set; }
        public string TEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_KHACHSAN> tb_KHACHSAN { get; set; }
        public virtual TINH TINH { get; set; }
    }
}
