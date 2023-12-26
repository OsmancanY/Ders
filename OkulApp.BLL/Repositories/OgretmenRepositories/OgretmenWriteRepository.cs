using DAL.Repositories.OgretmenRepository;
using OkulApp.BLL.Contexts;
using OkulApp.MODEL;

namespace OkulApp.BLL.Repositories.OgretmenRepositories
{
    public class OgretmenWriteRepository : WriteRepository<Ogretmen>, IOgretmenWriteRepository
    {
        public OgretmenWriteRepository(AppDBContext context) : base(context)
        {
        }
    }
}
