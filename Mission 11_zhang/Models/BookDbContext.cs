﻿using Microsoft.EntityFrameworkCore;


namespace Mission_11_zhang.Models
{
	public class BookDbContext: DbContext
	{
		public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }


		public DbSet<Book> Books { get; set; }
	}
}
