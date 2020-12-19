# Unit Testing
- Unit tests should not go beyond their respective layers
- Any calls to other layers should be `Mock`ed instead
- Tests that make use of vertical slice (_multiple layers_) without `Mock`s are **Integration tests**
- The test data should be **Deterministic** and **Idempotent**
- The methods under test should have a basic and concise implementation as much as possible for easy testability