// <copyright file="Title.cs" company="Marcus Pallinger">
// Copyright (c) 2019 Marcus Pallinger. All rights reserved.
// Licensed under the BSD 2-clause license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>Store information about a role</summary>

#pragma warning disable CA2227 // Collection properties should be read only

namespace SixDegrees.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// A Title (May be a film or an episode).
    /// </summary>
    public class Title
    {
        /// <summary>
        /// Gets or sets the id of the title.
        /// </summary>
        /// <value>
        /// The id of the title, from IMDB.
        /// </value>
        public string TitleId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the title.
        /// </summary>
        /// <value>
        /// The name of the title.
        /// </value>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the roles in this title.
        /// </summary>
        /// <value>
        /// The roles in this title.
        /// </value>
        public List<Role>? Roles { get; set; }
    }
}
