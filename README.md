# payments-hub

payments platform: .net payments, fastapi ledger, react portal, infra

## architecture

- **`payments/`** — .net payments service
- **`ledger/`** — fastapi double-entry ledger
- **`portal/`** — react merchant portal
- **`infra/`** — terraform + k8s

Each service is independently buildable; `docker-compose.yml` wires them
together for local dev.

## running locally

```
docker compose up --build
```

## layout

```
payments-hub/
  payments/
  ledger/
  portal/
  infra/
  docker-compose.yml
  Makefile
```

