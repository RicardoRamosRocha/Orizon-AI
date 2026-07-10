#!/usr/bin/env bash

set -euo pipefail

echo "========================================"
echo "Orizon AI - Configuração do ambiente"
echo "========================================"

echo
echo "1. Validando .NET..."
dotnet --version
dotnet --info

echo
echo "2. Instalando ou atualizando dotnet-ef..."

if dotnet tool list --global | grep -q "dotnet-ef"; then
    dotnet tool update --global dotnet-ef --version 8.*
else
    dotnet tool install --global dotnet-ef --version 8.*
fi

export PATH="$PATH:/home/vscode/.dotnet/tools"

echo
echo "3. Validando EF Core Tools..."
dotnet ef --version

echo
echo "4. Restaurando dependências..."
dotnet restore

echo
echo "5. Aguardando PostgreSQL..."

until pg_isready \
    -h postgres \
    -p 5432 \
    -U orizon_user \
    -d orizon_ai
do
    sleep 2
done

echo
echo "PostgreSQL disponível."

echo
echo "6. Compilando solução..."
dotnet build --no-restore

echo
echo "========================================"
echo "Ambiente Orizon AI configurado."
echo "========================================"