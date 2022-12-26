using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TranVanDung_2019603537.Models
{
    public partial class CSDL : DbContext
    {
        public CSDL()
            : base("name=CSDL")
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
