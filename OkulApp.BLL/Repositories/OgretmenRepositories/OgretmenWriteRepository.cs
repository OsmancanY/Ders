using DAL.Entities;
using DAL.Repositories.OgretmenRepository;
using OkulApp.BLL.Contexts;


namespace OkulApp.BLL.Repositories.OgretmenRepositories
{
    public class OgretmenWriteRepository : WriteRepository<Ogretmen>, IOgretmenWriteRepository
    {
        public OgretmenWriteRepository(AppDBContext context) : base(context)
        {
        }
    }
}
