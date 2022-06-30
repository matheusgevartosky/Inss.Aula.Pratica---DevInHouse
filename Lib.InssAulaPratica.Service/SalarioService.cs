using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.InssAulaPratica.Domain.Interfaces;
using Lib.InssAulaPratica.Domain.Models;
using Lib.InssAulaPratica.Service.Factory;

namespace Lib.InssAulaPratica.Service
{
    public class SalarioService : ISalarioService
    {
        public ServiceResposta<DescontoSalario> CalcularInss(Salario salario)
        {
            var serviceRespostaDescontoSalario = new ServiceResposta<DescontoSalario>();
            var inssFactory = new InssFactory();
            int ano = salario.Data.Year;
            ServiceResposta<IInss> respostaFactory =  inssFactory.MakeInss(ano);
            if (respostaFactory.Sucesso)
            {
                IInss inss = respostaFactory.Resposta;
                serviceRespostaDescontoSalario.Sucesso = true;
                serviceRespostaDescontoSalario.Resposta = inss.calculaDescontoSalario(salario.Valor);
            }
            else
            {
                serviceRespostaDescontoSalario.Sucesso = respostaFactory.Sucesso;
                serviceRespostaDescontoSalario.MensagemErro = respostaFactory.MensagemErro;
            }

            return serviceRespostaDescontoSalario;

        }
    }
}
