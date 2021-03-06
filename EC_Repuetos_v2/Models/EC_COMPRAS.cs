//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC_Repuetos_v2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class EC_COMPRAS
    {
        public int EC_COMPRAS_ID { get; set; }
        [DisplayName("Usuario")]
        public int EC_COMPRAS_USUARIOS { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor, ingrese la fecha"), DisplayName("Fecha"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime EC_COMPRAS_FECHA { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese la cantidad de productos"), DisplayName("Cantidad"), StringLength(2, ErrorMessage = "Cantidad Excedida"), RegularExpression("([1-9][0-9]*)", ErrorMessage = "Formato Inválido (Ingrese números.)")]
        public int EC_COMPRAS_CANTIDAD { get; set; }

        [DisplayName("Productos")]
        public int EC_COMPRAS_PRODUCTOS { get; set; }

        [DisplayName("Impuesto")]
        public double EC_COMPRAS_IMPUESTO { get; set; }

        [DisplayName("Subtotal")]
        public Nullable<double> EC_COMPRAS_SUBTOTAL { get; set; }

        [DisplayName("Total")]
        public int EC_COMPRAS_TOTAL { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor seleccione el método de pago"), DisplayName("Metodo de Pago")]
        public string EC_COMPRAS_PAGO { get; set; }

        public virtual EC_PRODUCTOS EC_PRODUCTOS { get; set; }
        public virtual EC_USUARIOS EC_USUARIOS { get; set; }
    }
}
