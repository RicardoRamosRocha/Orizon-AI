# Veltis AI Platform

## Documento 05 – Modelagem do Banco de Dados

**Versão:** 1.0
**Data:** Junho/2026
**Status:** Em Desenvolvimento

---

# Objetivo

Este documento define a modelagem lógica inicial do banco de dados do Veltis AI Platform.

A estrutura foi projetada para suportar uma plataforma SaaS Multi-Tenant, permitindo o gerenciamento de múltiplas empresas, usuários, assinaturas e integrações com diversos provedores de Inteligência Artificial.

---

# Visão Geral

O banco de dados será desenvolvido utilizando PostgreSQL.

Toda a aplicação utilizará Entity Framework Core para acesso aos dados.

Cada empresa (Company) será um Tenant independente dentro da plataforma.

---

# Modelo Conceitual

```text
Company
│
├── Users
├── Customers
├── Plans
├── Subscriptions
├── Credits
├── AI Providers
├── AI Models
├── Conversations
├── Messages
└── Usage
```

---

# Entidades Principais

## Company

Representa uma empresa cadastrada na plataforma.

Campos:

* Id
* Name
* Email
* Phone
* Document
* Active
* CreatedAt
* UpdatedAt

Relacionamentos:

* 1:N Users
* 1:N Customers
* 1:N Plans
* 1:N Subscriptions

---

## ApplicationUser

Usuário autenticado na plataforma.

Campos:

* Id
* CompanyId
* FullName
* Email
* PasswordHash
* PhoneNumber
* Active
* LastLogin
* CreatedAt

Relacionamentos:

* N:1 Company

---

## Customer

Representa o cliente final vinculado à empresa.

Campos:

* Id
* CompanyId
* Name
* Email
* Phone
* Document
* Credits
* Active
* CreatedAt

Relacionamentos:

* N:1 Company
* 1:N Conversations
* 1:N Usage

---

## Plan

Plano comercial disponível.

Campos:

* Id
* Name
* Description
* MonthlyPrice
* CreditsIncluded
* MaxUsers
* MaxTokensPerMonth
* Active

Relacionamentos:

* 1:N Subscriptions

---

## Subscription

Assinatura contratada.

Campos:

* Id
* CompanyId
* PlanId
* StartDate
* EndDate
* Status
* AutoRenew
* CreatedAt

Relacionamentos:

* N:1 Company
* N:1 Plan

---

## Credit

Controle financeiro de créditos.

Campos:

* Id
* CompanyId
* CustomerId
* Amount
* Balance
* Type
* Description
* CreatedAt

Relacionamentos:

* N:1 Company
* N:1 Customer

---

# Inteligência Artificial

## AIProvider

Representa um provedor de IA.

Exemplos:

* OpenAI
* Anthropic
* Google Gemini
* Grok
* DeepSeek
* Azure OpenAI
* OpenRouter

Campos:

* Id
* Name
* BaseUrl
* ApiKey
* Active

Relacionamentos:

* 1:N AIModels

---

## AIModel

Representa um modelo disponível.

Campos:

* Id
* ProviderId
* Name
* ModelIdentifier
* ContextLimit
* InputTokenPrice
* OutputTokenPrice
* Active

Relacionamentos:

* N:1 AIProvider

---

# Chat

## Conversation

Campos:

* Id
* CompanyId
* CustomerId
* Title
* CreatedAt

Relacionamentos:

* N:1 Customer
* 1:N Messages

---

## Message

Campos:

* Id
* ConversationId
* Role
* Content
* PromptTokens
* CompletionTokens
* TotalTokens
* Cost
* CreatedAt

Relacionamentos:

* N:1 Conversation

---

# Consumo

## Usage

Campos:

* Id
* CompanyId
* CustomerId
* ModelId
* PromptTokens
* CompletionTokens
* TotalTokens
* Cost
* CreatedAt

Relacionamentos:

* N:1 Company
* N:1 Customer
* N:1 AIModel

---

# Financeiro

## Invoice

Campos:

* Id
* CompanyId
* SubscriptionId
* Total
* DueDate
* PaidDate
* Status

---

## Payment

Campos:

* Id
* InvoiceId
* Method
* TransactionId
* Amount
* CreatedAt

---

# Auditoria

## AuditLog

Campos:

* Id
* UserId
* Action
* Entity
* EntityId
* OldValues
* NewValues
* IpAddress
* CreatedAt

---

# Relacionamentos Gerais

```text
Company
 ├── Users
 ├── Customers
 ├── Subscriptions
 ├── Credits
 ├── Conversations
 ├── Usage
 ├── Invoices
 └── AuditLogs

Plan
 └── Subscriptions

AIProvider
 └── AIModels

Conversation
 └── Messages

Invoice
 └── Payments
```

---

# Convenções

* Chaves primárias do tipo Guid.
* Datas armazenadas em UTC.
* Exclusão lógica para entidades de negócio.
* Controle de auditoria em operações críticas.
* Índices para campos de pesquisa e relacionamentos.
* Suporte à expansão de novos módulos sem alterações estruturais significativas.

---

# Controle de Revisões

| Versão | Data       | Descrição                                      |
| ------ | ---------- | ---------------------------------------------- |
| 1.0    | Junho/2026 | Criação inicial da modelagem do banco de dados |
