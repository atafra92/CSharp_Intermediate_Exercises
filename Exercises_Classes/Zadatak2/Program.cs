using System;

namespace Zadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post()
            {
                Title = "Working with Entity Framework Core in ASP.NET Core WebApi",
                Description = "Implementation details for a EF Core and database schema in ASP.NET Core WebApi project"
            };

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();

            post.DownVote();         
            post.DownVote();
            post.DownVote();


            Console.WriteLine($"Current vote value is: { post.CurrentVoteValue }");
            Console.WriteLine($"{ post.Title } has a { post.UpVote() } upvotes and a { post.DownVote() } downvotes.");

            Console.ReadLine();
        }
    }
}
