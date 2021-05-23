using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CloneApp.Model;
using System.Linq;
using CloneApp.Services;
using Xamarin.Forms;

namespace CloneApp.ViewModel
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<ShoesItems> shoesItems { get; }
        public ObservableCollection<ShoesItems> shoesItemsTop { get; }
        public Command ViewCartCommand { get; set; }
        public Command ViewSearchCommand { get; set; }
        public MainPageViewModel()
        {
            shoes = GetShoes();
            shoesItems =  new ObservableCollection<ShoesItems>();
            shoesItemsTop =  new ObservableCollection<ShoesItems>();
            brands = GetBrands();
            GetShoesItems();
            GetShoesItemsTop();
            ViewSearchCommand = new Command(async () => await ViewSearch());
        }

        private async Task ViewSearch()
        {
            await Shell.Current.GoToAsync("Search");
        }

      

        private void GetShoesItems()
        {
            var data = new MockDataStore().Getshoes();
            foreach(var item in data)
            {
                shoesItems.Add(item);
            }
        }
        private void GetShoesItemsTop()
        {
            var data = new MockDataStore().Getshoes();
            foreach (var item in data.OrderByDescending(x => x.Price))
            {
                shoesItemsTop.Add(item);
            }
        }

        ObservableCollection<Brands> brands;
        public ObservableCollection<Brands> Brands
        {
            get { return brands; }
            set
            {
                brands = value;
                OnPropertyChanged();
            }
        }
        
        public ObservableCollection<Brands> GetBrands()
        {
            return new ObservableCollection<Brands>
            {
                new Brands
                {
                    Image = "https://i.pinimg.com/originals/9c/d1/bf/9cd1bf6c2d1a88e8ac473f62a2898c62.png"
                },
                new Brands
                {
                    Image = "https://brandslogos.com/wp-content/uploads/images/large/adidas-logo.png"
                },
                new Brands
                {
                    Image = "https://i.pinimg.com/originals/e3/7b/c6/e37bc6bbc9f37deb0e56d193864e4a29.png"
                },
                new Brands
                {
                    Image = "https://i.pinimg.com/originals/df/95/31/df953177f0bb5d6d93717bed7d05033d.png"
                },
                new Brands
                {
                    Image = "https://i.pinimg.com/originals/e3/7b/c6/e37bc6bbc9f37deb0e56d193864e4a29.png"
                },
                new Brands
                {
                    Image = "https://i.pinimg.com/originals/df/95/31/df953177f0bb5d6d93717bed7d05033d.png"
                }
            };
        }

        ObservableCollection<Shoes> shoes;
        public ObservableCollection<Shoes> Shoes {
            get { return shoes; }
            set
            {
                shoes = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Shoes> GetShoes()
        {
            return new ObservableCollection<Shoes>
            {
                new Shoes { Image = "https://www.buystylegoods.net/image/catalog/aj_1024x1024.png" },
                new Shoes { Image = "https://ubuykw.s3.amazonaws.com/ubuy/wysiwyg/1557135417_jorden_banner.jpg" },
                new Shoes { Image = "https://24segons.files.wordpress.com/2015/05/banner-jordan1-chicago-20150528.jpg" },
            };
        }
    }
}
