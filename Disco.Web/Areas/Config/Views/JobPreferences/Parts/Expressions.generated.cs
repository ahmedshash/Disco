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

namespace Disco.Web.Areas.Config.Views.JobPreferences.Parts
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
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/JobPreferences/Parts/Expressions.cshtml")]
    public partial class Expressions : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.JobPreferences.IndexModel>
    {
        public Expressions()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
  
    Authorization.Require(Claims.Config.JobPreferences.Show);

    var canConfig = Authorization.Has(Claims.Config.JobPreferences.Configure);

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"Config_JobPref_Expressions\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 530px;\"");

WriteLiteral(">\r\n    <h2>Expressions</h2>\r\n    <table>\r\n        <tr>\r\n            <th");

WriteLiteral(" style=\"width: 200px\"");

WriteLiteral(">On Create:</th>\r\n            <td>\r\n");

            
            #line 13 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                
            
            #line default
            #line hidden
            
            #line 13 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                 if (canConfig)
                {
                    
            
            #line default
            #line hidden
            
            #line 15 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
               Write(Html.EditorFor(model => model.OnCreateExpression));

            
            #line default
            #line hidden
            
            #line 15 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                                                                      
                    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
               Write(AjaxHelpers.AjaxRemove());

            
            #line default
            #line hidden
            
            #line 16 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                                             
                    
            
            #line default
            #line hidden
            
            #line 17 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
               Write(AjaxHelpers.AjaxSave());

            
            #line default
            #line hidden
            
            #line 17 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                                           
                    
            
            #line default
            #line hidden
            
            #line 18 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
               Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
            
            #line 18 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                                             

            
            #line default
            #line hidden
WriteLiteral("                    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                            $(function () {
                                var field = $('#OnCreateExpression');
                                var fieldRemove = field.next('.ajaxRemove');
                                var fieldOriginalWidth, fieldOriginalHeight;

                                document.DiscoFunctions.PropertyChangeHelper(
                                    field,
                                    'None',
                                    '");

            
            #line 28 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                                Write(Url.Action(MVC.API.JobPreferences.UpdateOnCreateExpression()));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                                    \'OnCreateExpression\'\r\n                   " +
"             );\r\n\r\n                                field.focus(function () {\r\n  " +
"                                  fieldOriginalWidth = field.width();\r\n         " +
"                           fieldOriginalHeight = field.height();\r\n              " +
"                      field.css(\'overflow\', \'visible\').animate({ width: field.pa" +
"rent().width() - 42, height: 75 }, 200);\r\n                                }).blu" +
"r(function () {\r\n                                    field.css(\'overflow\', \'hidd" +
"en\').animate({ width: fieldOriginalWidth, height: fieldOriginalHeight }, 200);\r\n" +
"                                }).change(function () {\r\n                       " +
"             if (!!field.val()) {\r\n                                        field" +
"Remove.show();\r\n                                    } else {\r\n                  " +
"                      fieldRemove.hide();\r\n                                    }" +
"\r\n                                }).attr(\'placeholder\', \'None\').attr(\'spellchec" +
"k\', \'false\');\r\n\r\n                                fieldRemove.click(function () {" +
"\r\n                                    field.val(\'\').change();\r\n                 " +
"               });\r\n\r\n                                if (!!field.val()) {\r\n    " +
"                                fieldRemove.show();\r\n                           " +
"     } else {\r\n                                    fieldRemove.hide();\r\n        " +
"                        }\r\n                            });\r\n                    " +
"</script>\r\n");

            
            #line 57 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(Model.OnCreateExpression))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">&lt;None Specified&gt;</span>\r\n");

            
            #line 63 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"code\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 67 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                       Write(Model.OnCreateExpression);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

            
            #line 69 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"info-box\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"fa-p\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-fw fa-info-circle\"");

WriteLiteral("></i>This expression will be evaluated whenever a job is created. If the expressi" +
"on has any output it will be added to the job log.\r\n                    </p>\r\n  " +
"              </div>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n          " +
"  <th");

WriteLiteral(" style=\"width: 200px\"");

WriteLiteral(">On Close:</th>\r\n            <td>\r\n");

            
            #line 81 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                
            
            #line default
            #line hidden
            
            #line 81 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                 if (canConfig)
                {
                    
            
            #line default
            #line hidden
            
            #line 83 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
               Write(Html.EditorFor(model => model.OnCloseExpression));

            
            #line default
            #line hidden
            
            #line 83 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                                                                     
                    
            
            #line default
            #line hidden
            
            #line 84 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
               Write(AjaxHelpers.AjaxRemove());

            
            #line default
            #line hidden
            
            #line 84 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                                             
                    
            
            #line default
            #line hidden
            
            #line 85 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
               Write(AjaxHelpers.AjaxSave());

            
            #line default
            #line hidden
            
            #line 85 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                                           
                    
            
            #line default
            #line hidden
            
            #line 86 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
               Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
            
            #line 86 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                                             

            
            #line default
            #line hidden
WriteLiteral("                    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                            $(function () {
                                var field = $('#OnCloseExpression');
                                var fieldRemove = field.next('.ajaxRemove');
                                var fieldOriginalWidth, fieldOriginalHeight;

                                document.DiscoFunctions.PropertyChangeHelper(
                                    field,
                                    'None',
                                    '");

            
            #line 96 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                                Write(Url.Action(MVC.API.JobPreferences.UpdateOnCloseExpression()));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                                    \'OnCloseExpression\'\r\n                    " +
"            );\r\n\r\n                                field.focus(function () {\r\n   " +
"                                 fieldOriginalWidth = field.width();\r\n          " +
"                          fieldOriginalHeight = field.height();\r\n               " +
"                     field.css(\'overflow\', \'visible\').animate({ width: field.par" +
"ent().width() - 42, height: 75 }, 200);\r\n                                }).blur" +
"(function () {\r\n                                    field.css(\'overflow\', \'hidde" +
"n\').animate({ width: fieldOriginalWidth, height: fieldOriginalHeight }, 200);\r\n " +
"                               }).change(function () {\r\n                        " +
"            if (!!field.val()) {\r\n                                        fieldR" +
"emove.show();\r\n                                    } else {\r\n                   " +
"                     fieldRemove.hide();\r\n                                    }\r" +
"\n                                }).attr(\'placeholder\', \'None\').attr(\'spellcheck" +
"\', \'false\');\r\n\r\n                                fieldRemove.click(function () {\r" +
"\n                                    field.val(\'\').change();\r\n                  " +
"              });\r\n\r\n                                if (!!field.val()) {\r\n     " +
"                               fieldRemove.show();\r\n                            " +
"    } else {\r\n                                    fieldRemove.hide();\r\n         " +
"                       }\r\n                            });\r\n                    <" +
"/script>\r\n");

            
            #line 125 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(Model.OnCloseExpression))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">&lt;None Specified&gt;</span>\r\n");

            
            #line 131 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"code\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 135 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                       Write(Model.OnCloseExpression);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");

            
            #line 137 "..\..\Areas\Config\Views\JobPreferences\Parts\Expressions.cshtml"
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"info-box\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"fa-p\"");

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-fw fa-info-circle\"");

WriteLiteral("></i>This expression will be evaluated whenever a job is closed. If the expressio" +
"n has any output it will be added to the job log.\r\n                    </p>\r\n   " +
"             </div>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>");

        }
    }
}
#pragma warning restore 1591