using System;
using CloneApp.ViewModel;
using CloneApp.Model;
using Rg.Plugins.Popup.Extensions;


namespace CloneApp.Views
{
    public partial class ItemDetailPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        readonly ItemDetailViewModel _model;
        public Cart cart { get; set; }
        public ItemDetailPage(ShoesItems shoesitems)
        {
            InitializeComponent();
            _model = new ItemDetailViewModel(shoesitems);
            BindingContext = _model;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopPopupAsync();
        }
    }
}