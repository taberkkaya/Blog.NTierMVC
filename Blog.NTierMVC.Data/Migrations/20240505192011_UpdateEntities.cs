using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.NTierMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("115ceecf-1810-460b-889e-ec6b76f4997b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("76ca4c8a-45e6-45ef-be86-16d1beffd129"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Images",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Images",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Images",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Articles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Articles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Articles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("b930a77e-a754-4c48-b3e4-74a850aa5d57"), new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2024, 5, 5, 22, 20, 10, 773, DateTimeKind.Local).AddTicks(6410), null, null, new Guid("644a194e-8811-474c-92e4-796d3140af23"), false, null, null, "What is Lorem Ipsum?", new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"), 15 },
                    { new Guid("feadd580-fef3-4d79-b463-2f03942b53af"), new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin", new DateTime(2024, 5, 5, 22, 20, 10, 773, DateTimeKind.Local).AddTicks(6417), null, null, new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"), false, null, null, "Why do we use it?", new Guid("5499dd26-468d-4606-be18-1abe347582ff"), 19 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5e5b68dd-2512-4600-add0-882c842a8b56"),
                column: "ConcurrencyStamp",
                value: "b0c6620b-a369-4dfe-a43b-6b93b5512fd5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("97b28373-bf1c-4188-a833-03379fd3679f"),
                column: "ConcurrencyStamp",
                value: "b280d617-991d-47c9-b4b2-f74910d5bda3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c685c5ab-f989-4372-b46e-0bea49d44098"),
                column: "ConcurrencyStamp",
                value: "e1dd4206-a250-4c71-aa95-3410cfa170e2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5499dd26-468d-4606-be18-1abe347582ff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4838322e-8e52-4d1c-b1f4-d71540f7bb9e", "AQAAAAIAAYagAAAAEDzAAt38G4jX6tJr1b1a4/Ue9qIiYixgvLFWJSDjiAxQ2fAGRYJ1/KDqmRXMhVlzpA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4185069e-7800-4637-861d-2f1721686b21", "AQAAAAIAAYagAAAAEGGhTz3b43JIjbZiKYNvRI+Vqatceeul8/F/Suxr+eI+xmYeaH7DmTRY1fg6XIyUew==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 22, 20, 10, 773, DateTimeKind.Local).AddTicks(7302), null, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 22, 20, 10, 773, DateTimeKind.Local).AddTicks(7304), null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("644a194e-8811-474c-92e4-796d3140af23"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 22, 20, 10, 773, DateTimeKind.Local).AddTicks(7862), null, null });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 22, 20, 10, 773, DateTimeKind.Local).AddTicks(7875), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b930a77e-a754-4c48-b3e4-74a850aa5d57"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("feadd580-fef3-4d79-b463-2f03942b53af"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Images",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletedDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("115ceecf-1810-460b-889e-ec6b76f4997b"), new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin", new DateTime(2024, 4, 20, 0, 27, 51, 283, DateTimeKind.Local).AddTicks(1290), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Why do we use it?", new Guid("5499dd26-468d-4606-be18-1abe347582ff"), 19 },
                    { new Guid("76ca4c8a-45e6-45ef-be86-16d1beffd129"), new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2024, 4, 20, 0, 27, 51, 283, DateTimeKind.Local).AddTicks(1282), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("644a194e-8811-474c-92e4-796d3140af23"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is Lorem Ipsum?", new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5e5b68dd-2512-4600-add0-882c842a8b56"),
                column: "ConcurrencyStamp",
                value: "93a81bf8-7acc-46bd-a666-001ab79440a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("97b28373-bf1c-4188-a833-03379fd3679f"),
                column: "ConcurrencyStamp",
                value: "89739166-f9fc-4ae3-8eb2-1ee39f92afc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c685c5ab-f989-4372-b46e-0bea49d44098"),
                column: "ConcurrencyStamp",
                value: "890e8798-ef3b-40fa-9408-37999da5d84f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5499dd26-468d-4606-be18-1abe347582ff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8425b720-26ac-4153-b707-f9d3d63c0370", "AQAAAAIAAYagAAAAEFbdVR5NP3A8OvMd/MKcfS4L8GjHwuyeyeR4cHqiO4Xv0giriLLI6HtvlrRyiPfcoA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3df6a898-dbb2-40e1-8f2a-ee1f73e2139e", "AQAAAAIAAYagAAAAEIvb9eRVG4Csk0xNv/EcqQD/nsc3jAtMQ9rWc1YSzIpOWxb+YpsmaijPv2dMcXjNXQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 27, 51, 283, DateTimeKind.Local).AddTicks(2417), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 27, 51, 283, DateTimeKind.Local).AddTicks(2421), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("644a194e-8811-474c-92e4-796d3140af23"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 27, 51, 283, DateTimeKind.Local).AddTicks(3250), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"),
                columns: new[] { "CreatedDate", "DeletedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 27, 51, 283, DateTimeKind.Local).AddTicks(3253), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
