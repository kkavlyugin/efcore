// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using JetBrains.Annotations;

#nullable enable

namespace Microsoft.EntityFrameworkCore.Metadata
{
    /// <summary>
    ///     <para>
    ///         Represents a type in an <see cref="IMutableModel" />.
    ///     </para>
    ///     <para>
    ///         This interface is used during model creation and allows the metadata to be modified.
    ///         Once the model is built, <see cref="ITypeBase" /> represents a read-only view of the same metadata.
    ///     </para>
    /// </summary>
    public interface IMutableTypeBase : ITypeBase, IMutableAnnotatable
    {
        /// <summary>
        ///     Gets the model that this type belongs to.
        /// </summary>
        new IMutableModel Model { get; }

        /// <summary>
        ///     Marks the given member name as ignored, preventing conventions from adding a matching property
        ///     or navigation to the type.
        /// </summary>
        /// <param name="memberName"> The name of the member to be ignored. </param>
        /// <returns> The name of the ignored member. </returns>
        string AddIgnored([NotNull] string memberName);

        /// <summary>
        ///     Removes the ignored member name.
        /// </summary>
        /// <param name="memberName"> The name of the member to be removed. </param>
        /// <returns> The removed ignored member name, or <see langword="null" /> if the member name was not found. </returns>
        string? RemoveIgnored([NotNull] string memberName);

        /// <summary>
        ///     Indicates whether the given member name is ignored.
        /// </summary>
        /// <param name="memberName"> The name of the member that might be ignored. </param>
        /// <returns> <see langword="true" /> if the given member name is ignored. </returns>
        bool IsIgnored([NotNull] string memberName);

        /// <summary>
        ///     Gets all the ignored members.
        /// </summary>
        /// <returns> The list of ignored member names. </returns>
        IEnumerable<string> GetIgnoredMembers();
    }
}
