# AgroSolutions MVP
Esta é uma API robusta desenvolvida para a plataforma AgroSolutions, focada em fornecer serviços backend para o setor agrícola. O projeto foi arquitetado seguindo boas práticas de desenvolvimento, conteinerização com Docker e uma esteira de deploy contínuo (CD) automatizada para o MiniKube EKS

## 🚀 Tecnologias Utilizadas

Linguagem: .NET Core / C#

Containerização: Docker

Cloud Provider: AWS (Amazon Web Services)

Orquestração: Kubernetes (Amazon EKS)

Registro de Imagens: Amazon ECR (Elastic Container Registry)

CI/CD: GitHub Actions

Banco de Dados: SQL Server (ou o banco configurado via ConnectionString)

## 🏗️ Arquitetura de Deploy (CI/CD)

O projeto conta com uma esteira de automação no GitHub Actions que realiza os seguintes passos a cada push na branch master:

Checkout: Coleta a versão mais recente do código.

AWS Auth: Autentica no ambiente AWS usando Secrets do GitHub.

Docker Build & Push: Gera a imagem Docker da API e a envia para o Amazon ECR.

Kubernetes Config: Configura o contexto do kubectl para o cluster EKS.

Secrets Management: Atualiza os segredos do Kubernetes (Connection Strings e URIs).

Rolling Update: Atualiza o Deployment no EKS, garantindo que a nova versão suba sem derrubar o serviço (Zero Downtime).

📦 Como rodar localmente (Docker)

Certifique-se de ter o Docker instalado e execute:
```
# Build da imagem
docker build -t agrosolutions-api .

# Rodar o container
docker run -d -p 8080:80 --name agrosolutions-api agrosolutions-api
```

## ☸️ Deploy no Kubernetes

Os manifestos necessários para o deploy estão localizados na pasta /k8s. Para aplicar manualmente:
```
# Aplicar configurações de Deployment e Service
kubectl apply -f k8s/deployment.yaml
kubectl apply -f k8s/service.yaml
```
