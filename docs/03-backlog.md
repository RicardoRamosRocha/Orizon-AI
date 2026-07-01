# Veltis AI Platform

## Documento 03 – Product Backlog

**Versão:** 1.1  
**Data:** Julho/2026  
**Status:** Em Desenvolvimento

---

# Objetivo

Este documento organiza as funcionalidades do Veltis AI Platform em Épicos e Funcionalidades.

O Product Backlog representa todas as funcionalidades que agregam valor ao produto e será atualizado continuamente durante sua evolução.

---

# ÉPICO 1 — Fundação da Plataforma

## Infraestrutura Inicial

- [x] Estrutura da solução
- [x] Arquitetura em camadas
- [x] PostgreSQL
- [x] Entity Framework Core
- [x] ASP.NET Identity
- [x] Dashboard inicial
- [x] Área Administrativa

## Interface Administrativa

- [ ] Layout Premium
- [ ] Sidebar Responsiva
- [ ] Topbar
- [ ] Tema Claro / Escuro
- [ ] Dashboard Executivo
- [ ] Cards Estatísticos
- [ ] Gráficos

---

# ÉPICO 2 — Administração

## Empresas

- [x] Cadastro
- [x] Alteração
- [x] Exclusão
- [ ] Pesquisa avançada
- [ ] Paginação
- [ ] Auditoria

## Clientes

- [x] Estrutura inicial
- [ ] CRUD completo
- [ ] Associação com Empresa
- [ ] Status
- [ ] Histórico

## Usuários

- [ ] Cadastro
- [ ] Perfis
- [ ] Permissões
- [ ] Bloqueio
- [ ] Alteração de senha

---

# ÉPICO 3 — Comercial

## Planos

- [x] Estrutura inicial
- [ ] CRUD completo
- [ ] Créditos mensais
- [ ] Limite de usuários
- [ ] Limite mensal de tokens
- [ ] Ativação
- [ ] Desativação

## Assinaturas

- [ ] Criar assinatura
- [ ] Renovação
- [ ] Cancelamento
- [ ] Suspensão
- [ ] Histórico

## Créditos

- [ ] Compra de créditos
- [ ] Consumo
- [ ] Histórico
- [ ] Ajustes manuais
- [ ] Saldo

---

# ÉPICO 4 — Infraestrutura de IA

## Provedores

- [ ] OpenAI
- [ ] Anthropic
- [ ] Google Gemini
- [ ] Grok
- [ ] DeepSeek
- [ ] OpenRouter
- [ ] Azure OpenAI

## Configuração

- [ ] API Keys
- [ ] Endpoints
- [ ] Timeout
- [ ] Retry
- [ ] Health Check
- [ ] Ativação
- [ ] Desativação

## Modelos

- [ ] Cadastro
- [ ] Configuração
- [ ] Ativação
- [ ] Custos
- [ ] Tokens
- [ ] Context Window

---

# ÉPICO 5 — Consumo

- [ ] Tokens enviados
- [ ] Tokens recebidos
- [ ] Créditos consumidos
- [ ] Histórico
- [ ] Estatísticas
- [ ] Rateio
- [ ] Custo Real
- [ ] Margem
- [ ] Lucro
- [ ] Consumo por Empresa
- [ ] Consumo por Usuário

---

# ÉPICO 6 — Chat

- [ ] Nova conversa
- [ ] Histórico
- [ ] Contexto
- [ ] Exportação
- [ ] Exclusão

---

# ÉPICO 7 — Financeiro

- [ ] PIX
- [ ] Cartão
- [ ] Gateway de Pagamento
- [ ] Webhooks
- [ ] Cobranças
- [ ] Faturas
- [ ] Renovação Automática
- [ ] Relatórios

---

# ÉPICO 8 — API Pública

- [ ] Autenticação
- [ ] Empresas
- [ ] Clientes
- [ ] Usuários
- [ ] Créditos
- [ ] Consumo
- [ ] API Keys
- [ ] Documentação Swagger

---

# ÉPICO 9 — Aplicativo Flutter

- [ ] Login
- [ ] Dashboard
- [ ] Consumo
- [ ] Histórico
- [ ] Perfil
- [ ] Notificações

---

# ÉPICO 10 — Observabilidade

- [ ] Auditoria
- [ ] Logs
- [ ] Monitoramento
- [ ] Alertas
- [ ] Dashboard Operacional

---

# Status Geral

| Épico | Progresso |
|--------|-----------|
| Fundação da Plataforma | 85% |
| Administração | 35% |
| Comercial | 25% |
| Infraestrutura de IA | 0% |
| Consumo | 0% |
| Chat | 0% |
| Financeiro | 0% |
| API Pública | 0% |
| Flutter | 0% |
| Observabilidade | 0% |

---

# Observações

Este documento contempla exclusivamente funcionalidades do produto.

Atividades técnicas como Docker, CI/CD, GitHub Actions, Refatorações, Scripts de Banco de Dados e demais tarefas de infraestrutura serão mantidas em um documento específico de **Development Backlog**.

---

# Controle de Revisões

| Versão | Data | Descrição |
|---------|------|-----------|
| 1.0 | Junho/2026 | Criação inicial do Product Backlog |
| 1.1 | Julho/2026 | Revisão completa alinhando o backlog ao posicionamento do Veltis AI Platform como infraestrutura para acesso e gerenciamento de Inteligência Artificial. |