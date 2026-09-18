---
applyTo: "src/api/**"
---

- This folder is for a C# .NET 10 Azure Functions app using the isolated worker model.
- Keep functions lightweight HTTP triggers that support the Azure Static Web Apps frontend in `src/web`.
- Read configuration, service endpoints, and credentials from environment variables or local settings that are not committed.
- If adding sample endpoints, keep them simple and easy for the frontend to call, such as a greeting endpoint that accepts a `name` value.
