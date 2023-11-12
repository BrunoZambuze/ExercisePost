using System;

namespace ExercisePost.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        //Construtor
        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
