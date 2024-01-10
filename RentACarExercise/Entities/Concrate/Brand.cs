
using Core.Entities;

namespace Entities.Concrate;

public class Brand : Entity<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
}
