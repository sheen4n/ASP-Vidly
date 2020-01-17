namespace VidlyASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7428f06c-e330-493e-ae6f-471c36322b5d', N'guest@vidly.com', 0, N'AE4Uh5bXakKE9Kx0xVYSVnIg5Ch+1uKyFMRarTJbXfcCkP3g3ouC3/kt/q5/3+hvow==', N'7ef8980b-4c5d-4c45-a088-67c5a87b8a34', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'eee0ca4b-6076-4210-ae31-b27d6b7a61f3', N'admin@vidly.com', 0, N'AKtXdXpN2gKFfQhrwO9QUtTj273BIthm8/qw9VHtZw5+woydOqzZhEtQjVUH1kn0GQ==', N'bf26a3bb-b0d8-4bfd-97a9-526284dc2fae', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");

            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5e06daea-104a-47c1-8e9d-f1d3c14e7cb2', N'CanManageMovies')");

            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'eee0ca4b-6076-4210-ae31-b27d6b7a61f3', N'5e06daea-104a-47c1-8e9d-f1d3c14e7cb2')");
        }

        public override void Down()
        {
        }
    }
}
