using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace CloneApp.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddtoCartItems(T cart);
        Task<bool> DeleteItemsCart(string id);

        Task<ObservableCollection<T>> GetCartsAsync();
    }
}
