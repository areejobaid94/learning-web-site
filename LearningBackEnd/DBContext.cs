using System;
using Microsoft.EntityFrameworkCore;

public class DBContext : DbContext
{
	public DBContext(DbContextOptions<BloggingContext> options) : base(options)
	{ 
	}
	public DbSet<Users> Users { get; set; }
}
