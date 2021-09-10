using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLinq1
{
    record Car (string marka, string model, int year, string color)
    {
        public override string ToString()
        {
            return $"Марка {marka}, модель {model}, год выпуска {year}, цвет {color}.";
        }
    }

    record Customer(string name, string model, string tel)
    {
        public override string ToString()
        {
            return $"Покупатель {name}, модель {model}, телефон {tel}.";
        }
    }
}
