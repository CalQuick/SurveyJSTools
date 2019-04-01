using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class TriggerModel
    {
        /*
        "type": "setvalue",
        "expression": html['visibleIf'],
        "setToName": "__diagnosis",
        "setValue": str(trigger)}
        */

        public string type { get; private set; } = "setvalue";
        public string expression { get; set; }  // the visibleIf logic required to trigger the trigger!
        public string setToName { get; private set; } = "__diagnosis";
        public string setValue { get; set; }    // diagnosis number to set to.
    }
}
