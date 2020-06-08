using System;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

public class Users
{
	[Key]
	public long UserID { get; set; }

	[Column(TypeName = "nvarchar(100)")]
	public string Username { get; set; }

	[Column(TypeName = "nvarchar(100)")]
	public string Password { get; set; }

	[Column(TypeName = "nvarchar(100)")]
	public string email { get; set; }

	[Column(TypeName = "nvarchar(100)")]
	public string PhoneNumber { get; set; }

	public int Age { get; set; }
}
