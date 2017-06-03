/*
 *  Feito Por:
 *      Lucas Hideo Hirata 166210-4
 *      Paulino Junior 166219-8 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria.Modelos
{
    public class ClientesModelo
    {
        public int CliId { get; set; }
        public string CliNome {get; set; }
        public string CliCPF { get; set; }
        public string CliRG { get; set; }
        public string CliEndereco { get; set; }
        public string CliCEP { get; set; }
        public string CliTelefone1 { get; set; }
        public string CliTelefone2 { get; set; }
        public string CliEmail { get; set; }
        public string CliDataNascimento { get; set; }

    }
}
