namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4cc3eca6-20f9-4a48-98cd-11ea8c95b27e', N'admin@vidly.com', 0, N'AJZpJ6MHixQ0PrVWk/QQcyu5cil8KemCV3apov0/r42yugIDoO0hPtBW8qJKMsioQA==', N'de78783a-88b1-4c21-904b-ffa3bb78d420', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e6e686cc-b98c-4574-b80a-a14bbabac6f3', N'guest@vidly.com', 0, N'AJUv6V2gmEPnP4X4Vn0AOd2LWYE15alKxfWgkflIHi652Igmk+lOsaKc+QqflNGApA==', N'd3a8f2ce-57a5-43c2-a5d8-fa6f01e64251', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8e586810-ed83-420a-9fa4-2ce1cb3947b7', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4cc3eca6-20f9-4a48-98cd-11ea8c95b27e', N'8e586810-ed83-420a-9fa4-2ce1cb3947b7')

            ");

        }
        
        public override void Down()
        {
        }
    }
}
