// ClassGuard.cs Copyright (c) z0ne.
// All Rights Reserved.
// Licensed under the EUPL 1.2 License.
// See LICENSE the project root for license information.

namespace Z0ne.Officer;

public static class ClassGuard
{
    public static ArgumentGuard<T> Null<T>(this ArgumentGuard<T> guard)
        where T : class
    {
        if (guard.Value is null)
        {
            throw new ArgumentNullException(guard.ParameterName);
        }

        return guard;
    }
}
