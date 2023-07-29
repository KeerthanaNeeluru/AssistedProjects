using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymarphism
{
    internal class MiddleSchoolGradeCard: BasiGradeCard
    {
        int maths, physics, chemistry, biology;
        public MiddleSchoolGradeCard(int maths,int physics,int chemistry,int biology)
        {
            this.maths = maths;
            this.physics = physics;
            this.chemistry = chemistry;
            this.biology = biology;
            
        }
        public int Maths
        {
            get { return maths; } set { maths = value; }
        }
        public int Physics
        {
            get { return physics; } set { physics = value; }
        }
        public int Chemistry
        {
            get { return chemistry; }
            set { chemistry = value; }
        }
        public int Biology
        {
            get { return biology; } set { biology = value; }
        }
        public override int GetTotal()
        {
            this.Total=maths+physics+chemistry+biology;
            return Total;
        }
    }
}
