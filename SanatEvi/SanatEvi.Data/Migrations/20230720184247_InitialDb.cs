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
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    EducationStatus = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
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
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
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
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Branch = table.Column<string>(type: "TEXT", nullable: true),
                    About = table.Column<string>(type: "TEXT", nullable: true),
                    Experience = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_AspNetUsers_UserId",
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
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    StartingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Classtime = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    CurrentPerson = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CourseInstructors",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    InstructorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInstructors", x => new { x.CourseId, x.InstructorId });
                    table.ForeignKey(
                        name: "FK_CourseInstructors_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseInstructors_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseUser",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    DateRegistration = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseUser", x => new { x.CourseId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CourseUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseUser_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "EducationStatus", "Email", "EmailConfirmed", "FirstName", "Gender", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "Url", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "Halide Edip Adıvar Mahallesi Darülaceze Caddesi No:3A BOMONTİ / ŞİŞLİ", "İstanbul", "6398f2bc-517b-45e1-9ccd-d85d13097682", 2000, "Lisans", null, false, "Mehmet", "Erkek", "mehmet-derik.jpg", "Derik", false, null, null, null, null, null, null, false, "cbe89ab7-9481-471f-9c60-ff2efca975c4", false, "mehmet-derik", null },
                    { "2", 0, "Meliha Avni Sezen Cad. Sakız Ağacı Sok. No: 47/C Esentepe", "İstanbul", "42c089f5-1f3d-4c8c-acbb-e9a2b0090cd8", 1998, "Lisans", null, false, "Selen", "Kadın", "selen-sargin.jpg", "Sargın", false, null, null, null, null, null, null, false, "09e5f2b2-a43d-4d90-9425-2f3aa0ff9291", false, "selen-sargın", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(131), "Resim kursları, sanatseverlere resim becerilerini geliştirme ve yaratıcılıklarını keşfetme fırsatı sunan bir eğitim programıdır. Bu kurslar, çeşitli resim teknikleri ve malzemeleri üzerinde odaklanırken, katılımcılara renk, kompozisyon ve perspektif gibi temel sanat prensiplerini öğretir. Öğrenciler, uzman ressamlardan rehberlik alırken, kendi sanatsal tarzlarını keşfeder ve eserlerini yaratıcı bir şekilde ifade ederler. Resim kursları, sanatı sevdiren, ilham veren ve katılımcılara güven veren bir ortamda sanatsal becerilerini geliştirmek isteyen herkes için idealdir.", "resim-jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(146), "Resim", "resim" },
                    { 2, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(151), "Seramik ve çömlekçilik, binlerce yıllık bir geçmişe sahip olan zanaat ve sanat dalıdır. Bu disiplin, kilin şekillendirilmesi, pişirilmesi ve süslemesiyle özgün ve dayanıklı seramik eserlerin yaratılmasını içerir. Seramik ve çömlekçilik kursları, katılımcılara temel teknikleri öğretirken, el becerilerini ve yaratıcılıklarını geliştirme imkanı sunar. Öğrenciler, çömlek tekerleği kullanarak vazolar, tabaklar ve heykeller gibi çeşitli eserler yapabilir, glazelerle renklendirme ve dekorasyon tekniklerini öğrenebilirler. Bu kurslar, sanatsal ifadeye ilgi duyan ve kendi benzersiz seramik eserlerini yaratmak isteyen herkese hitap eder.", "seramik-comlekcilik.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(153), "Seramik Ve Çömlekçilik", "seramik-comlekcilik" },
                    { 3, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(156), "Mozaik kursları, katılımcılara renkli ve çarpıcı mozaik eserlerinin nasıl oluşturulacağını öğretmek için mükemmel bir fırsattır. Bu kurslar, mozaik sanatının temel prensiplerini ve tekniklerini kapsar. Öğrenciler, farklı renk ve şekillerdeki mozaik parçalarını kullanarak, çeşitli yüzeylere güzel desenler ve görüntüler oluşturabilir. Kurslar genellikle farklı mozaik malzemelerinin kullanımını, kesmeyi, yerleştirmeyi ve tutkalı içerir. Mozaik kursları, yaratıcılığı teşvik ederken, kişilerin el becerilerini geliştirmelerini ve kendilerini sanatla ifade etmelerini sağlar.", "mozaik.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(156), "Mozaik", "mozaik" },
                    { 4, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(159), "Cam işleme kursu, camın farklı tekniklerle şekillendirilmesi ve dekoratif eserlerin yapılmasını öğreten bir eğitim programıdır. Bu kurslar, cam kesme, cam eritme, cam füzyonu, cam süsleme ve cam oyma gibi çeşitli tekniklere odaklanabilir. Katılımcılar, camdan vazolar, heykeller, takılar, lambalar ve vitray panolar gibi çeşitli objeler oluşturabilir. Cam işleme kursları, camın ışığı yansıtma özelliği ve renk çeşitliliğiyle sanatsal ifade imkanı sağlar. Bu kurslar, el becerilerini geliştirmek isteyen, estetik açıdan etkileyici cam eserler yaratmak isteyen herkese hitap eder.", "cam-isleme.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(160), "Cam İşleme", "cam-isleme" },
                    { 5, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(162), "Cam işleme kursu, camın farklı tekniklerle şekillendirilmesi ve dekoratif eserlerin yapılmasını öğreten bir eğitim programıdır. Bu kurslar, cam kesme, cam eritme, cam füzyonu, cam süsleme ve cam oyma gibi çeşitli tekniklere odaklanabilir. Katılımcılar, camdan vazolar, heykeller, takılar, lambalar ve vitray panolar gibi çeşitli objeler oluşturabilir. Cam işleme kursları, camın ışığı yansıtma özelliği ve renk çeşitliliğiyle sanatsal ifade imkanı sağlar. Bu kurslar, el becerilerini geliştirmek isteyen, estetik açıdan etkileyici cam eserler yaratmak isteyen herkese hitap eder.", "ahsap-isleme-sanati.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(163), "Ahşap İşleme", "ahsap-isleme-sanati" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CategoryId", "Classtime", "CreatedDate", "CurrentPerson", "Description", "EndDate", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "Price", "StartingDate", "Title", "Url" },
                values: new object[,]
                {
                    { 1, 1, "120 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7296), 25, "Bu tür kurslar, resim yapmaya yeni başlayanlar için temel resim becerilerini öğretmeyi amaçlar. Renk teorisi, kompozisyon, perspektif, ışık-gölge gibi temel resim prensipleri ve teknikleri bu kurslar kapsamında öğretilebilir.", new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "temel-resim-kurslari.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7307), 1000m, new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temel Resim Kursu", "temel-resim-kurslari" },
                    { 2, 1, "80 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7317), 25, "Yağlı boya resim tekniğine odaklanan kurslardır. Yağlı boya malzemeleri, fırça teknikleri, renk karışımları ve tablo üzerinde çalışma gibi konular bu kurslar kapsamında ele alınır.", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yagli-boya-kursu.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7318), 1200m, new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yağlı Boya Kursu", "yagli-boya-kursu" },
                    { 3, 1, "70 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7323), 25, "Karakalem tekniğiyle resim yapmayı öğretmeyi amaçlayan kurslardır. Karakalem fırçaları, tonlama, çizim teknikleri ve gölgelendirme gibi konular bu kurslar içinde yer alır.", new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "karakalem-kursu.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7324), 800m, new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karakalem Kursu", "karakalem-kursu.jpg" },
                    { 4, 1, "100 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7329), 25, "Portre resim yapmayı öğretmeyi hedefleyen kurslardır. İnsan yüzünün anatomisi, yüz ifadeleri, ışık-gölge ilişkileri ve detaylandırma gibi konular bu kurslar kapsamında ele alınır.", new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "portre-resim-kursu.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7330), 1000m, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Portre Resim Kursu", "portre-resim-kursu" },
                    { 5, 1, "60 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7334), 25, "Akrilik boya kullanarak resim yapmayı öğretmeyi hedefleyen kurslardır. Akrilik boya malzemeleri, fırça teknikleri, renk geçişleri ve katmanlar gibi konular bu kurslar kapsamında ele alınır.", new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "akrilik-resim-kursu.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7335), 1400m, new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Akrilik Boya Kursu", "akrilik-resim-kursu" },
                    { 6, 2, "100 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7339), 20, "Bu kurs, seramik malzemeleri, el şekillendirme teknikleri, kilin hazırlanması, merkezleme ve şekil verme gibi temel becerileri öğretir. Katılımcılar, çeşitli seramik formları oluşturma ve kilin pişirme sürecini deneyimleme fırsatı bulurlar.", new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "temel-seramik-kursu.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7340), 1500m, new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temel Seramik Kursu", "temel-seramik-kursu" },
                    { 7, 2, "50 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7345), 20, "Bu kurs, çömlekçilik tekerleği üzerinde çalışmayı öğretir. Katılımcılar, çömlekçilik tekerleği kullanarak çeşitli kaplar, vazolar veya tabaklar gibi formlar oluşturma becerilerini geliştirir. Ayrıca, eserlerin sonraki aşamaları olan kurutma, glazelenme ve pişirme süreçlerini de öğrenirler.", new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "carkta-comlekcilik-kursu.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7346), 1400m, new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çarkta Çömlekçilik Kursu", "carkta-comlekcilik-kursu" },
                    { 8, 2, "100 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7350), 20, "Bu kurs, seramik parçaların dekoratif tekniklerle süslenmesini öğretir. Katılımcılar, boyama, sırlama, transfer baskı, kabartma ve serigrafi gibi farklı dekoratif yöntemleri kullanarak seramik eserlerini kişiselleştirme becerisini kazanırlar.", new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "dekoratif-seramik-kurs.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7351), 1000m, new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dekoratif Seramik Kursu", "dekoratif-seramik-kurs" },
                    { 9, 3, "120 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7355), 20, "Bu kurs, mozaik sanatının temellerini öğretir. Mozaik malzemeleri seçme, kesme, düzenleme ve yapıştırma teknikleri gibi konuları kapsar. Katılımcılar, küçük projelerde pratik yaparak mozaik sanatına giriş yaparlar.", new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "temel-mozaik-kursu.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7356), 1100m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temel Mozaik Kursu", "temel-mozaik-kursu" },
                    { 10, 3, "85 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7364), 20, "Bu kurs, mozaik tablolar oluşturmayı öğretir. Katılımcılar, ahşap bir tablo yüzeyine mozaik parçalarını yerleştirerek kişisel ve dekoratif bir tablo yapma becerilerini geliştirirler. Mozaik tasarımı, renk uyumu ve yapıştırma teknikleri kursun odak noktalarıdır.", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mozaik-tablo-kursu.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7365), 1350m, new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mozaik Tablo Kursu", "mozaik-tablo-kursu" },
                    { 11, 4, "150 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7370), 20, "Bu kurs, vitray cam tekniklerini öğretir. Katılımcılar, cam levhaları kesme, lehimleme ve farklı renklerdeki camları bir araya getirerek vitray pencereler, lambalar veya dekoratif cam paneller gibi ürünler yapmayı öğrenirler.", new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "vitray-cam-kursu.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7371), 2000m, new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vitray Cam Kursu", "vitray-cam-kursu" },
                    { 12, 4, "100 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7377), 25, "Bu kurs, cam yüzeyine kabartma efektleri verme tekniklerini öğretir. Katılımcılar, cam levhaları ısıtma ve şekillendirme yöntemleriyle üç boyutlu desenler ve kabartmalar oluştururlar.", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "cam-kabartma-kursu.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7378), 1000m, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cam Kabartma Kursu", "cam-kabartma-kursu" },
                    { 13, 5, "130 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7382), 25, "Bu kurs, ahşap işleme tekniklerinin temellerini öğretir. Katılımcılar, ahşap malzemeleri kesme, şekillendirme, zımparalama ve birleştirme gibi temel becerileri kazanarak küçük projeler yaparlar.", new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "temel-ahsap-isleme-kursu.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7383), 1500m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temel Ahşap İşleme Kursu", "temel-ahsap-isleme-kursu" },
                    { 14, 5, "100 saat", new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7387), 20, "Bu kurs, ahşap oyma sanatını öğretir. Katılımcılar, çeşitli oyma teknikleri kullanarak ahşap üzerine desenler ve kabartmalar oluştururlar. Ahşap oyma aletlerini kullanma becerilerini geliştirirler ve kendi oyma projelerini tamamlarlar.", new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahsap-oyma-kurs.jpg", true, false, new DateTime(2023, 7, 20, 21, 42, 47, 676, DateTimeKind.Local).AddTicks(7388), 1100m, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahşap Oyma Kursu", "ahsap-oyma-kursu" }
                });

            migrationBuilder.InsertData(
                table: "CourseUser",
                columns: new[] { "CourseId", "UserId", "DateRegistration" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
                name: "IX_CourseInstructors_InstructorId",
                table: "CourseInstructors",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseUser_UserId",
                table: "CourseUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_UserId",
                table: "Instructors",
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
                name: "CourseInstructors");

            migrationBuilder.DropTable(
                name: "CourseUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
