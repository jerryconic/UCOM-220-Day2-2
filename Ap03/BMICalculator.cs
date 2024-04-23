using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap03
{
    internal class BMICalculator
    {
        private double _height, _weight, _bmi;
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="height">身高(cm)</param>
        /// <param name="weight">體重(kg)</param>
        public BMICalculator(double height, double weight)
        {
            _height = height / 100;
            _weight = weight;
            _bmi = _weight / (_height * _height);
        }

        public string Status()
        {
            if (_bmi < 18.5)
                return $"身高:{_height*100:0.00},體重:{_weight:0.00}, BMI:{_bmi:0.00}, 過輕";
            else if (_bmi < 24)
                return $"身高:{_height * 100:0.00},體重:{_weight:0.00}, BMI:{_bmi:0.00}, 正常";
            else
                return $"身高:{_height * 100:0.00},體重:{_weight:0.00}, BMI:{_bmi:0.00}, 過重";
            
            
        }
    }
}
