﻿namespace HospitalScheduling.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAddressToHospital : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hospitals", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hospitals", "Address");
        }
    }
}
