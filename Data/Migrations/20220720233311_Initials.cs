using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ClassifiedAds");

            migrationBuilder.CreateTable(
                name: "Address",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Company = table.Column<string>(type: "text", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: true),
                    StateProvinceId = table.Column<int>(type: "integer", nullable: true),
                    County = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Address1 = table.Column<string>(type: "text", nullable: false),
                    Address2 = table.Column<string>(type: "text", nullable: false),
                    ZipPostalCode = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    FaxNumber = table.Column<string>(type: "text", nullable: false),
                    CustomAttributes = table.Column<string>(type: "text", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    EmailToRevalidate = table.Column<string>(type: "text", nullable: false),
                    AdminComment = table.Column<string>(type: "text", nullable: false),
                    VendorId = table.Column<int>(type: "integer", nullable: false),
                    HasShoppingCartItems = table.Column<bool>(type: "boolean", nullable: false),
                    CannotLoginUntilDateUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastIpAddress = table.Column<string>(type: "text", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastLoginDateUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastActivityDateUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    RegisteredInStoreId = table.Column<int>(type: "integer", nullable: false),
                    BillingAddressId = table.Column<int>(type: "integer", nullable: true),
                    ShippingAddressId = table.Column<int>(type: "integer", nullable: true),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPost",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IncludeInSitemap = table.Column<bool>(type: "boolean", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    BodyOverview = table.Column<string>(type: "text", nullable: false),
                    AllowComments = table.Column<bool>(type: "boolean", nullable: false),
                    Tags = table.Column<string>(type: "text", nullable: false),
                    StartDateUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    EndDateUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    MetaKeywords = table.Column<string>(type: "text", nullable: false),
                    MetaDescription = table.Column<string>(type: "text", nullable: false),
                    MetaTitle = table.Column<string>(type: "text", nullable: false),
                    LimitedToStores = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPostTag",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    BlogPostCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPostTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTemplate",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ViewPath = table.Column<string>(type: "text", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Download",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DownloadGuid = table.Column<Guid>(type: "uuid", nullable: false),
                    UseDownloadUrl = table.Column<bool>(type: "boolean", nullable: false),
                    DownloadUrl = table.Column<string>(type: "text", nullable: false),
                    DownloadBinary = table.Column<byte[]>(type: "bytea", nullable: false),
                    ContentType = table.Column<string>(type: "text", nullable: false),
                    Filename = table.Column<string>(type: "text", nullable: false),
                    Extension = table.Column<string>(type: "text", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Download", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ManufacturerTemplateId = table.Column<int>(type: "integer", nullable: false),
                    MetaKeywords = table.Column<string>(type: "text", nullable: false),
                    MetaDescription = table.Column<string>(type: "text", nullable: false),
                    MetaTitle = table.Column<string>(type: "text", nullable: false),
                    PictureId = table.Column<int>(type: "integer", nullable: false),
                    PageSize = table.Column<int>(type: "integer", nullable: false),
                    AllowCustomersToSelectPageSize = table.Column<bool>(type: "boolean", nullable: false),
                    PageSizeOptions = table.Column<string>(type: "text", nullable: false),
                    SubjectToAcl = table.Column<bool>(type: "boolean", nullable: false),
                    LimitedToStores = table.Column<bool>(type: "boolean", nullable: false),
                    Published = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PriceRangeFiltering = table.Column<bool>(type: "boolean", nullable: false),
                    PriceFrom = table.Column<decimal>(type: "numeric", nullable: false),
                    PriceTo = table.Column<decimal>(type: "numeric", nullable: false),
                    ManuallyPriceRange = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Picture",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MimeType = table.Column<string>(type: "text", nullable: false),
                    SeoFilename = table.Column<string>(type: "text", nullable: false),
                    AltAttribute = table.Column<string>(type: "text", nullable: false),
                    TitleAttribute = table.Column<string>(type: "text", nullable: false),
                    IsNew = table.Column<bool>(type: "boolean", nullable: false),
                    VirtualPath = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Picture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PictureBinary",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BinaryData = table.Column<byte[]>(type: "bytea", nullable: false),
                    PictureId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureBinary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductTypeId = table.Column<int>(type: "integer", nullable: false),
                    ParentGroupedProductId = table.Column<int>(type: "integer", nullable: false),
                    VisibleIndividually = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortDescription = table.Column<string>(type: "text", nullable: false),
                    FullDescription = table.Column<string>(type: "text", nullable: false),
                    AdminComment = table.Column<string>(type: "text", nullable: false),
                    ProductTemplateId = table.Column<int>(type: "integer", nullable: false),
                    VendorId = table.Column<int>(type: "integer", nullable: false),
                    ShowOnHomepage = table.Column<bool>(type: "boolean", nullable: false),
                    MetaKeywords = table.Column<string>(type: "text", nullable: false),
                    MetaDescription = table.Column<string>(type: "text", nullable: false),
                    MetaTitle = table.Column<string>(type: "text", nullable: false),
                    AllowCustomerReviews = table.Column<bool>(type: "boolean", nullable: false),
                    ApprovedRatingSum = table.Column<int>(type: "integer", nullable: false),
                    NotApprovedRatingSum = table.Column<int>(type: "integer", nullable: false),
                    ApprovedTotalReviews = table.Column<int>(type: "integer", nullable: false),
                    NotApprovedTotalReviews = table.Column<int>(type: "integer", nullable: false),
                    SubjectToAcl = table.Column<bool>(type: "boolean", nullable: false),
                    LimitedToStores = table.Column<bool>(type: "boolean", nullable: false),
                    Sku = table.Column<string>(type: "text", nullable: false),
                    ManufacturerPartNumber = table.Column<string>(type: "text", nullable: false),
                    Gtin = table.Column<string>(type: "text", nullable: false),
                    IsGiftCard = table.Column<bool>(type: "boolean", nullable: false),
                    GiftCardTypeId = table.Column<int>(type: "integer", nullable: false),
                    OverriddenGiftCardAmount = table.Column<decimal>(type: "numeric", nullable: true),
                    RequireOtherProducts = table.Column<bool>(type: "boolean", nullable: false),
                    RequiredProductIds = table.Column<string>(type: "text", nullable: false),
                    AutomaticallyAddRequiredProducts = table.Column<bool>(type: "boolean", nullable: false),
                    IsDownload = table.Column<bool>(type: "boolean", nullable: false),
                    DownloadId = table.Column<int>(type: "integer", nullable: false),
                    UnlimitedDownloads = table.Column<bool>(type: "boolean", nullable: false),
                    MaxNumberOfDownloads = table.Column<int>(type: "integer", nullable: false),
                    DownloadExpirationDays = table.Column<int>(type: "integer", nullable: true),
                    DownloadActivationTypeId = table.Column<int>(type: "integer", nullable: false),
                    HasSampleDownload = table.Column<bool>(type: "boolean", nullable: false),
                    SampleDownloadId = table.Column<int>(type: "integer", nullable: false),
                    HasUserAgreement = table.Column<bool>(type: "boolean", nullable: false),
                    UserAgreementText = table.Column<string>(type: "text", nullable: false),
                    IsRecurring = table.Column<bool>(type: "boolean", nullable: false),
                    RecurringCycleLength = table.Column<int>(type: "integer", nullable: false),
                    RecurringCyclePeriodId = table.Column<int>(type: "integer", nullable: false),
                    RecurringTotalCycles = table.Column<int>(type: "integer", nullable: false),
                    IsRental = table.Column<bool>(type: "boolean", nullable: false),
                    RentalPriceLength = table.Column<int>(type: "integer", nullable: false),
                    RentalPricePeriodId = table.Column<int>(type: "integer", nullable: false),
                    IsShipEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    IsFreeShipping = table.Column<bool>(type: "boolean", nullable: false),
                    ShipSeparately = table.Column<bool>(type: "boolean", nullable: false),
                    AdditionalShippingCharge = table.Column<decimal>(type: "numeric", nullable: false),
                    DeliveryDateId = table.Column<int>(type: "integer", nullable: false),
                    IsTaxExempt = table.Column<bool>(type: "boolean", nullable: false),
                    TaxCategoryId = table.Column<int>(type: "integer", nullable: false),
                    IsTelecommunicationsOrBroadcastingOrElectronicServices = table.Column<bool>(type: "boolean", nullable: false),
                    ManageInventoryMethodId = table.Column<int>(type: "integer", nullable: false),
                    ProductAvailabilityRangeId = table.Column<int>(type: "integer", nullable: false),
                    UseMultipleWarehouses = table.Column<bool>(type: "boolean", nullable: false),
                    WarehouseId = table.Column<int>(type: "integer", nullable: false),
                    StockQuantity = table.Column<int>(type: "integer", nullable: false),
                    DisplayStockAvailability = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayStockQuantity = table.Column<bool>(type: "boolean", nullable: false),
                    MinStockQuantity = table.Column<int>(type: "integer", nullable: false),
                    LowStockActivityId = table.Column<int>(type: "integer", nullable: false),
                    NotifyAdminForQuantityBelow = table.Column<int>(type: "integer", nullable: false),
                    BackorderModeId = table.Column<int>(type: "integer", nullable: false),
                    AllowBackInStockSubscriptions = table.Column<bool>(type: "boolean", nullable: false),
                    OrderMinimumQuantity = table.Column<int>(type: "integer", nullable: false),
                    OrderMaximumQuantity = table.Column<int>(type: "integer", nullable: false),
                    AllowedQuantities = table.Column<string>(type: "text", nullable: false),
                    AllowAddingOnlyExistingAttributeCombinations = table.Column<bool>(type: "boolean", nullable: false),
                    NotReturnable = table.Column<bool>(type: "boolean", nullable: false),
                    DisableBuyButton = table.Column<bool>(type: "boolean", nullable: false),
                    DisableWishlistButton = table.Column<bool>(type: "boolean", nullable: false),
                    AvailableForPreOrder = table.Column<bool>(type: "boolean", nullable: false),
                    PreOrderAvailabilityStartDateTimeUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CallForPrice = table.Column<bool>(type: "boolean", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    OldPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    ProductCost = table.Column<decimal>(type: "numeric", nullable: false),
                    CustomerEntersPrice = table.Column<bool>(type: "boolean", nullable: false),
                    MinimumCustomerEnteredPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    MaximumCustomerEnteredPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    BasepriceEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    BasepriceAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    BasepriceUnitId = table.Column<int>(type: "integer", nullable: false),
                    BasepriceBaseAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    BasepriceBaseUnitId = table.Column<int>(type: "integer", nullable: false),
                    MarkAsNew = table.Column<bool>(type: "boolean", nullable: false),
                    MarkAsNewStartDateTimeUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    MarkAsNewEndDateTimeUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    HasTierPrices = table.Column<bool>(type: "boolean", nullable: false),
                    HasDiscountsApplied = table.Column<bool>(type: "boolean", nullable: false),
                    Weight = table.Column<decimal>(type: "numeric", nullable: false),
                    Length = table.Column<decimal>(type: "numeric", nullable: false),
                    Width = table.Column<decimal>(type: "numeric", nullable: false),
                    Height = table.Column<decimal>(type: "numeric", nullable: false),
                    AvailableStartDateTimeUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    AvailableEndDateTimeUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false),
                    Published = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ProductType = table.Column<int>(type: "integer", nullable: false),
                    DownloadActivationType = table.Column<int>(type: "integer", nullable: false),
                    GiftCardType = table.Column<int>(type: "integer", nullable: false),
                    RecurringCyclePeriod = table.Column<int>(type: "integer", nullable: false),
                    RentalPricePeriod = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttribute",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttribute", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeValue",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductAttributeMappingId = table.Column<int>(type: "integer", nullable: false),
                    AttributeValueTypeId = table.Column<int>(type: "integer", nullable: false),
                    AssociatedProductId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ColorSquaresRgb = table.Column<string>(type: "text", nullable: false),
                    ImageSquaresPictureId = table.Column<int>(type: "integer", nullable: false),
                    PriceAdjustment = table.Column<decimal>(type: "numeric", nullable: false),
                    PriceAdjustmentUsePercentage = table.Column<bool>(type: "boolean", nullable: false),
                    WeightAdjustment = table.Column<decimal>(type: "numeric", nullable: false),
                    Cost = table.Column<decimal>(type: "numeric", nullable: false),
                    CustomerEntersQty = table.Column<bool>(type: "boolean", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    IsPreSelected = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false),
                    PictureId = table.Column<int>(type: "integer", nullable: false),
                    AttributeValueType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewType",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false),
                    VisibleToAllCustomers = table.Column<bool>(type: "boolean", nullable: false),
                    IsRequired = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddressMapping",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<string>(type: "text", nullable: false),
                    AddressId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddressMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddressMapping_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerClaims",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerLogins",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_CustomerLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTokens",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_CustomerTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExternalAuthenticationRecord",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    ExternalIdentifier = table.Column<string>(type: "text", nullable: false),
                    ExternalDisplayIdentifier = table.Column<string>(type: "text", nullable: false),
                    OAuthToken = table.Column<string>(type: "text", nullable: false),
                    OAuthAccessToken = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalAuthenticationRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExternalAuthenticationRecord_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogComment",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<string>(type: "text", nullable: false),
                    CommentText = table.Column<string>(type: "text", nullable: false),
                    IsApproved = table.Column<bool>(type: "boolean", nullable: false),
                    StoreId = table.Column<int>(type: "integer", nullable: false),
                    BlogPostId = table.Column<int>(type: "integer", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogComment_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogComment_BlogPost_BlogPostId",
                        column: x => x.BlogPostId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "BlogPost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CategoryTemplateId = table.Column<int>(type: "integer", nullable: false),
                    MetaKeywords = table.Column<string>(type: "text", nullable: false),
                    MetaDescription = table.Column<string>(type: "text", nullable: false),
                    MetaTitle = table.Column<string>(type: "text", nullable: false),
                    ParentCategoryId = table.Column<int>(type: "integer", nullable: false),
                    PictureId = table.Column<int>(type: "integer", nullable: false),
                    PageSize = table.Column<int>(type: "integer", nullable: false),
                    AllowCustomersToSelectPageSize = table.Column<bool>(type: "boolean", nullable: false),
                    PageSizeOptions = table.Column<string>(type: "text", nullable: false),
                    ShowOnHomepage = table.Column<bool>(type: "boolean", nullable: false),
                    IncludeInTopMenu = table.Column<bool>(type: "boolean", nullable: false),
                    SubjectToAcl = table.Column<bool>(type: "boolean", nullable: false),
                    LimitedToStores = table.Column<bool>(type: "boolean", nullable: false),
                    Published = table.Column<bool>(type: "boolean", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PriceRangeFiltering = table.Column<bool>(type: "boolean", nullable: false),
                    PriceFrom = table.Column<decimal>(type: "numeric", nullable: false),
                    PriceTo = table.Column<decimal>(type: "numeric", nullable: false),
                    ManuallyPriceRange = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_CategoryTemplate_CategoryTemplateId",
                        column: x => x.CategoryTemplateId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "CategoryTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeCombination",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    AttributesXml = table.Column<string>(type: "text", nullable: false),
                    StockQuantity = table.Column<int>(type: "integer", nullable: false),
                    AllowOutOfStockOrders = table.Column<bool>(type: "boolean", nullable: false),
                    Sku = table.Column<string>(type: "text", nullable: false),
                    ManufacturerPartNumber = table.Column<string>(type: "text", nullable: false),
                    Gtin = table.Column<string>(type: "text", nullable: false),
                    OverriddenPrice = table.Column<decimal>(type: "numeric", nullable: true),
                    NotifyAdminForQuantityBelow = table.Column<int>(type: "integer", nullable: false),
                    PictureId = table.Column<int>(type: "integer", nullable: false),
                    MinStockQuantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeCombination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributeCombination_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeMapping",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    ProductAttributeId = table.Column<int>(type: "integer", nullable: false),
                    TextPrompt = table.Column<string>(type: "text", nullable: false),
                    IsRequired = table.Column<bool>(type: "boolean", nullable: false),
                    AttributeControlTypeId = table.Column<int>(type: "integer", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false),
                    ValidationMinLength = table.Column<int>(type: "integer", nullable: true),
                    ValidationMaxLength = table.Column<int>(type: "integer", nullable: true),
                    ValidationFileAllowedExtensions = table.Column<string>(type: "text", nullable: false),
                    ValidationFileMaximumSize = table.Column<int>(type: "integer", nullable: true),
                    DefaultValue = table.Column<string>(type: "text", nullable: false),
                    ConditionAttributeXml = table.Column<string>(type: "text", nullable: false),
                    AttributeControlType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributeMapping_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    IsFeaturedProduct = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductManufacturer",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    ManufacturerId = table.Column<int>(type: "integer", nullable: false),
                    IsFeaturedProduct = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductManufacturer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductManufacturer_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPicture",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    PictureId = table.Column<int>(type: "integer", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPicture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPicture_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductReview",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    StoreId = table.Column<int>(type: "integer", nullable: false),
                    IsApproved = table.Column<bool>(type: "boolean", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    ReviewText = table.Column<string>(type: "text", nullable: false),
                    ReplyText = table.Column<string>(type: "text", nullable: false),
                    CustomerNotifiedOfReply = table.Column<bool>(type: "boolean", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    HelpfulYesTotal = table.Column<int>(type: "integer", nullable: false),
                    HelpfulNoTotal = table.Column<int>(type: "integer", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReview", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductReview_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSpecificationAttribute",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: false),
                    AttributeTypeId = table.Column<int>(type: "integer", nullable: false),
                    SpecificationAttributeOptionId = table.Column<int>(type: "integer", nullable: false),
                    CustomValue = table.Column<string>(type: "text", nullable: false),
                    AllowFiltering = table.Column<bool>(type: "boolean", nullable: false),
                    ShowOnProductPage = table.Column<bool>(type: "boolean", nullable: false),
                    DisplayOrder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSpecificationAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSpecificationAttribute_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTag",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTag_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CustomerRoleClaims",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerRoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerRoles",
                schema: "ClassifiedAds",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_CustomerRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "ClassifiedAds",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "ClassifiedAds",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "ClassifiedAds",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_BlogPostId",
                schema: "ClassifiedAds",
                table: "BlogComment",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_CustomerId",
                schema: "ClassifiedAds",
                table: "BlogComment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryTemplateId",
                schema: "ClassifiedAds",
                table: "Category",
                column: "CategoryTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddressMapping_CustomerId",
                schema: "ClassifiedAds",
                table: "CustomerAddressMapping",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerClaims_UserId",
                schema: "ClassifiedAds",
                table: "CustomerClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLogins_UserId",
                schema: "ClassifiedAds",
                table: "CustomerLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRoleClaims_RoleId",
                schema: "ClassifiedAds",
                table: "CustomerRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerRoles_RoleId",
                schema: "ClassifiedAds",
                table: "CustomerRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalAuthenticationRecord_CustomerId",
                schema: "ClassifiedAds",
                table: "ExternalAuthenticationRecord",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeCombination_ProductId",
                schema: "ClassifiedAds",
                table: "ProductAttributeCombination",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeMapping_ProductId",
                schema: "ClassifiedAds",
                table: "ProductAttributeMapping",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_ProductId",
                schema: "ClassifiedAds",
                table: "ProductCategory",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductManufacturer_ProductId",
                schema: "ClassifiedAds",
                table: "ProductManufacturer",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPicture_ProductId",
                schema: "ClassifiedAds",
                table: "ProductPicture",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReview_ProductId",
                schema: "ClassifiedAds",
                table: "ProductReview",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSpecificationAttribute_ProductId",
                schema: "ClassifiedAds",
                table: "ProductSpecificationAttribute",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTag_ProductId",
                schema: "ClassifiedAds",
                table: "ProductTag",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "ClassifiedAds",
                table: "Role",
                column: "NormalizedName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "BlogComment",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "BlogPostTag",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "CustomerAddressMapping",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "CustomerClaims",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "CustomerLogins",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "CustomerRoleClaims",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "CustomerRoles",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "CustomerTokens",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "Download",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ExternalAuthenticationRecord",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "Manufacturer",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "Picture",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "PictureBinary",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ProductAttribute",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ProductAttributeCombination",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ProductAttributeMapping",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ProductAttributeValue",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ProductCategory",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ProductManufacturer",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ProductPicture",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ProductReview",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ProductSpecificationAttribute",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ProductTag",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "ReviewType",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "Setting",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "BlogPost",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "CategoryTemplate",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "ClassifiedAds");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "ClassifiedAds");
        }
    }
}
