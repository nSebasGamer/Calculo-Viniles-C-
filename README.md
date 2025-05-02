
# 🧮 Calculadora de Costo de Materiales con Colores - Windows Forms

Este proyecto es una aplicación de escritorio desarrollada en **C# utilizando Windows Forms**. Permite calcular el costo de materiales en base a dimensiones de un área, cantidad de colores y aplicar distintas opciones de precio: estándar, mayoreo y con IVA.

---

## ✨ Características

- Cálculo automático del costo total basado en:
  - Dimensiones: **Ancho** y **Alto** del área.
  - **Cantidad de colores** seleccionados mediante un `TrackBar`.
- Muestra:
  - Total estándar.
  - Precio de mayoreo.
  - Total con IVA (16%).
- Interfaz gráfica simple y fácil de usar.

---

## 🧮 Fórmulas Utilizadas

- **Área:**

  ```
  área = ancho × alto
  ```

- **Costo de Material:**

  ```
  material = 55 × área / 6000 + 9.5 × área / 3000 + 550 × área / 28800
  ```

- **Total estándar:**

  ```
  total = material × 2.5 × colores
  ```

- **Total mayoreo:**

  ```
  totalMayoreo = material × 2 × colores
  ```

- **Total con IVA (16%):**

  ```
  totalIVA = material × 2.5 × colores × 1.16
  ```

---

## 🖥️ Interfaz de Usuario

- **Entradas:**
  - `TextBox`: ancho (`textBoxAncho`)
  - `TextBox`: alto (`textBoxAlto`)
  - `TrackBar`: colores (`trackBarColores`)

- **Botones:**
  - `buttonCalcular` → Calcula el total estándar.
  - `buttonMayoreo` → Calcula el precio de mayoreo.
  - `buttonIVA` → Calcula el total con IVA.

- **Salidas (Labels):**
  - `labelTotal` → Muestra el total estándar.
  - `labelMayoreo` → Muestra el precio de mayoreo.
  - `labelTotalIVA` → Muestra el total con IVA.

---

## 📦 Requisitos

- Visual Studio 2019 o superior
- .NET Framework 4.7.2 o .NET 6+ (dependiendo de la versión usada)
- Sistema operativo Windows

---

## ▶️ Cómo ejecutar

1. Clona este repositorio o descarga el código.
2. Abre el proyecto `.sln` en Visual Studio.
3. Ejecuta con `F5` o presiona "Start".

---

## 📸 Capturas de pantalla

> *(Agrega aquí imágenes del programa si deseas)*

---

## 📄 Licencia

Este proyecto es de libre uso para fines personales, educativos o de demostración.

---

## 👨‍💻 Autor

- Proyecto adaptado de un script en JavaScript a C# por **Noe Gonzalez**.
