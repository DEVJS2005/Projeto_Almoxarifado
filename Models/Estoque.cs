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
    
    public partial class Estoque
    {
        public int idEstoque { get; set; }
        public int idProduto { get; set; }
        public int quantidadeEstoque { get; set; }
    
        public virtual Produto Produto { get; set; }
    }
}