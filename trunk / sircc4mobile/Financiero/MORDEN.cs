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

namespace Financiero
{
    public partial class MORDEN
    {
        public decimal VIGENCIA { get; set; }
        public decimal NUM_ORDEN { get; set; }
        public string OBJ_ORDEN { get; set; }
        public decimal COD_ORDEN { get; set; }
        public decimal VIG_COMPROMISO { get; set; }
        public decimal NUM_COMPROMISO { get; set; }
        public string NRO_FACTURA { get; set; }
        public Nullable<System.DateTime> FEC_FACTURA { get; set; }
        public Nullable<System.DateTime> FEC_VENC_FACT { get; set; }
        public Nullable<decimal> VAL_TOTAL { get; set; }
        public Nullable<decimal> VAL_NETO { get; set; }
        public Nullable<decimal> VAL_PAGADO { get; set; }
        public string ESTADO_ORDEN { get; set; }
        public System.DateTime FEC_RADICACION { get; set; }
        public Nullable<System.DateTime> FEC_PENDIENTE { get; set; }
        public Nullable<System.DateTime> FEC_APROBACION { get; set; }
        public Nullable<System.DateTime> FEC_CAUSACION { get; set; }
        public Nullable<System.DateTime> FEC_PROGPAGO { get; set; }
        public Nullable<decimal> NUM_EGRESO { get; set; }
        public string CLS_EGRESO { get; set; }
        public Nullable<System.DateTime> FEC_EGRESO { get; set; }
        public Nullable<decimal> OP_CONTRIBUCION { get; set; }
        public string NIT { get; set; }
        public string ANTICIPO { get; set; }
        public string AMORTIZA { get; set; }
        public string FIDUCIA { get; set; }
        public string MULTIPLES_PAGO { get; set; }
        public decimal VAL_AMORTIZADO { get; set; }
        public string COD_CENTRO { get; set; }
        public string COD_REGION { get; set; }
        public string COD_DEPTO { get; set; }
        public string COD_MUNIC { get; set; }
        public decimal VALOR_CAMBIO { get; set; }
    
        public virtual MCOMPROMISO MCOMPROMISO { get; set; }
    }
    
}
