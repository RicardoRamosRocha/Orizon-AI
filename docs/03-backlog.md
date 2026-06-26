# Veltis AI Platform

## Documento 03 – Product Backlog

**Versão:** 1.0
**Data:** Junho/2026
**Status:** Em Desenvolvimento

---

# Objetivo

Este documento organiza todas as funcionalidades do Veltis AI Platform em Épicos, Funcionalidades e Sprints.

O backlog será atualizado continuamente durante a evolução da plataforma.

---

# ÉPICO 1 — Fundação da Plataforma

## Sprint 0

### Infraestrutura

* [x] Criar solução .NET 8
* [x] Criar arquitetura em camadas
* [x] Configurar GitHub
* [x] Configurar PostgreSQL
* [x] Configurar Entity Framework Core
* [x] Criar AppDbContext
* [x] Criar primeira Migration

### Segurança

* [x] ASP.NET Identity
* [x] Login
* [x] Logout
* [x] Seed do Administrador

### Administração

* [x] Dashboard inicial
* [x] Área Administrativa
* [ ] Layout Premium
* [ ] Sidebar responsiva
* [ ] Topbar
* [ ] Tema Claro/Escuro

---

# ÉPICO 2 — Cadastros

## Empresas

* [x] Cadastro
* [x] Alteração
* [x] Exclusão
* [ ] Pesquisa avançada
* [ ] Paginação
* [ ] Auditoria

## Clientes

* [x] Estrutura
* [ ] CRUD completo
* [ ] Associação com empresa
* [ ] Histórico
* [ ] Status

## Usuários

* [ ] Cadastro
* [ ] Perfis
* [ ] Permissões
* [ ] Bloqueio
* [ ] Alteração de senha

---

# ÉPICO 3 — Planos

* [x] Estrutura inicial
* [ ] CRUD
* [ ] Limite de usuários
* [ ] Limite de tokens
* [ ] Créditos mensais
* [ ] Controle de ativação

---

# ÉPICO 4 — Assinaturas

* [ ] Criar assinatura
* [ ] Renovação
* [ ] Cancelamento
* [ ] Suspensão
* [ ] Histórico

---

# ÉPICO 5 — Créditos

* [ ] Compra de créditos
* [ ] Consumo
* [ ] Histórico
* [ ] Saldo
* [ ] Ajustes manuais

---

# ÉPICO 6 — Inteligência Artificial

## Provedores

* [ ] OpenAI
* [ ] Anthropic
* [ ] Google Gemini
* [ ] Grok
* [ ] DeepSeek
* [ ] OpenRouter
* [ ] Azure OpenAI

## Modelos

* [ ] Cadastro
* [ ] Configuração
* [ ] Ativação
* [ ] Custos por token

---

# ÉPICO 7 — Chat

* [ ] Nova conversa
* [ ] Histórico
* [ ] Contexto
* [ ] Prompts
* [ ] Exportação
* [ ] Exclusão

---

# ÉPICO 8 — Consumo

* [ ] Tokens enviados
* [ ] Tokens recebidos
* [ ] Custos
* [ ] Histórico
* [ ] Estatísticas

---

# ÉPICO 9 — Financeiro

* [ ] Planos
* [ ] Assinaturas
* [ ] Cobranças
* [ ] PIX
* [ ] Cartão
* [ ] Faturas
* [ ] Relatórios

---

# ÉPICO 10 — API

* [ ] Autenticação
* [ ] Empresas
* [ ] Clientes
* [ ] Chats
* [ ] Créditos
* [ ] Consumo
* [ ] Documentação Swagger

---

# ÉPICO 11 — Aplicativo Flutter

* [ ] Login
* [ ] Dashboard
* [ ] Chat
* [ ] Histórico
* [ ] Perfil
* [ ] Notificações

---

# ÉPICO 12 — Infraestrutura

* [ ] Docker
* [ ] CI/CD
* [ ] Logs
* [ ] Backup
* [ ] Monitoramento
* [ ] Hospedagem

---

# Status Geral

| Épico          | Progresso |
| -------------- | --------- |
| Fundação       | 80%       |
| Cadastros      | 30%       |
| Planos         | 20%       |
| Assinaturas    | 0%        |
| Créditos       | 0%        |
| IA             | 0%        |
| Chat           | 0%        |
| Financeiro     | 0%        |
| API            | 0%        |
| Flutter        | 0%        |
| Infraestrutura | 0%        |

---

# Controle de Revisões

| Versão | Data       | Descrição                          |
| ------ | ---------- | ---------------------------------- |
| 1.0    | Junho/2026 | Criação inicial do Product Backlog |
