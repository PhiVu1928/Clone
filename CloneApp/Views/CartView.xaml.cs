using System;
using CloneApp.ViewModel;
using CloneApp.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloneApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartView : ContentPage
    {
        ViewCartViewModel _model;
        public CartView()
        {
            InitializeComponent();
            _model = new ViewCartViewModel();
            BindingContext = _model;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {
            SwipeItem item = sender as SwipeItem;
            Cart model = item.BindingContext as Cart;
            _model.DataStore.DeleteItemsCart(model.ProductID);
            Shell.Current.GoToAsync("..");
        }               
    }
}