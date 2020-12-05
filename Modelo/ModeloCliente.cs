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
            ConFila = "";
        }

        public ModeloCliente(int concod, string concnpjcpf,string contel, string confila, DateTime condata)
        {
            ConCod = concod;
            ConCnpjCpf = concnpjcpf;
            ConTel = contel;
            ConData = condata;
            ConFila = confila;
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

        private string con_fila;
        public string ConFila
        {
            get { return con_fila; }
            set { con_fila = value; }

        }

        private DateTime con_data;

        public DateTime ConData
        {
            get { return con_data; }
            set { con_data = value; }
        }
    }
}
