# CopilotTest

A minimal scaffold for a chat-bot style app, built entirely on **.NET 10**:

- `src/web` — Blazor WebAssembly (standalone) front-end using Bootstrap, with a simple chat UI.
- `src/api` — Azure Functions (isolated worker, .NET 10) backend with a `Greet` HTTP-triggered function.

The front-end calls the `Greet` function (`GET /api/Greet?name=<name>`) and displays the greeting it returns. No AI/backend integration is wired up yet — this is just the starting scaffold.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Azure Functions Core Tools v4+](https://learn.microsoft.com/azure/azure-functions/functions-run-local) (for running the API locally)

## Local development

Build everything:

```bash
dotnet build
```

Run the Blazor WASM app:

```bash
dotnet run --project src/web
```

Run the Functions API (from `src/api`):

```bash
cd src/api
func start
```

## Deployment

The repository includes a GitHub Actions workflow (`.github/workflows/azure-static-web-apps.yml`) that builds both projects and deploys them to Azure Static Web Apps. It expects an `AZURE_STATIC_WEB_APPS_API_TOKEN` repository secret.


hahaha
