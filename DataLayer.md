# Data Layer
- Handles interaction with database
- The repository services are per aggregates and/or commonly used group of entities, not per database table
- Repository methods should only return `Task<>`s for single results or `IEnumerable<>`s for multiple results to defer query execution/enumeration to caller