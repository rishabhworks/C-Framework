using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalExamRishabh.BusinessLogic
{
    public class Repository
    {
        public List
       <Province> LoadProvinces(string filePath)
        {
            var provinces = new List
                <Province>();

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                var province = new Province(
                    int.Parse(parts[0]),
                    parts[1],
                    parts[2],
                    parts[3],
                    int.Parse(parts[4]),
                    parts[5]
                );

                provinces.Add(province);
            }

            return provinces;
        }
    }
}
