# 📌 CPFValidoAPI

API simples para validar números de CPF conforme as regras brasileiras.

**API está disponível para teste:**
```sh
https://validarcpf-api.onrender.com/api/cpf/validar?cpf=12345678909

Basta mudar o valor do parâmetro e usar
```

## 🚀 Tecnologias Utilizadas
- .NET 8
- ASP.NET Core
- C#
- Docker

## 📂 Estrutura do Projeto
```
/CPFValidoAPI
│── Controllers
│   ├── CpfController.cs
│── Services
│   ├── ICpfService.cs
│   ├── CpfService.cs
```

## 🔧 Configuração e Execução

### 1️⃣ Clonar o Repositório
```sh
git clone https://github.com/seu-usuario/CPFValidoAPI.git
cd CPFValidoAPI
```

## 📌 Endpoints Disponíveis

### ✅ Validar um CPF
**Rota:** `GET /api/cpf/validar`

**Parâmetros:**
- `cpf` (query param) - Número do CPF a ser validado

**Exemplo de Requisição:**
```sh
GET http://localhost:8080/api/cpf/validar?cpf=12345678909
```
ou
```sh
GET http://localhost:8080/api/cpf/validar?cpf=123.456.789-09
```

**Exemplo de Resposta:**
```json
{
  "valido": true
}
```

```json
{
  "valido": false
}
```
