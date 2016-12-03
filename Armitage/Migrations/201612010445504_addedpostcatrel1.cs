namespace Armitage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpostcatrel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Posts", "Tag_TagId", "dbo.Tags");
            DropIndex("dbo.Posts", new[] { "Tag_TagId" });
            DropColumn("dbo.Posts", "Tag_TagId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "Tag_TagId", c => c.Int());
            CreateIndex("dbo.Posts", "Tag_TagId");
            AddForeignKey("dbo.Posts", "Tag_TagId", "dbo.Tags", "TagId");
        }
    }
}
