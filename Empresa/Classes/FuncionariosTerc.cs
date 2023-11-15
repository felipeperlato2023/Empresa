using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Classes
{
    internal class FuncionariosTerc : Funcionarios
    {
        private double despadicional { get; set; }

        public FuncionariosTerc()
        {
        }

        public FuncionariosTerc(string nome, int horas, double valorhora, double despadicional) 
        {   
            nome = nome;
            horas = horas;
            valorhora = valorhora;
            despadicional = despadicional;

        }

        public override double Pagamento()
        {
            return (valorhora * horas) + (despadicional * 110/100);
            
        }
    }



}
