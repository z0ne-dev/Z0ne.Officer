// EnumerationGuard.cs Copyright (c) z0ne.
// All Rights Reserved.
// Licensed under the EUPL 1.2 License.
// See LICENSE the project root for license information.

using System.Collections;

namespace Z0ne.Officer;

public static class CollectionGuard
{
    public static ArgumentGuard<TOuter> Empty<TOuter, TInner>(this ArgumentGuard<TOuter> guard)
        where TOuter : IEnumerable<TInner>
    {
        if (!guard.Value?.Any() ?? false)
        {
            throw new ArgumentException("Enumeration is empty", guard.ParameterName);
        }

        return guard;
    }
}
