﻿using System.Data;

namespace Blog.Models;

public class User
{
    // [Id] INT NOT NULL IDENTITY(1, 1),
    // [Name] NVARCHAR(80) NOT NULL,
    // [Email] VARCHAR(200) NOT NULL,
    // [PasswordHash] VARCHAR(255) NOT NULL,
    // [Bio] TEXT NOT NULL,
    // [Image] VARCHAR(2000) NOT NULL,
    // [Slug] VARCHAR(80) NOT NULL,
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }
    public string PasswordHash { get; set; }    
    public string Image { get; set; }
    public string Slug { get; set; }
    
    public IList<Post> Posts { get; set; }
    public IList<Role> Roles { get; set; }
}   