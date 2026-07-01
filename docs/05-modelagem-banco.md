# Veltis AI Platform

## Documento 05 – Modelo de Domínio

**Versão:** 1.0  
**Data:** Julho/2026  
**Status:** Em Desenvolvimento

---

# 1. Objetivo

Este documento define o modelo de domínio do Veltis AI Platform.

O objetivo é estabelecer os principais conceitos de negócio da plataforma antes da modelagem definitiva do banco de dados e da implementação das entidades no código.

Este documento responde perguntas fundamentais como:

- Quem contrata a plataforma?
- Quem utiliza a plataforma?
- Quem possui assinatura?
- Quem possui créditos?
- Quem consome Inteligência Artificial?
- Como pessoas físicas e empresas serão representadas?
- Como sistemas externos poderão consumir a plataforma?

---

# 2. Princípio Central

O Veltis AI Platform será centrado no conceito de **Account**.

A Account representa a conta contratante da plataforma.

Uma Account pode representar:

- Uma pessoa física.
- Uma empresa.
- Um sistema ou aplicação externa.

Todas as principais operações da plataforma estarão vinculadas a uma Account.

---

# 3. Conceito de Account

## Definição

A **Account** representa a unidade principal de contratação, cobrança, consumo e isolamento lógico da plataforma.

Ela é o centro do domínio do Veltis AI.

## Responsabilidades

Uma Account possui:

- Usuários.
- Assinaturas.
- Créditos.
- Histórico de consumo.
- Conversas.
- API Keys.
- Faturas.
- Configurações.

## Tipos de Account

Tipos iniciais:

- Individual
- Company
- System

## Exemplos

### Conta Individual

Um profissional autônomo contrata um plano para acessar diversos provedores de IA em uma única plataforma.

### Conta Empresa

Uma empresa contrata um plano para que vários usuários internos acessem e consumam IA.

### Conta Sistema

Um sistema externo, como ERP, CRM ou Veltis Workspace, consome a API do Veltis AI.

---

# 4. Account x Company

A entidade **Company** não deve ser o centro da plataforma.

Company representa dados empresariais vinculados a uma Account do tipo Company.

Exemplo:

```text
Account
 └── CompanyProfile