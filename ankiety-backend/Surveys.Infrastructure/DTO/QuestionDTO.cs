﻿using System;
using Surveys.Core.Enums;
using Surveys.Core.Entities;
using System.Collections.Generic;

namespace Surveys.Infrastructure.DTO
{
    public class QuestionDTO
    {
        public Guid Id { get; set; }

        public string Text { get; set; }

        public QuestionType QuestionType { get; set; }

        public ICollection<Option> Options { get; set; }
    }
}
