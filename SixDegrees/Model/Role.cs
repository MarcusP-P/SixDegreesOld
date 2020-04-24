// <copyright file="Role.cs" company="Marcus Pallinger">
// Copyright (c) 2019 Marcus Pallinger. All rights reserved.
// Licensed under the BSD 2-clause license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>The model for rols linking a person and a title</summary>

namespace SixDegrees.Model
{
    /// <summary>
    /// The link between a person and a Title.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Gets or sets the ID of the role.
        /// </summary>
        /// <value>
        /// The ID of the role. Becasue a person may have more thn one role in a title,
        /// we can't use a concatinated key.
        /// </value>
        public long RoleId { get; set; }

        /// <summary>
        /// Gets or sets the PersonId.
        /// </summary>
        /// <value>
        /// The ID of the assosciated Person.
        /// </value>
        public string PersonId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the TitleId.
        /// </summary>
        /// <value>
        /// The ID of the assosciated Title.
        /// </value>
        public string TitleId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the related Person.
        /// </summary>
        /// <value>
        /// The related person for this role.
        /// </value>
        public Person Person { get; set; } = null!;

        /// <summary>
        /// Gets or sets the related Title.
        /// </summary>
        /// <value>
        /// The related title for this role.
        /// </value>
        public Title Title { get; set; } = null!;
    }
}
