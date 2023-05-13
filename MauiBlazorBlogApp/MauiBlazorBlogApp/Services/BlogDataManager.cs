namespace MauiBlazorBlogApp.Services;

public static class BlogDataManager
{
    private readonly static string url =
        "https://devblogs.microsoft.com/dotnet/category/maui/feed/";

    public static List<BlogPost> BlogPosts = new List<BlogPost>();

    /// <summary>
    /// Reads posts from the .NET MAUI Blog into the BlogPosts list
    /// </summary>
    /// <returns></returns>
    public static void GetBlogPosts()
    {
        var posts = new List<BlogPost>();
        
        using var reader = XmlReader.Create(url);
    
        var feed = SyndicationFeed.Load(reader);
        
        foreach (var item in feed.Items )
        {
            var post = new BlogPost();

            // Publish Date
            post.PublishDate = item.PublishDate.DateTime;
            
            // Author. Use ElementExtensions to read the dc:creator tag
            var creators = 
                item.ElementExtensions.ReadElementExtensions<string>
                ("creator", "http://purl.org/dc/elements/1.1/");
            if (creators != null && creators.Count > 0)
            {
                post.Author = creators.FirstOrDefault<string>();
            }
            
            // Title
            post.Title = item.Title.Text;
            
            // Description
            post.Description = item.Summary.Text;
            
            // Content. Use ElementExtensions to read encoded content
            var contents = 
                item.ElementExtensions.ReadElementExtensions<string>
                ("encoded", "http://purl.org/rss/1.0/modules/content/");
            if (contents != null && contents.Count > 0)
            {
                post.Content = $"<![CDATA[<html><body style='font-family:tahoma;'>{contents.FirstOrDefault<string>()}</body></html>]]>"; 
            }

            // Done. Add to list
            posts.Add(post);
        }

        // Refresh the list
        BlogPosts.Clear();
        BlogPosts.AddRange(posts);
    }
}
