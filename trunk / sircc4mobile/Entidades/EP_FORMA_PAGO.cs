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
    public partial class EP_FORMA_PAGO
    {
        public decimal ID { get; set; }
        public Nullable<decimal> ID_EP { get; set; }
        public Nullable<decimal> ORD_FPAG { get; set; }
        public string TIP_FPAG { get; set; }
        public Nullable<decimal> VAL_FPAG { get; set; }
        public Nullable<decimal> POR_FPAG { get; set; }
        public string CON_FPAG { get; set; }
        public string PGEN_FPAG { get; set; }
        public Nullable<System.DateTime> FEC_REG { get; set; }
        public string USAP_REG { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
        public string USAP_MOD { get; set; }
    
        public virtual TIPO_PAGO TIPO_PAGO { get; set; }
        public virtual ESTPREV ESTPREV { get; set; }
    }
    
}
