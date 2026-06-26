# Veltis AI Platform

## Documento 06 – Arquitetura do Sistema

**Versão:** 1.0
**Data:** Junho/2026
**Status:** Em Desenvolvimento

---

# 1. Objetivo

Este documento descreve a arquitetura adotada pelo Veltis AI Platform, apresentando sua organização, responsabilidades de cada camada, fluxo de dados, padrões utilizados e diretrizes para evolução do sistema.

O objetivo é garantir que todo o desenvolvimento siga uma arquitetura consistente, escalável e de fácil manutenção.

---

# 2. Princípios Arquiteturais

O projeto foi desenvolvido com base nos seguintes princípios:

* Separação de responsabilidades.
* Baixo acoplamento.
* Alta coesão.
* Escalabilidade.
* Reutilização de código.
* Facilidade de testes.
* Segurança.
* Manutenção simplificada.

---

# 3. Arquitetura Geral

O sistema utiliza uma arquitetura em camadas inspirada na Clean Architecture.

```text
                 Usuário
                    │
                    ▼
         ASP.NET Core MVC (Web)
                    │
                    ▼
            Application Layer
                    │
                    ▼
               Domain Layer
                    │
                    ▼
          Infrastructure Layer
                    │
                    ▼
              PostgreSQL
```

Além da aplicação Web, a plataforma disponibilizará uma API REST utilizada por aplicações externas e pelo aplicativo Flutter.

---

# 4. Estrutura da Solução

```text
src/
│
├── VeltisAI.Domain
├── VeltisAI.Application
├── VeltisAI.Infrastructure
├── VeltisAI.Web
└── VeltisAI.API
```

---

# 5. Responsabilidade de Cada Projeto

## VeltisAI.Domain

Contém:

* Entidades
* Enums
* Value Objects
* Interfaces de domínio
* Regras de negócio

Não possui dependência de infraestrutura.

---

## VeltisAI.Application

Responsável por:

* Casos de uso
* Serviços de aplicação
* DTOs
* Validações
* Mapeamentos
* Orquestração das regras

Não acessa diretamente o banco de dados.

---

## VeltisAI.Infrastructure

Responsável por:

* Entity Framework Core
* PostgreSQL
* Identity
* Repositórios
* Serviços externos
* Integrações com provedores de IA
* Persistência de dados

---

## VeltisAI.Web

Aplicação MVC responsável por:

* Interface administrativa
* Dashboard
* Cadastros
* Autenticação
* Gerenciamento da plataforma

---

## VeltisAI.API

Responsável por fornecer uma API REST para:

* Aplicativo Flutter
* Integrações externas
* Parceiros
* Consumo por sistemas terceiros

---

# 6. Fluxo de Requisições

```text
Navegador
      │
      ▼
Controller
      │
      ▼
Application Service
      │
      ▼
Domain
      │
      ▼
Repository
      │
      ▼
PostgreSQL
```

---

# 7. Persistência

Banco de dados:

* PostgreSQL

ORM:

* Entity Framework Core

Migrações:

* EF Core Migrations

Chaves primárias:

* Guid

Datas:

* UTC

---

# 8. Autenticação

A autenticação será baseada em ASP.NET Identity.

Recursos:

* Login
* Logout
* Recuperação de senha
* Alteração de senha
* Papéis (Roles)
* Controle de permissões

---

# 9. Multi-Tenant

Cada empresa cadastrada será um Tenant.

Toda informação operacional deverá estar vinculada à empresa correspondente.

Exemplos:

* Usuários
* Clientes
* Assinaturas
* Créditos
* Conversas
* Consumo

Isso garante isolamento lógico dos dados.

---

# 10. Integração com Inteligência Artificial

A plataforma será preparada para integração com diversos provedores.

Inicialmente:

* OpenAI
* Anthropic
* Google Gemini
* Grok
* DeepSeek
* Azure OpenAI
* OpenRouter

Cada provedor poderá possuir vários modelos configuráveis.

---

# 11. API REST

A API seguirá os princípios REST.

Características:

* JSON
* HTTPS
* JWT
* Versionamento
* Swagger/OpenAPI

---

# 12. Aplicativo Flutter

O aplicativo Flutter consumirá exclusivamente a API REST.

Fluxo:

```text
Flutter
    │
 HTTPS + JWT
    │
    ▼
VeltisAI.API
    │
    ▼
Application
    │
    ▼
Infrastructure
```

---

# 13. Segurança

O projeto adotará:

* HTTPS obrigatório
* ASP.NET Identity
* Hash seguro de senhas
* Controle de acesso por papéis
* Proteção CSRF
* Validação de entrada
* Auditoria de operações críticas

---

# 14. Escalabilidade

A arquitetura foi planejada para permitir:

* Novos módulos
* Novos provedores de IA
* Novos modelos
* Aplicativo móvel
* Integrações externas
* Evolução para microsserviços, caso necessário

---

# 15. Padrões de Desenvolvimento

* Código em inglês.
* Interface em português (PT-BR).
* Classes com responsabilidade única.
* Injeção de dependência.
* Commits semânticos.
* Documentação atualizada junto com o código.

---

# Controle de Revisões

| Versão | Data       | Descrição                                 |
| ------ | ---------- | ----------------------------------------- |
| 1.0    | Junho/2026 | Criação inicial da arquitetura do sistema |
