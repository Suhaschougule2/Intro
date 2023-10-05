using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Overloadingindexer
    {
        private string[] word = new string[2];

        // this indexer gets executed
        // when Obj[0]gets executed
        public string this[int flag]
        {

            // using get accessor
            get
            {
                string temp = word[flag];
                return temp;
            }

            // using set accessor
            set
            {
                word[flag] = value;
            }
        }

        // this is an Overloaded indexer
        // which will execute when 
        // Obj[1.0f] gets executed
        public string this[float flag]
        {

            // using get accessor
            get
            {
                string temp = word[1];
                return temp;
            }

            // using set accessor
            set
            {

                // it will set value of 
                // the private string 
                // assigned in main
                word[1] = value;

            }
        }
    }

}
