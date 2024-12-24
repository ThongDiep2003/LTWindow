namespace QLThietBi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Phong
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaThietBi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay { get; set; }

        public int? SoLuong { get; set; }

        public virtual Phong Phong { get; set; }

        public virtual ThietBi ThietBi { get; set; }
    }
}
