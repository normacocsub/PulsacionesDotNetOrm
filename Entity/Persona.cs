using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Persona
    {
        [Key]
        [Required(ErrorMessage = "Proporcione una identificacion")]
        public string Identificacion { get; set; }
        [StringLength(25, ErrorMessage = "Nombre demasiado largo")]
        public string Nombre { get; set; }
        public int Edad { get; set; }

        [SexoValidacion(ErrorMessage = "El sexo debe ser valido")]
        public string Sexo { get; set; }
        public decimal Pulsacion { get; set; }
        public void CalcularPulsaciones()
        {
            if (Sexo.ToLower().Equals("femenino"))
            {
                Pulsacion = (220 - Edad) / 10;
            }
            else
            {
                Pulsacion = (210 - Edad) / 10;
            }

        }

        public class SexoValidacion : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if ((value.ToString().ToLower() == "masculino") || (value.ToString().ToLower() == "femenino"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(ErrorMessage);
                }
            }
        }

        //[DataType(DataType.EmailAddress,ErrorMessage = "Debe ser un email valido")]
    }
}
