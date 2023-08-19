using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Exercise12
{
    internal class Student : IStudent
    {
        private List<string> _testsTaken = new List<string>();

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            double correctAnswers = 0;
            double questions = paper.MarkScheme.Length;
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == paper.MarkScheme[i])
                {
                    correctAnswers++;
                }
            }

            double score = Math.Round((correctAnswers / questions) * 100, 0);
            _testsTaken.Add($"{paper.Subject} - {CheckIfPassed(correctAnswers, paper.PassMark)} - {score}%");
        }

        public string CheckIfPassed(double correctAnswers, string passmark)
        {
            bool passed = correctAnswers >= int.Parse(passmark);

            if (passed)
            {
                return "Test passed!";
            }
            else
            {
                return "Test failed.";
            }
        }

        public List<string> TestsTaken => _testsTaken.Count > 0 ? _testsTaken : new List<string>() { "No tests taken" };
    }
}
