//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Almoxarifado.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Saida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Saida()
        {
            this.SaidaProduto = new HashSet<SaidaProduto>();
        }
    
        public int idSaida { get; set; }
        public System.DateTime dataSaida { get; set; }
        public string observacaoSaida { get; set; }
        public int idColaborador { get; set; }
    
        public virtual Colaborador Colaborador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaidaProduto> SaidaProduto { get; set; }
    }
}