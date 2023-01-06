// EnumGuard.cs Copyright (c) z0ne.
// All Rights Reserved.
// Licensed under the EUPL 1.2 License.
// See LICENSE the project root for license information.

namespace Z0ne.Officer;

public static class EnumGuard
{
    public static ArgumentGuard<T> Unknown<T>(this ArgumentGuard<T> guard)
        where T : struct, Enum
    {
        var values = Enum.GetValues<T>();

        if (!values.Contains(guard.Value))
        {
            throw new ArgumentException("Unknown enum value", guard.ParameterName);
        }

        return guard;
    }

}
