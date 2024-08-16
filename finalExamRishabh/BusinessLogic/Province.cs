using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalExamRishabh.BusinessLogic
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Capital { get; set; }

        public string Description { get; set; }

        public int Population { get; set; }

        public string Flag { get; set; }

        public Province() { }

        public Province(int id, string name, string capital, string description, int population, string flag)
        {
            Id = id;
            Name = name;
            Capital = capital;
            Description = description;
            Population = population;
            Flag = flag;
        }

        public override string ToString()
        {
            return $"{Name} ({Capital})";
        }
    }
}
