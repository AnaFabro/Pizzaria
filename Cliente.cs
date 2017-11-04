using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Classes
{
    class Cliente
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
        int telefone;

        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        String rua;

        public String Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        String cidade;

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        String uf;

        public String Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        String complemento;

        public String Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        String bairro;

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


    }
}