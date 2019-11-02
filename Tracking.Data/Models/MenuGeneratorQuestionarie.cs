using System;
using System.Collections.Generic;
using System.Text;

namespace Tracking.Data.Models
{
    public class MenuGeneratorQuestionarie
    {
        public Guid MenuGeneratorQuestionarieId { get; set; }
        public Guid CompanyUnitId { get; set; }

    }

    public class Question
    {
        public Guid QuestionId { get; set; }
        public Guid QuestionText { get; set; }
        public Guid Description { get; set; }
    }
}
