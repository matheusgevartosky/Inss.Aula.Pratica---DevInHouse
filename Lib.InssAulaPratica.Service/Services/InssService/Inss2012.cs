using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.InssAulaPratica.Domain.Interfaces;
using Lib.InssAulaPratica.Domain.Models;

namespace Lib.InssAulaPratica.Service.Services.InssService
{
    public class Inss2012 : IInss
    {
        public DescontoSalario calculaDescontoSalario(decimal salario)
        {
            var descontoSalario = new DescontoSalario();
            if (salario < 1000m)
            {
                descontoSalario.ValorDesconto = salario * (7 / 100);
                descontoSalario.SalarioComDesconto = salario - descontoSalario.ValorDesconto;
            }
            else if (salario <= 1500m)
            {

                descontoSalario.ValorDesconto = salario * (8 / 100);
                descontoSalario.SalarioComDesconto = salario- descontoSalario.ValorDesconto;
            }
            else
            {

                descontoSalario.ValorDesconto = salario - 500;
                descontoSalario.SalarioComDesconto = salario - descontoSalario.ValorDesconto;
            }

            return descontoSalario;
        }
    }
}
