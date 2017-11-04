using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Classes
{
    class Bebidac
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
        string litros;

        public string Litros
        {
            get { return litros; }
            set { litros = value; }
        }

        float preco;

        public float Preco
        {
            get { return preco; }
            set { preco = value; }
        }

    }
}
