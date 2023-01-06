// ValueGuard.cs Copyright (c) z0ne.
// All Rights Reserved.
// Licensed under the EUPL 1.2 License.
// See LICENSE the project root for license information.

using System.Diagnostics.CodeAnalysis;

namespace Z0ne.Officer;

public sealed partial class ArgumentGuard<T>
{
    internal readonly string ParameterName;

    internal readonly T? Value;

    public T Release => Value!;

    public ArgumentGuard<T> Against => this;

    public ArgumentGuard<T> And => this;

    public ArgumentGuard([AllowNull] T value, string parameterName)
    {
        Value = value;
        ParameterName = parameterName;
    }

    public static implicit operator T(ArgumentGuard<T> guard)
    {
        return guard.Release;
    }

    public ArgumentGuard<T> Default()
    {
        if (Value?.Equals(obj: default) ?? true)
        {
            throw new ArgumentException("Default value not allowed", ParameterName);
        }

        return this;
    }

    public ArgumentGuard<T> InvalidValues(params T[] invalidValue)
    {
        if (invalidValue.Contains(Value))
        {
            throw new ArgumentException($"Value {Value} not allowed", ParameterName);
        }

        return this;
    }
}
