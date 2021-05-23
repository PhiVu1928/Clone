using System.Linq;
using Rg.Plugins.Popup.Extensions;
using CloneApp.ViewModel;
using CloneApp.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloneApp.Views
{
    public partial class CategoryView : ContentPage
    {
        readonly CategoryViewModel _model;
        public CategoryView(Category category)
        {
            InitializeComponent();
            _model = new CategoryViewModel(category);
            BindingContext = _model;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(e.CurrentSelection.FirstOrDefault() is ShoesItems shoesitems))
                return;
            await Navigation.PushPopupAsync(new ItemDetailPage(shoesitems));

            ((CollectionView)sender).SelectedItem = null;
        }
    }
}