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
    
    public partial class experiencia_internacional_trabalhador
    {
        public int idInternacionalTrabalhador { get; set; }
        public string nomeEmpresaInternacionalTrabalhador { get; set; }
        public string cargoInternacionalTrabalhador { get; set; }
        public System.DateTime dataEntradaInternacionalTrabalhador { get; set; }
        public System.DateTime dataSaidaInternacionalTrabalhador { get; set; }
        public string paisInternacionalTrabalhador { get; set; }
        public int FK_curriculo { get; set; }
    
        public virtual curriculo curriculo { get; set; }
    }
}
