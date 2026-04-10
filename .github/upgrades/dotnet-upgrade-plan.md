# .NET 8.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 8.0 upgrade.
3. Upgrade `Coldairarrow.Util\01.Coldairarrow.Util.csproj`
4. Upgrade `Coldairarrow.DataRepository\02.Coldairarrow.DataRepository.csproj`
5. Upgrade `Coldairarrow.Entity\03.Coldairarrow.Entity.csproj`
6. Upgrade `Coldairarrow.Business\04.Coldairarrow.Business.csproj`
7. Upgrade `Coldairarrow.Console\06.Coldairarrow.ConsoleApp.csproj`
8. Upgrade `Coldairarrow.Web\05.Coldairarrow.Web.csproj`
9. Upgrade `Coldairarrow.UnitTests\10.Coldairarrow.UnitTests.csproj`

## Settings

This section contains settings and data used by execution steps.

### Excluded projects

Table below contains projects that belong to the dependency graph for selected projects and should not be included in the upgrade.

| Project name                                   | Description                 |
|:-----------------------------------------------|:---------------------------:|
| None                                           | No projects excluded        |

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                                 | Current Version(s) | New Version | Description                                   |
|:---------------------------------------------|:------------------:|:-----------:|:----------------------------------------------|
| AutoMapper                                   | 6.2.2              | 16.1.1      | Security vulnerability — update to secure version |
| EPPlus                                       | 4.5.1              | 8.5.1       | Deprecated old version — replace with latest   |
| Microsoft.AspNetCore.App                      | (framework ref)    |             | Functionality is included with new framework reference (remove explicit package) |
| Microsoft.EntityFrameworkCore                | 2.1.3              | 8.0.25      | Major framework upgrade required for EF Core 8 |
| Microsoft.EntityFrameworkCore.SqlServer      | 2.1.3              | 8.0.25      | Major framework upgrade required for EF Core SQL Server provider |
| Microsoft.Extensions.Caching.Memory          | 2.1.2              | 8.0.1       | Update to assembly compatible with .NET 8     |
| Microsoft.Extensions.Configuration           | 2.1.1              | 8.0.0       | Update to assembly compatible with .NET 8     |
| Microsoft.Extensions.Configuration.Json      | 2.1.1              | 8.0.1       | Update to assembly compatible with .NET 8     |
| Microsoft.Extensions.Primitives              | 2.1.1              | 8.0.0       | Update to assembly compatible with .NET 8     |
| Microsoft.VisualStudio.Web.CodeGeneration.Design | 2.1.4           | 8.0.23      | Update code generation tooling to supported version |
| Newtonsoft.Json                               | 11.0.2             | 13.0.4      | Security vulnerability — update to secure version |
| Npgsql                                        | 4.0.3              | 10.0.2      | Security vulnerability — update to secure version |
| Pomelo.EntityFrameworkCore.MySql              | 2.1.2              | 9.0.0       | Deprecated — replace with Pomelo 9.0.0 compatible with EF Core 8 |
| System.Configuration.ConfigurationManager    | 4.4.1              | 8.0.1       | Update to assembly compatible with .NET 8     |
| System.Data.SqlClient                         | 4.5.1              | 4.9.1       | Security vulnerability — update to secure version |
| System.Drawing.Common                         | 4.5.0              | 10.0.5      | Security vulnerability — update to secure/latest version |
| System.Linq.Dynamic.Core                      | 1.0.8.2            | 1.7.2       | Security vulnerability — update to secure version |
| System.Text.Encoding.CodePages                | 4.5.0              | 8.0.0       | Update to assembly compatible with .NET 8     |

### Project upgrade details
This section contains details about each project upgrade and modifications that need to be done in the project.

#### Coldairarrow.Util/01.Coldairarrow.Util.csproj modifications

Project properties changes:
  - If target is `netstandard2.0` keep multi-targeting as appropriate. No automatic target framework addition required unless project consumes APIs that require net8.0.

NuGet packages changes:
  - Microsoft.EntityFrameworkCore: `2.1.3` -> `8.0.25`
  - Microsoft.EntityFrameworkCore.SqlServer: `2.1.3` -> `8.0.25`
  - Microsoft.Extensions.Caching.Memory: `2.1.2` -> `8.0.1`
  - Newtonsoft.Json: `11.0.2` -> `13.0.4` (security)
  - System.Configuration.ConfigurationManager: `4.4.1` -> `8.0.1`
  - System.Drawing.Common: `4.5.0` -> `10.0.5` (security)
  - System.Text.Encoding.CodePages: `4.5.0` -> `8.0.0`

Feature upgrades / notes:
  - EF Core 2.x -> 8.x includes many breaking changes (DbContext APIs, model building, migrations). Review data access code and migrations.

Other changes:
  - Verify usage of `System.Drawing.Common` on non-Windows platforms and adapt where necessary.

#### Coldairarrow.DataRepository/02.Coldairarrow.DataRepository.csproj modifications

Project properties changes:
  - No target framework change suggested by analysis (keep existing or multi-target if needed).

NuGet packages changes:
  - Microsoft.EntityFrameworkCore: `2.1.3` -> `8.0.25`
  - Microsoft.EntityFrameworkCore.SqlServer: `2.1.3` -> `8.0.25`
  - Npgsql: `4.0.3` -> `10.0.2` (security)
  - Pomelo.EntityFrameworkCore.MySql: `2.1.2` -> `9.0.0` (replacement)

Feature upgrades / notes:
  - Review EF Core provider changes and SQL translation differences.

#### Coldairarrow.Entity/03.Coldairarrow.Entity.csproj modifications

Project properties changes:
  - No target framework change suggested by analysis.

NuGet packages changes:
  - Microsoft.EntityFrameworkCore: `2.1.3` -> `8.0.25`
  - Microsoft.EntityFrameworkCore.SqlServer: `2.1.3` -> `8.0.25`
  - Npgsql: `4.0.3` -> `10.0.2` (security)
  - Pomelo.EntityFrameworkCore.MySql: `2.1.2` -> `9.0.0` (replacement)

Other changes:
  - Check for API surface changes if this project exposes types consumed by other projects.

#### Coldairarrow.Business/04.Coldairarrow.Business.csproj modifications

Project properties changes:
  - No target framework change suggested by analysis.

NuGet packages changes:
  - Microsoft.EntityFrameworkCore: `2.1.3` -> `8.0.25`
  - Microsoft.EntityFrameworkCore.SqlServer: `2.1.3` -> `8.0.25`
  - Npgsql: `4.0.3` -> `10.0.2` (security)
  - Pomelo.EntityFrameworkCore.MySql: `2.1.2` -> `9.0.0` (replacement)

Other changes:
  - Review business-layer code that depends on EF Core behavior.

#### Coldairarrow.Console/06.Coldairarrow.ConsoleApp.csproj modifications

Project properties changes:
  - Change target framework from `netcoreapp2.1` -> `net8.0`.

NuGet packages changes:
  - Update any referenced packages to versions compatible with .NET 8 as listed in the packages table above.

Other changes:
  - Update `Program` entrypoint if using old `Main` signature or WebHost-specific patterns. Ensure third-party packages are compatible with net8.0.

#### Coldairarrow.Web/05.Coldairarrow.Web.csproj modifications

Project properties changes:
  - Change target framework from `netcoreapp2.1` -> `net8.0`.

NuGet packages changes:
  - Microsoft.EntityFrameworkCore: `2.1.3` -> `8.0.25`
  - Microsoft.EntityFrameworkCore.SqlServer: `2.1.3` -> `8.0.25`
  - Microsoft.Extensions.Primitives: `2.1.1` -> `8.0.0`
  - Microsoft.VisualStudio.Web.CodeGeneration.Design: `2.1.4` -> `8.0.23`
  - EPPlus: `4.5.1` -> `8.5.1`
  - Pomelo.EntityFrameworkCore.MySql: `2.1.2` -> `9.0.0` (replacement)
  - Remove explicit `Microsoft.AspNetCore.App` package reference (functionality is in the shared framework)
  - Npgsql: `4.0.3` -> `10.0.2` (security)

Feature upgrades / notes:
  - Update startup code to minimal hosting model or maintain Host/Startup conversion; adapt middleware and endpoint routing as needed.

#### Coldairarrow.UnitTests/10.Coldairarrow.UnitTests.csproj modifications

Project properties changes:
  - Change target framework from `netcoreapp2.0` -> `net8.0`.

NuGet packages changes:
  - Microsoft.EntityFrameworkCore: `2.1.3` -> `8.0.25`
  - Microsoft.EntityFrameworkCore.SqlServer: `2.1.3` -> `8.0.25`
  - Microsoft.Extensions.Configuration: `2.1.1` -> `8.0.0`
  - Microsoft.Extensions.Configuration.Json: `2.1.1` -> `8.0.1`
  - Npgsql: `4.0.3` -> `10.0.2` (security)

Other changes:
  - Update test frameworks and adapt test host configuration for .NET 8 where needed.



One-line summary

Upgrade to .NET 8.0 requires updating project targets for the Console, Web, and UnitTests projects and a broad set of NuGet package updates (including several security-critical upgrades such as AutoMapper, Newtonsoft.Json, Npgsql, System.Data.SqlClient, System.Drawing.Common) plus replacing deprecated providers (Pomelo) and removing `Microsoft.AspNetCore.App` package references in favor of the shared framework. Expect code changes for EF Core (2.x -> 8.x) and hosting/middleware updates for the Web project.


Please open `dotnet-upgrade-plan.md`, review and confirm before I proceed to finalize the plan and start executing upgrade steps.