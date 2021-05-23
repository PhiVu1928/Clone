using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloneApp.Model;

namespace CloneApp.Services
{

    public class CategoryServices 
    {
        ObservableCollection<Category> categories { get; set; }
        ObservableCollection<ProductSize> productSizes { get; set; }
        public ObservableCollection<Category> GetCategories()
        {
            categories = new ObservableCollection<Category>()
            {
                new Category { CateID = 1, Name = "Jordan", Image = "https://i.pinimg.com/originals/e3/7b/c6/e37bc6bbc9f37deb0e56d193864e4a29.png" },
                new Category { CateID = 2, Name = "Nike", Image = "https://i.pinimg.com/originals/9c/d1/bf/9cd1bf6c2d1a88e8ac473f62a2898c62.png"},
                new Category { CateID = 3, Name = "Adidas", Image = "https://brandslogos.com/wp-content/uploads/images/large/adidas-logo.png" },
                new Category { CateID = 4, Name = "Gucci", Image = "https://gudlogo.com/wp-content/uploads/2019/11/bieu-tuong-logo-gucci.jpg" },
                new Category { CateID = 5, Name = "Louis Vutton", Image = "https://i.pinimg.com/originals/df/95/31/df953177f0bb5d6d93717bed7d05033d.png" },
            };
            return categories;
        }              
        public ObservableCollection<ProductSize> GetProductSizes()
        {
            productSizes = new ObservableCollection<ProductSize>()
            {
                new ProductSize{ItemSize = 6},
                new ProductSize{ItemSize = 7},
                new ProductSize{ItemSize = 8},
                new ProductSize{ItemSize = 9},
                new ProductSize{ItemSize = 10},
                new ProductSize{ItemSize = 11},
                new ProductSize{ItemSize = 12},
            };
            return productSizes;
        }

        
    }
}
