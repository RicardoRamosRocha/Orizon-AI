# Veltis AI Platform

## Documento 02 – Requisitos do Sistema

**Versão:** 1.0
**Data:** Junho/2026
**Status:** Em Desenvolvimento

---

# 1. Objetivo

Este documento define os requisitos funcionais e não funcionais do Veltis AI Platform, servindo como referência para o desenvolvimento, testes e evolução da plataforma.

---

# 2. Requisitos Funcionais

## RF001 – Autenticação

O sistema deve permitir:

* Login por e-mail e senha.
* Logout.
* Recuperação de senha.
* Alteração de senha.
* Confirmação de e-mail.
* Controle de sessão.

---

## RF002 – Empresas

O sistema deve permitir:

* Cadastrar empresas.
* Editar empresas.
* Excluir empresas (quando permitido).
* Ativar/Inativar empresas.
* Pesquisar empresas.
* Visualizar detalhes da empresa.

Cada empresa será um tenant da plataforma.

---

## RF003 – Usuários

O sistema deve permitir:

* Cadastro de usuários.
* Associação à empresa.
* Associação a perfis de acesso.
* Bloqueio e desbloqueio.
* Alteração de senha.
* Controle de permissões.

---

## RF004 – Perfis de Acesso

Perfis iniciais:

* Administrador
* Gestor
* Operador
* Cliente

Cada perfil possuirá permissões específicas.

---

## RF005 – Clientes

O sistema deve permitir:

* Cadastro.
* Alteração.
* Exclusão lógica.
* Consulta.
* Pesquisa.
* Associação à empresa.

---

## RF006 – Planos

O sistema deve permitir:

* Cadastro de planos.
* Definição do valor mensal.
* Definição de créditos.
* Limite de usuários.
* Limite mensal de tokens.
* Ativação e desativação.

---

## RF007 – Assinaturas

O sistema deve permitir:

* Criar assinatura.
* Renovar assinatura.
* Cancelar assinatura.
* Suspender assinatura.
* Histórico de alterações.

---

## RF008 – Créditos

O sistema deve permitir:

* Adicionar créditos.
* Debitar créditos.
* Histórico de movimentações.
* Saldo disponível.

---

## RF009 – Provedores de IA

O sistema deverá permitir cadastrar múltiplos provedores, como:

* OpenAI
* Anthropic
* Google Gemini
* Grok
* DeepSeek
* Outros provedores compatíveis

Cada provedor poderá possuir diferentes modelos e configurações.

---

## RF010 – Modelos de IA

Cada provedor poderá possuir:

* Nome do modelo.
* Identificador.
* Limite de contexto.
* Valor por token.
* Status.
* Configurações específicas.

---

## RF011 – Chat

O sistema deverá permitir:

* Criar conversas.
* Histórico.
* Contexto.
* Mensagens.
* Exclusão.
* Exportação.

---

## RF012 – Controle de Consumo

O sistema deverá controlar:

* Tokens enviados.
* Tokens recebidos.
* Valor consumido.
* Créditos utilizados.
* Histórico por usuário.
* Histórico por empresa.

---

## RF013 – Financeiro

O sistema deverá permitir:

* Emissão de faturas.
* Controle de pagamentos.
* Histórico financeiro.
* Assinaturas.
* Créditos.

---

## RF014 – Dashboard

O painel administrativo deverá apresentar indicadores como:

* Empresas cadastradas.
* Clientes ativos.
* Assinaturas.
* Consumo de IA.
* Créditos disponíveis.
* Receita mensal.
* Alertas operacionais.

---

## RF015 – API

O sistema disponibilizará API REST para:

* Autenticação.
* Empresas.
* Clientes.
* Chats.
* Créditos.
* Consumo.
* Integrações externas.

---

# 3. Requisitos Não Funcionais

## RNF001 – Plataforma

* ASP.NET Core 8
* Entity Framework Core
* PostgreSQL

---

## RNF002 – Interface

* Responsiva.
* Compatível com desktop, tablet e smartphone.
* Bootstrap 5.

---

## RNF003 – Segurança

* ASP.NET Identity.
* Hash de senhas.
* Autorização baseada em papéis.
* HTTPS.
* Proteção contra CSRF.

---

## RNF004 – Performance

* Paginação.
* Consultas otimizadas.
* Cache onde necessário.
* Índices no banco de dados.

---

## RNF005 – Escalabilidade

Arquitetura preparada para:

* Novos módulos.
* Novos provedores de IA.
* Aplicativo Flutter.
* API pública.

---

## RNF006 – Auditoria

Registrar:

* Login.
* Logout.
* Alterações de cadastro.
* Exclusões.
* Consumo de IA.
* Alterações financeiras.

---

# 4. Regras de Negócio

* Cada usuário pertence a apenas uma empresa.
* Cada empresa pode possuir vários usuários.
* Cada assinatura está vinculada a um plano.
* Créditos não podem ficar negativos.
* Todo consumo de IA gera registro de utilização.
* Somente administradores podem alterar configurações globais.
* Toda alteração crítica deverá gerar registro de auditoria.

---

# 5. Critérios de Qualidade

O sistema deverá ser:

* Seguro.
* Escalável.
* Modular.
* Responsivo.
* Testável.
* Documentado.
* Versionado no GitHub.

---

# Controle de Revisões

| Versão | Data       | Descrição                                 |
| ------ | ---------- | ----------------------------------------- |
| 1.0    | Junho/2026 | Criação inicial dos requisitos do sistema |
