using CloneApp.Model;
using CloneApp.Services;
using Rg.Plugins.Popup.Extensions;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloneApp.Views
{
    public partial class CategoryPage : ContentPage 
    {
        public CategoryPage()
        {
            InitializeComponent();
            ShoesList.IsVisible = false;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }


        async void CollectionView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (!(e.CurrentSelection.FirstOrDefault() is ShoesItems shoesitems))
                return;
            await Navigation.PushPopupAsync(new ItemDetailPage(shoesitems));

            ((CollectionView)sender).SelectedItem = null;
        }
        private void SearchShoes_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = SearchShoes.Text;
            if (keyword.Length >= 1)
            {
                var data = new MockDataStore().Getshoes();
                var suggestion = data.Where(c => c.Name.Contains(keyword)).Take(15);
                ShoesList.ItemsSource = suggestion;
                ShoesList.IsVisible = true;
                Brandss.IsVisible = false;
            }
            else
            {
                ShoesList.IsVisible = false;
                Brandss.IsVisible = true;
            }
        }

        async void ShoesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(e.CurrentSelection.FirstOrDefault() is ShoesItems shoesitems))
                return;
            await Navigation.PushPopupAsync(new ItemDetailPage(shoesitems));

            ((CollectionView)sender).SelectedItem = null;
        }

        async void Brandss_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(e.CurrentSelection.FirstOrDefault() is Category category))
                return;
            var data = await MockDataStore.GetItemsByCate(category.CateID);
            LstItems.ItemsSource = data;
        }
    }
}
