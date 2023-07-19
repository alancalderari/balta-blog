namespace Blog.Models;

public class Category
{
    // [Id] INT NOT NULL IDENTITY(1, 1),
    // [Name] VARCHAR(80) NOT NULL,
    // [Slug] VARCHAR(80) NOT NULL,
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    
    public IList<Post> Posts { get; set; }

}