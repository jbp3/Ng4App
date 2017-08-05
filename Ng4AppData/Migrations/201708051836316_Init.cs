namespace Ng4AppData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Thoughts",
                c => new
                    {
                        ThoughtID = c.Int(nullable: false, identity: true),
                        ThoughtLiteral = c.String(),
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.ThoughtID)
                .ForeignKey("dbo.People", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Thoughts", "Person_PersonID", "dbo.People");
            DropIndex("dbo.Thoughts", new[] { "Person_PersonID" });
            DropTable("dbo.Thoughts");
            DropTable("dbo.People");
        }
    }
}
