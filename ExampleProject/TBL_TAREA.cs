//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExampleProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_TAREA
    {
        public int ID_TAREA { get; set; }
        public int ID_PROJECT { get; set; }
        public string NAME { get; set; }
        public Nullable<System.DateTime> STARTDATE { get; set; }
        public Nullable<System.DateTime> ENDDATE { get; set; }
        public Nullable<System.DateTime> PLANSTARTDATE { get; set; }
        public Nullable<System.DateTime> PLANENDDATE { get; set; }
        public int DEPENDENCIA { get; set; }
        public int COMPLETADO { get; set; }
        public double DURACION { get; set; }
        public string DURACIONTYPE { get; set; }
        public double TRABAJO { get; set; }
        public string TRABAJOTYPE { get; set; }
        public int ACTIVO { get; set; }
    }
}
