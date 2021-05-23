using System;
using CloneApp.Model;
using CloneApp.ViewModel;
using System.Linq;
using Rg.Plugins.Popup.Extensions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloneApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mainpage : ContentPage
    {
        public Mainpage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CartTotal.Text = new ViewCartViewModel().TotalResult.ToString();
        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(e.CurrentSelection.FirstOrDefault() is ShoesItems shoesitem))
                return;
            await Navigation.PushPopupAsync(new ItemDetailPage(shoesitem));
            ((CollectionView)sender).SelectedItem = null;
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new CartView());
        }
    }
}