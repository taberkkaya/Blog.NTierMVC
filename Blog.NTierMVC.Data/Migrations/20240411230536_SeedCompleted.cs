using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.NTierMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"), "Admin", new DateTime(2024, 4, 12, 2, 5, 36, 568, DateTimeKind.Local).AddTicks(3250), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is Lorem Ipsum?" },
                    { new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"), "Admin", new DateTime(2024, 4, 12, 2, 5, 36, 568, DateTimeKind.Local).AddTicks(3254), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Why do we use it?" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("644a194e-8811-474c-92e4-796d3140af23"), "Admin", new DateTime(2024, 4, 12, 2, 5, 36, 568, DateTimeKind.Local).AddTicks(4076), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", "jpg", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"), "Admin", new DateTime(2024, 4, 12, 2, 5, 36, 568, DateTimeKind.Local).AddTicks(4079), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem_Ipsum", "png", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("8b145b55-dc0a-490f-a521-5015ff42cd86"), new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin", new DateTime(2024, 4, 12, 2, 5, 36, 568, DateTimeKind.Local).AddTicks(2028), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Why do we use it?", 19 },
                    { new Guid("d634adb0-f6cb-4b70-8dfd-dddbb07b75a7"), new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2024, 4, 12, 2, 5, 36, 568, DateTimeKind.Local).AddTicks(2011), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("644a194e-8811-474c-92e4-796d3140af23"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is Lorem Ipsum?", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8b145b55-dc0a-490f-a521-5015ff42cd86"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d634adb0-f6cb-4b70-8dfd-dddbb07b75a7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("644a194e-8811-474c-92e4-796d3140af23"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
