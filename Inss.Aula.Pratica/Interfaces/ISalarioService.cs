using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.InssAulaPratica.Domain.Models;

namespace Lib.InssAulaPratica.Domain.Interfaces
{
    public interface ISalarioService
    {
        ServiceResposta<DescontoSalario> CalcularInss(Salario salario);
    }
}
