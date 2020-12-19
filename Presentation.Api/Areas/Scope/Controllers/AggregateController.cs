using System.Collections.Generic;
using System.Net.Mime;
using Application.Service.Scope.Aggregate;
using Data.Repository.Scope.Aggregate;
using Domain.Models.Scope.Aggregate;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Api.Areas.Scope.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AggregateController : Controller
    {
        public AggregateController(IAggregateService aggregateService)
        {
            this.AggregateService = aggregateService;
        }

        public IAggregateService AggregateService { get; }

        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        public IEnumerable<EntityListItem> GetList(
            [FromQuery] string searchTerm = "",
            [FromQuery] int page = 1,
            [FromQuery] int limit = 50)
        {
            var list = this.AggregateService.Query(searchTerm, page, limit);
            return list;
        }
    }
}
