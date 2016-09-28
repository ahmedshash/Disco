// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Disco.Web.Areas.API.Controllers
{
    public partial class JobPreferencesController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public JobPreferencesController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected JobPreferencesController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(Task<ActionResult> taskResult)
        {
            return RedirectToAction(taskResult.Result);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(Task<ActionResult> taskResult)
        {
            return RedirectToActionPermanent(taskResult.Result);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateLongRunningJobDaysThreshold()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateLongRunningJobDaysThreshold);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateStaleJobMinutesThreshold()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateStaleJobMinutesThreshold);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateDefaultNoticeboardTheme()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateDefaultNoticeboardTheme);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateLocationMode()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateLocationMode);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult UpdateLocationList()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateLocationList);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult ImportLocationList()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ImportLocationList);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public JobPreferencesController Actions { get { return MVC.API.JobPreferences; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "API";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "JobPreferences";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "JobPreferences";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string UpdateLongRunningJobDaysThreshold = "UpdateLongRunningJobDaysThreshold";
            public readonly string UpdateStaleJobMinutesThreshold = "UpdateStaleJobMinutesThreshold";
            public readonly string UpdateDefaultNoticeboardTheme = "UpdateDefaultNoticeboardTheme";
            public readonly string UpdateLocationMode = "UpdateLocationMode";
            public readonly string UpdateLocationList = "UpdateLocationList";
            public readonly string ImportLocationList = "ImportLocationList";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string UpdateLongRunningJobDaysThreshold = "UpdateLongRunningJobDaysThreshold";
            public const string UpdateStaleJobMinutesThreshold = "UpdateStaleJobMinutesThreshold";
            public const string UpdateDefaultNoticeboardTheme = "UpdateDefaultNoticeboardTheme";
            public const string UpdateLocationMode = "UpdateLocationMode";
            public const string UpdateLocationList = "UpdateLocationList";
            public const string ImportLocationList = "ImportLocationList";
        }


        static readonly ActionParamsClass_UpdateLongRunningJobDaysThreshold s_params_UpdateLongRunningJobDaysThreshold = new ActionParamsClass_UpdateLongRunningJobDaysThreshold();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateLongRunningJobDaysThreshold UpdateLongRunningJobDaysThresholdParams { get { return s_params_UpdateLongRunningJobDaysThreshold; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateLongRunningJobDaysThreshold
        {
            public readonly string LongRunningJobDaysThreshold = "LongRunningJobDaysThreshold";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateStaleJobMinutesThreshold s_params_UpdateStaleJobMinutesThreshold = new ActionParamsClass_UpdateStaleJobMinutesThreshold();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateStaleJobMinutesThreshold UpdateStaleJobMinutesThresholdParams { get { return s_params_UpdateStaleJobMinutesThreshold; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateStaleJobMinutesThreshold
        {
            public readonly string StaleJobMinutesThreshold = "StaleJobMinutesThreshold";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateDefaultNoticeboardTheme s_params_UpdateDefaultNoticeboardTheme = new ActionParamsClass_UpdateDefaultNoticeboardTheme();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateDefaultNoticeboardTheme UpdateDefaultNoticeboardThemeParams { get { return s_params_UpdateDefaultNoticeboardTheme; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateDefaultNoticeboardTheme
        {
            public readonly string DefaultNoticeboardTheme = "DefaultNoticeboardTheme";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateLocationMode s_params_UpdateLocationMode = new ActionParamsClass_UpdateLocationMode();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateLocationMode UpdateLocationModeParams { get { return s_params_UpdateLocationMode; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateLocationMode
        {
            public readonly string LocationMode = "LocationMode";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_UpdateLocationList s_params_UpdateLocationList = new ActionParamsClass_UpdateLocationList();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_UpdateLocationList UpdateLocationListParams { get { return s_params_UpdateLocationList; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_UpdateLocationList
        {
            public readonly string LocationList = "LocationList";
            public readonly string redirect = "redirect";
        }
        static readonly ActionParamsClass_ImportLocationList s_params_ImportLocationList = new ActionParamsClass_ImportLocationList();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_ImportLocationList ImportLocationListParams { get { return s_params_ImportLocationList; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_ImportLocationList
        {
            public readonly string LocationList = "LocationList";
            public readonly string AutomaticList = "AutomaticList";
            public readonly string Override = "Override";
            public readonly string redirect = "redirect";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
            }
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_JobPreferencesController : Disco.Web.Areas.API.Controllers.JobPreferencesController
    {
        public T4MVC_JobPreferencesController() : base(Dummy.Instance) { }

        [NonAction]
        partial void UpdateLongRunningJobDaysThresholdOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int LongRunningJobDaysThreshold, bool redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateLongRunningJobDaysThreshold(int LongRunningJobDaysThreshold, bool redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateLongRunningJobDaysThreshold);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "LongRunningJobDaysThreshold", LongRunningJobDaysThreshold);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateLongRunningJobDaysThresholdOverride(callInfo, LongRunningJobDaysThreshold, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateStaleJobMinutesThresholdOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int StaleJobMinutesThreshold, bool redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateStaleJobMinutesThreshold(int StaleJobMinutesThreshold, bool redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateStaleJobMinutesThreshold);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "StaleJobMinutesThreshold", StaleJobMinutesThreshold);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateStaleJobMinutesThresholdOverride(callInfo, StaleJobMinutesThreshold, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateDefaultNoticeboardThemeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string DefaultNoticeboardTheme, bool redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateDefaultNoticeboardTheme(string DefaultNoticeboardTheme, bool redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateDefaultNoticeboardTheme);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "DefaultNoticeboardTheme", DefaultNoticeboardTheme);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateDefaultNoticeboardThemeOverride(callInfo, DefaultNoticeboardTheme, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateLocationModeOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Disco.Models.Services.Job.LocationModes LocationMode, bool redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateLocationMode(Disco.Models.Services.Job.LocationModes LocationMode, bool redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateLocationMode);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "LocationMode", LocationMode);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateLocationModeOverride(callInfo, LocationMode, redirect);
            return callInfo;
        }

        [NonAction]
        partial void UpdateLocationListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string[] LocationList, bool redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult UpdateLocationList(string[] LocationList, bool redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.UpdateLocationList);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "LocationList", LocationList);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            UpdateLocationListOverride(callInfo, LocationList, redirect);
            return callInfo;
        }

        [NonAction]
        partial void ImportLocationListOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string LocationList, bool AutomaticList, bool Override, bool redirect);

        [NonAction]
        public override System.Web.Mvc.ActionResult ImportLocationList(string LocationList, bool AutomaticList, bool Override, bool redirect)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.ImportLocationList);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "LocationList", LocationList);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "AutomaticList", AutomaticList);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "Override", Override);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "redirect", redirect);
            ImportLocationListOverride(callInfo, LocationList, AutomaticList, Override, redirect);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591
