using Explorer.Stakeholders.API.Dtos;
using Explorer.Stakeholders.API.Public;
using Explorer.Stakeholders.Core.UseCases;
using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Explorer.API.Controllers;

[Authorize(Policy = "userPolicy")]
[Route("api/tourist/fight")]
public class ClubFightController : BaseApiController
{
    private readonly IClubFightService _clubFightService;

    public ClubFightController(IClubFightService clubFightService)
    {
        _clubFightService = clubFightService;
    }

    [HttpGet("{fightId:int}")]
    public ActionResult<ClubFightDto> GetById([FromRoute] int fightId)
    {
        var result = _clubFightService.GetWithClubs(fightId);
        return CreateResponse(result);
    }

    [HttpGet("all/{clubId:int}")]
    public ActionResult<List<ClubFightDto>> GetAllByClub([FromRoute] int clubId)
    {
        var result = _clubFightService.GetAllByClub(clubId);
        return CreateResponse(result);
    }
}