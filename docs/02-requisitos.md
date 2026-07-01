# Veltis AI Platform

## Documento 02 – Requisitos do Sistema

**Versão:** 1.1  
**Data:** Julho/2026  
**Status:** Em Desenvolvimento

---

# 1. Objetivo

Este documento define os requisitos funcionais e não funcionais do Veltis AI Platform, servindo como referência para o desenvolvimento, testes, implantação e evolução da plataforma.

---

# 2. Requisitos Funcionais

## RF001 – Autenticação

O sistema deve permitir:

- Login por e-mail e senha.
- Logout.
- Recuperação de senha.
- Alteração de senha.
- Confirmação de e-mail.
- Controle de sessão.
- Autenticação para contas individuais e empresariais.

---

## RF002 – Empresas

O sistema deve permitir:

- Cadastrar empresas.
- Editar empresas.
- Ativar/Inativar empresas.
- Pesquisar empresas.
- Visualizar detalhes.
- Controlar assinatura da empresa.

Cada empresa representa um tenant da plataforma.

---

## RF003 – Usuários

O sistema deve permitir:

- Cadastro de usuários.
- Associação a uma conta individual ou empresa.
- Associação a perfis de acesso.
- Bloqueio e desbloqueio.
- Alteração de senha.
- Controle de permissões.

---

## RF004 – Perfis de Acesso

Perfis iniciais:

- Administrador
- Gestor
- Operador
- Cliente

Cada perfil possuirá permissões específicas.

---

## RF005 – Clientes

O sistema deve permitir:

- Cadastro.
- Alteração.
- Exclusão lógica.
- Consulta.
- Pesquisa.
- Associação à empresa quando aplicável.

---

## RF006 – Planos

O sistema deve permitir:

- Cadastro de planos.
- Valor mensal.
- Créditos inclusos.
- Limite de usuários.
- Limite mensal de tokens.
- Ativação e desativação.

---

## RF007 – Assinaturas

O sistema deve permitir:

- Criar assinatura.
- Renovar assinatura.
- Cancelar assinatura.
- Suspender assinatura.
- Histórico de alterações.

---

## RF008 – Créditos

O sistema deve permitir:

- Adicionar créditos.
- Debitar créditos.
- Consultar saldo.
- Histórico completo das movimentações.

---

## RF009 – Provedores de IA

O sistema deverá permitir:

- Cadastro de provedores.
- API Key.
- Endpoint.
- Status.
- Configurações.
- Ativação e desativação.

Exemplos:

- OpenAI
- Anthropic
- Google Gemini
- Grok
- DeepSeek
- Outros provedores compatíveis.

---

## RF010 – Modelos de IA

Cada modelo deverá possuir:

- Nome.
- Identificador.
- Provedor.
- Janela de contexto.
- Valor por token de entrada.
- Valor por token de saída.
- Status.
- Configurações específicas.

---

## RF011 – Chat

O sistema deverá permitir:

- Criar conversas.
- Histórico.
- Mensagens.
- Exclusão.
- Exportação.

---

## RF012 – Controle de Consumo

O sistema deverá registrar:

- Tokens enviados.
- Tokens recebidos.
- Modelo utilizado.
- Provedor utilizado.
- Valor consumido.
- Créditos utilizados.
- Usuário responsável.
- Empresa responsável quando aplicável.
- Data e horário.

---

## RF013 – Financeiro

O sistema deverá permitir:

- Emissão de faturas.
- Controle de pagamentos.
- Histórico financeiro.
- Assinaturas.
- Créditos.

---

## RF014 – Dashboard

O painel administrativo deverá apresentar indicadores como:

- Empresas cadastradas.
- Clientes ativos.
- Assinaturas.
- Consumo de IA.
- Créditos disponíveis.
- Receita mensal.
- Alertas operacionais.

---

## RF015 – API

O sistema disponibilizará API REST para:

- Autenticação.
- Empresas.
- Clientes.
- Usuários.
- Chats.
- Créditos.
- Consumo.
- API Keys.
- Integrações externas.

---

# 3. Requisitos Não Funcionais

## RNF001 – Plataforma

- ASP.NET Core 8.
- Entity Framework Core.
- PostgreSQL.

---

## RNF002 – Interface

- Responsiva.
- Compatível com desktop, tablet e smartphone.
- Bootstrap 5.

---

## RNF003 – Segurança

- ASP.NET Identity.
- Hash de senhas.
- Autorização baseada em papéis.
- HTTPS.
- Proteção contra CSRF.

---

## RNF004 – Performance

- Paginação.
- Consultas otimizadas.
- Cache onde necessário.
- Índices no banco de dados.

---

## RNF005 – Escalabilidade

Arquitetura preparada para:

- Novos módulos.
- Novos provedores de IA.
- Aplicativo Flutter.
- API pública.
- Integração com outras plataformas.

---

## RNF006 – Auditoria

Registrar:

- Login.
- Logout.
- Alterações cadastrais.
- Exclusões.
- Consumo de IA.
- Alterações financeiras.
- Alterações administrativas.

---

# 4. Regras de Negócio

- Cada usuário pertence a uma única conta (individual ou empresa).
- Cada empresa pode possuir vários usuários.
- Cada assinatura está vinculada a um plano.
- Créditos não podem ficar negativos.
- Todo consumo de IA gera registro de utilização.
- Somente administradores podem alterar configurações globais.
- Toda alteração crítica deverá gerar registro de auditoria.

---

# 5. Critérios de Qualidade

O sistema deverá ser:

- Seguro.
- Escalável.
- Modular.
- Responsivo.
- Testável.
- Documentado.
- Versionado no GitHub.

---

# Controle de Revisões

| Versão | Data | Descrição |
|---------|------|-----------|
| 1.0 | Junho/2026 | Criação inicial dos requisitos do sistema |
| 1.1 | Julho/2026 | Revisão dos requisitos alinhando o produto ao conceito de plataforma de infraestrutura para Inteligência Artificial, contemplando pessoas, empresas e integrações via API. |