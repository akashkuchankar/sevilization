using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sevilization
{
    [Serializable]
    public class Department
    {
        public int deptId { get; set; }
        public string deptname { get; set; }
        public string departmentlocation { get; set; }
    }
}
