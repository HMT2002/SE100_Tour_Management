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
    
    public partial class DOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOAN()
        {
            this.tb_DOAN = new HashSet<tb_DOAN>();
            this.tb_KHACHSAN = new HashSet<tb_KHACHSAN>();
            this.tb_NHIEMVU = new HashSet<tb_NHIEMVU>();
            this.tb_PHUONGTIEN = new HashSet<tb_PHUONGTIEN>();
            this.tb_PHUTRACH = new HashSet<tb_PHUTRACH>();
        }
    
        public string ID { get; set; }
        public string TEN { get; set; }
        public Nullable<System.DateTime> NGAYKHOIHANH { get; set; }
        public Nullable<System.DateTime> NGAYKETTHUC { get; set; }
        public string CHITIETCHUONGTRINH { get; set; }
        public string IDCHIPHI { get; set; }
        public string IDTOUR { get; set; }
    
        public virtual CHIPHI CHIPHI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_DOAN> tb_DOAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_KHACHSAN> tb_KHACHSAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NHIEMVU> tb_NHIEMVU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PHUONGTIEN> tb_PHUONGTIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PHUTRACH> tb_PHUTRACH { get; set; }
        public virtual TOUR TOUR { get; set; }
    }
}
