using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.InssAulaPratica.Domain.Interfaces;
using Lib.InssAulaPratica.Domain.Models;
using Lib.InssAulaPratica.Service.Services.InssService;


namespace Lib.InssAulaPratica.Service.Factory
{
    internal class InssFactory
    {
        public ServiceResposta<IInss> MakeInss(int ano)
        {
            var serviceResposta = new ServiceResposta<IInss>();
            switch (ano)
            {
                case 2011:
                    serviceResposta.Sucesso = true;
                    serviceResposta.Resposta = new Inss2011();
                    break;

                case 2012:
                    serviceResposta.Sucesso = true;
                    serviceResposta.Resposta = new Inss2012();
                break;
                default:
                    serviceResposta.Sucesso = false;
                    serviceResposta.MensagemErro = "Ano inválido";
                    break;
            }
            return serviceResposta;
        }
    }
}
