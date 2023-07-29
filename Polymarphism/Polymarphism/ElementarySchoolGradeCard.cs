using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymarphism
{
    internal class ElementarySchoolGradeCard : BasiGradeCard
    {
        int maths,english,social,science;
        public ElementarySchoolGradeCard(int maths,int english,int social,int science)
        {
            this.maths = maths;
            this.english = english;
            this.social = social;
            this.science = science;

            
        }
        public int Maths
        {
            get { return maths; } set { maths = value; }
        }
        public int English
        {
            get { return english; }
            set { english = value; }
        }
        public int Social
        {
            get { return social; }  set { social = value; }
        }
        public int Science
        {
            get { return science; } set { science = value; }
        }
        public override int GetTotal()
        {
            this.Total=maths+english+social+science;
            return Total;
        }

    }
}
