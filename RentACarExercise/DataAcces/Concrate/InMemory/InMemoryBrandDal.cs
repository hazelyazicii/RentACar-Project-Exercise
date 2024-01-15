

using DataAcces.Abstract;
using Entities.Concrate;

namespace DataAcces.Concrate.InMemory;

public class InMemoryBrandDal : IBrandDal
{
    private readonly HashSet<Brand> _brands = new();
    public void Add(Brand entity)
    {
        entity.CreatedAt = DateTime.UtcNow;
        _brands.Add(entity);
    }

    public void Delete(Brand entity)
    {
        entity.DeletedAt = DateTime.UtcNow;
        
    }

    public Brand? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public IList<Brand> GetList()   
    {
        throw new NotImplementedException();
    }

    public void Update(Brand entity) 
    {
        throw new NotImplementedException();
    }

    public List<Brand> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Delete(IBrandDal brand)
    {
        throw new NotImplementedException();
    }
}
