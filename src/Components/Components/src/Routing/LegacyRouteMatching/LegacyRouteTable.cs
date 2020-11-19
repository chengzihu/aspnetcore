// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Components.LegacyRouteMatching
{
    internal class LegacyRouteTable
    {
        public LegacyRouteTable(LegacyRouteEntry[] routes)
        {
            Routes = routes;
        }

        public LegacyRouteEntry[] Routes { get; }

        internal void Route(Routing.RouteContext routeContext)
        {
            for (var i = 0; i < Routes.Length; i++)
            {
                Routes[i].Match(routeContext);
                if (routeContext.Handler != null)
                {
                    return;
                }
            }
        }
    }
}
