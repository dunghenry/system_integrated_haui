using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace API.Models
{
    public partial class QLNV : DbContext
    {
        public QLNV()
            : base("name=QLNV")
        {
        }

        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>()
                .Property(e => e.HsLuong)
                .HasPrecision(3, 2);
        }
    }
}
