//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pismire_TCC.Resources
{
    using System;
    using System.Collections.Generic;
    
    public partial class experiencia_profissional_trabalhador
    {
        public int idExperienciaTrabalhador { get; set; }
        public string nomeEmpresaExperienciaTrabalhador { get; set; }
        public string cargoExperienciaTrabalhador { get; set; }
        public System.DateTime dataEntradaExperienciaTrabalhador { get; set; }
        public System.DateTime dataSaidaExperienciaTrabalhador { get; set; }
        public int FK_curriculo { get; set; }
    
        public virtual curriculo curriculo { get; set; }
    }
}
