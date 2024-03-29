﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Surveys.Infrastructure.DTO;
using Surveys.Infrastructure.Common;
using Surveys.Infrastructure.Requests.Surveys.PostSurvey;
using Surveys.Infrastructure.Requests.Surveys.UpdateSurvey;

namespace Surveys.Infrastructure.Services.Interfaces
{
    public interface ISurveysService
    {
        Task<Response<SurveyDTO>> GetByIdAsync(Guid id);

        Task<Response<IEnumerable<SurveyDTO>>> GetAllAsync();

        Task<Response<SurveyDTO>> DeleteAsync(Guid id);

        Task<Response<SurveyDTO>> UpdateAsync(UpdateSurveyRequest request);

        Task<Response<SurveyDTO>> PostAsync(PostSurveyRequest request);

        Task<Response<SurveyToFillDTO>> GetSurveyToFillAsync(Guid invitationId);

        Task<Response<FilledSurveySummaryDTO>> GetFilledSurvey(Guid invitationId);

        Task<Response<StatusResponseDTO>> SaveFilledSurvey(FilledSurveyDTO filledSurvey);
    }
}
