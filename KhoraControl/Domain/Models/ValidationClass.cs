using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhoraControl.Domain.Models
{
    public abstract class ValidationClass
    {
        public void ValidaClasse()
        {
            ValidationContext contextoValidacao = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> resultadoValidacao = new List<ValidationResult>();
            bool valido = Validator.TryValidateObject(this, contextoValidacao, resultadoValidacao, true);

            if (!valido)
            {
                StringBuilder Errors = new StringBuilder();
                foreach (var resultado in resultadoValidacao)
                {
                    Errors.AppendLine(resultado.ErrorMessage);
                }
                throw new ValidationException(Errors.ToString());
            }
        }
    }
}
