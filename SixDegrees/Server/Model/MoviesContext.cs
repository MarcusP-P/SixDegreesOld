// <copyright file="MoviesContext.cs" company="Marcus Pallinger">
// Copyright (c) 2019 Marcus Pallinger. All rights reserved.
// Licensed under the BSD 2-clause license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>The dabase context</summary>

namespace SixDegrees.Server.Model
{
    using System.Diagnostics.Contracts;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The database context for the Movies database.
    /// </summary>
    public class MoviesContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoviesContext"/> class.
        /// </summary>
        /// <param name="options">The context options.</param>
        public MoviesContext(DbContextOptions<MoviesContext> options)
        : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the People table.
        /// </summary>
        /// <value>
        /// The People table.
        /// </value>
        public DbSet<Person> People { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Roles table.
        /// </summary>
        /// <value>
        /// The Roles table.
        /// </value>
        public DbSet<Role> Roles { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Titles table.
        /// </summary>
        /// <value>
        /// The Titles table.
        /// </value>
        public DbSet<Title> Titles { get; set; } = null!;

        /// <summary>
        /// Method to configure creation of the model.
        /// </summary>
        /// <param name="modelBuilder">The builder used to create the model.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Contract.Requires(modelBuilder != null);
            _ = modelBuilder!.Entity<Person>()
                .HasMany(p => p.Roles)
                .WithOne(r => r.Person)
                .HasForeignKey(r => r.PersonId);
            _ = modelBuilder.Entity<Title>()
                .HasMany(t => t.Roles)
                .WithOne(r => r.Title)
                .HasForeignKey(r => r.TitleId);
            _ = modelBuilder.Entity<Role>()
                .HasOne(r => r.Person)
                .WithMany(p => p.Roles)
                .HasForeignKey(r => r.PersonId);
            _ = modelBuilder.Entity<Role>()
                .HasOne(r => r.Title)
                .WithMany(t => t.Roles)
                .HasForeignKey(r => r.TitleId);
        }
    }
}
