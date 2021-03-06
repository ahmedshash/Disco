﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.User
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
    using Disco.Models.Repository;
    using Disco.Services;
    using Disco.Services.Authorization;
    
    #line 2 "..\..\Views\User\Show.cshtml"
    using Disco.Services.Users.UserFlags;
    
    #line default
    #line hidden
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/Show.cshtml")]
    public partial class Show : Disco.Services.Web.WebViewPage<Disco.Web.Models.User.ShowModel>
    {
        public Show()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\User\Show.cshtml"
  
    Authorization.Require(Claims.User.Show);

    ViewBag.Title = Html.ToBreadcrumb("Users", MVC.User.Index(), string.Format("User: {0} ({1})", Model.User.DisplayName, Model.User.FriendlyId()));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"User_Show\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"User_Show_Flags\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\User\Show.cshtml"
        
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\User\Show.cshtml"
         foreach (var flag in Model.User.UserFlagAssignments.Where(f => !f.RemovedDate.HasValue).Select(f => Tuple.Create(f, UserFlagService.GetUserFlag(f.UserFlagId))))
        {

            
            #line default
            #line hidden
WriteLiteral("            <i");

WriteAttribute("class", Tuple.Create(" class=\"", 535), Tuple.Create("\"", 611)
, Tuple.Create(Tuple.Create("", 543), Tuple.Create("flag", 543), true)
, Tuple.Create(Tuple.Create(" ", 547), Tuple.Create("fa", 548), true)
, Tuple.Create(Tuple.Create(" ", 550), Tuple.Create("fa-", 551), true)
            
            #line 12 "..\..\Views\User\Show.cshtml"
, Tuple.Create(Tuple.Create("", 554), Tuple.Create<System.Object, System.Int32>(flag.Item2.Icon
            
            #line default
            #line hidden
, 554), false)
, Tuple.Create(Tuple.Create(" ", 572), Tuple.Create("fa-fw", 573), true)
, Tuple.Create(Tuple.Create(" ", 578), Tuple.Create("fa-lg", 579), true)
, Tuple.Create(Tuple.Create(" ", 584), Tuple.Create("d-", 585), true)
            
            #line 12 "..\..\Views\User\Show.cshtml"
, Tuple.Create(Tuple.Create("", 587), Tuple.Create<System.Object, System.Int32>(flag.Item2.IconColour
            
            #line default
            #line hidden
, 587), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"details\"");

WriteLiteral("><span");

WriteLiteral(" class=\"name\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\User\Show.cshtml"
                                                                                                                                Write(flag.Item2.Name);

            
            #line default
            #line hidden
WriteLiteral("</span>");

            
            #line 12 "..\..\Views\User\Show.cshtml"
                                                                                                                                                             if (flag.Item1.Comments != null)
                                                                                                                                                            {
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"comments\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\User\Show.cshtml"
                                                                                                                                                                               Write(flag.Item1.Comments.ToHtmlComment());

            
            #line default
            #line hidden
WriteLiteral("</span>");

            
            #line 13 "..\..\Views\User\Show.cshtml"
                                                                                                                                                                                                                               }
            
            #line default
            #line hidden
WriteLiteral("<span");

WriteLiteral(" class=\"added\"");

WriteLiteral(">");

            
            #line 13 "..\..\Views\User\Show.cshtml"
                                                                                                                                                                                                                                               Write(CommonHelpers.FriendlyDateAndUser(flag.Item1.AddedDate, flag.Item1.AddedUser));

            
            #line default
            #line hidden
WriteLiteral("</span></span></i>\r\n");

            
            #line 14 "..\..\Views\User\Show.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(function () {
            $('#User_Show_Flags')
                .appendTo('#layout_PageHeading')
                .tooltip({
                    items: 'i.flag',
                    content: function () {
                        var $this = $(this);
                        return $this.children('.details').html();
                    },
                    tooltipClass: 'User_FlagAssignment_Tooltip',
                    position: {
                        my: ""right top"",
                        at: ""right bottom"",
                        collision: ""flipfit flip""
                    },
                    hade: {
                        effect: ''
                    },
                    close: function (e, ui) {
                        ui.tooltip.hover(
                            function () {
                                $(this).stop(true).fadeTo(100, 1);
                            },
                            function () {
                                $(this).fadeOut(100, function () { $(this).remove(); });
                            });
                    }
                });
        });
    </script>
");

WriteLiteral("    ");

            
            #line 47 "..\..\Views\User\Show.cshtml"
Write(Html.Partial(MVC.User.Views.UserParts._Subject, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var $tabs = $(\'#UserDetailTabs\');\r\n      " +
"      if ($tabs.children().length > 1) {\r\n                $tabs.tabs({\r\n        " +
"            activate: function (event, ui) {\r\n                        window.set" +
"Timeout(function () {\r\n                            var $window = $(window);\r\n   " +
"                         var tabHeight = $tabs.height();\r\n                      " +
"      var tabOffset = $tabs.offset();\r\n                            var windowScr" +
"ollTop = $window.scrollTop();\r\n                            var windowHeight = $w" +
"indow.height();\r\n\r\n                            var tabTopNotShown = windowScroll" +
"Top - tabOffset.top;\r\n                            if (tabTopNotShown > 0) {\r\n   " +
"                             $(\'html\').animate({ scrollTop: tabOffset.top }, 125" +
");\r\n                            } else {\r\n                                var ta" +
"bBottomNotShown = ((windowScrollTop + windowHeight) - (tabHeight + tabOffset.top" +
")) * -1;\r\n                                if (tabBottomNotShown > 0) {\r\n        " +
"                            if (tabHeight > windowHeight)\r\n                     " +
"                   $(\'html\').animate({ scrollTop: tabOffset.top }, 125);\r\n      " +
"                              else\r\n                                        $(\'h" +
"tml\').animate({ scrollTop: windowScrollTop + tabBottomNotShown }, 125);\r\n       " +
"                         }\r\n                            }\r\n                     " +
"   }, 1);\r\n                    }\r\n                });\r\n            } else {\r\n   " +
"             $tabs.hide();\r\n            }\r\n        });\r\n    </script>\r\n    <div");

WriteLiteral(" id=\"UserDetailTabs\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" id=\"UserDetailTabItems\"");

WriteLiteral("></ul>\r\n");

            
            #line 83 "..\..\Views\User\Show.cshtml"
        
            
            #line default
            #line hidden
            
            #line 83 "..\..\Views\User\Show.cshtml"
         if (Authorization.Has(Claims.User.ShowJobs))
        {
            
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\User\Show.cshtml"
       Write(Html.Partial(MVC.User.Views.UserParts._Jobs, Model));

            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\User\Show.cshtml"
                                                                
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 87 "..\..\Views\User\Show.cshtml"
         if (Authorization.Has(Claims.User.ShowAssignmentHistory))
        {
            
            
            #line default
            #line hidden
            
            #line 89 "..\..\Views\User\Show.cshtml"
       Write(Html.Partial(MVC.User.Views.UserParts._AssignmentHistory, Model));

            
            #line default
            #line hidden
            
            #line 89 "..\..\Views\User\Show.cshtml"
                                                                             
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 91 "..\..\Views\User\Show.cshtml"
         if (Authorization.Has(Claims.User.ShowAttachments))
        {
            
            
            #line default
            #line hidden
            
            #line 93 "..\..\Views\User\Show.cshtml"
       Write(Html.Partial(MVC.User.Views.UserParts._Resources, Model));

            
            #line default
            #line hidden
            
            #line 93 "..\..\Views\User\Show.cshtml"
                                                                     
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 95 "..\..\Views\User\Show.cshtml"
         if (Authorization.Has(Claims.User.ShowFlagAssignments))
        {
            
            
            #line default
            #line hidden
            
            #line 97 "..\..\Views\User\Show.cshtml"
       Write(Html.Partial(MVC.User.Views.UserParts._Flags, Model));

            
            #line default
            #line hidden
            
            #line 97 "..\..\Views\User\Show.cshtml"
                                                                 
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 99 "..\..\Views\User\Show.cshtml"
         if (Authorization.Has(Claims.User.ShowAuthorization))
        {
            
            
            #line default
            #line hidden
            
            #line 101 "..\..\Views\User\Show.cshtml"
       Write(Html.Partial(MVC.User.Views.UserParts._Authorization, Model));

            
            #line default
            #line hidden
            
            #line 101 "..\..\Views\User\Show.cshtml"
                                                                         
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
