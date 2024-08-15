﻿using System.Collections.Generic;
using MigrationTools.Enrichers;

namespace MigrationTools._EngineV1.Configuration
{
    public class EngineConfiguration
    {
        public EngineConfiguration()
        {
            LogLevel = "Information";
        }

        public IMigrationClientConfig Source { get; set; }
        public IMigrationClientConfig Target { get; set; }
        public Dictionary<string, string> GitRepoMapping { get; set; } = new Dictionary<string, string>();

        public string LogLevel { get; private set; }
        public List<IProcessorConfig> Processors { get; set; }
        public string Version { get; set; }
    }
}
