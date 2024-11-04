using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ApiProducts
    {
        public ApiProducts()
        {
        }

        public ApiProducts (int id, string title, string description, string category, decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            Category = category;
            Price = price;
            
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }



        //?
       

        //public static object OrderBy(Func<object, object> value)
        //{
        //    throw new NotImplementedException();
        //}

        //public static object Select(Func<object, object> value)
        //{
        //    throw new NotImplementedException();
        //}

        //public static object where(Func<object, bool> value)
        //{
        //    throw new NotImplementedException();
        }
    }

