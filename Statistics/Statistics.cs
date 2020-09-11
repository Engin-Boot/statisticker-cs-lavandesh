using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        private double avg(List<double> numbers)
        {
            double sum = default(double);
            for (int i=0; i<numbers.Count; i++)
            {
                sum+= numbers[i];
            }
            return (double)sum/numbers.Count;
        }
        private double min_num(List<double> numbers)
        {
            double min = numbers[0];
            for (int i=0; i<numbers.Count; i++)
            {
                if (min > numbers[i])
                {
                    min=numbers[i];
                }
            }
            return min;
        }
        private double max_num(List<double> numbers)
        {
            double max = numbers[0];
            for (int i=0; i<numbers.Count; i++)
            {
                if (max < numbers[i])
                {
                    max=numbers[i];
                }
            }
            return max;
        }
        
        public Stats CalculateStatistics(List<double> numbers)
        {
            Stats obj = new Stats();
            if (numbers.Count==0)
                return obj;
            obj.Average = avg(numbers);
            obj.Min = min_num(numbers);
            obj.Max = max_num(numbers);
            return obj;
        }
    }
    public class Stats
    {
        private double average, min, max;
        internal Stats()
        {
            this.average=double.NaN;
            this.min  = double.NaN;
            this.max = double.NaN;
        }
        #region Properties
        public double Average
        {
            get;
            set;
        }
        public double Min
        {
            get;
            set;
        }
        public double Max
        {
            get;
            set;
        }

        #endregion


    }
}
