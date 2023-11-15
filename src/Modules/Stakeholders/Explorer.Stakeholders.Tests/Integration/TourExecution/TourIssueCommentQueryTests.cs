﻿using Explorer.API.Controllers.Tourist.TourExecution;
using Explorer.BuildingBlocks.Core.UseCases;
using Explorer.Stakeholders.Tests;
using Explorer.Stakeholders.API.Dtos;
using Explorer.Stakeholders.API.Public.TourExecution;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer.Tours.Tests.Integration.TourExecution
{
    public class TourIssueCommentQueryTests : BaseStakeholdersIntegrationTest
    {
        public TourIssueCommentQueryTests(StakeholdersTestFactory factory) : base(factory) { }

        [Fact]
        public void Retrieves_all()
        {
            //Arrange
            using var scope = Factory.Services.CreateScope();
            var controller = CreateController(scope);

            //Act
            var result = ((ObjectResult)controller.GetAll(0, 0).Result)?.Value as PagedResult<TourIssueCommentDto>;

            //Assert
            result.ShouldNotBeNull();
            result.Results.Count.ShouldBe(3);
            result.TotalCount.ShouldBe(3);
        }

        private static TourIssueCommentController CreateController(IServiceScope scope)
        {
            return new TourIssueCommentController(scope.ServiceProvider.GetRequiredService<ITourIssueCommentService>())
            {
                ControllerContext = BuildContext("-1")
            };
        }
    }
}
