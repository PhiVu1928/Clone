using System;
using CloneApp.Model;
using CloneApp.Services;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CloneApp.ViewModel
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Command AddToCartCommand { get; set; }
        public ObservableCollection<ProductSize> productSizes { get; set; }
        private ShoesItems _SelectedItems;
        private ProductSize _SelectedSize;
        public ItemDetailViewModel(ShoesItems shoesitems)
        {
            SelectedItems = shoesitems;
            productSizes = new ObservableCollection<ProductSize>();
            AddToCartCommand = new Command(() => AddToCart());
            GetSize();
        }
        public ProductSize SelectedSize
        {
            get
            {
                return _SelectedSize;
            }
            set
            {
                _SelectedSize = value;
                OnPropertyChanged();
            }
        }
        public void GetSize()
        {
            productSizes.Clear();
            var data = new CategoryServices().GetProductSizes();
            foreach(var items in data)
            {
                productSizes.Add(items);
            }
        }
        private async void AddToCart()
        {
            try
            {
                if(SelectedSize != null)
                {
                    Cart cart = new Cart()
                    {
                        ProductID = SelectedItems.Id,
                        ProductName = SelectedItems.Name,
                        ProductPrice = SelectedItems.Price,
                        ProductImage = SelectedItems.Image,
                        ProductQuantity = 1,
                        ProductSize = SelectedSize.ItemSize,
                    };
                    await DataStore.AddtoCartItems(cart);
                    await Application.Current.MainPage.DisplayAlert("Success", "Your item is added to cart", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "You must select a size before add to cart", "OK");
                }
            }
            catch(Exception ex)
            {
              await Application.Current.MainPage.DisplayAlert("Error", ex.ToString(), "Ok");
            }
            
        }
        
        public ShoesItems SelectedItems
        {
            get
            {
                return _SelectedItems;
            }
            set
            {
                _SelectedItems = value;
                OnPropertyChanged();
            }
        }
       
    }
}
