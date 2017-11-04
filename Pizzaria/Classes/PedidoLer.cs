using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Classes
{
    public class PedidoLer:Pedido
    {
        String descricao;

        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public string Cli_nome
        {
            get
            {
                return cli_nome;
            }

            set
            {
                cli_nome = value;
            }
        }

        public string Cli_tel
        {
            get
            {
                return cli_tel;
            }

            set
            {
                cli_tel = value;
            }
        }

        public float Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        string cli_nome;
        string cli_tel;
        float total;
        string status;
    }
}
