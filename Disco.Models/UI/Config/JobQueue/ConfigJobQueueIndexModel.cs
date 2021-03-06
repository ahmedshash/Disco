﻿using Disco.Models.Services.Jobs.JobQueues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disco.Models.UI.Config.JobQueue
{
    public interface ConfigJobQueueIndexModel : BaseUIModel
    {
        List<IJobQueueToken> Tokens { get; set; }
    }
}
