using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Service.Exceptions;
using Application.Service.Utilities;
using Data.Entities.Models;
using Data.Repository.Scope.Aggregate;
using Domain.Core.Scope.Aggregate.Operations.AggregateMatchesSearchTerm;
using Domain.Models.Scope.Aggregate;
using Infrastructure.Cache.Services;

namespace Application.Service.Scope.Aggregate
{
    public class AggregateService : IAggregateService
    {
        public AggregateService(IAggregateRepository aggregateRepository, ICacheManager cacheManager)
        {
            this.AggregateRepository = aggregateRepository;
            this.CacheManager = cacheManager;
        }

        public IAggregateRepository AggregateRepository { get; }

        public ICacheManager CacheManager { get; }

        public IEnumerable<EntityListItem> Query(string searchTerm = "", int page = 1, int limit = 20)
        {
            var partitionKey = $"{nameof(AggregateService)}.{nameof(AggregateService.Query)}";
            var hashKey = $"{searchTerm}-{page}-{limit}";

            var result = this.AggregateRepository.Query()
                .Select(e => e.ToModel())
                .Where(e => e.MatchesSearchTerm(searchTerm))
                .Paginate(page, limit)
                .Encache(this.CacheManager, partitionKey, hashKey);

            return result;
        }

        public void Create(EntityForm form)
        {
            var entity = form.FromModel();
            this.AggregateRepository.Create(entity);
            this.AggregateRepository.Save();
        }

        public void Update(EntityForm form)
        {
            var entity = form.FromModel();
            var existing = this.AggregateRepository.FindById(form.EntityId);
            if (existing == null)
            {
                throw new EntityNotFoundException(nameof(Entity), form.EntityId);
            }

            this.AggregateRepository.Create(entity);
            this.AggregateRepository.Save();
        }
    }
}
