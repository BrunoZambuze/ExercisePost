using System;
using System.Text;

namespace ExercisePost.Entities
{
    internal class Post
    {
        public DateTime Moment { get; private set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> listComment { get; set; } = new List<Comment>();

        //Construtor
        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        //Função para adicionar
        public void addComent(Comment comment)
        {
            listComment.Add(comment);
        }

        //Função para remover
        public void removeComent(Comment comment)
        {
            listComment.Remove(comment);
        }

        //Imprimir os dados
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in listComment)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
