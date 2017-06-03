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
    public class ModeloProfissional
    {
        private int profId;
        private string profNome;
        private string profProfissao;
        private string profTel1;
        private string profTel2;
        private double profValorHora;
        private string profObs;

        public int ProfId
        {
            get
            {
                return profId;
            }

            set
            {
                profId = value;
            }
        }

        public string ProfNome
        {
            get
            {
                return profNome;
            }

            set
            {
                profNome = value;
            }
        }

        public string ProfProfissao
        {
            get
            {
                return profProfissao;
            }

            set
            {
                profProfissao = value;
            }
        }

        public string ProfTel1
        {
            get
            {
                return profTel1;
            }

            set
            {
                profTel1 = value;
            }
        }

        public string ProfTel2
        {
            get
            {
                return profTel2;
            }

            set
            {
                profTel2 = value;
            }
        }

        public double ProfValorHora
        {
            get
            {
                return profValorHora;
            }

            set
            {
                profValorHora = value;
            }
        }

        public string ProfObs
        {
            get
            {
                return profObs;
            }

            set
            {
                profObs = value;
            }
        }
    }
}