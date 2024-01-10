


namespace Core.DataAccess;

public interface EntityRepository<Tentity, TEntityId>
{
    public List<TEntity> GetAll();
    public TEntity? GetById(int id);
    public void Add(TEntity entity);
    public void Update(TEntity entity);
    public void Delete(TEntity entity);
    
}
