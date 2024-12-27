# SwaggerDoc

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![.NET 6.0](https://img.shields.io/badge/.NET-6.0-blueviolet.svg)](https://dotnet.microsoft.com/download/dotnet/6.0)
[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-green.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)

## 🌟 项目简介

**SwaggerDoc** 是一款基于 C# 开发的轻量级工具，专注于生成、管理和展示基于 Swagger 规范的 API 文档。它帮助开发者快速生成高质量的文档，支持 Markdown 格式的输出，易于集成到各种 .NET 项目中，并可扩展为离线 PDF 文档。

---

## 🚀 核心功能

- **支持 Swagger 和 OpenAPI 规范**。
- **生成 Markdown 格式文档**，便于离线保存和分享。
- **高度集成**：轻松嵌入 .NET 项目中。
- **定制化文档生成**：支持自定义 XML 描述、枚举过滤器和文档样式。

---

## 🛠️ 安装与配置

### 环境要求

- **.NET 6.0 或 .NET 8.0**。
- 操作系统：Windows 或其他支持 .NET 的平台。

### 安装方法

通过 NuGet 安装 SwaggerDoc 包：

```bash
dotnet add package SwaggerDoc --version 8.0.1
```

---

## ⚙️ 配置步骤

### 1. 注册 SwaggerDoc 服务

在 `Startup.cs` 文件中添加以下代码，用于生成 Markdown 文档：

```csharp
services.AddSwaggerDoc(); // 注册 SwaggerDoc 服务
```

---

### 2. 注册 Swagger 服务

在 `Startup.cs` 文件中配置 Swagger 服务。**注意**：项目需开启 XML 文档生成。

1. 打开项目的属性，勾选“生成 XML 文档文件”，指定文件名为 `Samples.xml`。
2. 在服务中添加 SwaggerGen 配置：

```csharp
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo 
    {
        Title = "Swagger API 文档", 
        Version = "v1", 
        Description = "自动生成的 API 文档"
    });

    // 添加枚举过滤器，显示枚举的描述信息
    c.DocumentFilter<SwaggerEnumFilter>(new object[]
    {
        // 枚举所在的程序集
        new[] { Assembly.GetExecutingAssembly() }
    });

    // 引入 XML 注释
    c.IncludeXmlComments("Samples.xml");
});
```

---

### 3. 添加 Swagger 中间件

在 `Startup.cs` 文件的 `Configure` 方法中添加以下代码：

```csharp
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Samples v1"));
```

---

### 4. 生成 Markdown 文档

访问以下路径以生成 Markdown 文档：

```
https://{localhost}:{port}/doc?swaggerVersion={swaggerVersion}
```

- **swaggerVersion**：Swagger 文档版本（与 `SwaggerGen` 中的 `Version` 参数一致，默认为 `v1`）。

---

## 📝 示例展示

以下是生成的 Markdown 和 PDF 示例。

### Swagger 文档示例

![API 示例](Docs/Images/api.png?raw=true)

---

### 离线 PDF 示例

使用 [Typora](https://typora.io/) 编辑器，结合 [pandoc](https://github.com/jgm/pandoc/releases) 插件，将 Markdown 转换为 PDF 文档：

![Swagger PDF 示例](Docs/Images/swagger.png?raw=true)

---

## 🌈 样式调整

如果需要修改 Markdown 样式，可以参考 [Typora 官方主题库](https://theme.typora.io/) 下载自定义主题文件。

---

## 🤝 贡献指南

欢迎参与本项目开发！贡献方式如下：

1. Fork 本项目。
2. 创建特性分支：
   ```bash
   git checkout -b feature/你的功能描述
   ```
3. 提交更改：
   ```bash
   git commit -m "添加了新功能"
   ```
4. 推送到你的分支：
   ```bash
   git push origin feature/你的功能描述
   ```
5. 发起 Pull Request。

详细说明请参考 [CONTRIBUTING.md](CONTRIBUTING.md)。

---

## 📄 开源协议

本项目采用 [MIT License](LICENSE) 进行授权，允许用户自由使用、修改和分发。

---

## 📬 联系方式

- 提交 Issue：[GitHub Issues](https://github.com/liuweichaox/SwaggerDoc/issues)
- 邮箱：[liuweichaox@gmail.com](mailto:liuweichaox@gmail.com)

---

Made with ❤️ by [liuweichaox](https://github.com/liuweichaox)
```