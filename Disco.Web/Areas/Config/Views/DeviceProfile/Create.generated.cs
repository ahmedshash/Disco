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

namespace Disco.Web.Areas.Config.Views.DeviceProfile
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DeviceProfile/Create.cshtml")]
    public partial class Create : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.DeviceProfile.CreateModel>
    {
        public Create()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
  
    Authorization.RequireAll(Claims.Config.DeviceProfile.Create, Claims.Config.DeviceProfile.Configure);
    
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Device Profiles", MVC.Config.DeviceProfile.Index(null), "Create");

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
 using (Html.BeginForm())
{ 
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
Write(Html.ValidationSummary(false));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
                                  

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 450px\"");

WriteLiteral(">\r\n        <table>\r\n            <tr>\r\n                <th>\r\n                    N" +
"ame:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                ");

            
            #line 17 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
           Write(Html.TextBoxFor(model => model.DeviceProfile.Name));

            
            #line default
            #line hidden
WriteLiteral("<br />");

            
            #line 17 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
                                                                    Write(Html.ValidationMessageFor(model => model.DeviceProfile.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">\r\n                    Short Name:\r\n                </th>\r\n                <td>");

            
            #line 24 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
               Write(Html.TextBoxFor(model => model.DeviceProfile.ShortName));

            
            #line default
            #line hidden
WriteLiteral("<br />");

            
            #line 24 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
                                                                             Write(Html.ValidationMessageFor(model => model.DeviceProfile.ShortName));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">\r\n                    Description:\r\n                </th>\r\n                <td>" +
"");

            
            #line 31 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
               Write(Html.TextBoxFor(model => model.DeviceProfile.Description));

            
            #line default
            #line hidden
WriteLiteral("<br />");

            
            #line 31 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
                                                                               Write(Html.ValidationMessageFor(model => model.DeviceProfile.Description));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");

WriteLiteral("        ");

            
            #line 35 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
   Write(Html.HiddenFor(model => model.DeviceProfile.ComputerNameTemplate));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 36 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
   Write(Html.HiddenFor(model => model.DeviceProfile.ProvisionADAccount));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("        ");

            
            #line 37 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
   Write(Html.HiddenFor(model => model.DeviceProfile.DistributionType));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <p");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Create\"");

WriteLiteral(" />\r\n        </p>\r\n    </div>\r\n");

WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            $(\'#Name\').focus().select();\r\n        });" +
"\r\n    </script>\r\n");

            
            #line 47 "..\..\Areas\Config\Views\DeviceProfile\Create.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
