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
    public class ServicoImovelModelo
    {
        public int SerId{ get; set; }
        public int SerProfissionalId { get; set; }
        public int SerImovelId { get; set; }
        public String SerData { get; set; }
        public double SerValor { get; set; }
        public String SerObs { get; set; }
    }
}
