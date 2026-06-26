# Veltis AI Platform

> Plataforma SaaS para gerenciamento de clientes, assinaturas, créditos e acesso centralizado a múltiplos provedores de Inteligência Artificial.

![Status](https://img.shields.io/badge/status-em%20desenvolvimento-blue)
![.NET](https://img.shields.io/badge/.NET-8.0-purple)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-17-blue)
![License](https://img.shields.io/badge/license-MIT-green)

---

# Visão Geral

O **Veltis AI Platform** é uma plataforma SaaS desenvolvida para centralizar o acesso a diferentes modelos de Inteligência Artificial através de uma única interface.

A plataforma permitirá que empresas gerenciem clientes, planos, assinaturas, créditos e consumo de IA de forma segura, organizada e escalável.

---

# Objetivos

* Centralizar múltiplos provedores de IA.
* Gerenciar empresas e usuários.
* Controlar consumo de créditos e tokens.
* Comercializar planos de assinatura.
* Disponibilizar API REST para integrações.
* Preparar a plataforma para aplicativo Flutter.

---

# Tecnologias

## Backend

* ASP.NET Core 8
* Entity Framework Core
* PostgreSQL
* ASP.NET Identity

## Frontend

* ASP.NET Core MVC
* Bootstrap 5
* Bootstrap Icons
* Chart.js
* SweetAlert2
* DataTables

## Mobile

* Flutter (planejado)

---

# Arquitetura

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

# Funcionalidades

## Administração

* Dashboard
* Empresas
* Usuários
* Perfis
* Configurações

## Comercial

* Clientes
* Planos
* Assinaturas
* Créditos

## Inteligência Artificial

* Provedores
* Modelos
* Chat
* Histórico
* Controle de consumo

## Financeiro

* Faturas
* Pagamentos
* Relatórios

---

# Documentação

A documentação completa está disponível na pasta **docs/**.

* 01 – Visão do Produto
* 02 – Requisitos
* 03 – Product Backlog
* 04 – Roadmap
* 05 – Modelagem do Banco
* 06 – Arquitetura
* 07 – API

---

# Estrutura do Projeto

```text
assets/
database/
docs/
src/
tests/
```

---

# Roadmap

* Fundação da plataforma
* Interface administrativa
* Empresas
* Clientes
* Planos
* Assinaturas
* Créditos
* Integração com IA
* Chat
* API REST
* Aplicativo Flutter

---

# Status Atual

### Concluído

* Estrutura da solução
* PostgreSQL
* Entity Framework Core
* ASP.NET Identity
* Dashboard inicial
* Área Administrativa
* Documentação principal

### Em desenvolvimento

* Layout administrativo premium
* Gestão de clientes
* Gestão de planos
* Assinaturas
* Integração com provedores de IA

---

# Licença

Este projeto está licenciado sob a licença MIT.

---

# Autor

**Ricardo Ramos da Rocha**

Desenvolvido como parte da evolução do **Veltis AI Platform**, uma plataforma SaaS moderna para gerenciamento e comercialização de serviços baseados em Inteligência Artificial.
