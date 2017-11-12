using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta.Models
{
    class ResultForOneNeuron
    {
        public float w1;
        public float w2;
        public float w3;
        public float t;

        public ResultForOneNeuron(float w1, float w2, float w3, float t)
        {
            this.w1 = w1;
            this.w2 = w2;
            this.w3 = w3;
            this.t = t;
        }
    }
}
