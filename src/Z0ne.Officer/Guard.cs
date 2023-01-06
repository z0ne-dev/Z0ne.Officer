// Guard.cs Copyright (c) z0ne.
// All Rights Reserved.
// Licensed under the EUPL 1.2 License.
// See LICENSE the project root for license information.

using System.Runtime.CompilerServices;

namespace Z0ne.Officer;

public static class Guard
{
    public static ArgumentGuard<T> Argument<T>(T value, [CallerArgumentExpression(nameof(value))] string parameterName = "")
    {
        return new ArgumentGuard<T>(value, parameterName);
    }
}
