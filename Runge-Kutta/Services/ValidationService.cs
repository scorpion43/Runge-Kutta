using Runge_Kutta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Runge_Kutta.Services
{
    class ValidationService
    {
        public ValidationResult checkAllFieldValuesToGeneratePoints(String x, String y, String z, String h)
        {
            ValidationResult vResulut = new ValidationResult();

            bool xSuccess = checkFieldIsNumber(x);
            bool ySuccess = checkFieldIsNumber(y);
            bool zSuccess = checkFieldIsNumber(z);
            bool hSuccess = checkFieldIsNumber(h);

            if (!xSuccess)
            {
                vResulut.Success = false;
                vResulut.ValidationError += "Uncorect value for x(0). \n";
            }

            if (!ySuccess)
            {
                vResulut.Success = false;
                vResulut.ValidationError += "Uncorrect value for y(0). \n";
            }

            if (!zSuccess)
            {
                vResulut.Success = false;
                vResulut.ValidationError += "Uncorrect value for z(0). \n";
            }

            if (!hSuccess)
            {
                vResulut.Success = false;
                vResulut.ValidationError += "Uncorrect value for h(0). \n";
            }

            return vResulut;
        }

        public ValidationResult checkFieldsToTrain(String amountOfPoints, String errorMax)
        {
            ValidationResult vResult = new ValidationResult();

            bool matchAmountOfPoints = checkFieldIsInteger(amountOfPoints);
            bool matchErrorMax = checkFieldIsNumber(errorMax);

            if (!matchAmountOfPoints)
            {
                vResult.Success = false;
                vResult.ValidationError += "Uncorect value for Amount of Points field. \n";
            }

            if (!matchErrorMax)
            {
                vResult.Success = false;
                vResult.ValidationError += "Uncorect value for max error field. \n";
            }

            return vResult;
        }

        public ValidationResult checkFieldsToRepresent(String amountOfPoints, String startPoint)
        {
            ValidationResult vResult = new ValidationResult();

            bool matchAmountOfPoints = checkFieldIsInteger(amountOfPoints);
            bool matchStartPoint = checkFieldIsInteger(startPoint);

            if (!matchAmountOfPoints)
            {
                vResult.Success = false;
                vResult.ValidationError += "Uncorect value for Amount of Points field. \n";
            }

            if (!matchStartPoint)
            {
                vResult.Success = false;
                vResult.ValidationError += "Uncorect value for Start Point field. \n";
            }

            return vResult;
        }

        public bool checkFieldIsNumber(String field)
        {
            Match match = Regex.Match( field, "^[0-9]+[,]{1}[0-9]+$");

            if (!match.Success)
            {
                match = Regex.Match( field, "^[0-9]+$");
            }

            return match.Success;
        }

        public bool checkFieldIsInteger(String field) 
        {
            Match match = Regex.Match(field, "^[0-9]+$");
            return match.Success;
        }
    }
}
