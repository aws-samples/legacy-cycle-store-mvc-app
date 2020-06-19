using System.Collections.Generic;

using AdventureWorks.Business;

namespace AdventureWorks.Models
{
    public class SiteLayoutModel
    {
        public string AnonymousTemplateVisibility { get; set; }
        public string LoggedInTemplateVisibility { get; set; }
        public string LoggedInEmailID { get; set; }
        public string ShoppingCartItemsCount { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
    
}