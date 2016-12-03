namespace Armitage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpostcatrel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PostTags", "Post_PostId", "dbo.Posts");
            DropForeignKey("dbo.PostTags", "Tag_TagId", "dbo.Tags");
            DropIndex("dbo.PostTags", new[] { "Post_PostId" });
            DropIndex("dbo.PostTags", new[] { "Tag_TagId" });
            AddColumn("dbo.Posts", "Category_CategoryId", c => c.Int());
            AddColumn("dbo.Posts", "Tag_TagId", c => c.Int());
            CreateIndex("dbo.Posts", "Category_CategoryId");
            CreateIndex("dbo.Posts", "Tag_TagId");
            AddForeignKey("dbo.Posts", "Category_CategoryId", "dbo.Categories", "CategoryId");
            AddForeignKey("dbo.Posts", "Tag_TagId", "dbo.Tags", "TagId");
            DropTable("dbo.PostTags");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        Post_PostId = c.Int(nullable: false),
                        Tag_TagId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Post_PostId, t.Tag_TagId });
            
            DropForeignKey("dbo.Posts", "Tag_TagId", "dbo.Tags");
            DropForeignKey("dbo.Posts", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "Tag_TagId" });
            DropIndex("dbo.Posts", new[] { "Category_CategoryId" });
            DropColumn("dbo.Posts", "Tag_TagId");
            DropColumn("dbo.Posts", "Category_CategoryId");
            CreateIndex("dbo.PostTags", "Tag_TagId");
            CreateIndex("dbo.PostTags", "Post_PostId");
            AddForeignKey("dbo.PostTags", "Tag_TagId", "dbo.Tags", "TagId", cascadeDelete: true);
            AddForeignKey("dbo.PostTags", "Post_PostId", "dbo.Posts", "PostId", cascadeDelete: true);
        }
    }
}
