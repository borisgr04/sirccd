//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Entidades
{
    public partial class POLIZAS
    {
        public POLIZAS()
        {
            this.POLIZAS_CONTRATO = new HashSet<POLIZAS_CONTRATO>();
            this.POLIZAS_ADICIONES = new HashSet<POLIZAS_ADICIONES>();
            this.EP_POLIZAS = new HashSet<EP_POLIZAS>();
        }
    
        public int COD_POL { get; set; }
        public string NOM_POL { get; set; }
        public string EST_POL { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<POLIZAS_CONTRATO> POLIZAS_CONTRATO { get; set; }
        public virtual ICollection<POLIZAS_ADICIONES> POLIZAS_ADICIONES { get; set; }
        public virtual ICollection<EP_POLIZAS> EP_POLIZAS { get; set; }
    }
    
}