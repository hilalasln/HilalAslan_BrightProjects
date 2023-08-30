using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SanatEvi.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Branch = table.Column<string>(type: "TEXT", nullable: false),
                    EducationStatus = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    DateOfBirth = table.Column<int>(type: "INTEGER", nullable: false),
                    About = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    OrderStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentPerson = table.Column<int>(type: "INTEGER", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    CartId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseCategories",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseCategories", x => new { x.CourseId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CourseCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseCategories_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b222516e-df0e-497a-99ae-39fad2778d7f", null, "Yöneticilerin rolü bu.", "Admin", "ADMIN" },
                    { "f6f4901a-aa43-482e-8487-a384faac4165", null, "Diğer tüm kullanıcıların rolü bu.", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0dc901ea-d93e-4a13-904b-66b58f29d7ec", 0, "Kemalpaşa Mh. Zühtübey Sk. No:12 D:3 Üsküdar", "İstanbul", "c002fd5b-f3ca-477e-b3f8-2075e98a8fe7", new DateTime(1983, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "muratyilmaz@gmail.com", true, "Murat", "Erkek", "yılmaz", true, null, " ", "MURATYILMAZ@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEFBITt39JmbXvpdmso/HiAE6nFfehnmBpNfqQC0c/wdXRSDiALdlKcIuTj62Fo3J7A==", "+905436478990", true, "", false, "admin" },
                    { "fcec27df-3573-4d1b-b43e-bb3e515196db", 0, "Barbaros Bulvarı Feda İş Hanı K:5 D:23 Beşiktaş", "İstanbul", "5298dbea-1b69-4f2f-8f6a-bc5fb90ccfd7", new DateTime(1983, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "cemrekendirli@gmail.com", true, "Cemre", "Kadın", "Kendirli", true, null, " ", "CEMREKENDIRLI@GMAIL.COM", "USER", "AQAAAAIAAYagAAAAEOtm6/8zEPE23H4CYvFIOjcsAv8qnp0nCp+jTqBaXn1RRVAr7oxZdNrvFow+tcV/Ew==", "+904556677888", true, "", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1659), "Resim kursları, sanatseverlere resim becerilerini geliştirme ve yaratıcılıklarını keşfetme fırsatı sunan bir eğitim programıdır. Bu kurslar, çeşitli resim teknikleri ve malzemeleri üzerinde odaklanırken, katılımcılara renk, kompozisyon ve perspektif gibi temel sanat prensiplerini öğretir. Öğrenciler, uzman ressamlardan rehberlik alırken, kendi sanatsal tarzlarını keşfeder ve eserlerini yaratıcı bir şekilde ifade ederler. Resim kursları, sanatı sevdiren, ilham veren ve katılımcılara güven veren bir ortamda sanatsal becerilerini geliştirmek isteyen herkes için idealdir.", true, false, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1668), "Resim", "resim" },
                    { 2, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1671), "Seramik ve çömlekçilik, binlerce yıllık bir geçmişe sahip olan zanaat ve sanat dalıdır. Bu disiplin, kilin şekillendirilmesi, pişirilmesi ve süslemesiyle özgün ve dayanıklı seramik eserlerin yaratılmasını içerir. Seramik ve çömlekçilik kursları, katılımcılara temel teknikleri öğretirken, el becerilerini ve yaratıcılıklarını geliştirme imkanı sunar. Öğrenciler, çömlek tekerleği kullanarak vazolar, tabaklar ve heykeller gibi çeşitli eserler yapabilir, glazelerle renklendirme ve dekorasyon tekniklerini öğrenebilirler. Bu kurslar, sanatsal ifadeye ilgi duyan ve kendi benzersiz seramik eserlerini yaratmak isteyen herkese hitap eder.", true, false, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1671), "Seramik Ve Çömlekçilik", "seramik-comlekcilik" },
                    { 3, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1673), "Mozaik kursları, katılımcılara renkli ve çarpıcı mozaik eserlerinin nasıl oluşturulacağını öğretmek için mükemmel bir fırsattır. Bu kurslar, mozaik sanatının temel prensiplerini ve tekniklerini kapsar. Öğrenciler, farklı renk ve şekillerdeki mozaik parçalarını kullanarak, çeşitli yüzeylere güzel desenler ve görüntüler oluşturabilir. Kurslar genellikle farklı mozaik malzemelerinin kullanımını, kesmeyi, yerleştirmeyi ve tutkalı içerir. Mozaik kursları, yaratıcılığı teşvik ederken, kişilerin el becerilerini geliştirmelerini ve kendilerini sanatla ifade etmelerini sağlar.", true, false, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1673), "Mozaik", "mozaik" },
                    { 4, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1674), "Cam işleme kursu, camın farklı tekniklerle şekillendirilmesi ve dekoratif eserlerin yapılmasını öğreten bir eğitim programıdır. Bu kurslar, cam kesme, cam eritme, cam füzyonu, cam süsleme ve cam oyma gibi çeşitli tekniklere odaklanabilir. Katılımcılar, camdan vazolar, heykeller, takılar, lambalar ve vitray panolar gibi çeşitli objeler oluşturabilir. Cam işleme kursları, camın ışığı yansıtma özelliği ve renk çeşitliliğiyle sanatsal ifade imkanı sağlar. Bu kurslar, el becerilerini geliştirmek isteyen, estetik açıdan etkileyici cam eserler yaratmak isteyen herkese hitap eder.", true, false, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1675), "Cam İşleme", "cam-isleme" },
                    { 5, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1676), "Cam işleme kursu, camın farklı tekniklerle şekillendirilmesi ve dekoratif eserlerin yapılmasını öğreten bir eğitim programıdır. Bu kurslar, cam kesme, cam eritme, cam füzyonu, cam süsleme ve cam oyma gibi çeşitli tekniklere odaklanabilir. Katılımcılar, camdan vazolar, heykeller, takılar, lambalar ve vitray panolar gibi çeşitli objeler oluşturabilir. Cam işleme kursları, camın ışığı yansıtma özelliği ve renk çeşitliliğiyle sanatsal ifade imkanı sağlar. Bu kurslar, el becerilerini geliştirmek isteyen, estetik açıdan etkileyici cam eserler yaratmak isteyen herkese hitap eder.", true, false, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1676), "Ahşap İşleme", "ahsap-isleme-sanati" },
                    { 6, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1677), "", true, false, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1677), "Güzel Sanatlar", "güzel-sanatlar" },
                    { 7, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1678), "", true, false, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1679), "El Sanatları", "el-sanatlari" },
                    { 8, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1680), "", true, false, new DateTime(2023, 8, 30, 4, 33, 19, 448, DateTimeKind.Local).AddTicks(1680), "Hovi ve Sanat", "hobi-ve-sanat" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "About", "Address", "Branch", "City", "CreatedDate", "DateOfBirth", "EducationStatus", "FirstName", "Gender", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "Phone", "PhotoUrl", "Url" },
                values: new object[,]
                {
                    { 1, "Yetenekli ve deneyimli bir resim sanatçısı ve eğitmenim. Sanatsal yeteneklerimi öğrencilere aktarmaktan keyif alıyorum ve onları motive ederek yaratıcılıklarını geliştirmelerine yardımcı oluyorum. Çeşitli sanatsal tekniklerle resim yapmayı öğretme konusunda uzmanım ve öğrencilerimin bireysel ihtiyaçlarına odaklanarak etkili dersler sunuyorum.", "Bahçelievler", "Resim", "İstanbul", new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(2945), 1994, "Lisans", "Ali", "Erkek", true, false, "Asaf", new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(2951), "02164785696", "ali-asaf.jpg", "ali-asaf" },
                    { 2, "Tutkulu, motive edici ve öğrencilere ilham veren bir eğitmenim.Yaratıcı ve yenilikçi düşünce tarzıyla ders içeriğini zenginleştiriyorum.Sabırlı ve anlayışlı bir tutumla öğrencilerin özgüvenlerini artırıyorum.Takım çalışmasına yatkın ve iletişim becerileri güçlüyüm.", "Kadıköy", "Mozaik", "İstanbul", new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(2957), 1990, "Lisans", "Zeynep", "Kadın", true, false, "Hafsa", new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(2957), "05567789839", "zeynep-hafsa.jpg", "zeynep-hafsa" },
                    { 3, "Seramik sanatında uzmanlaşmış, yaratıcı ve öğrenci odaklı bir seramik öğretmeniyim. 10 yılı aşkın deneyimimle öğrencilere sanatsal yeteneklerini geliştirmede rehberlik ettim. Çeşitli seramik teknikleri, döküm, el işçiliği ve glazürleme konusunda bilgi ve becerilere sahibim. Öğrencilerin sanatsal ifade ve özgüvenlerini artırmak için etkili ders planları ve projeler tasarlarım.", "Şirinevler", "Seramik", "İstanbul", new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(2961), 1992, "Lisans", "Ahmet", "Erkek", true, false, "Salih", new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(2961), "05067782089", "ahmet-salih.jpg", "ahmet-salih" },
                    { 4, "Tecrübeli ahşap ustası ve tutkulu öğretmen olarak, öğrencilere ahşap işleme sanatını öğretme ve onların yaratıcı becerilerini geliştirme konusunda uzmanım. Eğitim materyallerini ve öğretim yöntemlerini kişiselleştirerek öğrencilerin ilgi ve ihtiyaçlarına uygun dersler sunarım. Motive edici bir yaklaşım benimseyerek öğrencilerin başarıya ulaşmasına katkıda bulunurum.", "Eyüp", "Ahşap", "İstanbul", new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(2963), 1990, "Lisans", "Ela", "Kadın", true, false, "Suna", new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(2964), "05447658990", "ela-suna.jpg", "ela-suna" },
                    { 5, "Henüz bir eğitmen atanmadı.", "Beşiktaş", "Güzel Sanatlar", "İstanbul", new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(2966), 1990, "Lisans", "Genel", "Kadın", true, false, "Eğitmen", new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(2966), "05467678904", "default-profile.jpg", "genel-egitmen" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b222516e-df0e-497a-99ae-39fad2778d7f", "0dc901ea-d93e-4a13-904b-66b58f29d7ec" },
                    { "f6f4901a-aa43-482e-8487-a384faac4165", "fcec27df-3573-4d1b-b43e-bb3e515196db" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 30, 4, 33, 19, 447, DateTimeKind.Local).AddTicks(6194), true, false, new DateTime(2023, 8, 30, 4, 33, 19, 447, DateTimeKind.Local).AddTicks(6204), "0dc901ea-d93e-4a13-904b-66b58f29d7ec" },
                    { 2, new DateTime(2023, 8, 30, 4, 33, 19, 447, DateTimeKind.Local).AddTicks(6210), true, false, new DateTime(2023, 8, 30, 4, 33, 19, 447, DateTimeKind.Local).AddTicks(6210), "fcec27df-3573-4d1b-b43e-bb3e515196db" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedDate", "CurrentPerson", "Description", "Duration", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "ModifiedDate", "Name", "Price", "TeacherId", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(28), 25, "Bu tür kurslar, resim yapmaya yeni başlayanlar için temel resim becerilerini öğretmeyi amaçlar. Renk teorisi, kompozisyon, perspektif, ışık-gölge gibi temel resim prensipleri ve teknikleri bu kurslar kapsamında öğretilebilir.", "120 saat", "temel-resim-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(35), "Temel Resim Kursu", 1000m, 1, "temel-resim-kursu" },
                    { 2, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(43), 25, "Yağlı boya resim tekniğine odaklanan kurslardır. Yağlı boya malzemeleri, fırça teknikleri, renk karışımları ve tablo üzerinde çalışma gibi konular bu kurslar kapsamında ele alınır.", "80 saat", "yagli-boya-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(43), "Yağlı Boya Kursu", 1200m, 1, "yagli-boya-kursu" },
                    { 3, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(46), 25, "Karakalem tekniğiyle resim yapmayı öğretmeyi amaçlayan kurslardır. Karakalem fırçaları, tonlama, çizim teknikleri ve gölgelendirme gibi konular bu kurslar içinde yer alır.", "70 saat", "kara-kalem-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(47), "Karakalem Kursu", 800m, 1, "kara-kalem-kursu" },
                    { 4, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(49), 25, "Portre resim yapmayı öğretmeyi hedefleyen kurslardır. İnsan yüzünün anatomisi, yüz ifadeleri, ışık-gölge ilişkileri ve detaylandırma gibi konular bu kurslar kapsamında ele alınır.", "100 saat", "portre-resim-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(49), "Portre Resim Kursu", 1000m, 1, "portre-resim-kursu" },
                    { 5, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(51), 25, "Akrilik boya kullanarak resim yapmayı öğretmeyi hedefleyen kurslardır. Akrilik boya malzemeleri, fırça teknikleri, renk geçişleri ve katmanlar gibi konular bu kurslar kapsamında ele alınır.", "60 saat", "akrilik-resim-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(57), "Akrilik Boya Kursu", 1400m, 1, "akrilik-resim-kursu" },
                    { 6, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(67), 20, "Bu kurs, seramik malzemeleri, el şekillendirme teknikleri, kilin hazırlanması, merkezleme ve şekil verme gibi temel becerileri öğretir. Katılımcılar, çeşitli seramik formları oluşturma ve kilin pişirme sürecini deneyimleme fırsatı bulurlar.", "100 saat", "temel-seramik-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(68), "Temel Seramik Kursu", 1500m, 3, "temel-seramik-kursu" },
                    { 7, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(70), 20, "Bu kurs, çömlekçilik tekerleği üzerinde çalışmayı öğretir. Katılımcılar, çömlekçilik tekerleği kullanarak çeşitli kaplar, vazolar veya tabaklar gibi formlar oluşturma becerilerini geliştirir. Ayrıca, eserlerin sonraki aşamaları olan kurutma, glazelenme ve pişirme süreçlerini de öğrenirler.", "50 saat", "carkta-comlekcilik-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(70), "Çarkta Çömlekçilik Kursu", 1400m, 3, "carkta-comlekcilik-kursu" },
                    { 8, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(72), 20, "Bu kurs, seramik parçaların dekoratif tekniklerle süslenmesini öğretir. Katılımcılar, boyama, sırlama, transfer baskı, kabartma ve serigrafi gibi farklı dekoratif yöntemleri kullanarak seramik eserlerini kişiselleştirme becerisini kazanırlar.", "100 saat", "dekoratif-seramik-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(72), "Dekoratif Seramik Kursu", 1000m, 3, "dekoratif-seramik-kursu" },
                    { 9, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(74), 20, "Bu kurs, mozaik sanatının temellerini öğretir. Mozaik malzemeleri seçme, kesme, düzenleme ve yapıştırma teknikleri gibi konuları kapsar. Katılımcılar, küçük projelerde pratik yaparak mozaik sanatına giriş yaparlar.", "120 saat", "temel-mozaik-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(74), "Temel Mozaik Kursu", 1100m, 2, "temel-mozaik-kursu" },
                    { 10, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(76), 20, "Bu kurs, mozaik tablolar oluşturmayı öğretir. Katılımcılar, ahşap bir tablo yüzeyine mozaik parçalarını yerleştirerek kişisel ve dekoratif bir tablo yapma becerilerini geliştirirler. Mozaik tasarımı, renk uyumu ve yapıştırma teknikleri kursun odak noktalarıdır.", "85 saat", "mozaik-tablo-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(77), "Mozaik Tablo Kursu", 1350m, 2, "mozaik-tablo-kursu" },
                    { 11, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(79), 20, "Bu kurs, vitray cam tekniklerini öğretir. Katılımcılar, cam levhaları kesme, lehimleme ve farklı renklerdeki camları bir araya getirerek vitray pencereler, lambalar veya dekoratif cam paneller gibi ürünler yapmayı öğrenirler.", "150 saat", "vitray-cam-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(79), "Vitray Cam Kursu", 2000m, 2, "vitray-cam-kursu" },
                    { 12, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(81), 25, "Bu kurs, cam yüzeyine kabartma efektleri verme tekniklerini öğretir. Katılımcılar, cam levhaları ısıtma ve şekillendirme yöntemleriyle üç boyutlu desenler ve kabartmalar oluştururlar.", "100 saat", "cam-kabartma-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(81), "Cam Kabartma Kursu", 1000m, 2, "cam-kabartma-kursu" },
                    { 13, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(83), 25, "Bu kurs, ahşap işleme tekniklerinin temellerini öğretir. Katılımcılar, ahşap malzemeleri kesme, şekillendirme, zımparalama ve birleştirme gibi temel becerileri kazanarak küçük projeler yaparlar.", "130 saat", "temel-ahsap-isleme-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(83), "Temel Ahşap İşleme Kursu", 1500m, 4, "temel-ahsap-isleme-kursu" },
                    { 14, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(86), 20, "Bu kurs, ahşap oyma sanatını öğretir. Katılımcılar, çeşitli oyma teknikleri kullanarak ahşap üzerine desenler ve kabartmalar oluştururlar. Ahşap oyma aletlerini kullanma becerilerini geliştirirler ve kendi oyma projelerini tamamlarlar.", "100 saat", "ahsap-oyma-kursu.jpeg", true, false, true, new DateTime(2023, 8, 30, 4, 33, 19, 449, DateTimeKind.Local).AddTicks(86), "Ahşap Oyma Kursu", 1100m, 4, "ahsap-oyma-kursu" }
                });

            migrationBuilder.InsertData(
                table: "CourseCategories",
                columns: new[] { "CategoryId", "CourseId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 6, 1 },
                    { 1, 2 },
                    { 6, 2 },
                    { 1, 3 },
                    { 6, 3 },
                    { 1, 4 },
                    { 6, 4 },
                    { 1, 5 },
                    { 6, 5 },
                    { 2, 6 },
                    { 7, 6 },
                    { 2, 7 },
                    { 7, 7 },
                    { 2, 8 },
                    { 7, 8 },
                    { 3, 9 },
                    { 7, 9 },
                    { 3, 10 },
                    { 8, 10 },
                    { 4, 11 },
                    { 8, 11 },
                    { 4, 12 },
                    { 7, 12 },
                    { 5, 13 },
                    { 8, 13 },
                    { 5, 14 },
                    { 8, 14 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CourseId",
                table: "CartItems",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseCategories_CategoryId",
                table: "CourseCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CourseId",
                table: "OrderItems",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
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
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "CourseCategories");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
