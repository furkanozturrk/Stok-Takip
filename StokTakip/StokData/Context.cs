using StokDataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokData
{
    public class Context:DbContext
    {
        public Context()
        {
            Database.SetInitializer(new MyInitializer());
        }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Müsteri> Müsteriler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
