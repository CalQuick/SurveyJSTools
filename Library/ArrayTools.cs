using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library
{
    public static class ArrayTools
    {
        public static void TrimWhiteSpace(this string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Trim();
            }
            
        }


        public static void AdvanceId(ref string stringWithNumber)
        {
            // "question_01" => ("question_")("01")
            Regex re = new Regex(@"(.*?)(\d+)");

            Match result = re.Match(stringWithNumber);
            string text = result.Groups[1].ToString();
            string numberString = result.Groups[2].ToString();

            int number = int.Parse(numberString);

            while ((numberString.Length - number.ToString().Length) != 0)
            {
                text += numberString.First();
                numberString = numberString.Substring(1);
            }

            int newNumber = number + 1;
            stringWithNumber = text + newNumber.ToString();
        }


        public static string[] SplitLines(this string inputString)
        {
            return inputString.Split(new[] { "\r\n"}, StringSplitOptions.None);
        }


        public static string[] SplitOnBlankLine(this string inputString)
        {
            return inputString.Split(new[] { "\r\n\r\n"}, StringSplitOptions.None);
        }

        public static Match ReturnIdMatchFromQuestion(string question)
        {
            // Regex must start with something like:
            // q01a.this is my question == (q01a) and (question text)
            // q01 Question goes here == (q01) and (question text)
            // q1 - Question == (q1) and (question text)
            // 1 Question == (1) and (question text)

            Regex re = new Regex(@"^(\w+\d+\w?)(\s*[\.-]?\s*)(.*)");
            Match result = re.Match(question);
            return result;
        }

        public static void ExtractIdFromQuestion(out string questionId, out string outputLine, string inputLine)
        {
            Match match = ReturnIdMatchFromQuestion(inputLine);

            questionId = match.Groups[1].ToString();
            if (!questionId.Any(x => char.IsLetter(x)))
            {
                questionId = "q" + questionId;
            }
            outputLine = match.Groups[3].ToString();
        }
    }
}
