﻿using System;
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
            question.WrongAnswersString = String.Join(',', question.WrongAnswers.ToArray());
            _context.Questions.Add(question);
            _context.SaveChanges();
    }
       [HttpGet]
        public ActionResult<IEnumerable<Question >> Get()
        {
            return _context.Questions;
        }
    }
   

}