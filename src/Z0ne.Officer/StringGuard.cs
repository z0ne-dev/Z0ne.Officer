// StringGuard.cs Copyright (c) z0ne.
// All Rights Reserved.
// Licensed under the EUPL 1.2 License.
// See LICENSE the project root for license information.

namespace Z0ne.Officer;

public static class StringGuard
{
    public static ArgumentGuard<string> Empty(this ArgumentGuard<string> guard)
    {
        if (string.IsNullOrEmpty(guard.Value))
        {
            throw new ArgumentException("String is null or empty", guard.ParameterName);
        }

        return guard;
    }
    public static ArgumentGuard<string> WhiteSpace(this ArgumentGuard<string> guard)
    {
        if (string.IsNullOrWhiteSpace(guard.Value))
        {
            throw new ArgumentException("String is null or whitespace", guard.ParameterName);
        }

        return guard;
    }
}
