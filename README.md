# APEAM - Sistema de Gestión

Prueba técnica desarrollada para APEAM (Asociación de Productores y Empacadores Exportadores de Aguacate de Michoacán). Sistema de gestión empresarial construido con ASP.NET MVC y Entity Framework Code First.

## 📋 Descripción

Sistema de gestión integral que permite administrar el flujo de operaciones de una empresa productora y exportadora de aguacate, incluyendo inventarios, productos, proveedores, y control de transacciones.

## ✨ Características Principales

- **Gestión de Inventarios**: Control de stock y movimientos de almacén
- **Gestión de Productos**: Catálogo de productos con información detallada
- **Gestión de Proveedores**: Administración de proveedores y contactos
- **Registro de Transacciones**: Seguimiento de operaciones y movimientos
- **Tipos de Pagos**: Control de métodos de pago disponibles
- **Arquitectura MVC**: Separación clara de responsabilidades
- **Entity Framework Code First**: Gestión de base de datos mediante código

## 🛠️ Tecnologías Utilizadas

- **Framework**: ASP.NET MVC
- **Lenguaje**: C#
- **ORM**: Entity Framework Code First
- **Base de Datos**: SQL Server
- **Frontend**: Razor Views, HTML5, CSS3, JavaScript
- **Control de Versiones**: Git

## 🏗️ Arquitectura

El proyecto sigue el patrón MVC (Model-View-Controller):

```
Controllers/
├── HomeController.cs              # Controlador principal
├── InventariosController.cs       # Gestión de inventarios
├── ProductosController.cs         # Gestión de productos
├── ProveedoresController.cs       # Gestión de proveedores
├── RegistroTransaccionsController.cs  # Registro de transacciones
└── TipoPagoesController.cs        # Tipos de pago
```

## 📦 Módulos del Sistema

### 1. **Inventarios**
Administración del stock y control de almacén

### 2. **Productos**
Catálogo y gestión de productos comercializados

### 3. **Proveedores**
Registro y control de proveedores

### 4. **Registro de Transacciones**
Seguimiento de operaciones comerciales

### 5. **Tipos de Pago**
Configuración de métodos de pago

## 🚀 Instalación y Configuración

### Prerrequisitos

- Visual Studio 2019 o superior
- .NET Framework 4.6+
- SQL Server 2016 o superior

### Pasos de Instalación

1. **Clonar el repositorio**
```bash
git clone https://github.com/marco0525/APEAM.git
cd APEAM
```

2. **Configurar la cadena de conexión**

Editar el archivo `Web.config` y actualizar la cadena de conexión:

```xml
<connectionStrings>
    <add name="DefaultConnection" 
         connectionString="Server=TU_SERVIDOR;Database=APEAM_DB;Trusted_Connection=True;" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

3. **Restaurar paquetes NuGet**
```bash
# En Visual Studio: Tools > NuGet Package Manager > Restore NuGet Packages
# O desde Package Manager Console:
Update-Package -reinstall
```

4. **Aplicar migraciones de Entity Framework**

En Package Manager Console:
```bash
Enable-Migrations
Add-Migration InitialCreate
Update-Database
```

5. **Ejecutar el proyecto**

Presionar `F5` en Visual Studio o:
```bash
dotnet run
```

## 💾 Base de Datos

El proyecto utiliza **Entity Framework Code First**, lo que significa que:

- Las tablas se generan automáticamente desde los modelos
- Las migraciones permiten control de versiones del esquema
- No es necesario crear manualmente la base de datos

### Aplicar Migraciones

```bash
# Crear una nueva migración
Add-Migration NombreDeLaMigracion

# Aplicar migraciones pendientes
Update-Database

# Revertir a una migración específica
Update-Database -TargetMigration: NombreDeLaMigracion
```

## 🔧 Configuración Adicional

### Connection String para desarrollo local:

```xml
<add name="DefaultConnection" 
     connectionString="Server=(localdb)\mssqllocaldb;Database=APEAM_DB;Trusted_Connection=True;" 
     providerName="System.Data.SqlClient" />
```

### Connection String para SQL Server:

```xml
<add name="DefaultConnection" 
     connectionString="Server=localhost;Database=APEAM_DB;User Id=sa;Password=TU_PASSWORD;" 
     providerName="System.Data.SqlClient" />
```

## 📝 Notas del Desarrollador

- Este proyecto fue desarrollado como prueba técnica para demostrar conocimientos en ASP.NET MVC y Entity Framework
- Implementa buenas prácticas de desarrollo como separación de responsabilidades y Code First
- La arquitectura permite fácil escalabilidad y mantenimiento

## 👤 Autor

**Marco Antonio Méndez Espinosa**
- GitHub: [@marco0525](https://github.com/marco0525)
- Email: marco_0525@outlook.com

## 📄 Licencia

Este proyecto fue desarrollado como prueba técnica.

---

**Nota**: Este es un proyecto de prueba técnica. Para uso en producción se recomienda implementar medidas adicionales de seguridad, validaciones y manejo de errores.
