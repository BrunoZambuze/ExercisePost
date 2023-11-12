using System;
using ExercisePost.Entities;
namespace ExercisePosta
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment1 = new Comment("Have a nice trip!");
            Comment comment2 = new Comment("Wow that's awesome!");
            Post post1 = new Post(
                    DateTime.Now,
                    "Traveling to New Zeeland",
                    "I'm going to visit wonderful country",
                    12);
            post1.addComent(comment1);
            post1.addComent(comment2);

            Comment comment3 = new Comment("Good night");
            Comment comment4 = new Comment("May the Force be whith you");
            Post post2 = new Post(
                DateTime.Now,
                "Good Night guys",
                "See you tomorrow",
                5);
            post2.addComent(comment3);
            post2.addComent(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}