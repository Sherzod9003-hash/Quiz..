using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Quiz
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions <QuizContext> options ): base(options)
        {

        }
        public DbSet<Question> Questions { get;  set; }
    }
    }

