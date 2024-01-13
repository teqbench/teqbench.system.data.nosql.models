# System Data NoSql Models

![Build Status Badge](.badges/build-status.svg) ![Build Number Badge](.badges/build-number.svg) ![Coverage](.badges/code-coverage.svg)

## Overview
Base interface for a repository document model.

## Contents
- [Developer Environment Setup](#Developer+Environment+Setup)
- [Usage](#Usage)
- [License](#License)

## Developer Environment Setup

### General
- [Branching Strategy & Practices](https://github.com/teqbench/teqbench.docs/wiki/Branching-Strategy)

### .NET
- [General Tooling](https://github.com/teqbench/teqbench.docs/wiki/.NET-General-Tooling)
- [Configurations](https://github.com/teqbench/teqbench.docs/wiki/.NET-Configuration-Standards)
- [Coding Standards](https://github.com/teqbench/teqbench.docs/wiki/.NET-Coding-Standards)
- [Solutions](https://github.com/teqbench/teqbench.docs/wiki/.NET-Solutions)
- [Projects](https://github.com/teqbench/teqbench.docs/wiki/.NET-Projects)
- [Building](https://github.com/teqbench/teqbench.docs/wiki/.NET-Build-Process)
- [Packing & Deploying NuGet Package](#)
- [Versioning](https://github.com/teqbench/teqbench.docs/wiki/.NET-Versioning-Standards)

## Usage

### Add NuGet Package To Project

```
dotnet add package TeqBench.System.Data.NoSql.Models
```

### Update Source Code

> [!NOTE]
> For complete usage, see [TeqBench.System.Data.NoSql.MongoDB.Models](https://github.com/teqbench/teqbench.system.data.nosql.mongodb.models)

```csharp
/// <summary>
/// Base document interface for MongoDB repository implementation.
/// </summary>
public interface IDocument : IDocument<string>
{
    // Note, using the generic IDocument interface from TeqBench.System.Data.NoSql.Models allows
    // the implementing interface/class to specific a different data type for the Id property.
}

/// <summary>
/// Base (abstract) document implementation for MongoDB repository implementation.
/// </summary>
public abstract class Document : IDocument
{
    /// <summary>
    /// Unique document identifier; to be assigned by database when document is created.
    /// </summary>
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
}
```

## Licensing

[License](https://github.com/teqbench/teqbench.docs/wiki/License)
