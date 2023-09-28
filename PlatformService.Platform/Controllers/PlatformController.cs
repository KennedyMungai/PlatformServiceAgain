using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Platform.Models.Dtos;
using PlatformService.Platform.Repositories.PlatformRepos;

namespace PlatformService.Platform.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlatformController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IPlatformRepo _platformService;

    public PlatformController(IPlatformRepo platformService, IMapper mapper)
    {
        _mapper = mapper;
        _platformService = platformService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<PlatformReadDto>>> GetAllPlatformsEndpoint()
    {
        var platforms = _mapper.Map<IEnumerable<PlatformReadDto>>(await _platformService.GetAllPlatforms());

        return await Task.FromResult(Ok(platforms));
    }
}