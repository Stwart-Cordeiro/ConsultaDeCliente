using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static string servidor = "172.16.22.25";
        //public static string porta = "5432";
        public static string banco = "Estudo";
        public static string usuario = "ramos";
        public static string senha = "";

        public static string StringDeConexao
        {
            get
            {
                return "Data Source=" + servidor + ";Initial Catalog=" + banco + ";Persist Security Info=True;User ID=" + usuario + ";Password=" + senha;

                //return "Server ="+ servidor +"; Port ="+ porta +"; Database ="+ banco +"; User Id ="+ usuario +";Password ="+ senha;
            }
        }
    }
}
