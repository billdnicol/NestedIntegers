using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace NWEA
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static List<int> flatten(NestedInteger thickList, List<int> FinalAnswer = default )
        {
            if (FinalAnswer == default) { FinalAnswer = new List<int>(); }
            if (thickList.isInteger())
            {
                FinalAnswer.Add(thickList.getInteger());
            }
            else
            {
                foreach (NestedInteger paredList in thickList.getList())
                {
                    flatten(paredList, FinalAnswer);
                }
            }
            return FinalAnswer;
        }

        public class NestedInteger
        {
            private int integer ; 
            private List<NestedInteger> list;
            private bool isitInteger = false;

            // Constructors
            public NestedInteger (List<NestedInteger> list)
            {
                this.list = list;
            }
            public NestedInteger (int integer)
            {
                this.integer = integer;
                this.isitInteger = true;
            }
            public NestedInteger()
            {
                
                this.list = new List<NestedInteger>();
            }

            //methods
            public void add(NestedInteger nestedInteger)
            {
                if(this.list != null)
                {
                    this.list.Add(nestedInteger);
                } 
                else
                {
                    this.list=new List<NestedInteger>();
                    this.list.Add(nestedInteger);
                }
            }
            public bool isInteger()
            {
                return this.isitInteger ;
            }
            public int getInteger()
            {
                return this.integer;
            }
            public List<NestedInteger> getList()
            {
                return this.list;
            }

        }



    }
}
