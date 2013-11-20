﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Common.Configuration.Fluent
{
    /// <summary>
    /// Defines interface for adding messages when configuring a <see cref="ReplaceHandler"/> for an exception.
    /// <seealso cref="ReplaceHandlerData"/>
    /// </summary>
    public interface IExceptionConfigurationWithMessage : IExceptionConfigurationForExceptionTypeOrPostHandling
    {
        /// <summary>
        /// Use the provided message as part of the new exception.
        /// </summary>
        /// <param name="message">Message to use when providing an alternative exception, typically through wrapping or replacing.</param>
        /// <returns></returns>
        IExceptionConfigurationForExceptionTypeOrPostHandling UsingMessage(string message);

        /// <summary>
        /// Use the message in the specified resource file and name.
        /// </summary>
        /// <param name="resourceType">The type from the assembly with the resource to use for a message</param>
        /// <param name="resourceName">The name of the resource.</param>
        /// <returns></returns>
        IExceptionConfigurationForExceptionTypeOrPostHandling UsingResourceMessage(Type resourceType, string resourceName);
    }
}
