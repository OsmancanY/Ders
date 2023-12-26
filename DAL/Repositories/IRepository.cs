using Microsoft.EntityFrameworkCore;
using OkulApp.MODEL;

namespace DAL.Repositories
{
    public interface IRepository<T> where T : BaseModel
    {
        DbSet<T> Table
        {
            get;
        }
    }
}
