# Repository Copilot instructions

This repository is currently focused on Copilot guidance for a planned Azure Static Web Apps project. Keep changes small and aligned with the existing instruction files.

## Intended application shape

- `src/web` is reserved for a .NET 10 Blazor WebAssembly frontend.
- `src/api` is reserved for a .NET 10 Azure Functions backend using the isolated worker model.
- The frontend and backend are intended to work together as an Azure Static Web App.

## Working in this repository

- Do not scaffold `src/web`, `src/api`, workflows, or solution files unless an issue explicitly asks for implementation files.
- When application files are added, keep a root solution that includes both projects and validate with `dotnet build`.
- Prefer lightweight HTTP-trigger functions for API endpoints used by the static web frontend.
- Keep secrets out of source control. Use repository secrets or local environment variables for Azure deployment tokens and service credentials.
- Update the folder-specific instruction files in `.github/instructions/` when guidance for `src/web` or `src/api` changes.

## Validation guidance

- For instruction-only changes, review the Markdown/YAML for clarity and correct paths.
- For future .NET code changes, run the most targeted available build or test command first, then broader validation if needed.
