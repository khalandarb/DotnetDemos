using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
    class Instructor
    {
        float avg;
        int expr;
        string name;
        string[] instructorSkill;

        public bool checkSkill(string tech)
        {
            for(int i = 0; i < instructorSkill.Length; i++)
            {
                if (tech == instructorSkill[i])
                {
                    if (validateEligibility())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public Instructor()
        {
            Console.WriteLine("Default Constructor");
        }
        public Instructor(string name,float avg,int expr,string[] instructorSkill)
        {
            this.name = name;
            this.avg = avg;
            this.expr = expr;
            this.instructorSkill = instructorSkill;
        }

        public bool validateEligibility()
        {
            if (expr > 3)
            {
                if (avg >= 4.5)
                {
                    return true;
                }
            }
            else
            {
                if (avg >= 4)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
