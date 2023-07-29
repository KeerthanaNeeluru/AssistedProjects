using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Polymarphism
{
    internal class BasiGradeCard
    {
        public int Total;
        public BasiGradeCard() { 
        Total = 0;
        }
        public virtual int GetTotal()
        {
            return Total;
        } 
    }
}
