﻿using Explorer.BuildingBlocks.Core.UseCases;
using Explorer.Tours.API.Dtos;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.API.Public.TourExecution
{
    public interface ITourReviewService
    {
        public Result<TourReviewDto> Create(TourReviewDto review);
        public Result<TourReviewDto> Get(int id);
        public Result<PagedResult<TourReviewDto>> GetPaged(int page, int pageSize);
        public Result<TourReviewDto> Update(TourReviewDto review);
        public Result Delete(int id);
    }
}
