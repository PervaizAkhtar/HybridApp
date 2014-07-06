namespace Apis.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Apis.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Apis.Models.CustomerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Apis.Models.CustomerContext context)
        {
            context.Customers.AddOrUpdate(new Customers[] { 
            
                new Customers(){
                    CustomerID="ALFKI",	
                    CompanyName="Alfreds",	
                    ContactName	="Futterkiste",
                    ContactTitle="Maria Anders",	
                    Address="Sales Representative",	
                    City="Obere Str.  57	Berlin",	
                    Region=null,	
                    PostalCode="12209",	
                    Country	="Germany",
                    Phone="030-0074321",	
                    Fax="030-0076545"
                },
                 new Customers(){
                    CustomerID="ANATR",	
                    CompanyName="Great Lakes Food Market",	
                    ContactName	="Howard Snyder",
                    ContactTitle="Marketing Manager",	
                    Address="2732 Baker Blvd",	
                    City="Eugene",	
                    Region=null,	
                    PostalCode="05021",	
                    Country	="Mexico",
                    Phone="(5) 555-4729",	
                    Fax="(5) 555-3745"
                },
                new Customers(){
                    CustomerID="AROUT",	
                    CompanyName="Around the Horn",	
                    ContactName	="Thomas Hardy",
                    ContactTitle="Sales Representative",	
                    Address="120 Hanover Sq.",	
                    City="London",	
                    Region=null,	
                    PostalCode="WA1 1DP",	
                    Country	="UK",
                    Phone="(171) 555-7788",	
                    Fax="(171) 555-6750"
                }

            });
        }
    }
}
