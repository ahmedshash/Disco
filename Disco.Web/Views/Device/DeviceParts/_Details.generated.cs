﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.Device.DeviceParts
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/DeviceParts/_Details.cshtml")]
    public partial class Details : System.Web.Mvc.WebViewPage<Disco.Web.Models.Device.ShowModel>
    {
        public Details()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" id=\"DeviceDetailTab-Details\"");

WriteLiteral(" class=\"DevicePart\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"DeviceDetailTab-DetailsContainer\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(">\r\n            <tbody>\r\n                <tr>\r\n                    <th>LAN MAC Add" +
"ress</th>\r\n                    <td>");

            
            #line 8 "..\..\Views\Device\DeviceParts\_Details.cshtml"
                    Write(Model.Device.DeviceDetails.LanMacAddress() ?? "Unknown");

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th>WLAN " +
"MAC Address</th>\r\n                    <td>");

            
            #line 12 "..\..\Views\Device\DeviceParts\_Details.cshtml"
                    Write(Model.Device.DeviceDetails.WLanMacAddress() ?? "Unknown");

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r" +
"\n    <script>\r\n        $(\'#DeviceDetailTabItems\').append(\'<li><a href=\"#DeviceDe" +
"tailTab-Details\">Details</a></li>\');\r\n    </script>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591