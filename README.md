# Chat 💬

**A hands-on software engineering project focused on building a complete chat application with C# and .NET.**

> 🚧 **Status: In development** — the repository currently contains the initial backend solution and project structure. Application features are being developed incrementally.

## About the Project

I created this repository to go beyond isolated programming exercises and gain practical experience **building real software from the ground up**.

The goal is to work through the broader development process: designing an application, organizing its architecture, implementing business logic, connecting components, testing behavior, and gradually turning an initial idea into a working product.

This is both a learning project and a place to demonstrate how I approach **backend development, software architecture, problem-solving, and maintainable code**.

## What I'm Practicing

- **Software architecture** — organizing a multi-project solution and separating responsibilities.
- **Backend engineering** — designing APIs and implementing application behavior with ASP.NET Core.
- **Clean code** — writing readable, modular, maintainable C#.
- **Data management** — working toward consistent data models and persistence.
- **Application design** — understanding how individual components form a complete system.
- **Testing and debugging** — improving reliability as functionality is introduced.
- **Iterative development** — implementing, evaluating, and refining features over time.

## Current Project Structure

```
Chat/
├── Chat.Api/
├── Chat.BussinesLogic/
├── Chat.DataAccess/
└── Chat.slnx
```

The solution is structured around three projects with distinct *intended* responsibilities. The API is scaffolded, while the business logic and data access projects provide a foundation for future implementation.

## Tech Stack

| Area | Technology |
| --- | --- |
| Language | C# |
| Framework | .NET 10 |
| Backend | ASP.NET Core Web API |
| API documentation | ASP.NET Core OpenAPI |
| Development | .NET CLI, Git, GitHub |

Additional technologies will be documented as they are introduced into the project.

## Development Roadmap

The following items describe planned areas of development, **not features that are already complete**:

- [ ] Define chat domain models and API contracts.
- [ ] Implement conversation and message management.
- [ ] Add user accounts and access control.
- [ ] Introduce a persistence layer.
- [ ] Explore real-time message delivery.
- [ ] Add automated tests and robust error handling.
- [ ] Develop the application toward a usable end-to-end experience.

## Getting Started

**Prerequisite:** Install the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0).

```bash
git clone https://github.com/OlehProtsun/Chat.git
cd Chat

dotnet restore Chat.slnx
dotnet build Chat.slnx
dotnet run --project Chat.Api
```

At this stage, running the project starts the backend API scaffold; it does **not** provide a complete messaging application yet.

## Why This Repository Exists

My [Practical Tasks](https://github.com/OlehProtsun/Practical-tasks) repository is focused on individual coding challenges and programming fundamentals. **Chat** focuses on a different skill set: putting those skills together to design and build a larger, evolving software application.

The codebase will continue to change as I learn, experiment, refactor, and implement new functionality.

---

*From solving individual problems to engineering complete software — one feature at a time.*
