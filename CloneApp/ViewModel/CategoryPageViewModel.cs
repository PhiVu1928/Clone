using System;
using System.Collections.ObjectModel;
using CloneApp.Model;
using CloneApp.Services;
using System.Diagnostics;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using MvvmHelpers;

namespace CloneApp.ViewModel
{
    public class CategoryPageViewModel : BaseViewModel
    {
        private int _TotalItems;
        private string _Searchstring;
        private int page = 0;
        private int pagesize = 10;
        public Command SearchCommand { get; set; }
        public Command LoadMore { get; set; }
        private ObservableCollection<ShoesItems> _ShoesItemslist { get; set; }
        public ObservableRangeCollection<ShoesItems> SshoesItems { get; set; }
        public ObservableCollection<Category> categories { get; set; }
        public CategoryPageViewModel()
        {
            SshoesItems = new ObservableRangeCollection<ShoesItems>();
            categories = new ObservableCollection<Category>();
            ShoesItemList = new ObservableCollection<ShoesItems>();
            SearchCommand = new Command(() =>  Search());
            LoadMore = new Command(async () => await LoadMoreItem());
            GetCate();
            GetItems();
        }

        private async Task LoadMoreItem()
        {
            if (IsBusy)
                return;
            IsBusy = true;
            await Task.Delay(1000);
            SshoesItems.AddRange(SshoesItems.Skip(page * pagesize).Take(pagesize).ToList());
            pagesize += page;
            IsBusy = false;
        }

        private async void Search()
        {
            try
            {
                var data = _ShoesItemslist.Where(x => x.Name.Contains(SearchString));
                ShoesItemList.Clear();
                foreach (var items in data)
                {
                    ShoesItemList.Add(items);
                }
                await Application.Current.MainPage.DisplayAlert("Search", "Wait A Sec", "OK");
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
            
        }
        
        public string SearchString
        {
            get
            {
                return _Searchstring;
            }
            set
            {
                _Searchstring = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<ShoesItems> ShoesItemList
        {
            get
            {
                return _ShoesItemslist;
            }
            set
            {
                _ShoesItemslist = value;
                OnPropertyChanged();
            }
        }

        public int TotalItems
        {
            get { return _TotalItems; }
            set
            {
                _TotalItems = value;
                OnPropertyChanged();
            }
        }
        public void GetCate()
        {
            categories.Clear();
            var data = new CategoryServices().GetCategories();
            foreach (var item in data)
            {
                categories.Add(item);
            }
        }
        public async void GetItems()
        {
            SshoesItems.Clear();
            var data = await MockDataStore.GetItemsDelay(1000);
            foreach(var items in data.Take(pagesize))
            {
                SshoesItems.Add(items);
            }
            TotalItems = SshoesItems.Count();
        }
    }
}
