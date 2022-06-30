using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.InssAulaPratica.Domain.Models
{
    public class ServiceResposta<TEntity>
    {
        public TEntity? Resposta { get; set; }
        public bool Sucesso { get; set; }
        public string MensagemErro { get; set; }
    }
}
