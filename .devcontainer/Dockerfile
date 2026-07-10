FROM mcr.microsoft.com/devcontainers/dotnet:1-8.0-bookworm

USER root

RUN rm -f /etc/apt/sources.list.d/yarn.list \
 && rm -f /usr/share/keyrings/yarnkey.gpg || true

RUN apt-get update \
 && apt-get install -y --no-install-recommends \
    postgresql-client \
    git \
    curl \
    jq \
    ca-certificates

USER vscode