using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace indiGo.Data.Migrations
{
    public partial class ReceiptFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_ServiceDemands_DemandId1",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_DemandId1",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "DemandId1",
                table: "Receipts");

            migrationBuilder.AlterColumn<int>(
                name: "DemandId",
                table: "Receipts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_DemandId",
                table: "Receipts",
                column: "DemandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_ServiceDemands_DemandId",
                table: "Receipts",
                column: "DemandId",
                principalTable: "ServiceDemands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_ServiceDemands_DemandId",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_DemandId",
                table: "Receipts");

            migrationBuilder.AlterColumn<string>(
                name: "DemandId",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DemandId1",
                table: "Receipts",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ded163df-d8c6-4d68-8aaa-612856d88c82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2b8c9a70-a6d1-4d68-8fe1-4d36f69a32d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "fdc9c330-42ca-4a20-8b0e-66988e95bf16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7726f99d-bea7-4415-b5db-c8cf7e641897");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "2c27783e-98d0-410f-bbaa-509d04b093fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "5abf22fa-5f66-4c46-b449-0548655689e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "cea387e5-7164-45d6-84b0-83516ba14279");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a5g5-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "32969044-1fe3-4d6b-b5cf-a7697aecdb1b", "AQAAAAEAACcQAAAAEBBOPi+h3X6j+H3Elg6NZ6pFl9lFxUKCUUcjFUCPcn1iVz2IZUAv5VTZSOtslXyb0w==", new DateTime(2022, 6, 9, 10, 58, 41, 377, DateTimeKind.Utc).AddTicks(454), "1b692377-c048-4eee-8ba7-7917f9a8bc1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "06137bb7-4a41-4c7b-9809-9ede38133df1", "AQAAAAEAACcQAAAAEORj9BNIAcKBnHxFvBxskJ8Z3awOgrKlrNLI5Q+CDLOgQQpLNvuROmHlNoDjwQpgHQ==", new DateTime(2022, 6, 9, 10, 58, 41, 371, DateTimeKind.Utc).AddTicks(5543), "dca57772-747c-4cb5-9240-7ac9b632129c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "c05c413a-326b-4c8e-ab72-0cdf12478e2a", "AQAAAAEAACcQAAAAENrAGEoqTv5uVbDvWrZj6tZlYbsXWF93bsoV9sAqmtZRIx/8TbkEKETc9hvCZ3qzxA==", new DateTime(2022, 6, 9, 10, 58, 41, 366, DateTimeKind.Utc).AddTicks(391), "7fa71813-b365-4c1c-90de-56845c8d045f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "34a70ba7-0821-42fe-872f-3d5dd74b6d41", "AQAAAAEAACcQAAAAEEaoCKpJrZBKnXoCQCZO3vXVBnpKsM+yG9QgVSGxI6xR5opHwGvCY4IbnEFzWZOaCg==", new DateTime(2022, 6, 9, 10, 58, 41, 360, DateTimeKind.Utc).AddTicks(2779), "d880874b-a678-49fe-ae64-364496276669" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "cb51e1a8-bdd5-490e-b4c5-0931b078da19", "AQAAAAEAACcQAAAAEDIr1pNwx4KjdO//H+OQWbYSjlvIH5VUjhjMKLjiXDliVdZtsAeOLmVd6xuyuCVlug==", new DateTime(2022, 6, 9, 10, 58, 41, 354, DateTimeKind.Utc).AddTicks(5708), "d27bf5dc-e942-4b05-9ca3-601a249b0522" });

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_DemandId1",
                table: "Receipts",
                column: "DemandId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_ServiceDemands_DemandId1",
                table: "Receipts",
                column: "DemandId1",
                principalTable: "ServiceDemands",
                principalColumn: "Id");
        }
    }
}
