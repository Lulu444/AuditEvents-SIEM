// ----------------------------------------------------------------------------------------------------
// <copyright file="Apprenda81CallsiteMap.PlatformRegistry.cs" company="Apprenda, Inc.">
// Copyright (c) Apprenda, Inc. All rights reserved.
// Licensed under the MIT license. See the LICENSE.md in the project root for full license information.
// </copyright>
// ----------------------------------------------------------------------------------------------------

namespace Apprenda.AuditEventForwarder.Syslog
{
    /// <summary>
    /// This partial provides the mappings for the Registry Service component of the Apprenda Cloud Platform
    /// </summary>
    public partial class Apprenda81CallsiteMapCEF
    {
        /// <summary>
        /// Adds the mappings for the Registry Service component of the Apprenda Cloud Platform
        /// </summary>
        private void ConfigureRegistryService()
        {
            AddDefaultMapCef("Platform Registry Set Value","PR1");
            AddDefaultMapCef("Platform Registry Delete Value", "PR2");
        }
    }
}