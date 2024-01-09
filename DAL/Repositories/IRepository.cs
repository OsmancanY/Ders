using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL.Repositories
{
    public interface IRepository<T> : IDisposable where T : BaseEntity
    {
        DbSet<T> Table
        {
            get;
        }
    }
}
