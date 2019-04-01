using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class QuestionModel
    {
        public string type { get; set; } = "radiogroup";
        public string name { get; set; }
        public string title { get; set; }
        public bool isRequired { get; set; } = true;
        public List<string> choices { get; set; } = new List<string>{ "Yes", "No" };

        public QuestionModel(string id, string title)
        {
            name = id;
            this.title = title;
        }
    }
}
