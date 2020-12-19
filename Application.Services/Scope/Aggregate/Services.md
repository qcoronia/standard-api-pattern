# Service Code Rules

## Querying
Fetch data from repository.
```
this.AggregateRepository.Query()
```
This returns an `IEnumerable` so we can perform various operations on it.

Next, we map it to a Domain model so we know exactly what fields we're working on before anything else.
```
    .Select(e => e.ToDomain())
```
We can, therefore, perform business rule operations and chain them as needed.
```
    .Where(e => e.MatchesSearchTerm(searchTerm))
```
Lastly, the pagination comes after all filters.
```
    .Paginate(page, limit)
```
We can _optionally_ have caching at the end when required.
```
    .Encache(this.CacheManager, partitionKey, hashKey);
```
_Note: the data to be cached should be the **end result** so the whole process will be skipped when a cache is present._

## Creating / Updating