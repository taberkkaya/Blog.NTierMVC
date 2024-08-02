using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.NTierMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class Visitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "CreatedDate",
                table: "Images",
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
                name: "CreatedDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("81f740c8-d0d7-46b8-b26e-0a64b191772d"), new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin", new DateTime(2024, 8, 2, 14, 55, 38, 746, DateTimeKind.Local).AddTicks(2219), null, null, new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"), false, null, null, "Why do we use it?", new Guid("5499dd26-468d-4606-be18-1abe347582ff"), 19 },
                    { new Guid("bf6e0469-8a26-4866-a13d-34fd07a15e46"), new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2024, 8, 2, 14, 55, 38, 746, DateTimeKind.Local).AddTicks(2208), null, null, new Guid("644a194e-8811-474c-92e4-796d3140af23"), false, null, null, "What is Lorem Ipsum?", new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5e5b68dd-2512-4600-add0-882c842a8b56"),
                column: "ConcurrencyStamp",
                value: "3f116951-cb42-462f-8808-0e0316a9adfc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("97b28373-bf1c-4188-a833-03379fd3679f"),
                column: "ConcurrencyStamp",
                value: "ded0c50b-97d8-48b1-b216-954325e1d6b1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c685c5ab-f989-4372-b46e-0bea49d44098"),
                column: "ConcurrencyStamp",
                value: "bf7bba64-2ad3-4ddf-9c6a-98089b63faf5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5499dd26-468d-4606-be18-1abe347582ff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c32094e-736c-42b2-91a5-939ee23cc4b2", "AQAAAAIAAYagAAAAEFySSMp5/2Wd0xsznHDx9ZhESeSQSsyVc693+YHmisJjrAWE4+0raueUgxgostePJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6c13329-5196-41d5-947f-975e82bede5a", "AQAAAAIAAYagAAAAECTOE9R7Ih1C2XiGqQm5Y7d2PzljHezDJn/8zR8CpXk+VMgY1noE8v8BflJh/Apkkw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 2, 14, 55, 38, 746, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 2, 14, 55, 38, 746, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("644a194e-8811-474c-92e4-796d3140af23"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 2, 14, 55, 38, 746, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 2, 14, 55, 38, 746, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("81f740c8-d0d7-46b8-b26e-0a64b191772d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bf6e0469-8a26-4866-a13d-34fd07a15e46"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Images",
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
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 22, 20, 10, 773, DateTimeKind.Local).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 22, 20, 10, 773, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("644a194e-8811-474c-92e4-796d3140af23"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 22, 20, 10, 773, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"),
                column: "CreatedDate",
                value: new DateTime(2024, 5, 5, 22, 20, 10, 773, DateTimeKind.Local).AddTicks(7875));
        }
    }
}
