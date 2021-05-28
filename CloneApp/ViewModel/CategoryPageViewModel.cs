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
        private int page = 0;
        private int pagesize = 6;
        public Command LoadMore { get; set; }
        public ObservableRangeCollection<ShoesItems> SshoesItems { get; set; }
        public ObservableCollection<Category> categories { get; set; }
        public CategoryPageViewModel()
        {
            SshoesItems = new ObservableRangeCollection<ShoesItems>();
            categories = new ObservableCollection<Category>();
            LoadMore = new Command(async () => await LoadMoreItem());
            GetCate();
            GetItems();
        }
        private async Task LoadMoreItem()
        {
            if (IsBusy)
                return;
            IsBusy = true;
            await Task.Delay(2000);
            SshoesItems.AddRange(SshoesItems.Skip(page * pagesize).Take(pagesize).ToList());
            pagesize += page;
            IsBusy = false;
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
            var data = await MockDataStore.GetItemsDelay(0);
            foreach (var items in data.Take(pagesize))
            {
                SshoesItems.Add(items);
            }
            TotalItems = SshoesItems.Count();
        }
    }
}
