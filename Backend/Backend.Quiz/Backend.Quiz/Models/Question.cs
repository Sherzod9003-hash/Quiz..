using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Quiz
{
    public class Question
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string correctAnswer { get; set; }
        [NotMapped]
        public List <string> WrongAnswers { get; set; }
        public string WrongAnswersString { get; set; }
    }
}
