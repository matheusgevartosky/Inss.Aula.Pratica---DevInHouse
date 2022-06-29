using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.InssAulaPratica.Domain.Interfaces;
using Lib.InssAulaPratica.Service.Services.InssService;


namespace Lib.InssAulaPratica.Service.Factory
{
    internal class InssFactory
    {
        public IInss MakeInss(int ano)
        {
            switch (ano)
            {
                case 2011:
                    return new Inss2011();
                    break;

                case 2012:
                    return new Inss2012();
                break;
                default:
                    return null;
            }
        }
    }
}
