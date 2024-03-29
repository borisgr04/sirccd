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
    public partial class PCONTRATOS
    {
        public PCONTRATOS()
        {
            this.CDP_PCONTRATOS = new HashSet<CDP_PCONTRATOS>();
            this.CONTRATOS = new HashSet<CONTRATOS>();
            this.GPROCESOS = new HashSet<GPROCESOS>();
            this.MOD_CONTRATOS = new HashSet<MOD_CONTRATOS>();
            this.PAGOS_PARCIALES = new HashSet<PAGOS_PARCIALES>();
            this.PCONMUN = new HashSet<PCONMUN>();
            this.PPOLIZAS = new HashSet<PPOLIZAS>();
            this.PCRONOGRAMAS = new HashSet<PCRONOGRAMAS>();
            this.POBLIGACIONES = new HashSet<POBLIGACIONES>();
            this.PPROPONENTES = new HashSet<PPROPONENTES>();
            this.RUBROS_PCONTRATOS = new HashSet<RUBROS_PCONTRATOS>();
        }
    
        public string PRO_SEL_NRO { get; set; }
        public string IDE_CON { get; set; }
        public string OBJ_CON { get; set; }
        public string PRO_CON { get; set; }
        public int PLA_EJE_CON { get; set; }
        public string DEP_CON { get; set; }
        public string DEP_PCON { get; set; }
        public short VIG_CON { get; set; }
        public string TIP_CON { get; set; }
        public string STIP_CON { get; set; }
        public decimal VAL_CON { get; set; }
        public decimal VAL_APO_GOB { get; set; }
        public string COD_SEC { get; set; }
        public string TIP_FOR { get; set; }
        public string OTR_CNS { get; set; }
        public string NRO_PLA_CON { get; set; }
        public string IDE_REP { get; set; }
        public string URG_MAN { get; set; }
        public string EST_CONV { get; set; }
        public string APL_GAC { get; set; }
        public string EST_CON { get; set; }
        public string COD_CON { get; set; }
        public Nullable<int> NRO_CON { get; set; }
        public string USUARIO { get; set; }
        public Nullable<System.DateTime> FEC_REG { get; set; }
        public string USBD { get; set; }
        public Nullable<System.DateTime> FEC_MOD { get; set; }
        public string LUG_EJE { get; set; }
        public string USUENCARGADO { get; set; }
        public Nullable<System.DateTime> FECHAASIG { get; set; }
        public Nullable<System.DateTime> FECHARECIBIDO { get; set; }
        public string NUM_SOL { get; set; }
        public string COD_TPRO { get; set; }
        public string ESTADO { get; set; }
        public string TIPO_PLAZO { get; set; }
        public Nullable<int> NUMGRUPOS { get; set; }
    
        public virtual AN_PCONTRATO AN_PCONTRATO { get; set; }
        public virtual ICollection<CDP_PCONTRATOS> CDP_PCONTRATOS { get; set; }
        public virtual ICollection<CONTRATOS> CONTRATOS { get; set; }
        public virtual ICollection<GPROCESOS> GPROCESOS { get; set; }
        public virtual ICollection<MOD_CONTRATOS> MOD_CONTRATOS { get; set; }
        public virtual ICollection<PAGOS_PARCIALES> PAGOS_PARCIALES { get; set; }
        public virtual ICollection<PCONMUN> PCONMUN { get; set; }
        public virtual ICollection<PPOLIZAS> PPOLIZAS { get; set; }
        public virtual TIPOSPROC TIPOSPROC { get; set; }
        public virtual ICollection<PCRONOGRAMAS> PCRONOGRAMAS { get; set; }
        public virtual ICollection<POBLIGACIONES> POBLIGACIONES { get; set; }
        public virtual ICollection<PPROPONENTES> PPROPONENTES { get; set; }
        public virtual ICollection<RUBROS_PCONTRATOS> RUBROS_PCONTRATOS { get; set; }
        public virtual PESTADOS PESTADOS { get; set; }
        public virtual DEPENDENCIA DEPENDENCIA { get; set; }
        public virtual DEPENDENCIA DEPENDENCIA1 { get; set; }
        public virtual TERCEROS TERCEROS { get; set; }
    }
    
}
