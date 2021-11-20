using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//cria as classes, faz o instanciamento
//para associar o post com os comentarios - um para muitos
// na classe post declara lista de comentarios
// tipo lista<Comment> Comments - <Comment> é a classe declarada, o Comments o nome
// para garantir que a lista será instanciada, coloca um = new list<Comment>();

namespace PrimeiroProjeto.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        //construtor vazio
        public Post()
        {
        }
        //construtor preenchido, o argumento um para muitos (list) não entra
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        //adicionar as operações add e remove comment
        //AddComment recebe como argumento de entrada um Comment comment
        public void AddComment(Comment comment)
        {
            //operação vai na lista de comentarios (Comments) e adiciona o comentario que chegou como parametro de entrada (comment)
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
        //stringbuilder tem varias operações para montar a string em cima dele
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");

            foreach(Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }


            return sb.ToString();
        }
    }
}
