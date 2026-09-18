---
applyTo: "src/web/**"
---

- This folder is for a .NET 10 Blazor WebAssembly frontend hosted by Azure Static Web Apps.
- Use the Azure Functions backend in `src/api` for server-side operations instead of placing secrets or service credentials in the browser app.
- Keep the starting UI simple and Bootstrap-based unless an issue asks for a different design system.
- When adding API calls, make the request and response contracts clear and keep them consistent with the matching function endpoint.
