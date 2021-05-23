using System;
using System.Collections.ObjectModel;
using CloneApp.Model;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace CloneApp.ViewModel
{
    public class ViewCartViewModel : BaseViewModel
    {
        public ObservableCollection<Cart> carts { get; set; }
        public Command GetCartsCommand { get; set; }
        public Command BackToHome { get; set; }
        private int _TotalResult;
        private float _Total;
        public ViewCartViewModel()
        {
            carts = new ObservableCollection<Cart>();
            BackToHome = new Command(async () => await BackToHomeAsync());
            GetCarts();
            
        }
        public async Task BackToHomeAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
        public int TotalResult
        {
            get
            {
                return _TotalResult;
            }
            set
            {
                _TotalResult = value;
                OnPropertyChanged();
            }
        }
        public float Total
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
        public async void GetCarts()
        {
            try
            {
                carts.Clear();               
                var data = await DataStore.GetCartsAsync();
                foreach (var item in data)
                {
                    carts.Add(item);
                    for (int i = 0; i <= TotalResult; i++)
                    {
                        Total = item.ProductPrice + Total;
                    }
                }
                TotalResult = carts.Count();
                
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.ToString(), "OK");
            }
           
        }
      
    }
}
