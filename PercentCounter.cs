using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_3
{
    public class PercentCounter
    {
        public PercentCounter() { }

        public List<double> GetPercentChange(List<int> values)

        {
            List<double> pr = new List<double>();
            for (int i = 1; i < values.Count(); i++)
            {
                double percentChange = (values[i] - values[i - 1]) * 100.0 / values[i - 1];
                pr.Add(percentChange);
            }
            //int startValue = values[0];   // получаем стартовое значение из списка
            //int endValue = values[values.Count - 1];   // получаем конечное значение из списка
            //double percentChange = (endValue - startValue) * 100.0 / startValue;   // вычисляем процент изменения населения
            return pr;
        }
    }
}
