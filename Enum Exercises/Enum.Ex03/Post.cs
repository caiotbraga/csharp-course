using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Ex03.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comments> CommentList { get; set; } = new List<Comments>();

        public Post() { 
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComments(Comments comment)
        {
            CommentList.Add(comment);
        }

        public void RemoveComments(Comments comment)
        {
            CommentList.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach(Comments c in CommentList)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
