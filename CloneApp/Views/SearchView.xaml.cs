using System;
using System.Linq;
using CloneApp.Model;
using CloneApp.Services;
using Rg.Plugins.Popup.Extensions;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloneApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchView : ContentPage 
    {
        public SearchView()
        {
            InitializeComponent();
        }

        private void SearchShoes_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = SearchShoes.Text;
            if (keyword.Length >= 1)
            {
                var data = new MockDataStore().Getshoes();
                var suggestion = data.Where(c => c.Name.Contains(keyword)).Take(10);
                ShoesList.ItemsSource = suggestion;
                ShoesList.IsVisible = true;
            }
            else
            {
                ShoesList.IsVisible = false;               
            }
        }

        async void ShoesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(e.CurrentSelection.FirstOrDefault() is ShoesItems shoesitems))
                return;
            await Navigation.PushModalAsync(new ItemDetailPage(shoesitems));

            ((CollectionView)sender).SelectedItem = null;
        }
    }
}