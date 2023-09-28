using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Platform.Models;
using PlatformService.Platform.Models.Dtos;
using PlatformService.Platform.Repositories.PlatformRepos;
using PlatformService.Platform.SyncDataServices.Http;

namespace PlatformService.Platform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlatformController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IPlatformRepo _platformService;
    private readonly ICommandDataClient _command;

    public PlatformController(
        IPlatformRepo platformService,
        IMapper mapper,
        ICommandDataClient command)
    {
        _mapper = mapper;
        _platformService = platformService;
        _command = command;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<PlatformReadDto>>> GetAllPlatformsEndpoint()
    {
        var platforms = _mapper.Map<IEnumerable<PlatformReadDto>>(await _platformService.GetAllPlatforms());

        return await Task.FromResult(Ok(platforms));
    }

    [HttpGet("{id}", Name = "GetPlatformById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<PlatformReadDto>> GetPlatformByIdEndpoint(int id)
    {
        if (id < 0)
        {
            return await Task.FromResult(BadRequest("Invalid Id"));
        }

        var requestedPlatform = _mapper.Map<PlatformReadDto>(await _platformService.GetPlatformById(id));

        if (requestedPlatform is null)
        {
            return await Task.FromResult(NotFound("The requested platform does not exist"));
        }

        return await Task.FromResult(Ok(requestedPlatform));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PlatformReadDto>> CreatePlatformEndpoint(PlatformCreateDto platformCreateDto)
    {
        if (platformCreateDto is null)
        {
            return await Task.FromResult(BadRequest("Invalid platform data"));
        }

        var platformModel = _mapper.Map<PlatformModel>(platformCreateDto);
        var platformReadData = _mapper.Map<PlatformReadDto>(platformModel);

        await _platformService.CreatePlatform(platformModel);
        await _platformService.SaveChanges();

        return await Task.FromResult(CreatedAtRoute("GetPlatformById", new { id = platformModel.Id }, platformReadData));
    }
}