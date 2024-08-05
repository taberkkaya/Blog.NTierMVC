using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.NTierMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SocialMedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("81f740c8-d0d7-46b8-b26e-0a64b191772d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bf6e0469-8a26-4866-a13d-34fd07a15e46"));

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMedias_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("18c19546-43b0-4165-98d5-1085dca86166"), new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2024, 8, 5, 13, 46, 33, 139, DateTimeKind.Local).AddTicks(713), null, null, new Guid("644a194e-8811-474c-92e4-796d3140af23"), false, null, null, "What is Lorem Ipsum?", new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"), 15 },
                    { new Guid("390e9206-e60c-4662-a481-1c810964af66"), new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin", new DateTime(2024, 8, 5, 13, 46, 33, 139, DateTimeKind.Local).AddTicks(733), null, null, new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"), false, null, null, "Why do we use it?", new Guid("5499dd26-468d-4606-be18-1abe347582ff"), 19 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5e5b68dd-2512-4600-add0-882c842a8b56"),
                column: "ConcurrencyStamp",
                value: "24a60565-ba16-4cb4-93fb-49fef689d092");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("97b28373-bf1c-4188-a833-03379fd3679f"),
                column: "ConcurrencyStamp",
                value: "429e120c-f04c-4581-a1b9-8bc02fd3bed3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c685c5ab-f989-4372-b46e-0bea49d44098"),
                column: "ConcurrencyStamp",
                value: "da7975cc-9cc0-4c9c-aef0-4fc7850702fb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5499dd26-468d-4606-be18-1abe347582ff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a873bf95-af74-4b6a-b134-7ec7f9baee97", "AQAAAAIAAYagAAAAEJgwKKhI0omF/I1PBeoHlJrpMFyA8fz1Uxhx5qZrGm9qU4L0hu0eyV6ckoq20jL8gQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "00e2506f-dda0-4d0e-94ad-27d76da531c2", "AQAAAAIAAYagAAAAEFPBBu8S2OMW11LJTw+iSKotfBKGBai6gfC3tqzJ4aS0dGJmSKyFcSEBtHHlNgi++w==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 13, 46, 33, 139, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 13, 46, 33, 139, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("644a194e-8811-474c-92e4-796d3140af23"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 13, 46, 33, 140, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"),
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 13, 46, 33, 140, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_AppUserId",
                table: "SocialMedias",
                column: "AppUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("18c19546-43b0-4165-98d5-1085dca86166"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("390e9206-e60c-4662-a481-1c810964af66"));

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
        }
    }
}
