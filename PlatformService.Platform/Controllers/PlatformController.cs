using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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


}