//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcStok.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TBLURUNLER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLURUNLER()
        {
            this.TBLSATISLARs = new HashSet<TBLSATISLAR>();
        }
    
        public int URUNID { get; set; }
        [Required(ErrorMessage = "Urun Ad� Giriniz")]
        [StringLength(25, ErrorMessage = "Urun Ad� En Fazla 50 Karakter olabilir.")]
        public string URUNAD { get; set; }
        [Required(ErrorMessage = "Urun Markas� Giriniz")]
        [StringLength(25, ErrorMessage = "Urun Markas� En Fazla 50 Karakter olabilir.")]
        public string MARKA { get; set; }
        [Required(ErrorMessage = "Fiyat  Giriniz")]
        [Range(1, 1000, ErrorMessage = "Fiyat 1 Tl ile 1000 Tl aras�nda olabilir.")]
        public Nullable<short> URUNKATEGORI { get; set; }
        [Required(ErrorMessage = "Stok Adedi Giriniz")]
        [Range(1, 1000, ErrorMessage = "Stok Miktar� 1 ile 1000 adet aras�nda olabilir.")]
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<byte> STOK { get; set; }
        public bool isActive { get; set; }
    
        public virtual TBLKATEGORILER TBLKATEGORILER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSATISLAR> TBLSATISLARs { get; set; }
    }
}
