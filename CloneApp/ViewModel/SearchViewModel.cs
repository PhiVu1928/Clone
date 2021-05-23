using System;
using CloneApp.Model;
using CloneApp.Services;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;

namespace CloneApp.ViewModel
{
    public class SearchViewModel : BaseViewModel
    {
        private string _SearchString;
        private int _Total;
        public Command SearchCommand { get; set; }
        public ObservableCollection<ShoesItems> Shoesitems { get; set; }
        public ObservableCollection<ShoesItems> SearchResult { get; set; }
        public SearchViewModel()
        {
            Shoesitems = new ObservableCollection<ShoesItems>();
            SearchResult = new ObservableCollection<ShoesItems>();
            SearchCommand = new Command(() => GetItemSearch());
        }
        public void GetResult()
        {
            SearchResult.Clear();
            var data = new MockDataStore().Getshoes();
            foreach(var items in data)
            {
                SearchResult.Add(items);
            }
        }
        public string SearchString
        {
            get
            {
                return _SearchString;
            }
            set
            {
                _SearchString = value;
                OnPropertyChanged();
            }
        }
        public int Total
        {
            get
            {
                return _Total;
            }
            set
            {
                _Total = value;
                OnPropertyChanged();
            }
        }
        private async void GetItemSearch()
        {
            try
            {
                var searchWord = SearchString as string;
                if (!string.IsNullOrEmpty(searchWord))
                {
                    Shoesitems.Clear();
                    var data = new MockDataStore().Getshoes().Where(x => x.Name.Contains(searchWord));
                    if(data != null)
                    {
                        foreach (var items in data)
                        {
                            Shoesitems.Add(items);
                        }
                        Total = Shoesitems.Count();
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "We cant find your items", "OK");
                    }
                }                
            }
            catch(Exception ex)
            {
                 await Application.Current.MainPage.DisplayAlert("Error", ex.ToString(), "OK");
            }
        }
    }
}
