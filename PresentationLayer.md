# Presentation Layer
- Contains projects that provides public api or interacts with end users or external applications
- Only needs to reference *Application Layer* for executing logic and *Domain Models* for models to expose
- The CQRS/Mediator pattern implementation on api is already the `Controllers` themselves and `CommandHandlers` for workers