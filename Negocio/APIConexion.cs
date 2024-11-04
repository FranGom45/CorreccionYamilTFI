using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Negocio
{
    public class APIConexion
    {
        RestClient client;

        public APIConexion()
        {
            client = new RestClient("https://fakestoreapi.com");
            //List<String> Categories;
        }
        public List<ApiProducts> GetProducts()
        {

            var request = new RestRequest("products", Method.Get);
            List<ApiProducts> products = client.Get<List<ApiProducts>>(request);


            if (products == null)
            {
                products = new List<ApiProducts>();
            }

            return products;
        }


        public List<ApiProducts> GetCategories()
        {

            var request = new RestRequest("products/Categories", Method.Get);
            //List<ApiProducts> products = client.Get<List<ApiProducts>>(request);

            List<ApiProducts> products = new List<ApiProducts>();
            var response = client.Get(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                // products = new List<ApiProducts>();
                var categories = JsonConvert.DeserializeObject<List<string>>(response.Content);

                
            }

            return products;
        }




        public void AddProducts()
        {
            var request = new RestRequest("products", Method.Post);

            string producto = " { title: 'test product', price: 13.5, description: 'lorem ipsum set', category: 'electronic'}";

            request.AddJsonBody(producto, ContentType.Json);

            //var response = client.Post(request);


        }

        public void GetInCategory(List<ApiProducts> listProductsToUpdate, string category)
        {
            var request = new RestRequest($"products/categories/{category}", Method.Get);
            var response = client.Get(request);

        }

        //public List<ApiProducts> LimitResult(List<ApiProducts> listProductsToUpdate, int limitNumber)
        //    {
        //    }

    }
}