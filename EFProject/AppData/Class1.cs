using System.Data.Entity;
using EFDB;

namespace AppData {
    public class AppContext : DbContext
    {
        public DbSet<Classes.Product> Products { get; set; }
        public DbSet<Classes.Company> Companys { get; set; }
        public DbSet<Classes.ProductEquipment> Equipment { get; set; }
    }
}
