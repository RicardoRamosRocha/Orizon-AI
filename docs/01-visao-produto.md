# Veltis AI Platform

## Documento 01 – Visão do Produto

**Versão:** 1.1  
**Data:** Julho/2026  
**Status:** Em Desenvolvimento

---

# 1. Introdução

O **Veltis AI Platform** é uma plataforma SaaS (Software as a Service) desenvolvida para centralizar, gerenciar e disponibilizar acesso a múltiplos provedores e modelos de Inteligência Artificial através de uma única plataforma.

Seu principal objetivo é permitir que pessoas e empresas utilizem diferentes provedores de IA sem a necessidade de gerenciar múltiplas contas, chaves de API, integrações e formas de cobrança.

Além do acesso aos modelos de Inteligência Artificial, a plataforma oferece recursos completos para administração de clientes, empresas, usuários, planos, assinaturas, créditos, consumo de tokens, faturamento e integrações via API.

O Veltis AI Platform atua como uma camada de infraestrutura para aplicações baseadas em Inteligência Artificial, podendo ser utilizado diretamente por usuários finais ou integrado a sistemas externos, como ERP, CRM, plataformas SaaS e o próprio Veltis Workspace.

---

# 2. Objetivo do Produto

Construir uma plataforma moderna, segura e escalável capaz de:

- Centralizar múltiplos provedores de IA.
- Permitir acesso simplificado a diversos modelos de IA.
- Gerenciar contas individuais e empresas.
- Comercializar planos de assinatura.
- Controlar créditos e consumo de tokens.
- Disponibilizar APIs para integração.
- Servir como infraestrutura para outras aplicações.
- Permitir expansão futura para aplicativo móvel.

---

# 3. Público-Alvo

O Veltis AI Platform foi projetado para atender três públicos principais.

## Pessoas

- Profissionais autônomos.
- Desenvolvedores.
- Professores.
- Estudantes.
- Consultores.
- Criadores de conteúdo.
- Usuários que desejam acessar diversos modelos de IA através de uma única assinatura.

## Empresas

- Empresas de tecnologia.
- Software Houses.
- Agências de marketing.
- Escritórios de advocacia.
- Escritórios de contabilidade.
- Clínicas.
- Instituições de ensino.
- Pequenas e médias empresas.

## Sistemas

- ERP.
- CRM.
- Plataformas SaaS.
- Aplicações que desejam consumir Inteligência Artificial através da API do Veltis AI Platform.

---

# 4. Problema que o Produto Resolve

Hoje pessoas e empresas que utilizam Inteligência Artificial normalmente precisam:

- Criar contas em diversos provedores.
- Gerenciar múltiplas chaves de API.
- Desenvolver integrações específicas para cada fornecedor.
- Controlar custos manualmente.
- Monitorar diferentes painéis administrativos.
- Implementar regras próprias de cobrança e consumo.

O Veltis AI Platform elimina essa complexidade oferecendo uma única plataforma para gerenciamento e consumo de Inteligência Artificial.

---

# 5. Proposta de Valor

A plataforma permitirá:

- Acesso centralizado a diversos modelos de IA.
- Uma única assinatura para acessar diferentes provedores.
- Administração de pessoas, empresas e usuários.
- Gestão completa de planos e assinaturas.
- Controle de créditos.
- Controle de consumo de tokens.
- Histórico de utilização.
- Monitoramento operacional.
- API única para integração com sistemas externos.
- Interface moderna, intuitiva e responsiva.

---

# 6. Principais Funcionalidades

## Administração

- Dashboard
- Empresas
- Usuários
- Clientes
- Perfis de acesso
- Configurações

## Inteligência Artificial

- Provedores
- Modelos
- Chat
- Controle de Tokens
- Monitoramento de Consumo
- API Keys

## Comercial

- Planos
- Assinaturas
- Créditos
- Cobranças
- Relatórios

## Plataforma

- API REST
- Auditoria
- Logs
- Segurança
- Multi-Tenant

---

# 7. Diferenciais

- Plataforma Multi-Tenant.
- Arquitetura modular.
- Suporte a múltiplos provedores de IA.
- API única para integração.
- Controle centralizado de consumo.
- Gestão comercial integrada.
- Interface moderna e responsiva.
- Escalável.
- Preparada para aplicativo Flutter.
- Atende usuários individuais, empresas e sistemas corporativos.
- Base tecnológica para soluções como o Veltis Workspace.

---

# 8. Tecnologias

## Backend

- ASP.NET Core 8
- C#
- Entity Framework Core
- PostgreSQL

## Frontend

- ASP.NET Core MVC
- Bootstrap 5
- Bootstrap Icons
- Chart.js
- SweetAlert2
- DataTables
- Select2

## Mobile

- Flutter (planejado)

## Controle de Código

- Git
- GitHub

---

# 9. Arquitetura

O projeto utiliza uma arquitetura em camadas, separando claramente domínio, aplicação, infraestrutura e apresentação.

Estrutura principal:

```text
src/

├── VeltisAI.Domain
├── VeltisAI.Application
├── VeltisAI.Infrastructure
├── VeltisAI.Web
└── VeltisAI.API
```

Essa arquitetura facilita manutenção, testes, escalabilidade e reutilização da plataforma.

---

# 10. Visão de Longo Prazo

O objetivo é transformar o Veltis AI Platform em uma infraestrutura completa para comercialização, gerenciamento e distribuição de Inteligência Artificial.

Entre as evoluções previstas estão:

- Integração com novos provedores.
- API pública para parceiros.
- Aplicativo Flutter.
- Painéis analíticos avançados.
- Sistema automatizado de cobrança.
- Webhooks.
- Monitoramento operacional em tempo real.
- Integração com ERP, CRM e plataformas SaaS.
- Expansão internacional.

---

# 11. Status do Projeto

O projeto encontra-se em desenvolvimento da infraestrutura principal.

## Já implementado

- Estrutura da solução.
- Arquitetura em camadas.
- PostgreSQL.
- Entity Framework Core.
- ASP.NET Identity.
- Controle de versão com GitHub.
- Módulo de Empresas.
- Módulo de Clientes.
- Módulo de Planos.
- Dashboard Administrativo inicial.

## Próximas Etapas

- Assinaturas.
- Créditos.
- Provedores de IA.
- Modelos de IA.
- Controle de Consumo.
- API REST.
- Cobrança.
- Aplicativo Flutter.

---

# Controle de Revisões

| Versão | Data | Descrição |
|---------|------|-----------|
| 1.0 | Junho/2026 | Criação inicial da Visão do Produto |
| 1.1 | Julho/2026 | Revisão completa alinhando o Veltis AI Platform como infraestrutura para acesso, gerenciamento e comercialização de Inteligência Artificial para pessoas, empresas e sistemas. |