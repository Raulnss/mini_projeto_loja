using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_do_Andre
{
    internal class Conn
    {
        static private string servidor = "localhost";
        static private string bancoDados = "loja_andre";
        static private int porta = 3306;
        static private string usuario = "root";
        static private string senha = "";
        static public string strConn = $"server={servidor}; port={porta}; User Id={usuario}; database={bancoDados}; password={senha}";
    }
}