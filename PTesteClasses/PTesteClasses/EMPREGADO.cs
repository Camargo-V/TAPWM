using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTesteClasses
{
    internal class EMPREGADO
    {
        private int matrícula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        
        public int Matrícula
        {
            get { return matrícula; }
            set { matrícula = value; }
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set {  nomeEmpregado = value; }
        }
    }
}
