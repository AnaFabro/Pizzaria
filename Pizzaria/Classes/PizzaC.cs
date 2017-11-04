using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Classes
{
   public class PizzaC
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        float preco;

        public float Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        String descricao;

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}
