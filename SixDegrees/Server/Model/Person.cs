// <copyright file="Person.cs" company="Marcus Pallinger">
// Copyright (c) 2019 Marcus Pallinger. All rights reserved.
// Licensed under the BSD 2-clause license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>Information needed for tables</summary>

#pragma warning disable CA2227 // Collection properties should be read only

namespace SixDegrees.Server.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// A person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the AlphaNumeric primary key from IMDB.
        /// </summary>
        /// <value>
        /// The AlphaNumeric primary key from IMDB.
        /// </value>
        public string PersonId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the person's name.
        /// </summary>
        /// <value>
        /// The person's name.
        /// </value>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the list of roles for the person.
        /// </summary>
        /// <value>
        /// the list of roles for the person.
        /// </value>
        public List<Role>? Roles { get; set; }
    }
}
