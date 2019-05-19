// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.RenderTree;

namespace Microsoft.AspNetCore.Components
{
    /// <summary>
    /// Denotes the target member as a component parameter.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class ParameterAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets a value that determines whether the parameter will capture the values of
        /// additional attributes that don't match any other parameter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// <see cref="CaptureExtraAttributes"/> allows a component to accept arbitrary additional
        /// attributes, and pass them to another component, or some element of the underlying markup.
        /// </para>
        /// <para>
        /// <see cref="CaptureExtraAttributes"/> can be used on at most one parameter per component.
        /// </para>
        /// <para>
        /// <see cref="CaptureExtraAttributes"/> should only be applied to parameters of a type that
        /// can be used with <see cref="RenderTreeBuilder.AddMultipleAttributes{T}(int, System.Collections.Generic.IEnumerable{System.Collections.Generic.KeyValuePair{string, T}})"/>
        /// such as <see cref="Dictionary{String, Object}"/>.
        /// </para>
        /// </remarks>
        public bool CaptureExtraAttributes { get; set; }
    }
}
