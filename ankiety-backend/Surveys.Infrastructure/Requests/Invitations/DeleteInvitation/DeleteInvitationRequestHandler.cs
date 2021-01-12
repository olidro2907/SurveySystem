﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Surveys.Infrastructure.DTO;
using Surveys.Infrastructure.Common;

namespace Surveys.Infrastructure.Requests.Invitations.DeleteInvitation
{
    public class DeleteInvitationRequestHandler :
        IRequestHandler<DeleteInvitationRequest, Response<StatusResponseDTO>>
    {
        public Task<Response<StatusResponseDTO>> Handle(DeleteInvitationRequest request, 
            CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}