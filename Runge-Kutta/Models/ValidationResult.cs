using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta.Models
{
    class ValidationResult
    {
        public bool Success;
        public String ValidationError;
        
        public ValidationResult()
        {
            Success = true;
            ValidationError = "";
        }
    }
}
