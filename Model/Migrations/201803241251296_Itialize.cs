namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Itialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CFs",
                c => new
                    {
                        course = c.Int(name: "course#", nullable: false),
                        field = c.Int(name: "field#", nullable: false),
                        Kind = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.course, t.field })
                .ForeignKey("dbo.Course", t => t.course, cascadeDelete: true)
                .ForeignKey("dbo.Field", t => t.field, cascadeDelete: true)
                .Index(t => t.course)
                .Index(t => t.field);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        course = c.Int(name: "course#", nullable: false),
                        courseName = c.String(name: "course Name", nullable: false, maxLength: 40),
                        unit = c.Int(nullable: false),
                        type = c.Int(name: "type#", nullable: false),
                    })
                .PrimaryKey(t => t.course)
                .ForeignKey("dbo.Type", t => t.type, cascadeDelete: true)
                .Index(t => t.type);
            
            CreateTable(
                "dbo.G",
                c => new
                    {
                        std = c.Int(name: "std#", nullable: false),
                        course = c.Int(name: "course#", nullable: false),
                        term = c.Int(name: "term#", nullable: false),
                        Grade = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.std, t.course, t.term })
                .ForeignKey("dbo.Course", t => t.course, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.std, cascadeDelete: true)
                .Index(t => t.std)
                .Index(t => t.course);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        student = c.Int(name: "student#", nullable: false),
                        studentname = c.String(name: "student name", nullable: false, maxLength: 30),
                        startyear = c.Int(name: "start year", nullable: false),
                        field = c.Int(name: "field#", nullable: false),
                    })
                .PrimaryKey(t => t.student)
                .ForeignKey("dbo.Field", t => t.field, cascadeDelete: true)
                .Index(t => t.field);
            
            CreateTable(
                "dbo.Field",
                c => new
                    {
                        Field = c.Int(name: "Field#", nullable: false),
                        fieldName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Field);
            
            CreateTable(
                "dbo.Tutions",
                c => new
                    {
                        field = c.Int(name: "field#", nullable: false),
                        startyear = c.Int(name: "start year", nullable: false),
                        constution = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.field, t.startyear })
                .ForeignKey("dbo.Field", t => t.field, cascadeDelete: true)
                .Index(t => t.field);
            
            CreateTable(
                "dbo.PCs",
                c => new
                    {
                        prof = c.Int(name: "prof#", nullable: false),
                        course = c.Int(name: "course#", nullable: false),
                        term = c.Int(name: "term#", nullable: false),
                    })
                .PrimaryKey(t => new { t.prof, t.course, t.term })
                .ForeignKey("dbo.Course", t => t.course, cascadeDelete: true)
                .ForeignKey("dbo.Profs", t => t.prof, cascadeDelete: true)
                .Index(t => t.prof)
                .Index(t => t.course);
            
            CreateTable(
                "dbo.Profs",
                c => new
                    {
                        prof = c.Int(name: "prof#", nullable: false),
                        profName = c.String(name: "prof Name", nullable: false, maxLength: 30),
                        degree = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.prof);
            
            CreateTable(
                "dbo.Pres",
                c => new
                    {
                        crs = c.Int(name: "crs#", nullable: false),
                        pre = c.Int(name: "pre#", nullable: false),
                    })
                .PrimaryKey(t => new { t.crs, t.pre })
                .ForeignKey("dbo.Course", t => t.crs, cascadeDelete: true)
                .Index(t => t.crs);
            
            CreateTable(
                "dbo.Type",
                c => new
                    {
                        type = c.Int(name: "type#", nullable: false),
                        typeName = c.String(nullable: false, maxLength: 30),
                        fee = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.type);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Course", "type#", "dbo.Type");
            DropForeignKey("dbo.Pres", "crs#", "dbo.Course");
            DropForeignKey("dbo.PCs", "prof#", "dbo.Profs");
            DropForeignKey("dbo.PCs", "course#", "dbo.Course");
            DropForeignKey("dbo.G", "std#", "dbo.Student");
            DropForeignKey("dbo.Tutions", "field#", "dbo.Field");
            DropForeignKey("dbo.Student", "field#", "dbo.Field");
            DropForeignKey("dbo.CFs", "field#", "dbo.Field");
            DropForeignKey("dbo.G", "course#", "dbo.Course");
            DropForeignKey("dbo.CFs", "course#", "dbo.Course");
            DropIndex("dbo.Pres", new[] { "crs#" });
            DropIndex("dbo.PCs", new[] { "course#" });
            DropIndex("dbo.PCs", new[] { "prof#" });
            DropIndex("dbo.Tutions", new[] { "field#" });
            DropIndex("dbo.Student", new[] { "field#" });
            DropIndex("dbo.G", new[] { "course#" });
            DropIndex("dbo.G", new[] { "std#" });
            DropIndex("dbo.Course", new[] { "type#" });
            DropIndex("dbo.CFs", new[] { "field#" });
            DropIndex("dbo.CFs", new[] { "course#" });
            DropTable("dbo.Type");
            DropTable("dbo.Pres");
            DropTable("dbo.Profs");
            DropTable("dbo.PCs");
            DropTable("dbo.Tutions");
            DropTable("dbo.Field");
            DropTable("dbo.Student");
            DropTable("dbo.G");
            DropTable("dbo.Course");
            DropTable("dbo.CFs");
        }
    }
}
