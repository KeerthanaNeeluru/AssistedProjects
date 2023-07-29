using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymarphism
{
    internal class HighSchoolGradeCard:BasiGradeCard
    {
        int maths, english, physics, chemistry, biology, histroy, geograpy;
        public HighSchoolGradeCard(int maths,int english,int physics,int chemistry,int biology,int history,int geography)
        {
            this.maths = maths;
            this.english = english;
            this.physics = physics;
            this.chemistry = chemistry;
            this.biology = biology;
            this.histroy = history;
            this.geograpy = geography;
                

        }
        public int Maths
        {
            get { return maths; } set { maths = value; }
        }
        public int English
        {
            get { return english; } set { english = value; }
        }
        public int Physics
        {
            get { return physics; }
            set { physics = value; }
        }
        public int Chemistry
        {
            get { return chemistry; } set { chemistry = value; }
        }
        public int Biology
        {
            get { return biology; } set { biology = value; }
        }
        public int Histroy
        {
            get { return histroy; } set { histroy = value; }
        }
        public int Geography
        {
            get { return geograpy; } set { geograpy = value; }
        }
        public override int GetTotal()
        {
            this.Total=maths+english+physics+chemistry+biology+histroy+geograpy;
            return Total;
        }
    }
}
