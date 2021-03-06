using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Extensions;
using CloneApp.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CloneApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : Rg.Plugins.Popup.Pages.PopupPage
    {
        LazyloadVieModel _model;
        public Page2()
        {
            InitializeComponent();
            _model = new LazyloadVieModel();
            BindingContext = _model;
        }


        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopPopupAsync();
        }
    }
}