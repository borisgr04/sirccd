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
    public partial class MIN_MOD_CONTRATO
    {
        public string NUM_SOL_ADI { get; set; }
        public string CAMPO { get; set; }
        public string VALOR_NUEVO { get; set; }
        public string VALOR_ANTERIOR { get; set; }
        public string USBD { get; set; }
        public string USAP { get; set; }
        public Nullable<System.DateTime> FECMOD { get; set; }
        public Nullable<System.DateTime> FECREG { get; set; }
    
        public virtual SOL_ADICIONES SOL_ADICIONES { get; set; }
    }
    
}
