﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.Job
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
    using Disco;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/List.cshtml")]
    public partial class List : Disco.Services.Web.WebViewPage<Disco.Web.Models.Job.ListModel>
    {
        public List()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\List.cshtml"
  
    ViewBag.Title = Html.ToBreadcrumb("Jobs", MVC.Job.Index(), Model.PageTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\Job\List.cshtml"
Write(Html.Partial(MVC.Shared.Views._JobTable, Model.JobTable, new ViewDataDictionary()));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
