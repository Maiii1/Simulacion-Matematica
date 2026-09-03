# Simulación Matemática

Aplicación académica de escritorio desarrollada en **C# con Windows Forms** para implementar y visualizar distintos métodos de simulación matemática y generación de variables aleatorias. El proyecto también explora la integración de C# con **Python** y **R** para comparar generadores pseudoaleatorios y métodos de integración por simulación.

## Contenidos del proyecto

### Integración por simulación

Se estima mediante Monte Carlo la integral definida de la función cuadrática:

```text
f(x) = 1 - 2x + 3x²
```

La aplicación permite ingresar los límites de integración y el número de puntos de la simulación. El cálculo se prueba con distintos generadores:

- Generador provisto por la biblioteca externa `ACL.dll`.
- Blum Blum Shub (BBS), ejecutado mediante Python.
- XORShift32, ejecutado mediante R.

### Estimación de constantes y probabilidades

- Estimación de π mediante puntos aleatorios dentro de un cuadrado y un círculo unitario.
- Estimación del número e mediante sumas sucesivas de variables uniformes.
- Simulación de un juego de dos dados con ganancias y pérdidas según el resultado.
- Estimación de la probabilidad de recibir una beca y de una probabilidad condicional asociada a la facultad del estudiante.

### Generación de variables aleatorias por aceptación y rechazo

- Distribución normal con media y varianza configurables.
- Distribución discreta con soporte finito.
- Distribución de Poisson con parámetro λ configurable.
- Distribución exponencial con λ, cota superior y tamaño de muestra configurables.

La interfaz muestra las observaciones generadas y, según el ejercicio, calcula la media estimada de la muestra.

## Tecnologías utilizadas

- C#
- .NET 10 para Windows
- Windows Forms
- Python 3.14 mediante `pythonnet`
- R mediante `R.NET`
- Biblioteca externa `ACL.dll`

## Estructura principal

```text
simulacion-matematica/
├── Simulacion.py
└── SimESPOL/
    ├── SimESPOL.slnx
    └── SimESPOL/
        ├── SimESPOL.csproj
        ├── Program.cs
        ├── Form1.cs
        ├── Form1.Designer.cs
        ├── Form1.resx
        ├── Form2.cs
        ├── Form2.Designer.cs
        ├── Form2.resx
        ├── Form3.cs
        ├── Form3.Designer.cs
        ├── Form3.resx
        ├── IntegralSim.cs
        ├── EstimarSIM.cs
        ├── Acep_Rech.cs
        ├── AceptacionRechazoDiscreta.cs
        └── AcepyRech_exponencial.cs
```

### Función de los archivos

| Archivo | Descripción |
|---|---|
| `Program.cs` | Punto de entrada de la aplicación. Actualmente inicia `Form2`. |
| `Form1.cs` | Interfaz de integración Monte Carlo, estimación de π y e, juego de dados y probabilidad condicional. |
| `Form2.cs` | Interfaz para generar muestras normales, discretas y Poisson por aceptación-rechazo. |
| `Form3.cs` | Interfaz para generar muestras de una distribución exponencial. |
| `IntegralSim.cs` | Define la función cuadrática y estima su integral mediante simulación. |
| `EstimarSIM.cs` | Contiene las simulaciones de π, e, dados y becas. |
| `Acep_Rech.cs` | Implementa aceptación-rechazo para una distribución normal. |
| `AceptacionRechazoDiscreta.cs` | Implementa aceptación-rechazo para distribuciones discretas y Poisson. |
| `AcepyRech_exponencial.cs` | Implementa aceptación-rechazo para una distribución exponencial acotada. |
| `Simulacion.py` | Código complementario de simulación en Python. |

Los archivos `*.Designer.cs` y `*.resx` contienen el diseño y los recursos de las interfaces de Windows Forms.

## Requisitos

- Windows.
- Visual Studio con soporte para desarrollo de escritorio con .NET.
- SDK de .NET compatible con `net10.0-windows`.
- Python 3.14, si se desea ejecutar la integración con Python.
- R 4.5.x, si se desea ejecutar la integración con R.
- Paquetes NuGet `pythonnet` 3.1.0 y `R.NET` 1.9.0.
- Biblioteca `ACL.dll` utilizada por el generador congruencial.

## Configuración previa

El código contiene rutas locales que deben ajustarse al equipo donde se ejecute:

- Ruta de `python314.dll`.
- Carpeta desde la que se importa el módulo de Python `SM`.
- Ruta de instalación de R.
- Ruta del script `codigo.R`.
- Ruta donde se guarda la gráfica generada.
- Ruta de referencia de `ACL.dll` dentro de `SimESPOL.csproj`.

El código C# importa un módulo llamado `SM`. Si el archivo disponible en el repositorio es `Simulacion.py`, se debe renombrar a `SM.py` o modificar `Py.Import("SM")` para que coincida con el nombre real del módulo.

La integración con R también requiere que el archivo `codigo.R` contenga las funciones `IntegrarSIMxorShift32` y `graficar_cuadratica` utilizadas desde `Form1.cs`.

## Ejecución

1. Clonar o descargar el repositorio.
2. Abrir `SimESPOL/SimESPOL.slnx` en Visual Studio.
3. Restaurar los paquetes NuGet.
4. Agregar o corregir la referencia a `ACL.dll`.
5. Actualizar las rutas locales de Python, R, los scripts y la imagen de salida.
6. Compilar y ejecutar el proyecto.

También se puede restaurar y compilar desde una terminal ubicada en la raíz del repositorio:

```bash
dotnet restore SimESPOL/SimESPOL/SimESPOL.csproj
dotnet build SimESPOL/SimESPOL/SimESPOL.csproj
```

## Estado actual

El punto de entrada definido en `Program.cs` abre `Form2`, correspondiente a la generación de variables aleatorias. Para iniciar otra interfaz se puede cambiar temporalmente la línea:

```csharp
Application.Run(new Form2());
```

por `Form1` o `Form3`, según el módulo que se desee probar.

`PruebaSim.cs` corresponde a una versión de prueba y está excluido de la compilación en el archivo del proyecto.

## Propósito académico

Este repositorio reúne ejercicios desarrollados para la asignatura **Simulación Matemática**, con énfasis en métodos Monte Carlo, generación de números pseudoaleatorios, aceptación-rechazo, estimación estadística e integración de lenguajes.
