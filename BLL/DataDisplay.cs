using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DataDisplay
    {
        public string conversion(int Number)
        {
            if (Number.ToString().Length >= 5)
            {
                
                return $"{(Number * 10 / 10000) / 10.0f}万";
            }
            return Number.ToString();
        }
    }
}
