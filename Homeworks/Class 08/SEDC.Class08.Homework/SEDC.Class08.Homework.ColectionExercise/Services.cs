using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class08.Homework.ColectionExercise
{
    public class Services
    {
        public void ItterateArray(List<Product> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }

        #region Search products by category // return all products from given category

        public List<Product> SearchByCategory(List<Product> list, Category category)
        {
            List<Product> categorylist = new List<Product>();
            foreach (Product product in list)
            {
                if (product.Category == category)
                {
                    categorylist.Add(product);
                }
            }

            return categorylist;
        }

        #endregion

        #region Filter products by price range (from min to max) // return all products that fall in the given price range

        public List<Product> FilterByPriceRange(List<Product> list, int min, int max)
        {
            List<Product> filteredList = new List<Product>();

            foreach(Product product in list)
            {
                if(product.Price >= min && product.Price <= max)
                {
                    filteredList.Add(product);
                }
            }

            return filteredList;
        }

        #endregion

        #region Find products by part of name // get all products that consist the part in their names

        public List<Product> FindByPartOfName(List<Product> list, string partOfName)
        {
            List<Product> filteredList = new List<Product>();

            foreach(Product product in list)
            {
                if (product.Name.ToLower().Contains(partOfName.ToLower()))
                {
                    filteredList.Add(product);
                }
            }

            return filteredList;
        }

        #endregion

        #region Get only products ids // return only the ids of the products

        public List<string> GetOnlyProductsName(List<Product> list)
        {
            List<string> filteredList = new List<string>();

            foreach(Product product in list)
            {
                filteredList.Add(product.Name);
            }

            return filteredList;
        }
        #endregion

        #region Get product price // get the price of the product - give the id as parameter

        public int GetProductPrice(List<Product> list, string name)
        {
            int result = 0;

            foreach (Product product in list)
            {
                if (product.Name.ToLower().Contains(name.ToLower()))
                {
                    result = product.Price;
                    break;
                }
            }

            return result;
        }

        #endregion

        #region Get cheapest product // return the cheapest product

        public Product GetCheapestProduct(List<Product> list)
        {
            Product cheapest = new Product();

            list.Sort((x, y) => x.Price - y.Price);

            cheapest = list[0];

            return cheapest;
        }

        #endregion

        #region Get most expensive product // return the most expensive one

        public Product GetMostExpensiveProduct(List<Product> list)
        {
            Product expensive = new Product();

            list.Sort((x, y) => y.Price - x.Price);

            expensive = list[0];

            return expensive;
        }

        #endregion

        #region Add product // create method to add product to the list of products

        public List<Product> AddProduct(List<Product> list, Product newProduct)
        {
            list.Add(newProduct);

            return list;
        }

        #endregion

        #region Remove product // and a method to remove it - use id as parameter

        public List<Product> RemoveProduct(List<Product> list, string name)
        {
            //for(int i = 0; i < list.Count; i++)
            //{
            //    if (list[i].Name.ToLower().Contains(name.ToLower()))
            //    {
            //        list.Remove(list[i]);
            //    }

            //}
            list.RemoveAll((product) => product.Name.ToLower().Contains(name));

            return list;
        }
        #endregion
    }
}
