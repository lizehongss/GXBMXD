using GXXD.Domain.Entities;
using System.Data.Entity;

namespace GXXD.Domain.Concrete
{
    public class EFDContext : DbContext
    {
        public DbSet<Grand> Grands { get; set; }
    }
}
