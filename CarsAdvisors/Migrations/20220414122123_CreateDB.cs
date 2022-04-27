using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarsAdvisors.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Makers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MakerImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "News_Reviews",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News_Reviews", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Maker_ID = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body_Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Engine_Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Airbags_count = table.Column<int>(type: "int", nullable: false),
                    Fuelconsumption = table.Column<int>(type: "int", nullable: false),
                    Horse_power = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Luggageboxcapacity = table.Column<int>(type: "int", nullable: false),
                    Seats_count = table.Column<int>(type: "int", nullable: false),
                    Cylinders = table.Column<int>(type: "int", nullable: false),
                    Maximum_torque = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fuel_Consumption = table.Column<int>(type: "int", nullable: false),
                    Fuel_Type = table.Column<int>(type: "int", nullable: false),
                    Drive_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maximum_power = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acceleration = table.Column<float>(type: "real", nullable: false),
                    Maximum_Speed = table.Column<int>(type: "int", nullable: false),
                    Fuel_Tank_Capacity = table.Column<int>(type: "int", nullable: false),
                    Gear_Shifts = table.Column<int>(type: "int", nullable: false),
                    folding_for_back_seats = table.Column<bool>(type: "bit", nullable: false),
                    Paddle_shifters = table.Column<bool>(type: "bit", nullable: false),
                    Leather_Steering_Wheel = table.Column<bool>(type: "bit", nullable: false),
                    Variable_heated_driver_and_passenger_seat = table.Column<bool>(type: "bit", nullable: false),
                    Power_Tailgate = table.Column<bool>(type: "bit", nullable: false),
                    Ambient_Lighting = table.Column<bool>(type: "bit", nullable: false),
                    Steering_Wheel = table.Column<bool>(type: "bit", nullable: false),
                    Number_of_Seats = table.Column<int>(type: "int", nullable: false),
                    Rear_parking_sensors = table.Column<bool>(type: "bit", nullable: false),
                    Rear_View_Camera = table.Column<bool>(type: "bit", nullable: false),
                    Passenger_Seat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parking_Sensors = table.Column<bool>(type: "bit", nullable: false),
                    Electronic_Window = table.Column<bool>(type: "bit", nullable: false),
                    Multi_function_steering_wheel = table.Column<bool>(type: "bit", nullable: false),
                    Leather_Transmission = table.Column<bool>(type: "bit", nullable: false),
                    Back_Holder = table.Column<bool>(type: "bit", nullable: false),
                    Keyless_Entry = table.Column<bool>(type: "bit", nullable: false),
                    Auto_dimming_mirror = table.Column<bool>(type: "bit", nullable: false),
                    Air_Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keyless_Start = table.Column<bool>(type: "bit", nullable: false),
                    Front_Camera = table.Column<bool>(type: "bit", nullable: false),
                    Driver_Seat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leather_Seats = table.Column<bool>(type: "bit", nullable: false),
                    Center_Lock = table.Column<bool>(type: "bit", nullable: false),
                    Dashboard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RainSensor = table.Column<bool>(type: "bit", nullable: false),
                    Foglamps = table.Column<bool>(type: "bit", nullable: false),
                    RearLamps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Auto_lighting = table.Column<bool>(type: "bit", nullable: false),
                    Wheels_with_tire_size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Panorama_Roof = table.Column<bool>(type: "bit", nullable: false),
                    Auto_Folding_Mirrors = table.Column<bool>(type: "bit", nullable: false),
                    Privacy_glass = table.Column<bool>(type: "bit", nullable: false),
                    Headlamps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LED_Daytime_running_lamps = table.Column<bool>(type: "bit", nullable: false),
                    Light_Sensors = table.Column<bool>(type: "bit", nullable: false),
                    Sun_Roof = table.Column<bool>(type: "bit", nullable: false),
                    Power_mirrors = table.Column<bool>(type: "bit", nullable: false),
                    Rim_Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alarm_Anti_Theft_System = table.Column<bool>(type: "bit", nullable: false),
                    Hill_Assist = table.Column<bool>(type: "bit", nullable: false),
                    Speed_Limiter = table.Column<bool>(type: "bit", nullable: false),
                    Automatic_Start_Stop_Function = table.Column<bool>(type: "bit", nullable: false),
                    Tire_Pressure_Monitoring = table.Column<bool>(type: "bit", nullable: false),
                    Electronic_Brake_Force_Distribution = table.Column<bool>(type: "bit", nullable: false),
                    Cruise_Control = table.Column<bool>(type: "bit", nullable: false),
                    Airbags = table.Column<int>(type: "int", nullable: false),
                    Electric_Handbrake = table.Column<bool>(type: "bit", nullable: false),
                    Power_Assisted_Steering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active_Park_Assist = table.Column<bool>(type: "bit", nullable: false),
                    Traction_Control = table.Column<bool>(type: "bit", nullable: false),
                    Anti_Lock_Braking_System = table.Column<bool>(type: "bit", nullable: false),
                    AUX = table.Column<bool>(type: "bit", nullable: false),
                    USB = table.Column<bool>(type: "bit", nullable: false),
                    Multifunction_Steering_Wheel = table.Column<bool>(type: "bit", nullable: false),
                    Navigation_System = table.Column<bool>(type: "bit", nullable: false),
                    Speakers = table.Column<bool>(type: "bit", nullable: false),
                    Bluetooth = table.Column<bool>(type: "bit", nullable: false),
                    Head_Up_Display = table.Column<bool>(type: "bit", nullable: false),
                    Touch_screen = table.Column<bool>(type: "bit", nullable: false),
                    Wireless_Charger = table.Column<bool>(type: "bit", nullable: false),
                    Smartphone_Link_Systems = table.Column<bool>(type: "bit", nullable: false),
                    Luggage_Box_Capacity = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Wheelbase = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Models_Makers_Maker_ID",
                        column: x => x.Maker_ID,
                        principalTable: "Makers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compares",
                columns: table => new
                {
                    CompareID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model_ID = table.Column<int>(type: "int", nullable: false),
                    User_ID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compares", x => x.CompareID);
                    table.ForeignKey(
                        name: "FK_Compares_Models_Model_ID",
                        column: x => x.Model_ID,
                        principalTable: "Models",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_Models_Model_ID",
                        column: x => x.Model_ID,
                        principalTable: "Models",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Compares_Model_ID",
                table: "Compares",
                column: "Model_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_Model_ID",
                table: "Images",
                column: "Model_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Models_Maker_ID",
                table: "Models",
                column: "Maker_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Compares");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "News_Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Makers");
        }
    }
}
