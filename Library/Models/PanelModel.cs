using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class PanelModel
    {
        public string type { get; set; } = "panel";
        public string name { get; set; }
        public List<QuestionModel> elements;

        public PanelModel(string panelId, List<QuestionModel> questions)
        {
            name = panelId;
            elements = questions;
        }
    }
}
