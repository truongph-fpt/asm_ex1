using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Summary description for MyDbContext
/// </summary>
[ServiceContract]
public class MyDbContext : DbContext
{
    public MyDbContext() : base("MyConnectionString")
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DbSet<Student> Students { get; set; }
}