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
    public class ImoveisModelo
    {
        public int IdImovel { get; set; }
        public int IdCliente { get; set; }
        public string NomeImovel { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string ZonaCidade { get; set; }
        public string Cep { get; set; }
        public string TipoImovel { get; set; }
        public bool Condominio { get; set; }
        public double Metragem { get; set; }
        public int Dormitorios { get; set; }
        public int Banheiros { get; set; }
        public int Suites { get; set; }
        public int VagasGaragem { get; set; }
        public double ValorAluguelSugerido { get; set; }
        public double ValorIptu { get; set; }
        public string RequisitosInquilino { get; set; }
        public string Obs { get; set; }
    }
}
