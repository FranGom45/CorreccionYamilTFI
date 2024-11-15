using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Web.Configuration;

namespace Negocio
{
    public class APIConexion
    {
        RestClient client;
        List<string> Categories;
        private readonly string baseUrl;
        public APIConexion()
        {
            client = new RestClient("https://fakestoreapi.com");
            baseUrl = WebConfigurationManager.AppSettings["ApiBaseUrl"];
            //client = new RestClient(baseUrl);



        }



        //Métodos de https://fakestoreapi.com

        //Pantalla principal

        //Get all products https://fakestoreapi.com/products:
        //El método get me devuelve el tipo de dato que especifíco, en este caso <ApiProducts>
        //El en caso de List, es una clase que recibe un tipo genérico y nosotros le indicamos de que tipo es esa colección.

        public string GetProducts(List<ApiProducts> listProductsToUpdate)
        {
            try
            {
                var request = new RestRequest("products", Method.Get);
                var response = client.Get(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var products = JsonConvert.DeserializeObject<List<ApiProducts>>(response.Content);



                    listProductsToUpdate.Clear();
                    listProductsToUpdate.AddRange(products);


                    return "Buen día. Los productos se cargaron de manera correcta";
                }
                else
                {
                    return "Error";
                }

            }
            catch (Exception ex)
            {
                return "error obtener productos";

            }
        }

        //Get all categories https://fakestoreapi.com/products/categories:


        public string GetCategories(List<string> ListCategoriesToUpdate)
        {
            try
            {

                var request = new RestRequest("products/Categories", Method.Get);
                var response = client.Get(request);


                //List<ApiProducts> products = client.Get<List<ApiProducts>>(request);

                //List<ApiProducts> products = new List<ApiProducts>();


                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // products = new List<ApiProducts>();
                    var categories = JsonConvert.DeserializeObject<List<string>>(response.Content);
                    ListCategoriesToUpdate.Clear();
                    ListCategoriesToUpdate.AddRange(categories);

                    return "Ok categorias";

                }
                else
                {
                    return "No ok categorias";
                }
            }
            catch (Exception ex)
            {
                return "Error";
            }

        }

        //Limit results https://fakestoreapi.com/products?limit=x:

        public List<ApiProducts> LimitResult(List<ApiProducts> ListProductsToUpdate, int limitNumber)
        {
            try
            {


                var request = new RestRequest($"products?limit={limitNumber}", Method.Get);
                var response = client.Get(request);


                return ListProductsToUpdate.Take(limitNumber).ToList();
            }
            catch (Exception ex)
            {
                return new List<ApiProducts>();

            }

        }


        //Get products in a specific category https://fakestoreapi.com/products/category:


        public void GetInCategory(List<ApiProducts> ListProductsToUpdate, string category)
        {
            try
            {
                var request = new RestRequest($"products/categories/{category}", Method.Get);
                var response = client.Get(request);

                ListProductsToUpdate.RemoveAll(p => p.Category != category);

            }
            catch (Exception ex)
            {
            }
        }


        //Sort results https://fakestoreapi.com/products?sort=desc/ascen:


        public void SortResults(List<ApiProducts> ListProductsToUpdate, string order)
        {
            try
            {
                var request = new RestRequest("products/products?sort=desc", Method.Get);
                var response = client.Get(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    if (order == "Ascendente")
                    {
                        ListProductsToUpdate.Sort((fr1, fr2) => fr1.Id.CompareTo(fr2.Id));

                    }
                    else
                    {
                        ListProductsToUpdate.Sort((fr1, fr2) => fr2.Id.CompareTo(fr1.Id));

                    }
                }
                else
                {

                }

            }
            catch (Exception ex)
            {

            }
        }


        //Get a single product https://fakestoreapi.com/products/1:


        public ApiProducts GetSingleProduct(List<ApiProducts> ListProductsToUpdate, int id)
        {
            try
            {
                var request = new RestRequest($"products/{id}", Method.Get);
                var response = client.Get(request);
                return ListProductsToUpdate.FirstOrDefault(fran => fran.Id == id);
            }
            catch (Exception ex)
            {
                return null;
            }

            throw new NotImplementedException();
        }


        //Método Post para agregar un nuevo producto a la lista:
        public string PostProducts(List<ApiProducts> listProductsToUpdate, ApiProducts newProduct)
        {
            try
            {
                var request = new RestRequest("products", Method.Post);
                request.AddJsonBody(newProduct);
                var response = client.Post(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    listProductsToUpdate.Add(newProduct);
                    return "El producto se agregó de manera correcta";
                }
                else
                {
                    return "El producto de se pudo agregar";
                }
            }
            catch (Exception ex)
            {
                return "Ocurrió un error en el método post";
            }
        }

        //Método Put para actualizar un producto existente:

        public string PutProducts(List<ApiProducts> ListProductsToUpdate, ApiProducts productToEdit)
        {
            try
            {
                var request = new RestRequest($"products/{productToEdit.Id}", Method.Put);
                request.AddJsonBody(productToEdit);
                var response = client.Put(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var product = ListProductsToUpdate.Where(item => item.Id == productToEdit.Id).First();

                    product.Title = productToEdit.Title;
                    product.Description = productToEdit.Description;
                    product.Category = productToEdit.Category;
                    product.Price = productToEdit.Price;

                    return "Producto actualizado";
                }
                else
                {
                    return "Error al llamar al método PutProducts";
                }
            }
            catch (Exception ex)
            {
                return "Error al editar el producto";
            }
        }

        //Eliminar

        public string DeleteProducts(List<ApiProducts> listProductsToUpdate, List<int> listIDD)
        {
            try
            {
                foreach (int productId in listIDD)
                {
                    var request = new RestRequest($"products/{productId}", Method.Delete);
                    var response = client.Delete(request);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        listProductsToUpdate.RemoveAll(item => listIDD.Contains(item.Id));
                        return "Producto eliminado correctamente";
                    }
                    else
                    {
                        return "Error al llamar a DeleteProducts";
                    }
                }
                return "";


            }
            catch (Exception ex)
            {
                return "Error al eliminar el producto";
            }

        }
    }
}



























