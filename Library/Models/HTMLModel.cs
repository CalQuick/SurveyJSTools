using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class HTMLModel
    {
        /*
         "type": "html",
         "name": "Answer  07",
         "visibleIf": "(sum(\niif({p10a} = \"Yes\",  1, 0),\niif({p10b1} > 30,    1, 0),\niif({p10b2} = \"Yes\", 1, 0),\niif({p10c} = \"Yes\",  1, 0) ) < 2 and \n\nsum(\niif({p10a} = \"Yes\",  1, 0),\niif({p10b1} > 30,    1, 0),\niif({p10b2} = \"Yes\", 1, 0),\niif({p10c} = \"Yes\",  1, 0),\niif({p10d} = \"Yes\",  1, 0),\niif({p10e} = \"Yes\",  1, 0),\niif({p10f} = \"Yes\",  1, 0) ) >= 2)",
         "html": "Answer 7 -
         */

        public string type { get; set; }
        public string name { get; set; }
        public string visibleIf { get; set; }
        public string html { get; set; }
    }
}
