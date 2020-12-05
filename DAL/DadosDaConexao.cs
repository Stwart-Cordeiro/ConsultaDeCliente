namespace DAL
{
    public class DadosDaConexao
    {

        #region Banco Casa Testes
        //public static string servidor = "192.168.1.3";
        //public static string banco = "Pesquisa";
        //public static string usuario = "sa";
        //public static string senha = "Kakashi13";
        #endregion

        #region Banco Carlos
        //public static string servidor = "172.16.22.25";
        //public static string banco = "Estudo";
        //public static string usuario = "ramos";
        //public static string porta = "1621";
        //public static string senha = "p!ant3c10";
        #endregion

        #region Banco Plantec Produção
        public static string servidor = "172.16.27.31";
        public static string banco = "Pesquisa";
        public static string usuario = "sa";
        public static string senha = "C@pella10";
        #endregion

        public static string StringDeConexao
        {
            get
            {
                return "Data Source=" + servidor + ";Initial Catalog=" + banco + ";Persist Security Info=True;User ID=" + usuario + ";Password=" + senha;

                //return "Data Source=" + servidor + "," + porta + "," + ";Initial Catalog=" + banco + ";Persist Security Info=True;User ID=" + usuario + ";Password=" + senha;//                
            }
        }
    }
}
