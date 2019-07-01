using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Quiz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly QuizContext _context = null;
        public QuestionController(QuizContext context)
        {
            _context = context;
        }
         [HttpPost]
    public void Post([FromBody] Question question)
    {
            _context.Questions.Add(question);
            _context.SaveChanges();
    }
       [HttpGet]
        public ActionResult<IEnumerable<Question >> Get()
        {
            return new Question[] {
                new Question {Text =  " Bazaga ulash uchun nima qilish kerak birinchi?"},
                new Question {Text =  " entity fremwork bu nima?"}
            };
        }
    }
   

}