using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFDB {
    public class Classes {
        public class Product {
            public int Id { get; set; }
            public string Name { get; set; }
            public Company Company { get; set; }
            public List<ProductEquipment> EquipmentOwned { get; set; }
        }

        public class Company {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public List<Product> Products { get; set; }
        }

        public class ProductEquipment {
            public int Id { get; set; }
            public string Name { get; set; }
            public Product Product { get; set; }
        }
    }
}