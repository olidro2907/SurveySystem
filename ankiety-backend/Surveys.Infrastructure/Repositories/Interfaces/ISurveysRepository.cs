﻿using Surveys.Core.Entities;
using System;
using System.Threading.Tasks;

namespace Surveys.Infrastructure.Repositories.Interfaces
{
    public interface ISurveysRepository : IRepositoryBase<Survey>
    {
        Task<Survey> GetByIdWithQuestionsAndAnwerOptionsAsync(Guid id);
    }
}