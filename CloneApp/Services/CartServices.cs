using System;
using System.Collections.Generic;
using CloneApp.Model;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Linq;

namespace CloneApp.Services
{
    public class CartServices : IDataStore<Cart>
    {
        public ObservableCollection<Cart> carts;
        public CartServices()
        {
            carts = new ObservableCollection<Cart>();
        }        

        public async Task<bool> AddtoCartItems(Cart cart)
        {
            carts.Add(cart);
            return await Task.FromResult(true);
        } 
        
        public async Task<bool> DeleteItemsCart(string id)
        {
            var cartitems = carts.Where(x => x.ProductID == id).FirstOrDefault();
            carts.Remove(cartitems);
            return await Task.FromResult(true);
        }
       
        public async Task<ObservableCollection<Cart>> GetCartsAsync()
        {
            return await Task.FromResult(carts);
        }        
    }
    
}
