using DAL.Repositories.OgrenciWriteRepository;
using OkulApp.BLL.Contexts;
using OkulApp.MODEL;

namespace OkulApp.BLL.Repositories.OgrenciRepository
{
    public class OgrenciWriteRepository : WriteRepository<Ogrenci>, IOgrenciWriteRepository
    {
        public OgrenciWriteRepository(AppDBContext context) : base(context)
        {
        }
    }
}
