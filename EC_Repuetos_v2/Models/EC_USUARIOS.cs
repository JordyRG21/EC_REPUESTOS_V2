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

    public partial class EC_USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EC_USUARIOS()
        {
            this.EC_COMPRAS = new HashSet<EC_COMPRAS>();
        }
    
        public int EC_USUARIOS_ID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese la cédula del empleado"), DisplayName("Cédula"), StringLength(9, ErrorMessage = "La longitud de la cédula es muy extensa, no exceda los 9 caracteres."), RegularExpression("([1-9][0-9]*)", ErrorMessage = "Formato Inválido (Ingrese números.)")]
        public string EC_USUARIOS_CEDULA { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese un nombre"), DisplayName("Nombre de Usuario"), StringLength(25, ErrorMessage = "Nombre muy extenso. Por favor no exceda los 25 caracteres."), RegularExpression("([A-Za-z])+( [A-Za-z]+)*", ErrorMessage = "Formato Inválido.")]
        public string EC_USUARIOS_NOMBRE { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor, ingrese el primer apellido"), DisplayName("Primer Apellido"), StringLength(15, ErrorMessage = " El apellido del empleado es muy extenso. Por favor no exceda los 15 caracteres."), RegularExpression("([A-Za-z])+( [A-Za-z]+)*", ErrorMessage = "Formato Inválido.")]
        public string EC_USUARIOS_APE1 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor, ingrese el segundo apelliod"), DisplayName("Segundo Apellido"), StringLength(15, ErrorMessage = " El apellido del empleado es muy extenso. Por favor no exceda los 15 caracteres."), RegularExpression("([A-Za-z])+( [A-Za-z]+)*", ErrorMessage = "Formato Inválido.")]
        public string EC_USUARIOS_APE2 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese el teléfono móvil"), DisplayName("Teléfono Móvil"), StringLength(8, ErrorMessage = "El número es muy extenso, no exceda los 8 caracteres."), RegularExpression("([1-9][0-9]*)", ErrorMessage = "Formato Inválido (Ingrese números.)")]
        public string EC_USUARIOS_TELEFONO { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese un correo electrónico válido"), DisplayName("Correo Electrónico"), EmailAddress(ErrorMessage = "Correo Eléctronico con formato inválido")]
        public string EC_USUARIOS_EMAIL { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese un correo electrónico válido"), DisplayName("Estado")]
        public string EC_USUARIOS_ESTADO { get; set; }

        [DisplayName("Contraseña"), Required(AllowEmptyStrings = false, ErrorMessage = "Por favor ingrese la contraseña del usuario"), MinLength(8, ErrorMessage = "La contraseña debe ser de mínimo 8 caracteres"), StringLength(16, ErrorMessage = "!Contraseña muy extensa! No exceda lo 16 caracteres")]
        public string EC_USUARIOS_CONTRASENNA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EC_COMPRAS> EC_COMPRAS { get; set; }
    }
}
