# External Database Execute — OutSystems O11

<div align="center">

[![OutSystems Forge](https://img.shields.io/badge/OutSystems%20Forge-External%20Database%20Execute-red?style=for-the-badge&logo=outsystems&logoColor=white)](https://www.outsystems.com/forge/component-overview/16303/external-database-execute-o11)
[![Platform](https://img.shields.io/badge/Platform-OutSystems%20O11-red?style=for-the-badge&logo=outsystems&logoColor=white)](https://www.outsystems.com)
[![Language](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-BSD--3--Clause-blue?style=for-the-badge)](https://opensource.org/licenses/BSD-3-Clause)
[![Version](https://img.shields.io/badge/Version-1.0.0-brightgreen?style=for-the-badge)](https://github.com/edsoncms/O11_ExternalDatabaseExec/releases)

</div>

---

## 🇺🇸 English

### Overview

**External Database Execute** is an OutSystems O11 Extension that enables the execution of SQL commands — `INSERT`, `UPDATE`, `DELETE` — and queries returning results in JSON format, directly against external databases configured in **Service Center's Database Connections**.

This component eliminates the need for the native SQL conversion normally required through OutSystems' **Advanced SQL** element, providing a simpler and more direct way to interact with external databases mapped in the platform.

### ✨ Features

- ✅ Execute **SQL commands** (INSERT, UPDATE, DELETE) on external databases
- ✅ Execute **queries** and retrieve results in **JSON** format
- ✅ Works with any **Database Connection** configured in Service Center
- ✅ No need for the traditional Advanced SQL conversion
- ✅ Lightweight and easy to integrate into any OutSystems O11 application

### 📦 Installation

Install directly from the **OutSystems Forge**:

> 🔗 [**External Database Execute (O11) — OutSystems Forge**](https://www.outsystems.com/forge/component-overview/16303/external-database-execute-o11)

1. Click the link above to open the component on the OutSystems Forge.
2. Click **Install** to add it to your OutSystems O11 environment.
3. After installation, the extension will be available in **Integration Studio** and ready to use in your applications.

### 🗂️ Repository Structure

```
O11_ExternalDatabaseExec/
├── ExternalDatabaseExec/       # Extension project files
├── Source/NET/                 # C# source code (.NET)
├── Templates/NET/              # .NET project templates
├── External Database Execute.oap   # OutSystems Application Package
├── ExternalDatabaseExec.xif        # Extension Interface File (Integration Studio)
├── DBlogoPNG.png               # Extension logo (PNG)
└── DBlogoICO.ico               # Extension icon (ICO)
```

### 🔧 Prerequisites

- OutSystems Platform **version 11 (O11)**
- A **Database Connection** configured in Service Center pointing to your external database
- Proper database credentials and network access from the OutSystems environment to the external database

### 🚀 How to Use

1. **Install** the component from the Forge (see Installation above).
2. **Reference** the `ExternalDatabaseExec` extension in your OutSystems application.
3. **Configure** your external database connection in Service Center (**Administration → Database Connections**).
4. **Call** the extension actions in your logic flows:
   - Use the **Execute** action for `INSERT`, `UPDATE`, and `DELETE` commands.
   - Use the **Query** action to retrieve data as JSON from the external database.

### 🗄️ Supported Databases

Any database supported by OutSystems Database Connections, including:

- Microsoft SQL Server
- Oracle
- MySQL
- PostgreSQL
- iDB2 (IBM)

### 📄 License

This project is licensed under the **BSD 3-Clause License**.
See the full license text at: [https://opensource.org/licenses/BSD-3-Clause](https://opensource.org/licenses/BSD-3-Clause)

---

---

## 🇧🇷 Português

### Visão Geral

**External Database Execute** é uma Extension para OutSystems O11 que permite a execução de comandos SQL — `INSERT`, `UPDATE`, `DELETE` — e de consultas com retorno em JSON, diretamente nas bases de dados externas configuradas nas **Database Connections do Service Center**.

Este componente elimina a necessidade da conversão SQL nativa normalmente exigida pelo elemento **Advanced SQL** do OutSystems, oferecendo uma maneira mais simples e direta de interagir com bancos de dados externos mapeados na plataforma.

### ✨ Funcionalidades

- ✅ Execução de **comandos SQL** (INSERT, UPDATE, DELETE) em bases externas
- ✅ Execução de **consultas** com retorno em formato **JSON**
- ✅ Compatível com qualquer **Database Connection** configurada no Service Center
- ✅ Sem necessidade da conversão tradicional via Advanced SQL
- ✅ Leve e fácil de integrar em qualquer aplicação OutSystems O11

### 📦 Instalação

Instale diretamente pelo **OutSystems Forge**:

> 🔗 [**External Database Execute (O11) — OutSystems Forge**](https://www.outsystems.com/forge/component-overview/16303/external-database-execute-o11)

1. Clique no link acima para abrir o componente no OutSystems Forge.
2. Clique em **Install** para adicionar ao seu ambiente OutSystems O11.
3. Após a instalação, a extension estará disponível no **Integration Studio** e pronta para uso em suas aplicações.

### 🗂️ Estrutura do Repositório

```
O11_ExternalDatabaseExec/
├── ExternalDatabaseExec/       # Arquivos do projeto da Extension
├── Source/NET/                 # Código-fonte C# (.NET)
├── Templates/NET/              # Templates do projeto .NET
├── External Database Execute.oap   # Pacote de Aplicação OutSystems
├── ExternalDatabaseExec.xif        # Arquivo de Interface da Extension (Integration Studio)
├── DBlogoPNG.png               # Logo da Extension (PNG)
└── DBlogoICO.ico               # Ícone da Extension (ICO)
```

### 🔧 Pré-requisitos

- Plataforma OutSystems **versão 11 (O11)**
- Uma **Database Connection** configurada no Service Center apontando para o banco de dados externo
- Credenciais e acesso de rede do ambiente OutSystems até o banco de dados externo

### 🚀 Como Utilizar

1. **Instale** o componente pelo Forge (veja Instalação acima).
2. **Referencie** a extension `ExternalDatabaseExec` na sua aplicação OutSystems.
3. **Configure** a conexão de banco de dados externo no Service Center (**Administration → Database Connections**).
4. **Chame** as actions da extension nos seus fluxos de lógica:
   - Use a action **Execute** para comandos `INSERT`, `UPDATE` e `DELETE`.
   - Use a action **Query** para recuperar dados como JSON do banco de dados externo.

### 🗄️ Bancos de Dados Suportados

Qualquer banco de dados suportado pelas Database Connections do OutSystems, incluindo:

- Microsoft SQL Server
- Oracle
- MySQL
- PostgreSQL
- iDB2 (IBM)

### 📄 Licença

Este projeto está licenciado sob a **Licença BSD 3-Clause**.
Consulte o texto completo da licença em: [https://opensource.org/licenses/BSD-3-Clause](https://opensource.org/licenses/BSD-3-Clause)

---

<div align="center">

Made with ❤️ for the OutSystems Community

[![OutSystems Forge](https://img.shields.io/badge/Install%20from-OutSystems%20Forge-red?style=for-the-badge&logo=outsystems&logoColor=white)](https://www.outsystems.com/forge/component-overview/16303/external-database-execute-o11)

</div>
