using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CloneApp.Model;
using CloneApp.Services;
using Xamarin.Forms;

namespace CloneApp.ViewModel
{
    public class CategoryViewModel : BaseViewModel
    {
        public ObservableCollection<ShoesItems> ShoesItemsByCate { get; set; }
        public Command _BackAsync { set; get; }
        private Category _SelectedItem;
        private int _TotalItems;
        private string _Name;

        public  async Task BackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }
        public Category SelectedItem
        {
            get
            {
                return _SelectedItem;
            }
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
            }
        }
        public int TotalItems
        {
            get
            {
                return _TotalItems;
            }
            set
            {
                _TotalItems = value;
                OnPropertyChanged();
            }
        }

        public CategoryViewModel(Category category)
        {
            SelectedItem = category;
            ShoesItemsByCate = new ObservableCollection<ShoesItems>();
            GetShoesItemsByCate(category.CateID);
            GetNameCate(category.CateID);
            _BackAsync = new Command( async () => await BackAsync());
        }

        public void GetShoesItemsByCate(int id)
        {
            ShoesItemsByCate.Clear();
            var data = new MockDataStore().Getshoes();
            foreach(var item in data.Where(x => x.CateID == id))
            {
                ShoesItemsByCate.Add(item);
            }
            TotalItems = ShoesItemsByCate.Count();
        }
        public void GetNameCate(int id)
        {
            var data = new CategoryServices().GetCategories();
            foreach(var item in data.Where(x => x.CateID == id))
            {
                Name = item.Name;
            }
        }
    }
}
