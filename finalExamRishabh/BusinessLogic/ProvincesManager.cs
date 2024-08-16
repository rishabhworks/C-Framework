using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalExamRishabh.BusinessLogic
{
    public class ProvincesManager
    {
        public List<Province> Provinces
        { get; private set; }

        public ProvincesManager()
        {
            Provinces = new List<Province>();
        }

        public void AddProvince(Province province)
        {
            Provinces.Add(province);
        }

        public Province GetProvinceById(int id)
        {
            return Provinces.FirstOrDefault(p => p.Id == id);
        }
    }
}
