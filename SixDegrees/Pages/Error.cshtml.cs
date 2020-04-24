// <copyright file="Error.cshtml.cs" company="Marcus Pallinger">
// Copyright (c) 2019 Marcus Pallinger. All rights reserved.
// Licensed under the BSD 2-clause license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>
// Contains the ErrorModel class, which is the model for the error page.
// </summary>

namespace SixDegrees.Pages
{
    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// ViewModel for the error page.
    /// </summary>
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
#pragma warning disable SA1649 // File name should match first type name
    public class ErrorModel : PageModel
#pragma warning restore SA1649 // File name should match first type name
    {
#pragma warning disable IDE0052 // Remove unread private members
        private readonly ILogger<ErrorModel> logger;
#pragma warning restore IDE0052 // Remove unread private members

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorModel"/> class.
        /// </summary>
        /// <param name="logger">The logger supplied by DI.</param>
        public ErrorModel(ILogger<ErrorModel> logger)
        {
            this.logger = logger;
        }

        /// <summary>
        /// Gets or sets the RequestID.
        /// </summary>
        /// <value>
        /// This is the RequestID that caused the error.
        /// </value>
        public string? RequestId { get; set; }

        /// <summary>
        /// Gets a value indicating whether we have a RequestID.
        /// </summary>
        /// <value>
        /// Set tot rue if we have a RequestId.
        /// </value>
        public bool ShowRequestId => !string.IsNullOrEmpty(this.RequestId);

        /// <summary>
        /// Populate the RequestID.
        /// </summary>
        public void OnGet()
        {
            this.RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier;
        }
    }
}
