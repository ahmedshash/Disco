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

namespace Disco.Web.Areas.Public.Views.HeldDevices
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
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Public/Views/HeldDevices/Noticeboard.cshtml")]
    public partial class Noticeboard : Disco.Services.Web.WebViewPage<dynamic>
    {
        public Noticeboard()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Public\Views\HeldDevices\Noticeboard.cshtml"
  
    Layout = null;
    Html.BundleDeferred("~/ClientScripts/Modules/jQuery-SignalR");
    Html.BundleDeferred("~/ClientScripts/Core");
    Html.BundleDeferred("~/Style/Public/HeldDevicesNoticeboard");

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(" />\r\n    <title>Disco - Held Devices</title>\r\n");

WriteLiteral("    ");

            
            #line 13 "..\..\Areas\Public\Views\HeldDevices\Noticeboard.cshtml"
Write(Html.BundleRenderDeferred());

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n<body>\r\n    <div");

WriteLiteral(" id=\"page\"");

WriteLiteral(">\r\n        <header");

WriteLiteral(" id=\"mainHeader\"");

WriteLiteral(">\r\n            Held Devices\r\n        </header>\r\n        <section");

WriteLiteral(" id=\"mainSection\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"inProcess\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n                <h3>In Process <span");

WriteLiteral(" id=\"inProcessCount\"");

WriteLiteral("></span>\r\n                </h3>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <ul>\r\n                    </ul>\r\n                </div>\r\n " +
"           </div>\r\n            <div");

WriteLiteral(" id=\"readyForReturn\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n                <h3>Ready for Return <span");

WriteLiteral(" id=\"readyForReturnCount\"");

WriteLiteral("></span>\r\n                </h3>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <ul>\r\n                    </ul>\r\n                </div>\r\n " +
"           </div>\r\n            <div");

WriteLiteral(" id=\"waitingForUserAction\"");

WriteLiteral(" class=\"list\"");

WriteLiteral(">\r\n                <h3>Waiting for User Action <span");

WriteLiteral(" id=\"waitingForUserActionCount\"");

WriteLiteral("></span>\r\n                </h3>\r\n                <div");

WriteLiteral(" class=\"content\"");

WriteLiteral(">\r\n                    <ul>\r\n                    </ul>\r\n                </div>\r\n " +
"           </div>\r\n        </section>\r\n        <footer>\r\n        </footer>\r\n    " +
"</div>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        // Resizing\r\n        $(function () {\r\n            var $inProcess = $(\'" +
"#inProcess\');\r\n            var $inProcessContent = $inProcess.find(\'.content\');\r" +
"\n            var $inProcessHeader = $inProcess.find(\'.h3\');\r\n            var $re" +
"adyForReturn = $(\'#readyForReturn\');\r\n            var $readyForReturnContent = $" +
"readyForReturn.find(\'.content\');\r\n            var $readyForReturnHeader = $ready" +
"ForReturn.find(\'.h3\');\r\n            var $waitingForUserAction = $(\'#waitingForUs" +
"erAction\');\r\n            var $waitingForUserActionContent = $waitingForUserActio" +
"n.find(\'.content\');\r\n            var $waitingForUserActionHeader = $waitingForUs" +
"erAction.find(\'.h3\');\r\n            var $mainSection = $(\'#mainSection\');\r\n      " +
"      var $mainHeader = $(\'#mainHeader\');\r\n            var $mainFooter = $(\'#mai" +
"nFooter\');\r\n\r\n            var onResize = function () {\r\n                var widt" +
"h = $mainSection.width();\r\n                var height = $(window).height() - $ma" +
"inHeader.outerHeight() - $mainFooter.outerHeight() - 25;\r\n\r\n                $inP" +
"rocess.height(height);\r\n                $inProcess.width((width * .28) - 11);\r\n " +
"               $inProcessContent.height(height - $inProcessHeader.outerHeight() " +
"- 56);\r\n\r\n                $readyForReturn.height(height);\r\n                $read" +
"yForReturn.width((width * .36) - 11);\r\n                $readyForReturnContent.he" +
"ight(height - $readyForReturnHeader.outerHeight() - 56);\r\n\r\n                $wai" +
"tingForUserAction.height(height);\r\n                $waitingForUserAction.width((" +
"width * .36) - 11);\r\n                $waitingForUserActionContent.height(height " +
"- $waitingForUserActionHeader.outerHeight() - 56);\r\n            };\r\n\r\n          " +
"  $(window).resize(onResize);\r\n            onResize();\r\n        });\r\n    </scrip" +
"t>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        // Hide Mouse Mouse
        $(function () {
            var mouseVisible = true;
            var mouseHideToken;
            var documentBody = $('body');

            var hideMouse = function () {
                if (mouseVisible) {
                    documentBody.css('cursor', 'none');
                    mouseVisible = false;
                }
            };
            var showMouse = function () {
                if (!mouseVisible) {
                    documentBody.css('cursor', 'auto');
                    mouseVisible = true;
                }
            };

            $(document).mousemove(function () {
                showMouse();
                if (mouseHideToken)
                    window.clearTimeout(mouseHideToken);
                mouseHideToken = window.setTimeout(hideMouse, 2000);
            });
        });
    </script>
    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var models = {};\r\n            var modelsI" +
"nProcessSorted = [];\r\n            var modelsInProcessCount = 0;\r\n            var" +
" modelsReadyForReturnSorted = [];\r\n            var modelsReadyForReturnCount = 0" +
";\r\n            var modelsWaitingForUserActionSorted = [];\r\n            var model" +
"sWaitingForUserActionCount = 0;\r\n            var $inProcess = $(\'#inProcess\');\r\n" +
"            var $inProcessContent = $inProcess.find(\'.content ul\');\r\n           " +
" var $readyForReturn = $(\'#readyForReturn\');\r\n            var $readyForReturnCon" +
"tent = $readyForReturn.find(\'.content ul\');\r\n            var $waitingForUserActi" +
"on = $(\'#waitingForUserAction\');\r\n            var $waitingForUserActionContent =" +
" $waitingForUserAction.find(\'.content ul\');\r\n            var modelsInProcessInde" +
"xOffset = 0;\r\n            var scrollInProcessToken = null;\r\n            var mode" +
"lsReadyForReturnIndexOffset = 0;\r\n            var scrollReadyForReturnToken = nu" +
"ll;\r\n            var modelsWaitingForUserActionIndexOffset = 0;\r\n            var" +
" scrollWaitingForUserActionToken = null;\r\n            var scrollSpeed = 3000;\r\n " +
"           var persistantConnection = null;\r\n            var filterDeviceAddress" +
"Include;\r\n            var filterDeviceAddressExclude;\r\n            var filterDev" +
"iceProfileInclude;\r\n            var filterDeviceProfileExclude;\r\n\r\n            v" +
"ar getParameterByName = function (name) {\r\n                name = name.replace(/" +
"[\\[]/, \"\\\\\\[\").replace(/[\\]]/, \"\\\\\\]\");\r\n                var regexS = \"[\\\\?&]\" +" +
" name + \"=([^&#]*)\";\r\n                var regex = new RegExp(regexS);\r\n         " +
"       var results = regex.exec(window.location.search);\r\n                if (re" +
"sults == null)\r\n                    return \"\";\r\n                else\r\n          " +
"          return decodeURIComponent(results[1].replace(/\\+/g, \" \"));\r\n          " +
"  }\r\n\r\n            var buildFilters = function () {\r\n                var deviceA" +
"ddressInclude = getParameterByName(\'deviceAddressInclude\');\r\n                if " +
"(deviceAddressInclude) {\r\n                    filterDeviceAddressInclude = {};\r\n" +
"                    var split = deviceAddressInclude.split(\",\");\r\n              " +
"      for (var i = 0; i < split.length; i++) {\r\n                        filterDe" +
"viceAddressInclude[split[i].toLowerCase()] = true;\r\n                    }\r\n     " +
"           } else {\r\n                    var deviceAddressExclude = getParameter" +
"ByName(\'deviceAddressExclude\');\r\n                    if (deviceAddressExclude) {" +
"\r\n                        filterDeviceAddressExclude = {};\r\n                    " +
"    var split = deviceAddressExclude.split(\",\");\r\n                        for (v" +
"ar i = 0; i < split.length; i++) {\r\n                            filterDeviceAddr" +
"essExclude[split[i].toLowerCase()] = true;\r\n                        }\r\n         " +
"           } else {\r\n                        var deviceProfileInclude = getParam" +
"eterByName(\'deviceProfileInclude\');\r\n                        if (deviceProfileIn" +
"clude) {\r\n                            filterDeviceProfileInclude = {};\r\n        " +
"                    var deviceProfileIncludeSplit = deviceProfileInclude.split(\"" +
",\");\r\n                            for (var i = 0; i < deviceProfileIncludeSplit." +
"length; i++) {\r\n                                filterDeviceProfileInclude[parse" +
"Int(deviceProfileIncludeSplit[i])] = true;\r\n                            }\r\n     " +
"                   } else {\r\n                            var deviceProfileExclud" +
"e = getParameterByName(\'deviceProfileExclude\');\r\n                            if " +
"(deviceProfileExclude) {\r\n                                filterDeviceProfileExc" +
"lude = {};\r\n                                var deviceProfileExcludeSplit = devi" +
"ceProfileExclude.split(\",\");\r\n                                for (var i = 0; i " +
"< deviceProfileExcludeSplit.length; i++) {\r\n                                    " +
"filterDeviceProfileExclude[parseInt(deviceProfileExcludeSplit[i])] = true;\r\n    " +
"                            }\r\n                            }\r\n                  " +
"      }\r\n                    }\r\n                }\r\n            }\r\n            va" +
"r calculateFilter = function (model) {\r\n                if (model) {\r\n          " +
"          if (filterDeviceAddressInclude) {\r\n                        return (fil" +
"terDeviceAddressInclude[model.DeviceAddress.toLowerCase()] == true)\r\n           " +
"         }\r\n                    if (filterDeviceAddressExclude) {\r\n             " +
"           return (!filterDeviceAddressExclude[model.DeviceAddress.toLowerCase()" +
"])\r\n                    }\r\n                    if (filterDeviceProfileInclude) {" +
"\r\n                        return (filterDeviceProfileInclude[model.DeviceProfile" +
"Id] == true)\r\n                    }\r\n                    if (filterDeviceProfile" +
"Exclude) {\r\n                        return (!filterDeviceProfileExclude[model.De" +
"viceProfileId])\r\n                    }\r\n                    return true;\r\n      " +
"          }\r\n                return false;\r\n            }\r\n\r\n            var sor" +
"tModels = function () {\r\n                modelsInProcessSorted = [];\r\n          " +
"      modelsReadyForReturnSorted = [];\r\n                modelsWaitingForUserActi" +
"onSorted = [];\r\n                var modelSortFunc = function (a, b) {\r\n         " +
"           if (a.DeviceSerialNumber.toUpperCase() == b.DeviceSerialNumber.toUppe" +
"rCase()) {\r\n                        return 0;\r\n                    } else {\r\n   " +
"                     if (a.DeviceSerialNumber.toUpperCase() < b.DeviceSerialNumb" +
"er.toUpperCase()) {\r\n                            return -1\r\n                    " +
"    } else {\r\n                            return 1\r\n                        }\r\n " +
"                   }\r\n                };\r\n                for (var key in models" +
") {\r\n                    var model = models[key];\r\n                    if (model" +
") {\r\n                        if (model.WaitingForUserAction) {\r\n                " +
"            modelsWaitingForUserActionSorted.push(model);\r\n                     " +
"   } else {\r\n                            if (model.ReadyForReturn) {\r\n          " +
"                      modelsReadyForReturnSorted.push(model);\r\n                 " +
"           } else {\r\n                                modelsInProcessSorted.push(" +
"model);\r\n                            }\r\n                        }\r\n             " +
"       }\r\n                }\r\n                modelsReadyForReturnSorted = models" +
"ReadyForReturnSorted.sort(modelSortFunc);\r\n                modelsInProcessSorted" +
" = modelsInProcessSorted.sort(modelSortFunc);\r\n                modelsWaitingForU" +
"serActionSorted = modelsWaitingForUserActionSorted.sort(modelSortFunc);\r\n\r\n     " +
"           if (modelsInProcessSorted.length != modelsInProcessCount) {\r\n        " +
"            modelsInProcessCount = modelsInProcessSorted.length;\r\n              " +
"      $(\'#inProcessCount\').text(\'(\' + modelsInProcessCount + \')\');\r\n            " +
"    }\r\n                if (modelsReadyForReturnSorted.length != modelsReadyForRe" +
"turnCount) {\r\n                    modelsReadyForReturnCount = modelsReadyForRetu" +
"rnSorted.length;\r\n                    $(\'#readyForReturnCount\').text(\'(\' + model" +
"sReadyForReturnCount + \')\');\r\n                }\r\n                if (modelsWaiti" +
"ngForUserActionSorted.length != modelsWaitingForUserActionCount) {\r\n            " +
"        modelsWaitingForUserActionCount = modelsWaitingForUserActionSorted.lengt" +
"h;\r\n                    $(\'#waitingForUserActionCount\').text(\'(\' + modelsWaiting" +
"ForUserActionCount + \')\');\r\n                }\r\n\r\n            };\r\n\r\n            v" +
"ar scrollReadyForReturn = function () {\r\n                $readyForReturnContent." +
"find(\'li\').last().detach().prependTo($readyForReturnContent).hide().slideDown(\'s" +
"low\');\r\n                modelsReadyForReturnIndexOffset++;\r\n                if (" +
"modelsReadyForReturnIndexOffset >= modelsReadyForReturnSorted.length) {\r\n       " +
"             modelsReadyForReturnIndexOffset = 0;\r\n                }\r\n          " +
"      scrollReadyForReturnToken = window.setTimeout(scrollReadyForReturn, scroll" +
"Speed);\r\n            };\r\n            var updateScrollReadyForReturn = function (" +
") {\r\n                var containerHeight = $readyForReturn.find(\'.content\').heig" +
"ht();\r\n                var contentHeight = $readyForReturnContent.height();\r\n   " +
"             if (containerHeight >= contentHeight && scrollReadyForReturnToken) " +
"{\r\n                    window.clearTimeout(scrollReadyForReturnToken);\r\n        " +
"            return;\r\n                }\r\n                if (containerHeight < co" +
"ntentHeight && scrollReadyForReturnToken == null) {\r\n                    scrollR" +
"eadyForReturnToken = window.setTimeout(scrollReadyForReturn, scrollSpeed);\r\n    " +
"            }\r\n            };\r\n            var scrollInProcess = function () {\r\n" +
"                $inProcessContent.find(\'li\').last().detach().prependTo($inProces" +
"sContent).hide().slideDown(\'slow\');\r\n                modelsInProcessIndexOffset+" +
"+;\r\n                if (modelsInProcessIndexOffset >= modelsInProcessSorted.leng" +
"th) {\r\n                    modelsInProcessIndexOffset = 0;\r\n                }\r\n " +
"               scrollInProcessToken = window.setTimeout(scrollInProcess, scrollS" +
"peed);\r\n            };\r\n            var updateScrollInProcess = function () {\r\n " +
"               var containerHeight = $inProcess.find(\'.content\').height();\r\n    " +
"            var contentHeight = $inProcessContent.height();\r\n                if " +
"(containerHeight >= contentHeight && scrollInProcessToken) {\r\n                  " +
"  window.clearTimeout(scrollInProcessToken);\r\n                    return;\r\n     " +
"           }\r\n                if (containerHeight < contentHeight && scrollInPro" +
"cessToken == null) {\r\n                    scrollInProcessToken = window.setTimeo" +
"ut(scrollInProcess, scrollSpeed);\r\n                }\r\n            };\r\n          " +
"  var scrollWaitingForUserAction = function () {\r\n                $waitingForUse" +
"rActionContent.find(\'li\').last().detach().prependTo($waitingForUserActionContent" +
").hide().slideDown(\'slow\');\r\n                modelsInProcessIndexOffset++;\r\n    " +
"            if (modelsWaitingForUserActionIndexOffset >= modelsWaitingForUserAct" +
"ionSorted.length) {\r\n                    modelsWaitingForUserActionIndexOffset =" +
" 0;\r\n                }\r\n                scrollWaitingForUserActionToken = window" +
".setTimeout(scrollWaitingForUserAction, scrollSpeed);\r\n            };\r\n         " +
"   var updateScrollWaitingForUserAction = function () {\r\n                var con" +
"tainerHeight = $waitingForUserAction.find(\'.content\').height();\r\n               " +
" var contentHeight = $waitingForUserActionContent.height();\r\n                if " +
"(containerHeight >= contentHeight && scrollWaitingForUserActionToken) {\r\n       " +
"             window.clearTimeout(scrollWaitingForUserActionToken);\r\n            " +
"        return;\r\n                }\r\n                if (containerHeight < conten" +
"tHeight && scrollWaitingForUserActionToken == null) {\r\n                    scrol" +
"lWaitingForUserActionToken = window.setTimeout(scrollWaitingForUserAction, scrol" +
"lSpeed);\r\n                }\r\n            };\r\n\r\n            var modelInsertIndex " +
"= function (model) {\r\n                sortModels();\r\n                var findInd" +
"ex = function (model, array, offset) {\r\n                    for (var i = 0; i < " +
"array.length; i++) {\r\n                        if (model.DeviceSerialNumber == ar" +
"ray[i].DeviceSerialNumber) {\r\n                            var index = i + offset" +
";\r\n                            if (index > (array.length - 1)) {\r\n              " +
"                  index = index - (array.length - 1);\r\n                         " +
"   }\r\n                            return index;\r\n                        }\r\n    " +
"                };\r\n                };\r\n                if (model.WaitingForUser" +
"Action) {\r\n                    return findIndex(model, modelsWaitingForUserActio" +
"nSorted, modelsWaitingForUserActionIndexOffset);\r\n                } else {\r\n    " +
"                if (model.ReadyForReturn) {\r\n                        return find" +
"Index(model, modelsReadyForReturnSorted, modelsReadyForReturnIndexOffset);\r\n    " +
"                } else {\r\n                        return findIndex(model, models" +
"InProcessSorted, modelsInProcessIndexOffset);\r\n                    }\r\n          " +
"      }\r\n            }\r\n            var modelInsert = function (model) {\r\n      " +
"          var index = modelInsertIndex(model);\r\n                var insertTo = f" +
"unction (model, host) {\r\n                    var hostLi = host.children(\'li\');\r\n" +
"                    if (hostLi.length == 0 || hostLi.length < index) {\r\n        " +
"                host.append(model.htmlLi);\r\n                    } else {\r\n      " +
"                  if (index == 0) {\r\n                            host.prepend(mo" +
"del.htmlLi);\r\n                        } else {\r\n                            $(ho" +
"stLi.get(index - 1)).after(model.htmlLi);\r\n                        }\r\n          " +
"          }\r\n                }\r\n                if (model.WaitingForUserAction) " +
"{\r\n                    insertTo(model, $waitingForUserActionContent);\r\n         " +
"           window.setTimeout(updateScrollWaitingForUserAction, 100);\r\n          " +
"      } else {\r\n                    if (model.ReadyForReturn) {\r\n               " +
"         insertTo(model, $readyForReturnContent);\r\n                        windo" +
"w.setTimeout(updateScrollReadyForReturn, 100);\r\n                    } else {\r\n  " +
"                      insertTo(model, $inProcessContent);\r\n                     " +
"   window.setTimeout(updateScrollInProcess, 100);\r\n                    }\r\n      " +
"          }\r\n            }\r\n\r\n            var removeModel = function (model) {\r\n" +
"                if (model) {\r\n                    model.htmlLi.slideUp(\'fast\', f" +
"unction () {\r\n                        model.htmlLi.remove();\r\n                  " +
"  });\r\n                }\r\n            };\r\n\r\n            var processModel = funct" +
"ion (id, model, init) {\r\n                if (!calculateFilter(model)) {\r\n       " +
"             removeModel(models[id]);\r\n                    delete models[id];\r\n " +
"                   sortModels();\r\n                } else {\r\n                    " +
"var existing = models[id];\r\n                    models[id] = model;\r\n\r\n         " +
"           // Add\r\n                    model.htmlContent = $(\'<div>\').text(model" +
".DeviceDescription);\r\n                    if (!model.ReadyForReturn && model.Est" +
"imatedReturnTime) {\r\n                        model.htmlContent.append($(\'<span c" +
"lass=\"small\">\').text(\' (Expected: \' + model.EstimatedReturnTime + \')\'));\r\n      " +
"              }\r\n                    if (model.WaitingForUserAction) {\r\n        " +
"                model.htmlContent.append($(\'<span class=\"small\">\').text(\' (Since" +
" \' + model.WaitingForUserActionSince + \')\'));\r\n                    } else {\r\n   " +
"                     if (model.ReadyForReturn && model.ReadyForReturnSince) {\r\n " +
"                           model.htmlContent.append($(\'<span class=\"small\">\').te" +
"xt(\' (Ready \' + model.ReadyForReturnSince + \')\'));\r\n                        }\r\n " +
"                   }\r\n\r\n                    if (existing) {\r\n                   " +
"     if (existing.ReadyForReturn != model.ReadyForReturn || existing.WaitingForU" +
"serAction != model.WaitingForUserAction) {\r\n                            removeMo" +
"del(existing);\r\n                            model.htmlLi = $(\'<li>\').html(model." +
"htmlContent).data(\'ModelId\', id).hide();\r\n                            modelInser" +
"t(model);\r\n                            if (init) {\r\n                            " +
"    model.htmlLi.fadeIn();\r\n                            } else {\r\n              " +
"                  model.htmlLi.slideDown();\r\n                            }\r\n    " +
"                    } else {\r\n                            model.htmlLi = existin" +
"g.htmlLi;\r\n                            model.htmlLi.slideUp(\'fast\', function () " +
"{\r\n                                model.htmlLi.html(model.htmlContent).slideDow" +
"n();\r\n                            });\r\n                        }\r\n              " +
"      } else {\r\n                        model.htmlLi = $(\'<li>\').html(model.html" +
"Content).data(\'ModelId\', id).hide();\r\n                        modelInsert(model)" +
";\r\n                        if (init) {\r\n                            model.htmlLi" +
".fadeIn();\r\n                        } else {\r\n                            model." +
"htmlLi.slideDown(\'slow\');\r\n                        }\r\n                    }\r\n   " +
"                 if (model.htmlLi && model.IsAlert) {\r\n                        m" +
"odel.htmlLi.addClass(\'alert\');\r\n                    }\r\n                }\r\n      " +
"      };\r\n\r\n            var updatedModel = function (id) {\r\n                var " +
"deviceSerialNumber = id.toString();\r\n\r\n                $.ajax({\r\n               " +
"     dataType: \'json\',\r\n                    url: \'");

            
            #line 432 "..\..\Areas\Public\Views\HeldDevices\Noticeboard.cshtml"
                      Write(Url.Action(MVC.Public.HeldDevices.HeldDevice()));

            
            #line default
            #line hidden
WriteLiteral(@"',
                    data: { id: deviceSerialNumber },
                    success: function (data) {
                        processModel(deviceSerialNumber, data, false);
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        if (textStatus == 'parsererror') // null Result
                            processModel(deviceSerialNumber, null, false);
                    }
                })
            };

            var connectionError = function () {
                if (persistantConnection) {
                    persistantConnection.stop();
                    persistantConnection = null;
                    window.setTimeout(function () {
                        window.location.href = '");

            
            #line 449 "..\..\Areas\Public\Views\HeldDevices\Noticeboard.cshtml"
                                            Write(Url.Action(MVC.Public.HeldDevices.Noticeboard()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n                    }, 10000);\r\n                    }\r\n            }\r\n\r\n     " +
"       var init = function () {\r\n                buildFilters();\r\n              " +
"  persistantConnection = $.connection(\'");

            
            #line 456 "..\..\Areas\Public\Views\HeldDevices\Noticeboard.cshtml"
                                                 Write(Url.Content("~/Public/HeldDevices/Notifications"));

            
            #line default
            #line hidden
WriteLiteral("\');\r\n                persistantConnection.received(updatedModel);\r\n              " +
"  persistantConnection.error(connectionError);\r\n                persistantConnec" +
"tion.start(function () {\r\n                    $.getJSON(\'");

            
            #line 460 "..\..\Areas\Public\Views\HeldDevices\Noticeboard.cshtml"
                           Write(Url.Action(MVC.Public.HeldDevices.HeldDevices()));

            
            #line default
            #line hidden
WriteLiteral(@"', null, function (data) {
                        for (var i = 0; i < data.length; i++) {
                            processModel(data[i].DeviceSerialNumber, data[i], true);
                        }
                    });
                });
            };
            init();

        });
    </script>
    <div");

WriteLiteral(" id=\"mainFooter\"");

WriteLiteral(">\r\n        <img");

WriteLiteral(" style=\"width: 32px; height: 32px; margin-top: -5px; margin-bottom: -15px;\"");

WriteAttribute("src", Tuple.Create(" src=\"", 22627), Tuple.Create("\"", 22676)
            
            #line 472 "..\..\Areas\Public\Views\HeldDevices\Noticeboard.cshtml"
            , Tuple.Create(Tuple.Create("", 22633), Tuple.Create<System.Object, System.Int32>(Links.ClientSource.Style.Images.Icon32_png
            
            #line default
            #line hidden
, 22633), false)
);

WriteLiteral(" alt=\"Disco Logo\"");

WriteLiteral(" />\r\n        powered by Disco\r\n    </div>\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
