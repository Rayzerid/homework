using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Structs
{
    [Serializable]
    public struct StudentInfo
    {
        public string Group { get; set; }
        public string FIO { get; set; }
        public DateTime Birthday { get; set; }
    }
}
