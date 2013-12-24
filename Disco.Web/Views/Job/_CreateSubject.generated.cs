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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/_CreateSubject.cshtml")]
    public partial class CreateSubject : Disco.Services.Web.WebViewPage<Disco.Web.Models.Job.CreateModel>
    {
        public CreateSubject()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\_CreateSubject.cshtml"
  
    Authorization.Require(Claims.Job.Actions.Create);

            
            #line default
            #line hidden
WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <td>\r\n            <h2>Device</h2>\r\n        </td>\r\n");

            
            #line 10 "..\..\Views\Job\_CreateSubject.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Job\_CreateSubject.cshtml"
         if (Model.Device != null)
        {

            
            #line default
            #line hidden
WriteLiteral("            <td");

WriteLiteral(" style=\"width: 64px\"");

WriteLiteral(">\r\n                <img");

WriteLiteral(" class=\"modelImage\"");

WriteLiteral(" alt=\"Model Image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 322), Tuple.Create("\"", 432)
            
            #line 13 "..\..\Views\Job\_CreateSubject.cshtml"
, Tuple.Create(Tuple.Create("", 328), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.DeviceModel.Image(Model.Device.DeviceModelId, Model.Device.DeviceModel.ImageHash()))
            
            #line default
            #line hidden
, 328), false)
);

WriteLiteral(" />\r\n            </td>\r\n");

            
            #line 15 "..\..\Views\Job\_CreateSubject.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("        <td");

WriteLiteral(" style=\"width: 50%\"");

WriteLiteral(">\r\n");

            
            #line 17 "..\..\Views\Job\_CreateSubject.cshtml"
            
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\Job\_CreateSubject.cshtml"
             if (Model.Device == null)
            { 

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Device referenced to this Job</span>\r\n");

            
            #line 20 "..\..\Views\Job\_CreateSubject.cshtml"
            }
            else
            { 

            
            #line default
            #line hidden
WriteLiteral("                <span><strong>Serial Number:</strong> ");

            
            #line 23 "..\..\Views\Job\_CreateSubject.cshtml"
                                                 Write(Model.Device.SerialNumber);

            
            #line default
            #line hidden
WriteLiteral("</span>");

WriteLiteral("<br />\r\n");

WriteLiteral("                <span><strong>Name:</strong> ");

            
            #line 24 "..\..\Views\Job\_CreateSubject.cshtml"
                                        Write(Model.Device.ComputerName);

            
            #line default
            #line hidden
WriteLiteral("</span>");

WriteLiteral("<br />\r\n");

WriteLiteral("                <span><strong>Model:</strong> ");

            
            #line 25 "..\..\Views\Job\_CreateSubject.cshtml"
                                         Write(Model.Device.DeviceModel.ToString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 26 "..\..\Views\Job\_CreateSubject.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </td>\r\n        <td>\r\n            <h2>User</h2>\r\n        </td>\r\n        <t" +
"d");

WriteLiteral(" style=\"width: 50%\"");

WriteLiteral(">\r\n");

            
            #line 32 "..\..\Views\Job\_CreateSubject.cshtml"
            
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Job\_CreateSubject.cshtml"
             if (Model.User == null)
            { 

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No User referenced to this Job</span>\r\n");

            
            #line 35 "..\..\Views\Job\_CreateSubject.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <span><strong>Id:</strong> ");

            
            #line 38 "..\..\Views\Job\_CreateSubject.cshtml"
                                      Write(Model.User.Id);

            
            #line default
            #line hidden
WriteLiteral("</span>");

WriteLiteral("<br />\r\n");

WriteLiteral("                <span><strong>Name:</strong> ");

            
            #line 39 "..\..\Views\Job\_CreateSubject.cshtml"
                                        Write(Model.User.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 40 "..\..\Views\Job\_CreateSubject.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </td>\r\n    </tr>\r\n</table>\r\n");

        }
    }
}
#pragma warning restore 1591
