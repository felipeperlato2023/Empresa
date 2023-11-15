using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Classes
{
    internal class Funcionarios
    {
        private string nome { get; set; }
        protected   int horas { get; set; }
        protected double valorhora { get; set; }

        public Funcionarios()
        {
        }

        public Funcionarios(string nome, int horas, double valorhora)
        {
            this.nome = nome;
            this.horas = horas;
            this.valorhora = valorhora;
        }
        
        public virtual double Pagamento ()
        {
            
            return valorhora * horas; 
        }
    }
}
