# Veltis AI Platform

## Documento 07 – Especificação da API

**Versão:** 1.0
**Data:** Junho/2026
**Status:** Em Desenvolvimento

---

# 1. Objetivo

Este documento descreve a arquitetura e os principais endpoints da API REST do Veltis AI Platform.

A API será responsável pela comunicação entre os clientes (Web, Flutter e integrações externas) e a camada de negócios da plataforma.

---

# 2. Padrões da API

## Arquitetura

* RESTful
* JSON
* HTTPS obrigatório

## Autenticação

* JWT Bearer Token

## Versionamento

```text
/api/v1/
```

Exemplo:

```text
/api/v1/customers
```

---

# 3. Fluxo de Autenticação

```text
Cliente
    │
POST /api/v1/auth/login
    │
    ▼
JWT Token
    │
    ▼
Authorization: Bearer Token
    │
    ▼
Demais Endpoints
```

---

# 4. Endpoints

## Autenticação

### Login

```http
POST /api/v1/auth/login
```

Request

```json
{
  "email": "admin@empresa.com",
  "password": "********"
}
```

Response

```json
{
  "token": "...",
  "expiresIn": 3600
}
```

---

### Logout

```http
POST /api/v1/auth/logout
```

---

### Recuperar Senha

```http
POST /api/v1/auth/forgot-password
```

---

### Alterar Senha

```http
POST /api/v1/auth/change-password
```

---

# Empresas

```http
GET /api/v1/companies
```

```http
GET /api/v1/companies/{id}
```

```http
POST /api/v1/companies
```

```http
PUT /api/v1/companies/{id}
```

```http
DELETE /api/v1/companies/{id}
```

---

# Clientes

```http
GET /api/v1/customers
```

```http
POST /api/v1/customers
```

```http
PUT /api/v1/customers/{id}
```

```http
DELETE /api/v1/customers/{id}
```

---

# Planos

```http
GET /api/v1/plans
```

```http
POST /api/v1/plans
```

```http
PUT /api/v1/plans/{id}
```

```http
DELETE /api/v1/plans/{id}
```

---

# Assinaturas

```http
GET /api/v1/subscriptions
```

```http
POST /api/v1/subscriptions
```

```http
PUT /api/v1/subscriptions/{id}
```

---

# Créditos

```http
GET /api/v1/credits
```

```http
POST /api/v1/credits
```

```http
GET /api/v1/credits/history
```

---

# Provedores de IA

```http
GET /api/v1/providers
```

```http
POST /api/v1/providers
```

```http
PUT /api/v1/providers/{id}
```

---

# Modelos de IA

```http
GET /api/v1/models
```

```http
POST /api/v1/models
```

```http
PUT /api/v1/models/{id}
```

---

# Chat

### Criar Conversa

```http
POST /api/v1/chat/conversations
```

### Listar Conversas

```http
GET /api/v1/chat/conversations
```

### Enviar Mensagem

```http
POST /api/v1/chat/messages
```

### Histórico

```http
GET /api/v1/chat/history/{conversationId}
```

---

# Consumo

```http
GET /api/v1/usage
```

```http
GET /api/v1/usage/company
```

```http
GET /api/v1/usage/customer
```

---

# Dashboard

```http
GET /api/v1/dashboard
```

Retorna indicadores para o painel administrativo.

---

# 5. Códigos HTTP

| Código | Descrição              |
| ------ | ---------------------- |
| 200    | OK                     |
| 201    | Criado                 |
| 204    | Sem conteúdo           |
| 400    | Requisição inválida    |
| 401    | Não autenticado        |
| 403    | Acesso negado          |
| 404    | Recurso não encontrado |
| 409    | Conflito               |
| 500    | Erro interno           |

---

# 6. Segurança

* HTTPS obrigatório.
* JWT Bearer.
* Expiração de token.
* Controle por papéis (Roles).
* Validação de entrada.
* Auditoria de operações críticas.

---

# 7. Documentação

A API será documentada automaticamente com Swagger/OpenAPI.

Objetivos:

* Facilitar testes.
* Apoiar integrações.
* Servir de referência para o aplicativo Flutter.

---

# 8. Versionamento

A API será versionada.

Exemplo:

```text
/api/v1/
/api/v2/
```

Isso permitirá evoluções sem quebrar integrações existentes.

---

# 9. Evoluções Futuras

* Webhooks.
* API Keys para parceiros.
* Limitação de requisições (Rate Limiting).
* SDK oficial para .NET.
* SDK para Flutter.

---

# Controle de Revisões

| Versão | Data       | Descrição                               |
| ------ | ---------- | --------------------------------------- |
| 1.0    | Junho/2026 | Criação inicial da especificação da API |
