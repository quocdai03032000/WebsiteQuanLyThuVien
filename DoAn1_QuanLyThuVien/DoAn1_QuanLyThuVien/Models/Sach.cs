//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn1_QuanLyThuVien.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            this.DKyMuonSaches = new HashSet<DKyMuonSach>();
            this.Sach_Dang_Muon = new HashSet<Sach_Dang_Muon>();
        }
    
        public int id { get; set; }
        public int SoKiemSoat { get; set; }
        public Nullable<int> MaDauSach { get; set; }
        public Nullable<int> MaTinhTrangSach { get; set; }
        public string GhiChu { get; set; }
    
        public virtual DauSach DauSach { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DKyMuonSach> DKyMuonSaches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach_Dang_Muon> Sach_Dang_Muon { get; set; }
        public virtual TinhTrangSach TinhTrangSach { get; set; }
    }
}
