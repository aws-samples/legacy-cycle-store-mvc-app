using AdventureWorks.Business;
using System;
using System.Collections.Generic;
using System.Linq;


namespace EpicAdventureWorks
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductManager
    {
        /// <summary>
        /// Get Product's SubCategory
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public static List<ProductCategory> GetCategory(int categoryId)
        {
            List<ProductCategory> catList = null;
            //catList = (from cat in Common.DataEntities.ProductCategory
            //           where cat.ParentCategory.ProductCategoryID == categoryId
            //           select cat).ToList();
            return catList;
        }

        /// <summary>
        /// Gets the name of the product by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static Product GetProductByName(string name)
        {
            var product = from p in Common.DataEntities.Products
                          where p.Name == name 
                          select p;
            return product.FirstOrDefault();
        }

        /// <summary>
        /// Get product by categoryId
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public static IQueryable<Product> GetProductByCategory(ProductSubcategory category)
        {
            IQueryable<Product> prodList = null;
            prodList = from p in Common.DataEntities.Products
                       where p.ProductSubcategory.ProductSubcategoryID == category.ProductSubcategoryID
                       select p;
            return prodList;
        }

        /// <summary>
        /// Get product by ProductId
        /// </summary>
        /// <param name="prodId"></param>
        /// <returns></returns>
        public static Product GetProductByProductId(int prodId)
        {
            var prods = from p in Common.DataEntities.Product
                        where p.ProductID == prodId
                        select p;
            return prods.FirstOrDefault();
        }

        public static Product GetProductByProductId(int prodId, Entities entities)
        {
            Product prod;
            var prods = from p in entities.Product
                        where p.ProductID == prodId
                        select p;
            prod = prods.FirstOrDefault();
            return prod;
        }

        /// <summary>
        /// Get Product's Colors By category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public static List<string> GetProductColor(int categoryId)
        {
            List<string> colorList = null;
            colorList = (from p in Common.DataEntities.Product
                         where p.Color != null && p.ProductSubcategory.ProductSubcategoryID == categoryId
                         orderby p.Color
                         select p.Color).Distinct().ToList();
            return colorList;
        }

        /// <summary>
        /// Get Product's Weights By category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public static List<decimal?> GetProductWeight(int categoryId)
        {
            List<decimal?> weightList = null;
            weightList = (from p in Common.DataEntities.Product
                          where p.ProductSubcategory.ProductSubcategoryID == categoryId
                          && p.Weight != null
                          orderby p.Weight
                          select p.Weight).Distinct().ToList();
            return weightList;
        }

        public static List<string> GetProductWeightString(int categoryId)
        {
            List<string> weightListStr = new List<string>();
            List<decimal?> weightList = null;
            weightList = (from p in Common.DataEntities.Product
                          where p.ProductSubcategory.ProductSubcategoryID == categoryId
                          && p.Weight != null
                          orderby p.Weight
                          select p.Weight).Distinct().ToList();
            //weightListStr = weightList.ToString().ToList();
            //for (int i = 0; i <= weightList.Count; i++)
            //{
            //    weightListStr.Add(new string
            //    {
            //        weightList[i].ToString()
            //});
            //}
            return weightListStr;
        }

        /// <summary>
        /// Get Product's Colors By category
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public static List<string> GetProductSize(int categoryId)
        {
            List<string> sizeList = null;
            sizeList = (from p in Common.DataEntities.Product
                        where p.Size != null && p.ProductSubcategory.ProductSubcategoryID == categoryId
                        orderby p.Size
                        select p.Size).Distinct().ToList();
            return sizeList;
        }

        /// <summary>
        /// Get Product's Description
        /// </summary>
        /// <param name="descId"></param>
        /// <returns></returns>
        public static string GetProductDesc(int descId)
        {
            string desc = null;
            var descList = from pd in Common.DataEntities.ProductDescription
                           where pd.ProductDescriptionID == descId
                           select pd.Description;
            if (descList != null)
                desc = descList.First();
            return desc;
        }
    }
}