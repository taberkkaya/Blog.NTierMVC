using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.NTierMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4f43e6b7-8f85-4222-bff9-f1a0f56cd28c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8395009b-73e3-452f-a1ec-8ae692680b49"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("506fc3d7-91ed-4799-a508-6a6e3730db92"), new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin", new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(8221), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Why do we use it?", 19 },
                    { new Guid("6c8342bd-9800-4694-80ea-ae74dfeb9fea"), new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(8216), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("644a194e-8811-474c-92e4-796d3140af23"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is Lorem Ipsum?", 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5e5b68dd-2512-4600-add0-882c842a8b56"),
                column: "ConcurrencyStamp",
                value: "ec78d96b-7624-47bc-bb75-1260afa83426");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("97b28373-bf1c-4188-a833-03379fd3679f"),
                column: "ConcurrencyStamp",
                value: "5ed0af1d-26cb-41ff-aa8a-45450e0a2b9b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c685c5ab-f989-4372-b46e-0bea49d44098"),
                column: "ConcurrencyStamp",
                value: "c6ec467e-3afe-4f1d-9565-ce9b9bee4f8a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5499dd26-468d-4606-be18-1abe347582ff"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "3ff22b24-dde0-4016-948d-3ac600398404", "DUMMYUSER", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAENBXoeXPqC4+Mq/lGtKd5blLokdrHr+jzUeE44QZe7o4lpLpvfDUHCm+oEhp6Cr+WA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "PasswordHash" },
                values: new object[] { "6cbe3601-f4cc-4315-8c97-18294172275c", "DUMMYUSER", "AQAAAAIAAYagAAAAEO7zSdZS8gXYscFwK4GKSyX7SkZ1P3Qjr+214PrXruwdNfipQCLOemb3tBsGPCnBHQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("644a194e-8811-474c-92e4-796d3140af23"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 15, 59, 17, 567, DateTimeKind.Local).AddTicks(9927));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("506fc3d7-91ed-4799-a508-6a6e3730db92"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6c8342bd-9800-4694-80ea-ae74dfeb9fea"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("4f43e6b7-8f85-4222-bff9-f1a0f56cd28c"), new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin", new DateTime(2024, 4, 18, 15, 50, 51, 465, DateTimeKind.Local).AddTicks(6226), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("644a194e-8811-474c-92e4-796d3140af23"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is Lorem Ipsum?", 15 },
                    { new Guid("8395009b-73e3-452f-a1ec-8ae692680b49"), new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"), "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "Admin", new DateTime(2024, 4, 18, 15, 50, 51, 465, DateTimeKind.Local).AddTicks(6234), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"), false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Why do we use it?", 19 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("5e5b68dd-2512-4600-add0-882c842a8b56"),
                column: "ConcurrencyStamp",
                value: "403f7964-f54c-4dc8-9f65-554947a13707");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("97b28373-bf1c-4188-a833-03379fd3679f"),
                column: "ConcurrencyStamp",
                value: "e85d6507-5e63-4104-b380-5d6a6dd8eafb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c685c5ab-f989-4372-b46e-0bea49d44098"),
                column: "ConcurrencyStamp",
                value: "cc621be4-8272-4efe-a474-1a5d67ab5d0f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5499dd26-468d-4606-be18-1abe347582ff"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "3c12a556-711c-4424-a27e-4ed9839d0ac2", "DUMYUSER", "DMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEJ3XTNQfeMdBqmvweMqCtLIiCNjN5oPDL/fqoPJAr7s5crnC05oeXNQLi7OO2PlXKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cdd65005-d394-4b48-8ba4-c5526518f76f"),
                columns: new[] { "ConcurrencyStamp", "FirstName", "PasswordHash" },
                values: new object[] { "5662d466-cc8a-4fdb-a540-375ff0eae25e", "DUMYUSER", "AQAAAAIAAYagAAAAECxzyuVKBx9FOs+9X46+6FLm/n0ETjDd52zJuXwnY/Y7jBxOEcrRaoz4WtLUxNXfIQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6da1aee9-4ceb-4f36-b668-97e94ffda000"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 15, 50, 51, 465, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffbf1647-f1e9-4cca-b37c-c0988cd73ab7"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 15, 50, 51, 465, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("644a194e-8811-474c-92e4-796d3140af23"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 15, 50, 51, 465, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("cd6083ab-faa6-4a2c-bffa-1c01c46a7b71"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 18, 15, 50, 51, 465, DateTimeKind.Local).AddTicks(8433));
        }
    }
}
