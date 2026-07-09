using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevQuiz
{
    internal class QuestionRepository
    {
        public List<QuizQuestion> GetQuestions() 
        { 
            return new List<QuizQuestion> 
            { 
                new QuizQuestion 
                { 
                    QuestionText = "Wofür steht Git?", 
                    Answers = new List<string> 
                    { 
                        "Ein Texteditor", 
                        "Ein Versionsverwaltungssystem", 
                        "Eine Programmiersprache", 
                        "Ein Datenbankserver" 
                    }, 
                CorrectAnswerIndex = 1 
                } 
            }; 
        }
    }
}
