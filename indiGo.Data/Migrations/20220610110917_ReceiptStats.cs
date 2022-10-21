using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace indiGo.Data.Migrations
{
    public partial class ReceiptStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Paid",
                table: "ServiceDemands",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Receipted",
                table: "ServiceDemands",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2369cdb7-bda4-4a86-b776-78ac6f9802b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "53ea4479-6c36-4bb0-ab74-4c374da23a5b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "272a798b-17c8-481e-890d-30a4eddaa3a2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "bb4a586f-998b-473e-bee1-7706d8d90f5a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "01f9a583-12e0-4890-aa04-4c323d0b91f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "5a4eb3a0-f050-4e53-95ed-fabbe4ee0074");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "cb8949b7-7a0c-4aef-b633-75bef6f1580d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a5g5-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "832fe743-eb0b-42c6-80f1-254779bb64ab", "AQAAAAEAACcQAAAAEEqdrvlREiatb5PG6Vg4yePauZfDwNEmkNO4ezlEdX6SXcl9TI+jfTQO0F44kI3bqg==", new DateTime(2022, 6, 10, 11, 9, 17, 107, DateTimeKind.Utc).AddTicks(4567), "f4689c0b-aa86-4c4d-87df-e4eb20f9ef64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-8223d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "a5e14e6e-e02b-4424-aceb-2bc1fd4004ea", "AQAAAAEAACcQAAAAEIS59McxPQ4pY9kjQ4oXEGz+j2vJwczHEmQUh3ulnCfzJHoLZvngUiJDOEnn98Vxrg==", new DateTime(2022, 6, 10, 11, 9, 17, 101, DateTimeKind.Utc).AddTicks(5642), "8b1e893b-a096-47d8-ad96-a83a15e90079" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e443125-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "96aabd04-d52c-4050-8a01-02e03a46c803", "AQAAAAEAACcQAAAAEF49EHl28tVZGjNOtZsmjE2SmuO174vpCkON4oLGY1dvon2M3bfhVl4xiqLVTMdEcA==", new DateTime(2022, 6, 10, 11, 9, 17, 96, DateTimeKind.Utc).AddTicks(2358), "af874e63-7c6c-43bf-a214-9c60835014f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "650ab114-4c82-4792-8121-67af15de182f", "AQAAAAEAACcQAAAAEOMmIhkUUAvAO4c0g2WIbu/DDAviBX4MIDRJUKYKls7z5GkLhlvjp6f2L/K66h2CtQ==", new DateTime(2022, 6, 10, 11, 9, 17, 90, DateTimeKind.Utc).AddTicks(9313), "980d9dd3-edfa-40a4-950c-368173c988b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e552862-a24d-4548-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisterDate", "SecurityStamp" },
                values: new object[] { "82e1f11e-9703-4801-9f97-557d4b7667aa", "AQAAAAEAACcQAAAAEHp4EV2Gywu9QkbnhZtAxBhapAlk+abLWUVZvFtDEVTDScyw3V/uI4r6Ze5SS1x6Eg==", new DateTime(2022, 6, 10, 11, 9, 17, 85, DateTimeKind.Utc).AddTicks(4980), "81052e58-97b2-487d-be2a-eae8cb15d896" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paid",
                table: "ServiceDemands");

            migrationBuilder.DropColumn(
                name: "Receipted",
                table: "ServiceDemands");

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
    }
}
