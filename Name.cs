using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp31
{
    class Name : IName
    {
        public string NameShower(string name)
        {
            return $"Hello {name} from the interface";
        }
    }
}
