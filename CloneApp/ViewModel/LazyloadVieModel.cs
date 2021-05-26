using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

using CloneApp.Model;
using CloneApp.Services;
using System.Diagnostics;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Linq;
using MvvmHelpers;

namespace CloneApp.ViewModel
{
    public class LazyloadVieModel : BaseViewModel
    {
        private int pagesize = 5;
        private int page = 0;

        public Command LoadMoreItems { get; set; }
        public ObservableRangeCollection<ShoesItems> ShoesItems { get; set; }
        public ObservableRangeCollection<ShoesItems> ShoesItemsToDisplay { get; set; }
      
        public LazyloadVieModel()
        {
            ShoesItems = new ObservableRangeCollection<ShoesItems>();
            LoadMoreItems = new Command(async () => await LoadMore());
            Loadingitem();
        }

        private async Task LoadMore()
        {
            if (IsBusy)
                return;
            IsBusy = true;
            await Task.Delay(2000);
            ShoesItems.AddRange(ShoesItems.Skip(page * pagesize).Take(pagesize));
            pagesize += page;
            IsBusy = false;
        }

        public void Loadingitem()
        {
            try
            {
                ShoesItems.Clear();
                var data = new MockDataStore().Getshoes();
                foreach(var items in data.Take(pagesize))
                {
                    ShoesItems.Add(items);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
