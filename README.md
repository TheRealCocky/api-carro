# 🚗 CRUD de Carros — ASP.NET Core Web API

API RESTful simples para gerenciar uma lista de carros. Criado com C# e ASP.NET Core, ideal para aprender conceitos de CRUD, REST e Entity Framework Core.

<div align="center">
  <img src="https://img.shields.io/badge/.NET-6.0-blueviolet?style=flat-square&logo=.net" />
  <img src="https://img.shields.io/badge/EF--Core-ORM-green?style=flat-square" />
  <img src="https://img.shields.io/badge/Status-Em%20Desenvolvimento-yellow?style=flat-square" />
</div>

---

## 📌 Funcionalidades

- ✅ Criar um novo carro
- 🔍 Listar todos os carros
- 📄 Visualizar detalhes de um carro
- ✏️ Atualizar informações de um carro
- ❌ Deletar um carro

---

## 🧱 Tecnologias Utilizadas

| Tecnologia           | Descrição                                 |
|----------------------|---------------------------------------------|
| ASP.NET Core         | Framework para construção da API           |
| Entity Framework Core| ORM para acesso ao banco de dados          |
| SQL Server / SQLite  | Banco de dados relacional                  |
| Swagger              | Documentação e testes das rotas da API     |
| C#                   | Linguagem de programação principal         |

---

## 🧑‍💻 Como rodar localmente

### Pré-requisitos

- [.NET 6 ou superior](https://dotnet.microsoft.com/en-us/download)
- Banco de dados (SQL Server ou SQLite)

### Passo a passo

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/seu-repositorio.git

# Acesse a pasta do projeto
cd seu-repositorio

# Restaure os pacotes
dotnet restore

# Atualize o banco de dados com EF Core
dotnet ef database update

# Rode o projeto
dotnet run
