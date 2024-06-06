using Backend.Models;
using Backend.Repositories.Data;

namespace Backend.Repositories.Interfaces
{
    public interface IAssetRepository
    {
        public int Insert(TblProduct product);
        public IEnumerable<TblProduct> Get();
        public TblProduct Get(int Id);
        public int Update(TblProduct product);
        public int Delete(int Id);
    }
}
