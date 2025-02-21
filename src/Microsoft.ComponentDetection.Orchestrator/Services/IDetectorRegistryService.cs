﻿using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.ComponentDetection.Contracts;

namespace Microsoft.ComponentDetection.Orchestrator.Services
{
    public interface IDetectorRegistryService
    {
        IEnumerable<IComponentDetector> GetDetectors(IEnumerable<DirectoryInfo> additionalSearchDirectories, IEnumerable<string> extraDetectorAssemblies);

        IEnumerable<IComponentDetector> GetDetectors(Assembly assemblyToSearch, IEnumerable<string> extraDetectorAssemblies);
    }
}
