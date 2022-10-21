using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace indiGo.Data.Migrations
{
    public partial class ReceiptEntryFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "ReceiptDetail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4b16b586-67db-47b4-81ce-c7d43631ebc9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "449fd16e-6b42-41bd-9b46-fde6fa460b4a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "60dc7f10-39d4-40e5-98fb-011fc23ecbbb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "63f06136-39f9-4136-8eca-73801de5922a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "ce316cff-163b-41e5-90f8-bc8cc9bc38a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "703648b4-54ba-4d39-8307-cbba6d2045be");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "1f69d0f9-5709-44c9-8794-8ae5e0485cbc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a5g5-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "7dfcbc6f-3539-4981-92ef-ec20317b546b", "AQAAAAEAACcQAAAAEA+QWUoDlVlEkeZ2tH4SuAk0wUkhIfLz7wv8v5LX93kmV7tXk0bQW36Ghpcgep5w/g==", new DateTime(2022, 6, 10, 11, 3, 46, 492, DateTimeKind.Utc).AddTicks(1495), "fd63708e-19ff-47a6-afe5-9860e430970f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "dc8e2e45-cd4b-4b7d-ba3d-cc51aac997d9", "AQAAAAEAACcQAAAAEFyj1MOcsD5LBUXFYhObElio6iirJ31XZ0nsqFwZOljgm1oY1wfHEcUN2Ye9V0lR6A==", new DateTime(2022, 6, 10, 11, 3, 46, 486, DateTimeKind.Utc).AddTicks(8065), "2ea948fe-d8e6-46f3-8923-240f75cd84aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "3ab8800c-9ae8-4bde-83ff-fc2ad5fd9f88", "AQAAAAEAACcQAAAAEKsVaZBNFvPAIpKIqOlpuraesdrZlF20X3jf3ZJxgGqtGuR3NGZuihWKUDnnfnDaOg==", new DateTime(2022, 6, 10, 11, 3, 46, 481, DateTimeKind.Utc).AddTicks(4988), "81a3c0db-dfde-476e-8719-3655972f2427" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "fda00ab4-045b-4472-8e8f-bb5c324f73ae", "AQAAAAEAACcQAAAAEHJh3/ASld8Zc2S3IpUWI8B42gkNq6lSJpjpQVU+6T6Nz9hh/HbXw15JZzKjZlfXiQ==", new DateTime(2022, 6, 10, 11, 3, 46, 475, DateTimeKind.Utc).AddTicks(5445), "324d17af-4491-4b48-a39e-7ed7038339e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "0c875de8-4513-4e86-84ca-5e785b4b02f6", "AQAAAAEAACcQAAAAEHdc+WVibH+vMvqDG/G62EQ2tHtxZWdd4bP8G75BWEAmM/JfQ2Q7VusWNTa+bKTZ0w==", new DateTime(2022, 6, 10, 11, 3, 46, 470, DateTimeKind.Utc).AddTicks(2111), "1a186c81-1e91-41e4-a28c-2a9f3a7f0382" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ReceiptDetail");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "8d97bad1-f72e-46be-97c0-235d76710098");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "663b6d70-7c72-46cb-95bc-51d1e637e3e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "0d575423-c7a0-43a9-bd1a-e1c14294aebe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "f4853fcc-2289-43d2-8543-47eb6b3a7b58");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "9b17035d-e10f-4a04-be52-9673ff952c16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "d29fa513-8c0b-49a5-84e9-304299c54238");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "15c6ada4-5c32-4a97-9c73-036f6a174301");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a5g5-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "e0daa841-cfef-432d-b735-1f1b7b773ab1", "AQAAAAEAACcQAAAAEJleElGfBMKNd3kGoWUfjlWp2lpuFmzXSPvoLEDcBz63LbFsGKD2K/NtIZF2ZGs5tQ==", new DateTime(2022, 6, 10, 10, 4, 38, 501, DateTimeKind.Utc).AddTicks(2116), "7f30b9c6-d6c5-4c0d-98ff-4e39f706c92f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "d91a5721-71f0-4d1c-a26c-82b6454d32fa", "AQAAAAEAACcQAAAAEHPWSD/5ocxS3K+sniyxnzmnIwUkYLZTPns8qCITbBMw6Uq3fBybJMnNfpPo/l2NZg==", new DateTime(2022, 6, 10, 10, 4, 38, 495, DateTimeKind.Utc).AddTicks(7161), "9dd7dd1d-cb55-4eb5-afbe-6c0ac8cadc9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "36f23e13-7a8f-4e7f-aaaa-edf7520203e2", "AQAAAAEAACcQAAAAEGTKmMtXGgc35vbuBsKmj0k0zU5f/fc8DO73dTwvksIsuPRNjv2a9M8XjqEMQ/EtMw==", new DateTime(2022, 6, 10, 10, 4, 38, 490, DateTimeKind.Utc).AddTicks(4048), "fd93e426-780a-4a1c-94df-a261128af2f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "4804bb55-4c20-41f2-8905-966be1301860", "AQAAAAEAACcQAAAAEE7cnsRDeg007cBKdts0S1GC10ouOHmu+vgTLIUEvMuj/PVaTsaOpPqsrC0k5FRY2A==", new DateTime(2022, 6, 10, 10, 4, 38, 485, DateTimeKind.Utc).AddTicks(1022), "e4bfb32d-a8d4-4d6b-ac26-2e070305b204" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "79aeb4f0-fa7b-473b-b27d-5d6bfa9355e7", "AQAAAAEAACcQAAAAEGPQAWKkbxAR6aO8IgFmjStQXZCwN2EyfOiPY8U0aog2uKzHKUEcyIeUPBspPHjJJQ==", new DateTime(2022, 6, 10, 10, 4, 38, 479, DateTimeKind.Utc).AddTicks(7291), "794751c6-4b6e-4b7b-b303-dc2832f473b6" });
        }
    }
}
