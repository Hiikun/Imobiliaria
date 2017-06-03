using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria.DAL
{
    public class Dados
    {
        public static string strConexao
        {
            get
            {
                return "server = localhost; Database = imobiliaria; Uid = root; Connect Timeout = 30"; /*Pwd = !senha_banco!*/
            }
        }
    }
}
