using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OkulApp.MODEL;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OkulApp.BLL.Contexts
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Ogretmen> Ogretmens { get; set; }
        public DbSet<Ogrenci> Ogrencis { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            var datas = ChangeTracker.Entries<BaseModel>();
            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedDate = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        data.Entity.UpdatedDate = DateTime.UtcNow;
                        break;
                    default:
                        //bura boş çünkü eger data silinirse herhangi bir veri tabanı işlemi yapmamalı yoksa silinmiş data işlenemeyeceginden hata verir
                        break;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
