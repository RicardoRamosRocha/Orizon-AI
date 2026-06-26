# Veltis AI Platform

## Documento 01 – Visão do Produto

**Versão:** 1.0
**Data:** Junho/2026
**Status:** Em Desenvolvimento

---

# 1. Introdução

O **Veltis AI Platform** é uma plataforma SaaS (Software as a Service) desenvolvida para centralizar, gerenciar e disponibilizar acesso a múltiplos modelos de Inteligência Artificial através de uma única interface.

O objetivo da plataforma é simplificar o consumo de IA por empresas e usuários finais, permitindo utilizar diferentes provedores sem a necessidade de gerenciar diversas contas, chaves de API ou integrações individuais.

Além do acesso aos modelos de IA, a plataforma oferecerá recursos completos de administração, gerenciamento de clientes, assinaturas, créditos, monitoramento de consumo e faturamento.

---

# 2. Objetivo do Produto

Construir uma plataforma moderna, segura e escalável capaz de:

* Centralizar diversos provedores de IA.
* Gerenciar empresas e usuários.
* Controlar consumo de créditos e tokens.
* Comercializar planos de assinatura.
* Disponibilizar APIs para integração.
* Permitir futura expansão para aplicativo móvel.

---

# 3. Público-Alvo

O Veltis AI Platform foi projetado para atender:

* Empresas de tecnologia
* Agências de marketing
* Escritórios de advocacia
* Escritórios de contabilidade
* Clínicas
* Instituições de ensino
* Desenvolvedores
* Consultores
* Pequenas e médias empresas
* Profissionais autônomos

---

# 4. Problema que o Produto Resolve

Hoje, empresas que utilizam Inteligência Artificial normalmente precisam:

* Criar contas em diferentes provedores.
* Gerenciar múltiplas APIs.
* Controlar manualmente custos.
* Desenvolver integrações separadas.
* Monitorar diversos painéis administrativos.

O Veltis AI Platform elimina essa complexidade oferecendo um ambiente unificado.

---

# 5. Proposta de Valor

A plataforma permitirá:

* Acesso centralizado a diversos modelos de IA.
* Gestão completa de clientes.
* Controle financeiro.
* Administração de assinaturas.
* Monitoramento de consumo.
* Controle de créditos.
* Histórico completo das conversas.
* Interface intuitiva e responsiva.

---

# 6. Principais Funcionalidades

## Administração

* Dashboard
* Empresas
* Clientes
* Usuários
* Perfis
* Configurações

## Inteligência Artificial

* Provedores
* Modelos
* Chat
* Histórico
* Prompts
* Controle de Tokens

## Financeiro

* Planos
* Assinaturas
* Créditos
* Faturas
* Relatórios

## Sistema

* Logs
* Auditoria
* Permissões
* Segurança
* API REST

---

# 7. Diferenciais

* Plataforma Multi-Tenant.
* Interface moderna.
* Responsiva para desktop, tablet e smartphone.
* Integração com múltiplos provedores.
* Escalável.
* Arquitetura modular.
* API própria.
* Preparada para aplicativo Flutter.

---

# 8. Tecnologias

## Backend

* ASP.NET Core 8
* C#
* Entity Framework Core
* PostgreSQL

## Frontend

* ASP.NET Core MVC
* Bootstrap 5
* Bootstrap Icons
* Chart.js
* SweetAlert2
* DataTables
* Select2

## Mobile

* Flutter (planejado)

## Controle de Código

* Git
* GitHub

---

# 9. Arquitetura

O projeto segue uma arquitetura em camadas, separando responsabilidades entre domínio, aplicação, infraestrutura e apresentação.

Estrutura principal:

```text
src/
│
├── VeltisAI.Domain
├── VeltisAI.Application
├── VeltisAI.Infrastructure
├── VeltisAI.Web
└── VeltisAI.API
```

Essa organização facilita manutenção, testes e evolução da plataforma.

---

# 10. Visão de Longo Prazo

O objetivo é transformar o Veltis AI Platform em uma plataforma completa para gestão e comercialização de Inteligência Artificial, permitindo que empresas ofereçam serviços de IA de forma profissional, segura e escalável.

Entre as evoluções previstas estão:

* Marketplace de modelos.
* Integração com novos provedores.
* Aplicativo móvel.
* Painel analítico avançado.
* Sistema de automações.
* API pública para parceiros.
* Integração com sistemas ERP e CRM.

---

# 11. Status do Projeto

Atualmente o projeto encontra-se em fase de desenvolvimento da infraestrutura básica.

Já implementado:

* Estrutura da solução.
* Arquitetura em camadas.
* Controle de versão com GitHub.
* PostgreSQL.
* Entity Framework Core.
* ASP.NET Identity.
* Dashboard Administrativo inicial.
* Primeiros módulos administrativos.

Próximas etapas:

* Gestão de Planos.
* Gestão de Clientes.
* Assinaturas.
* Créditos.
* Integração com provedores de IA.
* API REST.
* Aplicativo Flutter.

---

# Controle de Revisões

| Versão | Data       | Descrição                           |
| ------ | ---------- | ----------------------------------- |
| 1.0    | Junho/2026 | Criação inicial da Visão do Produto |
