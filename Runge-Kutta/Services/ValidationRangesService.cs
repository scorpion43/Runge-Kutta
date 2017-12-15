using Runge_Kutta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta.Services
{
    class ValidationRangesService
    {
        public ValidationResult checkRangesForFieldsToTest(float amountOfPoints) 
        {
            ValidationResult vResult = new ValidationResult();

            if (amountOfPoints < 1 || amountOfPoints >= 1500)
            {
                vResult.Success = false;
                vResult.ValidationError += "Amount of points value is out of range.";
            }

            return vResult;
        }


        public ValidationResult checkRangesForRungeKuttaRepresentation(int startPoint, int amount)
        {
            ValidationResult vResult = new ValidationResult();

            if (startPoint < 0)
            {
                vResult.ValidationError += "Start point for Runge Kutta Representation should start from 0 or greater value";
                vResult.Success = false;
            }

            if (startPoint + amount > 1500)
            {
                vResult.ValidationError += "Out of range. Change the start point or amount.";
                vResult.Success = false;
            }

            return vResult;
        }

        public ValidationResult checkRangesForPerceptronRepresentation(int startPoint, int amount)
        {
            ValidationResult vResult = new ValidationResult();

            if (startPoint < 1)
            {
                vResult.ValidationError = "Start point for Perceptron/Correction Representation should start from 1 or greater value";
                vResult.Success = false;
            }

            if (startPoint + amount > 1500)
            {
                vResult.ValidationError = "Out of range. Change the start point or amount.";
                vResult.Success = false;
            }

            return vResult;
        } 
    }
}
