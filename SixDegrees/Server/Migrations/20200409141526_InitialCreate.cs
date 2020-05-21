// <copyright file="20200409141526_InitialCreate.cs" company="Marcus Pallinger">
// Copyright (c) 2019 Marcus Pallinger. All rights reserved.
// Licensed under the BSD 2-clause license. See LICENSE file in the project root for full license information.
// </copyright>
// <summary>Create the initial database</summary>

namespace SixDegrees.Server.Migrations
{
    using System.Diagnostics.Contracts;
    using Microsoft.EntityFrameworkCore.Migrations;

    /// <summary>
    /// Class to do the initial migration.
    /// </summary>
    public partial class InitialCreate : Migration
    {
        /// <summary>
        /// Do the initial migration.
        /// </summary>
        /// <param name="migrationBuilder">The builder for the changes.</param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Contract.Requires(migrationBuilder != null);
            _ = migrationBuilder!.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                },
                constraints: table => table.PrimaryKey("PK_People", x => x.PersonId));

            _ = migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    TitleId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                },
                constraints: table => table.PrimaryKey("PK_Titles", x => x.TitleId));

            _ = migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<string>(nullable: false),
                    TitleId = table.Column<string>(nullable: false),
                },
                constraints: table =>
                {
                    _ = table.PrimaryKey("PK_Roles", x => x.RoleId);
                    _ = table.ForeignKey(
                        name: "FK_Roles_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    _ = table.ForeignKey(
                        name: "FK_Roles_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "TitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            _ = migrationBuilder.CreateIndex(
                name: "IX_Roles_PersonId",
                table: "Roles",
                column: "PersonId");

            _ = migrationBuilder.CreateIndex(
                name: "IX_Roles_TitleId",
                table: "Roles",
                column: "TitleId");
        }

        /// <summary>
        /// Roll back the migrations.
        /// </summary>
        /// <param name="migrationBuilder">The builder to back out the changes.</param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            Contract.Requires(migrationBuilder != null);

            _ = migrationBuilder!.DropTable(
                name: "Roles");

            _ = migrationBuilder.DropTable(
                name: "People");

            _ = migrationBuilder.DropTable(
                name: "Titles");
        }
    }
}
