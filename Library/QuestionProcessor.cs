using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Library.Models;
using Newtonsoft.Json;

namespace Library
{
    public class QuestionProcessor
    {
        public string QuestionId;
        // public string OutputString { get; private set; }
        public List<QuestionModel> OutputQuestions { get; private set; } = new List<QuestionModel>();
        public List<PanelModel> OutputPanels { get; set; } = new List<PanelModel>();

        public string ValidateAndProcessQuestions(string IdText, string InputString)
        {
            if (ValidateQuestions(IdText, InputString))
            {
                List<QuestionModel> output = ProcessQuestions(IdText, InputString);
                return JsonConvert.SerializeObject(output);
            }

            return "Unable to process. Questions must be split onto separate lines. QuestionId must contain at least 1 digit at the end";
        }

        public string ValidateAndProcessPanels(string IdText, string PanelId, string InputString)
        {
            if (ValidatePanels(IdText, PanelId, InputString))
            {
                List<PanelModel> output = ProcessQuestionsInPanels(IdText, PanelId, InputString);
                return JsonConvert.SerializeObject(output);
            }

            return "Unable to process. Questions must be on separate lines. Leave a gap between panels.";
        }

        public List<QuestionModel> ProcessQuestions(string IdText, string InputString)
        {
            // Reset all properties
            QuestionId = IdText;
            if (QuestionId == "")
            {
                QuestionId = "q01"; // default starting value if no questionId was given by user.
            }

            string extractedId;
            string extractedQuestion;
            OutputQuestions = new List<QuestionModel>();

            foreach (string line in InputString.SplitLines())
            {
                if (line != null && line != "")
                {
                    // First try to extract the questionId from the inputLine. Must start with letter and have a number (no spaces)
                    if (ArrayTools.ReturnIdMatchFromQuestion(line).Success)
                    {
                        ArrayTools.ExtractIdFromQuestion(out extractedId, out extractedQuestion, line);
                        OutputQuestions.Add(new QuestionModel(extractedId.Trim(), extractedQuestion.Trim()));
                    }
                    // If unable, use the questionId stored.
                    else
                    {
                        OutputQuestions.Add(new QuestionModel(QuestionId.Trim(), line.Trim()));
                        ArrayTools.AdvanceId(ref QuestionId);
                    }
                }
            }
            return OutputQuestions;
        }


        private bool ValidateQuestions(string questionId, string inputString)
        {
            if (inputString == null)
            {
                return false;
            }
            return true;
        }

        private bool ValidatePanels(string questionId, string panelId, string inputString)
        {
            // TODO - add additional validation for panels here
            return ValidateQuestions(questionId, inputString);
        }


        public List<PanelModel> ProcessQuestionsInPanels(string IdText, string PanelId, string InputString)
        {
            // Reset all properties
            QuestionId = IdText;
            OutputPanels = new List<PanelModel>();

            if (PanelId == "")
            {
                PanelId = "panel1"; // default if none was given by user.
            }
            
            foreach (string panelString in InputString.SplitOnBlankLine())
            {
                OutputPanels.Add(new PanelModel(PanelId, ProcessQuestions(QuestionId, panelString)));
                ArrayTools.AdvanceId(ref PanelId);
            }
            
            return OutputPanels;
        }

        
    }
}
