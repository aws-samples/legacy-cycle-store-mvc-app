using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;


public static class UrlExtensions
{
    //URL Helper to return webresource.axd link to embedded resources in an assembly
    public static string WebResource(this UrlHelper urlHelper, Type type, string resourcePath)
    {
        //Create page in order to use ClientScript. Razor Views do no have access to Page otherwise this could be done in the View itself. 
        var page = new Page();
        return page.ClientScript.GetWebResourceUrl(type, resourcePath);
    }
}
