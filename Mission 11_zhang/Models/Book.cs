﻿using System.ComponentModel.DataAnnotations;

namespace Mission_11_zhang.Models
{
	public class Book
	{
		[Required]
		public int BookID { get; set; }

		[Required]
		public string Title { get; set; } = string.Empty;

		public string? Author { get; set; }
		public string? Publisher { get; set; }
		public string? ISBN { get; set; }
		public string? Classification { get; set; }
		public string? Category { get; set; }
		public int? PageCount { get; set; }
		public float? Price { get; set; }
	}
}
