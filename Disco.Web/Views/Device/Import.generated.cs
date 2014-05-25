﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Views.Device
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
    
    #line 2 "..\..\Views\Device\Import.cshtml"
    using Disco.Models.Services.Devices.Importing;
    
    #line default
    #line hidden
    using Disco.Services;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/Import.cshtml")]
    public partial class Import : Disco.Services.Web.WebViewPage<Disco.Web.Models.Device.ImportModel>
    {
        public Import()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Device\Import.cshtml"
  
    Authorization.Require(Claims.Device.Actions.Import);

    ViewBag.Title = Html.ToBreadcrumb("Devices", MVC.Device.Index(), "Import Devices");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"Devices_Import\"");

WriteLiteral(">\r\n");

            
            #line 9 "..\..\Views\Device\Import.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Device\Import.cshtml"
     using (Html.BeginForm(MVC.API.Device.ImportBegin(), FormMethod.Post, new { enctype = "multipart/form-data" }))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"importDialog\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 450px\"");

WriteLiteral(">\r\n            <h2>Import Devices</h2>\r\n            <table>\r\n                <tr>" +
"\r\n                    <th>\r\n");

WriteLiteral("                        ");

            
            #line 16 "..\..\Views\Device\Import.cshtml"
                   Write(Html.LabelFor(m => m.ImportFile));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </th>\r\n                    <td>\r\n                        <i" +
"nput");

WriteLiteral(" id=\"ImportFile\"");

WriteLiteral(" name=\"ImportFile\"");

WriteLiteral(" type=\"file\"");

WriteLiteral(" data-val=\"true\"");

WriteLiteral(" data-val-required=\"An Import File is required.\"");

WriteLiteral(" /><br />\r\n");

WriteLiteral("                        ");

            
            #line 20 "..\..\Views\Device\Import.cshtml"
                   Write(Html.ValidationMessageFor(m => m.ImportFile));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <div>\r\n");

WriteLiteral("                            ");

            
            #line 22 "..\..\Views\Device\Import.cshtml"
                       Write(Html.CheckBoxFor(m => m.HasHeader));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 23 "..\..\Views\Device\Import.cshtml"
                       Write(Html.LabelFor(m => m.HasHeader));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                </tr" +
">\r\n            </table>\r\n            <p");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Begin Import\"");

WriteLiteral(" />\r\n            </p>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" id=\"Devices_Import_Loading_Dialog\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(" title=\"Loading devices import...\"");

WriteLiteral(">\r\n            <h4><i");

WriteLiteral(" class=\"fa fa-lg fa-cog fa-spin\"");

WriteLiteral(" title=\"Please Wait\"");

WriteLiteral("></i>Loading device import...</h4>\r\n        </div>\r\n");

WriteLiteral(@"        <script>
            $(function () {
                var $Devices_Import_Loading_Dialog = null;

                $('#ImportFile').closest('form').submit(function () {
                    if ($Devices_Import_Loading_Dialog == null) {
                        $Devices_Import_Loading_Dialog = $('#Devices_Import_Loading_Dialog').dialog({
                            width: 400,
                            height: 160,
                            resizable: false,
                            modal: true,
                            autoOpen: false
                        });
                    }

                    window.setTimeout(function () {
                        $Devices_Import_Loading_Dialog.dialog('open');
                    }, 200);
                });
            });
        </script>
");

            
            #line 56 "..\..\Views\Device\Import.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"Devices_Import_Documentation\"");

WriteLiteral(">\r\n        <h3>CSV Import Specification</h3>\r\n        <h4>Format</h4>\r\n        <u" +
"l>\r\n            <li>The import file must be in <strong>comma-separated values fo" +
"rmat</strong> (<a");

WriteLiteral(" href=\"http://en.wikipedia.org/wiki/Comma-separated_values\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">CSV Reference</a>).</li>\r\n            <li>Be conscious of editors removing leadi" +
"ng zeros from serial numbers (ie: Microsoft Excel).</li>\r\n        </ul>\r\n       " +
" <h4>Fields</h4>\r\n        <div");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">The following fields/columns are available for to the import file. The Device Se" +
"rial Number is the only required field, all other fields are optional. Fields ca" +
"n appear in any order.</div>\r\n        <table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n                    <th");

WriteLiteral(" style=\"width: 100px;\"");

WriteLiteral(">Field Name</th>\r\n                    <th>Description</th>\r\n                </tr>" +
"\r\n            </thead>\r\n            <tbody>\r\n");

            
            #line 74 "..\..\Views\Device\Import.cshtml"
                
            
            #line default
            #line hidden
            
            #line 74 "..\..\Views\Device\Import.cshtml"
                 foreach (var field in Model.HeaderTypes)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <th>");

            
            #line 77 "..\..\Views\Device\Import.cshtml"
                       Write(field.Item2);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 79 "..\..\Views\Device\Import.cshtml"
                       Write(field.Item3);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 80 "..\..\Views\Device\Import.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 80 "..\..\Views\Device\Import.cshtml"
                             if (field.Item1 == DeviceImportFieldTypes.DeviceSerialNumber.ToString())
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <strong>Required</strong>\r\n");

            
            #line 83 "..\..\Views\Device\Import.cshtml"
                            }
                            else if (field.Item1 == DeviceImportFieldTypes.ModelId.ToString())
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span>(<a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"Devices_Import_Documentation_DeviceModels_Button\"");

WriteLiteral(">Show IDs</a>)</span>\r\n");

            
            #line 87 "..\..\Views\Device\Import.cshtml"
                            }
                            else if (field.Item1 == DeviceImportFieldTypes.ProfileId.ToString())
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span>(<a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"Devices_Import_Documentation_DeviceProfiles_Button\"");

WriteLiteral(">Show IDs</a>)</span>\r\n");

            
            #line 91 "..\..\Views\Device\Import.cshtml"
                            }
                            else if (field.Item1 == DeviceImportFieldTypes.BatchId.ToString())
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span>(<a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"Devices_Import_Documentation_DeviceBatches_Button\"");

WriteLiteral(">Show IDs</a>)</span>\r\n");

            
            #line 95 "..\..\Views\Device\Import.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                    </tr>                   \r\n");

            
            #line 99 "..\..\Views\Device\Import.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n\r\n        <div");

WriteLiteral(" id=\"Devices_Import_Documentation_DeviceModels_Dialog\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(" title=\"Disco Device Model Ids\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(@">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Description</th>
                        <th>Manufacturer</th>
                        <th>Model</th>
                    </tr>
                </thead>
                <tbody>
");

            
            #line 115 "..\..\Views\Device\Import.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 115 "..\..\Views\Device\Import.cshtml"
                     foreach (var dm in Model.DeviceModels)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr>\r\n                            <td>");

            
            #line 118 "..\..\Views\Device\Import.cshtml"
                           Write(Html.ActionLink(dm.Id.ToString(), MVC.Config.DeviceModel.Index(dm.Id)));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td>");

            
            #line 119 "..\..\Views\Device\Import.cshtml"
                           Write(dm.ToString());

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td>");

            
            #line 120 "..\..\Views\Device\Import.cshtml"
                           Write(dm.Manufacturer);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td>");

            
            #line 121 "..\..\Views\Device\Import.cshtml"
                           Write(dm.Model);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        </tr>\r\n");

            
            #line 123 "..\..\Views\Device\Import.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" id=\"Devices_Import_Documentation_DeviceProfiles_Dialog\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(" title=\"Disco Device Profile Ids\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(@">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Short Name</th>
                        <th>Description</th>
                    </tr>
                </thead>
                <tbody>
");

            
            #line 139 "..\..\Views\Device\Import.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 139 "..\..\Views\Device\Import.cshtml"
                     foreach (var dp in Model.DeviceProfiles)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr>\r\n                            <td>");

            
            #line 142 "..\..\Views\Device\Import.cshtml"
                           Write(Html.ActionLink(dp.Id.ToString(), MVC.Config.DeviceProfile.Index(dp.Id)));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td>");

            
            #line 143 "..\..\Views\Device\Import.cshtml"
                           Write(dp.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td>");

            
            #line 144 "..\..\Views\Device\Import.cshtml"
                           Write(dp.ShortName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td>");

            
            #line 145 "..\..\Views\Device\Import.cshtml"
                           Write(dp.Description);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        </tr>\r\n");

            
            #line 147 "..\..\Views\Device\Import.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" id=\"Devices_Import_Documentation_DeviceBatches_Dialog\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(" title=\"Disco Device Batch Ids\"");

WriteLiteral(">\r\n            <table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(@">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Purchase Date</th>
                    </tr>
                </thead>
                <tbody>
");

            
            #line 162 "..\..\Views\Device\Import.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 162 "..\..\Views\Device\Import.cshtml"
                     foreach (var db in Model.DeviceBatches)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr>\r\n                            <td>");

            
            #line 165 "..\..\Views\Device\Import.cshtml"
                           Write(Html.ActionLink(db.Id.ToString(), MVC.Config.DeviceBatch.Index(db.Id)));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td>");

            
            #line 166 "..\..\Views\Device\Import.cshtml"
                           Write(db.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td>");

            
            #line 167 "..\..\Views\Device\Import.cshtml"
                           Write(CommonHelpers.FriendlyDate(db.PurchaseDate));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        </tr>\r\n");

            
            #line 169 "..\..\Views\Device\Import.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n        <script" +
">\r\n            $(function () {\r\n                var dialogOptions = {\r\n         " +
"           width: 700,\r\n                    height: 600,\r\n                    re" +
"sizable: false,\r\n                    modal: true,\r\n                    autoOpen:" +
" false\r\n                },\r\n                $DeviceModelsDialog = null,\r\n       " +
"         $DeviceProfilesDialog = null,\r\n                $DeviceBatchesDialog = n" +
"ull;\r\n\r\n                $(\'#Devices_Import_Documentation_DeviceModels_Button\').c" +
"lick(function (e) {\r\n                    e.preventDefault();\r\n                  " +
"  if (!$DeviceModelsDialog)\r\n                        $DeviceModelsDialog = $(\'#D" +
"evices_Import_Documentation_DeviceModels_Dialog\').dialog(dialogOptions);\r\n      " +
"              $DeviceModelsDialog.dialog(\'open\');\r\n                });\r\n\r\n      " +
"          $(\'#Devices_Import_Documentation_DeviceProfiles_Button\').click(functio" +
"n (e) {\r\n                    e.preventDefault();\r\n                    if (!$Devi" +
"ceProfilesDialog)\r\n                        $DeviceProfilesDialog = $(\'#Devices_I" +
"mport_Documentation_DeviceProfiles_Dialog\').dialog(dialogOptions);\r\n            " +
"        $DeviceProfilesDialog.dialog(\'open\');\r\n                });\r\n            " +
"    $(\'#Devices_Import_Documentation_DeviceBatches_Button\').click(function (e) {" +
"\r\n                    e.preventDefault();\r\n                    if (!$DeviceBatch" +
"esDialog)\r\n                        $DeviceBatchesDialog = $(\'#Devices_Import_Doc" +
"umentation_DeviceBatches_Dialog\').dialog(dialogOptions);\r\n                    $D" +
"eviceBatchesDialog.dialog(\'open\');\r\n                });\r\n            });\r\n      " +
"  </script>\r\n    </div>\r\n</div>\r\n");

            
            #line 210 "..\..\Views\Device\Import.cshtml"
 if (Model.CompletedImportSessionContext != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"Devices_Import_Completed_Dialog\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(" title=\"Device Import Completed\"");

WriteLiteral(">\r\n        <h3><i");

WriteLiteral(" class=\"fa fa-lg fa-check\"");

WriteLiteral("></i>Successfully imported/updated ");

            
            #line 213 "..\..\Views\Device\Import.cshtml"
                                                                      Write(Model.CompletedImportSessionContext.AffectedRecords);

            
            #line default
            #line hidden
WriteLiteral(" device");

            
            #line 213 "..\..\Views\Device\Import.cshtml"
                                                                                                                                  Write(Model.CompletedImportSessionContext.AffectedRecords != 1 ? "s" : null);

            
            #line default
            #line hidden
WriteLiteral(".</h3>\r\n        <div>File: <code>");

            
            #line 214 "..\..\Views\Device\Import.cshtml"
                    Write(Model.CompletedImportSessionContext.Filename);

            
            #line default
            #line hidden
WriteLiteral("</code></div>\r\n    </div>\r\n");

WriteLiteral(@"    <script>
        $(function () {
            $('#Devices_Import_Completed_Dialog')
                .dialog({
                    width: 500,
                    resizable: false,
                    modal: true,
                    autoOpen: true,
                    buttons: {
                        Close: function () {
                            $(this).dialog('destroy');
                        }
                    }
                });
        });
    </script>
");

            
            #line 232 "..\..\Views\Device\Import.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
