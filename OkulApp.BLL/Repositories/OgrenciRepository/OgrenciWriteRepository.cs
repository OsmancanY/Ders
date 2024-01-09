using DAL.Entities;
using DAL.Repositories;
using DAL.Repositories.OgrenciWriteRepository;
using Microsoft.EntityFrameworkCore;
using OkulApp.BLL.Contexts;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace OkulApp.BLL.Repositories.OgrenciRepository
{
    public class OgrenciWriteRepository : WriteRepository<Ogrenci>, IOgrenciWriteRepository
    {
        public OgrenciWriteRepository(AppDBContext context) : base(context)
        {
        }

        DbSet<DAL.Entities.Ogrenci> IRepository<DAL.Entities.Ogrenci>.Table => throw new System.NotImplementedException();

        public Task<bool> AddAsync(DAL.Entities.Ogrenci model)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> AddRangeAsync(List<DAL.Entities.Ogrenci> model)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(DAL.Entities.Ogrenci model)
        {
            throw new System.NotImplementedException();
        }

        public bool RemoveRange(List<DAL.Entities.Ogrenci> model)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(DAL.Entities.Ogrenci model)
        {
            throw new System.NotImplementedException();
        }
    }
}
