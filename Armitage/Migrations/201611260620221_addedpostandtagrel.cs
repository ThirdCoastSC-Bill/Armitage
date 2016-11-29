namespace Armitage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpostandtagrel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Body = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        PublishedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostId);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        Post_PostId = c.Int(nullable: false),
                        Tag_TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Post_PostId, t.Tag_TagId })
                .ForeignKey("dbo.Posts", t => t.Post_PostId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.Tag_TagId, cascadeDelete: true)
                .Index(t => t.Post_PostId)
                .Index(t => t.Tag_TagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostTags", "Tag_TagId", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "Post_PostId", "dbo.Posts");
            DropIndex("dbo.PostTags", new[] { "Tag_TagId" });
            DropIndex("dbo.PostTags", new[] { "Post_PostId" });
            DropTable("dbo.PostTags");
            DropTable("dbo.Posts");
        }
    }
}
