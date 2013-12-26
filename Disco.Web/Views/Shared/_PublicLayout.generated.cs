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
    using Disco;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_PublicLayout.cshtml")]
    public partial class PublicLayout : Disco.Services.Web.WebViewPage<dynamic>
    {
        public PublicLayout()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Views\Shared\_PublicLayout.cshtml"
  
    Html.BundleDeferred("~/Style/Site");
    Html.BundleDeferred("~/ClientScripts/Core");

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(" />\r\n    <title>Disco - ");

            
            #line 10 "..\..\Views\Shared\_PublicLayout.cshtml"
              Write(CommonHelpers.BreadcrumbsTitle(ViewBag.Title));

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n");

WriteLiteral("    ");

            
            #line 11 "..\..\Views\Shared\_PublicLayout.cshtml"
Write(Html.BundleRenderDeferred());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 12 "..\..\Views\Shared\_PublicLayout.cshtml"
Write(RenderSection("head", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body");

WriteLiteral(" class=\"layout\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"page\"");

WriteLiteral(">\r\n        <header>\r\n            <div");

WriteLiteral(" id=\"heading\"");

WriteLiteral(">\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 491), Tuple.Create("\"", 526)
            
            #line 18 "..\..\Views\Shared\_PublicLayout.cshtml"
, Tuple.Create(Tuple.Create("", 498), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Job.Index())
            
            #line default
            #line hidden
, 498), false)
);

WriteLiteral("><i");

WriteLiteral(" title=\"Disco - ICT Management\"");

WriteLiteral("></i></a>\r\n            </div>\r\n            <nav>\r\n                <ul");

WriteLiteral(" id=\"menu\"");

WriteLiteral(">\r\n                    <li>");

            
            #line 22 "..\..\Views\Shared\_PublicLayout.cshtml"
                   Write(Html.ActionLink("Reports", MVC.Public.Public.Index()));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>");

            
            #line 23 "..\..\Views\Shared\_PublicLayout.cshtml"
                   Write(Html.ActionLink("Administration", MVC.Job.Index(), accesskey: "1"));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                </ul>\r\n            </nav>\r\n        </header>\r\n        <div" +
"");

WriteLiteral(" id=\"layout_PageHeading\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\Shared\_PublicLayout.cshtml"
                                Write(CommonHelpers.Breadcrumbs(ViewBag.Title));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        <section");

WriteLiteral(" id=\"layout_Page\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 29 "..\..\Views\Shared\_PublicLayout.cshtml"
       Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n        </section>\r\n        <footer>\r\n            Disco v");

            
            #line 32 "..\..\Views\Shared\_PublicLayout.cshtml"
               Write(Disco.Web.DiscoApplication.Version);

            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("@ ");

            
            #line 32 "..\..\Views\Shared\_PublicLayout.cshtml"
                                                        Write(Disco.Web.DiscoApplication.OrganisationName);

            
            #line default
            #line hidden
WriteLiteral(" | ");

            
            #line 32 "..\..\Views\Shared\_PublicLayout.cshtml"
                                                                                                        Write(Html.ActionLink("Credits", MVC.Public.Public.Credits()));

            
            #line default
            #line hidden
WriteLiteral(" | ");

            
            #line 32 "..\..\Views\Shared\_PublicLayout.cshtml"
                                                                                                                                                                   Write(Html.ActionLink("Licence", MVC.Public.Public.Licence()));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </footer>\r\n    </div>\r\n");

            
            #line 35 "..\..\Views\Shared\_PublicLayout.cshtml"
    
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Shared\_PublicLayout.cshtml"
       Disco.Services.Plugins.Features.UIExtension.UIExtensions.ExecuteExtensionResult(this); 
            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591