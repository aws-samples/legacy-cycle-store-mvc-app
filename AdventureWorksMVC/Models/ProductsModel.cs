using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdventureWorks;
using AdventureWorks.Business;

namespace AdventureWorks.Models
{
    public class ProductsModel
    {
        public string PageTitle { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductSubcategory ProductSubCategory { get; set; }
        public List<ProductSubcategory> ProductSubCategoryList { get; set; }
        public List<string> CarouselNameList { get; set; }
        public string CarouselName { get; set; }
        public string CarouselData { get; set; }
        public string ChartVisibility { get; set; }
        public string ChartCategory { get; set; }
        public string ChartName { get; set; }
        public string HFSubCategoryName { get; set; }

        public string ColorDivVisibility { get; set; }
        public string SizeDivVisibility { get; set; }
        public string WeightDivVisibility { get; set; }
        public int ProductSizeMin { get; set; }
        public int ProductSizeMax { get; set; }
        public List<string> ProductColorsList { get; set; }
        public List<string> ProductSizesList { get; set; }
        public string[] ProductSizesListArray { get; set; }
        public List<string> ProductWeightsList { get; set; }

        public string phSpecsHTML { get; set; }
        public string phModelHTML { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductDescVisibility { get; set; }
        public string ProductDesc { get; set; }

    }
}