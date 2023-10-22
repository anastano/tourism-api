﻿using AutoMapper;
using Explorer.BuildingBlocks.Core.UseCases;
using Explorer.Stakeholders.API.Dtos;
using Explorer.Stakeholders.API.Public.Tourist;
using Explorer.Stakeholders.Core.Domain;
using Explorer.Stakeholders.Core.Domain.RepositoryInterfaces;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Stakeholders.Core.UseCases.Tourist
{
    public class ClubJoinRequestService : CrudService<ClubJoinRequestDto, ClubJoinRequest>, IClubJoinRequestService
    {
        protected readonly IClubJoinRequestRepository _requestRepository;
        public ClubJoinRequestService(IClubJoinRequestRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _requestRepository = repository;
        }

        public Result<PagedResult<ClubJoinRequestDto>> GetAllByUser(int userId)
        {
            try
            {
                var requests = _requestRepository.GetAllByUser(userId);
                return MapToDto(requests);
            }
            catch (KeyNotFoundException e)
            {
                return Result.Fail(FailureCode.NotFound).WithError(e.Message);
            }
        }
    }
}
