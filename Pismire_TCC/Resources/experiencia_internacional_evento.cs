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
    
    public partial class experiencia_internacional_evento
    {
        public int idInternacionalEvento { get; set; }
        public string cargoInternacionalEvento { get; set; }
        public string paisCargoInternacionalEvento { get; set; }
        public int FK_evento { get; set; }
    
        public virtual evento evento { get; set; }
    }
}
