﻿using Disco.Models.Services.Job;
using System.Collections.Generic;

namespace Disco.Models.UI.Config.JobPreferences
{
    public interface ConfigJobPreferencesIndexModel : BaseUIModel
    {
        int LongRunningJobDaysThreshold { get; set; }
        int StaleJobMinutesThreshold { get; set; }
        LocationModes LocationMode { get; set; }
        List<string> LocationList { get; set; }

        List<KeyValuePair<int, string>> LongRunningJobDaysThresholdOptions();
        List<KeyValuePair<int, string>> StaleJobMinutesThresholdOptions();
        List<KeyValuePair<string, string>> LocationModeOptions();
    }
}
