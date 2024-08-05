using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.NTierMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SocialMediaMap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("31a608cc-cdaa-40b0-8237-ff5fbf90f1b2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8b3595f0-038b-4ec9-988c-e5b33e341fab"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("19f1cde8-b9d7-41b5-880b-3d8073fa3bd4"), new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin", new DateTime(2024, 8, 5, 15, 3, 32, 479, DateTimeKind.Local).AddTicks(9601), null, null, new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"), false, null, null, "Why do we use it?", new Guid("5499dd26-468d-4606-be18-1abe347582ff"), 19 },
                    { new Guid("b18d83ee-c7ee-4e8e-8c93-14479f587a3a"), new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2024, 8, 5, 15, 3, 32, 479, DateTimeKind.Local).AddTicks(9594), null, null, new Guid("644a194e-8811-474c-92e4-796d3140af23"), false, null, null, "What is Lorem Ipsum?", new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5e5b68dd-2512-4600-add0-882c842a8b56"),
                column: "ConcurrencyStamp",
                value: "44359745-38a2-4ade-830f-ff2b91ada1be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("97b28373-bf1c-4188-a833-03379fd3679f"),
                column: "ConcurrencyStamp",
                value: "7445e600-6b2f-4268-aa17-e742b0c0fd1b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c685c5ab-f989-4372-b46e-0bea49d44098"),
                column: "ConcurrencyStamp",
                value: "ebb39d2b-f4c5-49fc-a50d-3fb981faf4d8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5499dd26-468d-4606-be18-1abe347582ff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb53b8f5-14f2-413f-be34-8a5ea3d09a86", "AQAAAAIAAYagAAAAEAohLEWKkGi5nS+Qda7SC9fQYnQSgu8D4GwUkK+/1NB4wlSnHSSjTdZYBVtIMRoajQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a30bad0d-7b84-4f25-b335-9534d4c9bf46", "AQAAAAIAAYagAAAAELO8gns/USQ2rDfrRvUJvQelokpH1+vtXyYm7SPEc5bk/i1I3YZJrZd83SBdkAeR0A==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 15, 3, 32, 480, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 15, 3, 32, 480, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("644a194e-8811-474c-92e4-796d3140af23"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 15, 3, 32, 480, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 15, 3, 32, 480, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "AppUserId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Icon", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("a7ea51b6-550d-40b6-a66a-e7a4e85344e0"), null, "Admin", new DateTime(2024, 8, 5, 15, 3, 32, 481, DateTimeKind.Local).AddTicks(2747), null, null, "fa-brands fa-github", false, null, null, "Github", " " },
                    { new Guid("eeab62c1-e84e-4527-8482-052d8b8c1760"), null, "Admin", new DateTime(2024, 8, 5, 15, 3, 32, 481, DateTimeKind.Local).AddTicks(2744), null, null, "fa-brands fa-github", false, null, null, "Github", " " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("19f1cde8-b9d7-41b5-880b-3d8073fa3bd4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b18d83ee-c7ee-4e8e-8c93-14479f587a3a"));

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: new Guid("a7ea51b6-550d-40b6-a66a-e7a4e85344e0"));

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: new Guid("eeab62c1-e84e-4527-8482-052d8b8c1760"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("31a608cc-cdaa-40b0-8237-ff5fbf90f1b2"), new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2024, 8, 5, 13, 50, 27, 483, DateTimeKind.Local).AddTicks(1750), null, null, new Guid("644a194e-8811-474c-92e4-796d3140af23"), false, null, null, "What is Lorem Ipsum?", new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"), 15 },
                    { new Guid("8b3595f0-038b-4ec9-988c-e5b33e341fab"), new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin", new DateTime(2024, 8, 5, 13, 50, 27, 483, DateTimeKind.Local).AddTicks(1757), null, null, new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"), false, null, null, "Why do we use it?", new Guid("5499dd26-468d-4606-be18-1abe347582ff"), 19 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5e5b68dd-2512-4600-add0-882c842a8b56"),
                column: "ConcurrencyStamp",
                value: "cee4a81d-5b79-4a43-bc03-b68233b4d5e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("97b28373-bf1c-4188-a833-03379fd3679f"),
                column: "ConcurrencyStamp",
                value: "89c8313a-d41a-4c79-8050-0e9943274f2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c685c5ab-f989-4372-b46e-0bea49d44098"),
                column: "ConcurrencyStamp",
                value: "2d388a07-0164-4232-bbce-2bbb7f4fc786");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5499dd26-468d-4606-be18-1abe347582ff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "765fde0e-17a2-4e2a-98ad-fe23a6035bdf", "AQAAAAIAAYagAAAAEJIvNSjFnKdFXLD7h5wJGzNaHOnRQfbIPzfx8Jn/CNgR/YpidBMdc7HDD/zdn9B2qw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "54285090-ffe1-486b-a66e-b5263c9b35dc", "AQAAAAIAAYagAAAAEBV4LmjDiGakiEFyToTV/9hq8KOfqfWXa65gVnprpZHN9W1iDhi+JqW/3PpZVjUrfA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 13, 50, 27, 483, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 13, 50, 27, 483, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("644a194e-8811-474c-92e4-796d3140af23"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 13, 50, 27, 483, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 13, 50, 27, 483, DateTimeKind.Local).AddTicks(7286));
        }
    }
}
