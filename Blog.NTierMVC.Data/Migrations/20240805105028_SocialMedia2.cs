using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.NTierMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SocialMedia2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("18c19546-43b0-4165-98d5-1085dca86166"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("390e9206-e60c-4662-a481-1c810964af66"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SocialMedias");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("31a608cc-cdaa-40b0-8237-ff5fbf90f1b2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8b3595f0-038b-4ec9-988c-e5b33e341fab"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "SocialMedias",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
        }
    }
}
