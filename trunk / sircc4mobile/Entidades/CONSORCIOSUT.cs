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
    public partial class CONSORCIOSUT
    {
        public string IDE_TER { get; set; }
        public string ID_MIEMBROS { get; set; }
        public string ID_ESTADO { get; set; }
        public Nullable<decimal> PORC_PART { get; set; }
    
        public virtual TERCEROS TERCEROS { get; set; }
    }
    
}