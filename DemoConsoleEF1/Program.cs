using System;
using System.Linq;


namespace DemoConsoleEF1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                db.Add(new Blog { Url = "http://blogs.msdn.com/adonet"});
                db.Add(new Blog { Url = "http://gabiviana.com/adonet"});
                db.SaveChanges();

                var blogs = db.Blogs.OrderBy(blogs => blogs.BlogId).ToList();

                blogs.ForEach(b => Console.WriteLine($"Id: {b.BlogId} Url: {b.Url}"));
            }//.dispose()
        }
    }
}
