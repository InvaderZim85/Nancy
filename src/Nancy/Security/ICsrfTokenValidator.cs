﻿namespace Nancy.Security
{
    using System;

    /// <summary>
    /// Validates Csrf tokens
    /// </summary>
    public interface ICsrfTokenValidator
    {
        /// <summary>
        /// Validates a pair of tokens
        /// </summary>
        /// <param name="tokenOne">First token (usually from either a form post or querystring)</param>
        /// <param name="tokenTwo">Second token (usually from a cookie)</param>
        /// <param name="salt">Optional salt value specified during creation</param>
        /// <param name="validityPeriod">Optional period that the tokens are valid for</param>
        /// <returns>Token validation result</returns>
        CsrfTokenValidationResult IsValid(CsrfToken tokenOne, CsrfToken tokenTwo, string salt = null, TimeSpan? validityPeriod = null);
    }
}