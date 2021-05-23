using System;
using System.Collections.ObjectModel;
using CloneApp.Model;
using CloneApp.Services;
using System.Diagnostics;
using Xamarin.Forms;
using System.Linq;

namespace CloneApp.ViewModel
{
    public class CategoryPageViewModel : BaseViewModel
    {
        private int _TotalItems;
        private string _Searchstring;
        public Command SearchCommand { get; set; }
        private ObservableCollection<ShoesItems> _ShoesItemslist { get; set; }
        public ObservableCollection<ShoesItems> SshoesItems { get; set; }
        public ObservableCollection<Category> categories { get; set; }
        public CategoryPageViewModel()
        {
            SshoesItems = new ObservableCollection<ShoesItems>();
            categories = new ObservableCollection<Category>();
            ShoesItemList = new ObservableCollection<ShoesItems>();
            SearchCommand = new Command(() =>  Search());
            GetCate();
            GetItems();
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
        public void GetItems()
        {
            SshoesItems.Clear();
            var data = new MockDataStore().Getshoes();
            foreach(var items in data)
            {
                SshoesItems.Add(items);
            }
            TotalItems = SshoesItems.Count();
        }
    }
}
