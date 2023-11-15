﻿using Explorer.BuildingBlocks.Core.UseCases;
using Explorer.Stakeholders.API.Dtos;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Stakeholders.API.Public.Identity
{
    public interface IChatMessageService
    {
        Result<PagedResult<ChatMessageDto>> GetConversation(long firstParticipantId, long secondParticipantId);
        Result<ChatMessageDto> Create(long senderId, MessageDto message);
        Result<List<ChatMessageDto>> GetPreviewMessages(long userId);
    }
}