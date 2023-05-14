using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_3
{
    public class Data
    {
        private List<int> years;
        private List<int> people;

        public Data(List<int> years, List<int> people)
        {
            this.years = years;
            this.people = people;
        }

        public List<int> getYears() { return years; }

        public List<int> getPeople() { return people; }
    }
}
