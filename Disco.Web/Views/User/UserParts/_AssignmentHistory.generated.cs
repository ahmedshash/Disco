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

namespace Disco.Web.Views.User.UserParts
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/UserParts/_AssignmentHistory.cshtml")]
    public partial class AssignmentHistory : Disco.Services.Web.WebViewPage<Disco.Web.Models.User.ShowModel>
    {
        public AssignmentHistory()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
  
    Authorization.Require(Claims.User.ShowAssignmentHistory);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"UserDetailTab-AssignmentHistory\"");

WriteLiteral(" class=\"UserPart\"");

WriteLiteral(">\r\n");

            
            #line 6 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
    
            
            #line default
            #line hidden
            
            #line 6 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
     if (Model.User.DeviceUserAssignments.Count > 0)
    { 

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"genericData\"");

WriteLiteral(@">
            <tr>
                <th>Device Serial #
                </th>
                <th>Device Asset #
                </th>
                <th>Device Model
                </th>
                <th>Assigned
                </th>
                <th>Unassigned
                </th>
            </tr>
");

            
            #line 21 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
            
            
            #line default
            #line hidden
            
            #line 21 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
             foreach (var dua in Model.User.DeviceUserAssignments.OrderByDescending(m => m.AssignedDate))
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n");

            
            #line 25 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
                         if (Authorization.Has(Claims.Device.Show))
                        {
                            
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
                       Write(Html.ActionLink(dua.Device.SerialNumber, MVC.Device.Show(dua.DeviceSerialNumber)));

            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
                                                                                                              
                        }
                        else
                        {
                            
            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
                       Write(dua.Device.SerialNumber);

            
            #line default
            #line hidden
            
            #line 31 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
                                                    
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 35 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
                   Write(dua.Device.AssetNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 38 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
                   Write(dua.Device.DeviceModel.ToString());

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 41 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
                   Write(CommonHelpers.FriendlyDate(dua.AssignedDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 44 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
                   Write(CommonHelpers.FriendlyDate(dua.UnassignedDate, "Current"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 47 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </table>\r\n");

            
            #line 49 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
    }
    else
    { 

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Assignment History Available</span>\r\n");

            
            #line 53 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <script>\r\n        $(\'#UserDetailTabItems\').append(\'<li><a href=\"#UserDetailTa" +
"b-AssignmentHistory\">Assignment History [");

            
            #line 55 "..\..\Views\User\UserParts\_AssignmentHistory.cshtml"
                                                                                                        Write(Model.User.DeviceUserAssignments.Count);

            
            #line default
            #line hidden
WriteLiteral("]</a></li>\');\r\n    </script>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
