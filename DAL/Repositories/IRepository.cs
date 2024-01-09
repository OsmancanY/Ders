using Microsoft.EntityFrameworkCore;
using OkulApp.MODEL;
using System;

namespace DAL.Repositories
{
    public interface IRepository<T> : IDisposable where T : BaseModel
    {
        DbSet<T> Table
        {
            get;
        }
    }
}
