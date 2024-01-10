
using Entities.Concrate;
namespace DataAcces.Abstract;

public interface IBrandDal
{  public List<Brand> GetAll();
   public Brand? GetById(int id);
  public void Add(Brand brand);
   public void Update(Brand brand);
  public void Delete(IBrandDal brand);

}
