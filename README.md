# arishma-gateway

YARP reverse proxy for Arishma Lead Workspace. No database, no domain —
it only routes `api.arishmasolutions.com/<service>/...` to the service
on its local port / subdomain, stripping the service prefix.

Routes: /auth, /leads, /verify, /outreach, /crm, /billing.
In production, each route points at its service's subdomain instead of localhost.
Run: `dotnet run --project src/Arishma.Gateway`, then `curl http://localhost:5000/health`.
