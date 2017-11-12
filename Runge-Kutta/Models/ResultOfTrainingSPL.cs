using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runge_Kutta.Models
{
    class ResultOfTrainingSPL
    {
        public ResultForOneNeuron xResult;
        public ResultForOneNeuron yResult;
        public ResultForOneNeuron zResult;

        public ResultOfTrainingSPL
            (ResultForOneNeuron xResult, ResultForOneNeuron yResult, ResultForOneNeuron zResult)
        {
            this.xResult = xResult;
            this.yResult = yResult;
            this.zResult = zResult;
        }
    }
}
