﻿using System;

namespace LightsOut.Extensions
{
    /// <summary>
    /// Extension methods for all objects
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Method for ensuring that the given object is not null
        /// </summary>
        /// <param name="obj">The object being checked</param>
        /// <param name="paramName">The name of the parameter being checked</param>
        public static void EnsureNotNull(this object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }
}
