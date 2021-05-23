using System;
using System.Collections.Generic;
using CloneApp.ViewModel;
using CloneApp.Views;

using Xamarin.Forms;

namespace CloneApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Home", typeof(Mainpage));
            Routing.RegisterRoute("Category", typeof(CategoryPage));
            Routing.RegisterRoute("Search", typeof(SearchView));
            Routing.RegisterRoute("Cart", typeof(CartView));
        }
    }
}
