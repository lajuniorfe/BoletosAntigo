using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdmBoletos.Models
{
    public class ListagemBoletosModel
    {
        public string AgenciaBeneficiario { get; set; } =  "1234";
        public string ContaBeneficiario { get; set; } = "5678";

        public string TokenAcesso { get; set; }
    }
}
