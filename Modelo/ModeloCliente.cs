using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        public ModeloCliente()
        {
            ConCod = 0;
            ConCnpjCpf = "";
            ConTel = "";
        }
        public ModeloCliente(int concod, string concnpjcpf,string contel)
        {
            ConCod = concod;
            ConCnpjCpf = concnpjcpf;
            ConTel = contel;

        }

        private int con_cod;
        public int ConCod
        {
            get { return con_cod; }
            set { con_cod = value; }
        }

        private string con_cnpjcpf;
        public string ConCnpjCpf
        {
            get { return con_cnpjcpf; }
            set { con_cnpjcpf = value; }

        }

        private string con_tel;
        public string ConTel
        {
            get { return con_tel; }
            set { con_tel = value; }

        }
    }
}
