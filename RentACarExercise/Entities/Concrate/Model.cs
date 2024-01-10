
using Core.Entities;

namespace Entities.Concrate;

internal class Model : Entity<int>
{
    public int Id { get; set; }
    public int BrandId {get; set;}
    public string Name { get; set; }
    public short Year { get; set; }
    public Brand? Brand { get; set; } = null;


}
