﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.Shared
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_JobTable.cshtml")]
    public partial class JobTable : System.Web.Mvc.WebViewPage<Disco.Models.BI.Job.JobTableModel>
    {
        public JobTable()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_JobTable.cshtml"
 if (DiscoApplication.MultiSiteMode)
{
    if (Model == null || Model.Items == null || Model.Items.Count == 0)
    { 

            
            #line default
            #line hidden
WriteLiteral("    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Jobs Found</span>\r\n");

            
            #line 7 "..\..\Views\Shared\_JobTable.cshtml"
    }
    else
    {
        var multiSiteModels = Model.MultiCampusModels;

        foreach (var multiSiteModel in multiSiteModels)
        {
            if (!string.IsNullOrEmpty(multiSiteModel.Key))
            {

            
            #line default
            #line hidden
WriteLiteral("    <h3>");

            
            #line 16 "..\..\Views\Shared\_JobTable.cshtml"
   Write(multiSiteModel.Key);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 17 "..\..\Views\Shared\_JobTable.cshtml"
            }
    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\_JobTable.cshtml"
Write(Html.Partial(MVC.Shared.Views._JobTableRender, multiSiteModel.Value, new ViewDataDictionary()));

            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\_JobTable.cshtml"
                                                                                                   
        }
    }
}
else
{ 
    
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Shared\_JobTable.cshtml"
Write(Html.Partial(MVC.Shared.Views._JobTableRender, Model, new ViewDataDictionary()));

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Shared\_JobTable.cshtml"
                                                                                    
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
