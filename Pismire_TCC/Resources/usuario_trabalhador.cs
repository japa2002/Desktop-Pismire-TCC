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
    
    public partial class usuario_trabalhador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario_trabalhador()
        {
            this.candidatos = new HashSet<candidatos>();
            this.curriculo = new HashSet<curriculo>();
            this.interessados_trabalhador = new HashSet<interessados_trabalhador>();
            this.recomendados_trabalhador = new HashSet<recomendados_trabalhador>();
        }
    
        public string CPF { get; set; }
        public string RG { get; set; }
        public System.DateTime dataNascimento { get; set; }
        public int FK_usuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<candidatos> candidatos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<curriculo> curriculo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<interessados_trabalhador> interessados_trabalhador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<recomendados_trabalhador> recomendados_trabalhador { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
