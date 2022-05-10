namespace Blog.Web.Models;

public class Blog
{
    public string Name { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public string ImageSrc { get; set; }
}