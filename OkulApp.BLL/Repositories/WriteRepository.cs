﻿using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OkulApp.BLL.Contexts;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OkulApp.BLL.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseModel
    {
        private readonly AppDBContext _context;
        public WriteRepository(AppDBContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }



        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }
        public bool RemoveRange(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }
        public async Task<bool> RemoveAsync(string id)
        {
            T model = await Table.FirstOrDefaultAsync(d => d.Id == Guid.Parse(id));
            return Remove(model);

        }
        public bool Update(T model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
