# DAS-Hotel: Gestión de Reservaciones en un Hotel

**Desarrollo de una aplicación en C# para la gestión de reservaciones en un hotel.**

¡Hola a todos! Esta es mi solución para el desafío práctico 1 de DAS ciclo 1 2025.

## Tecnologías:
- **C#**

## Problemática:
El sistema debe permitir administrar habitaciones, clientes y reservaciones, utilizando **POO** (Programación Orientada a Objetos) para la estructura del programa, **matrices** para la disponibilidad de habitaciones, **listas** para almacenar clientes y **diccionarios** para las reservaciones.

## Requerimientos:

### Clases y POO:
1. **Habitación**:
   - Debe contener:
     - Número de habitación.
     - Tipo (sencilla, doble, suite).
     - Precio por noche.
     - Estado (disponible/ocupada).

2. **Cliente**:
   - Debe contener:
     - Nombre.
     - Documento de identidad.
     - Número de teléfono.

3. **Reservación**:
   - Debe asociar un cliente con una habitación, indicando:
     - La cantidad de noches.
     - El monto total de la reservación.

### Matrices:
- Representar las habitaciones en una matriz de **5x10** (5 pisos, 10 habitaciones por piso).
- Cada celda indica si la habitación está disponible o no.

### Listas:
- Almacenar los clientes registrados en una lista.

### Diccionarios:
- Usar un diccionario donde la **clave** sea el número de habitación y el **valor** sea el objeto de la reservación.

## Funcionalidades:
1. **Registrar clientes**.
2. **Mostrar la disponibilidad de habitaciones**.
3. **Crear una reservación** asignando un cliente a una habitación disponible.
4. **Consultar las reservaciones activas**.
5. **Cancelar una reservación** y liberar la habitación.

## Entrega:
- **Código fuente bien documentado**.
- **Capturas de pantalla** o evidencia de ejecución.

---

## Explicación breve del diseño del programa:

Este programa está diseñado para gestionar las **habitaciones, clientes y reservaciones** de un hotel. Se utiliza la **Programación Orientada a Objetos (POO)** para estructurar las clases de **Habitación**, **Cliente** y **Reservación**. Además, el sistema usa **matrices** para representar las habitaciones en un formato de 5 pisos por 10 habitaciones, lo que permite gestionar la disponibilidad de forma sencilla.

### Componentes principales:
1. **Clase Habitacion**: Contiene propiedades como el número de habitación, tipo, precio por noche y su estado (disponible u ocupada).
2. **Clase Cliente**: Almacena los detalles del cliente como nombre, documento de identidad y teléfono.
3. **Clase Reservacion**: Asocia un cliente con una habitación, registrando la cantidad de noches y el monto total de la reservación.

### Funcionalidades clave:
- El programa permite **registrar clientes**, **mostrar la disponibilidad de habitaciones** y **crear o cancelar reservaciones**.
- Se utiliza una **matriz 5x10** para gestionar las habitaciones y su disponibilidad.
- Los **clientes** se almacenan en una lista, y las **reservaciones** se gestionan en un diccionario.

Este diseño permite que el sistema sea **extensible** y **fácil de mantener**, facilitando futuras mejoras o modificaciones.

---

## Autor:
**ANDREA PAOLA MONTENEGRO PAZ**  
Carnet: MP101106

---

## Prueba de Funcionamiento:

### 1. Agregar nueva reservación
![Agregar Reservación](https://github.com/user-attachments/assets/4f4e4784-63e9-4438-ab3c-70e023e2891d)

### 2. Eliminar una reservación
![Eliminar Reservación](https://github.com/user-attachments/assets/d64086b3-9a61-4658-8683-44a7a70ad560)



