using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Newtonsoft.Json;

namespace Library
{
    public class TriggerProcessor
    {
        public string ValidateAndProcessTriggers(string idString, string input)
        {
            // TODO - process everything.
            List<HTMLModel> htmlModels = JsonConvert.DeserializeObject<List<HTMLModel>>(input);
            string[] idArray = idString.SplitLines();
            idArray.TrimWhiteSpace();

            if (Validate(idArray, htmlModels))
            {
                List<TriggerModel> triggerModels = Process(idArray, htmlModels);

                return JsonConvert.SerializeObject(triggerModels);
            }
            else
            {
                return "Could not convert. Check the number of elements match the number of id's given.";
            }

            
        }

        private bool Validate(string[] idArray, List<HTMLModel> htmlModels)
        {
            // TODO - make sure there is equal trigger numbers to the html objects
            if (idArray.Length == htmlModels.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private List<TriggerModel> Process(string[] idArray, List<HTMLModel> htmlModels)
        {
            List<TriggerModel> output = new List<TriggerModel>();
            TriggerModel trigger;

            // TODO - turn html into trigger objects
            for (int i = 0; i < idArray.Length; i++)
            {
                trigger = new TriggerModel();
                trigger.setValue = idArray[i];
                trigger.expression = htmlModels[i].visibleIf;
                output.Add(trigger);
            }

            return output;
        }
    }
}
