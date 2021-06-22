using CDVShopApp.api;
using CDVShopApp.Models;
using System.Collections.Generic;
namespace CDVShopApp.Services
{
    public class ServiceDummy
    {
        private static ServiceDummy _instance;
        public static ServiceDummy Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ServiceDummy();
                return _instance;
            }
        }
        public List<Product> GetProducts()
        {
            var api = new ApiService();
            return api.Gimme().GetAwaiter().GetResult();

        }
    }
}
