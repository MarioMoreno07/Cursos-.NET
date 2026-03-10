# Ejercicio 2 – Tarifas de envío (SOLID + OCP)

## Qué trabaja
- Open/Closed Principle (OCP)
- Polimorfismo
- Sustitución de comportamientos sin modificar el código principal

## Enunciado
Una tienda calcula el coste del envío según el tipo de servicio:
- `EnvioEstandar`
- `EnvioUrgente`
- `EnvioInternacional`

El programa principal no debe cambiar al añadir nuevos tipos de envío.

## Tareas
1. Ejecuta el proyecto.
2. Identifica por qué está cerrado a modificación y abierto a extensión. 
3. Añade una nueva clase `EnvioRecogidaTienda`.
4. Comprueba que `Program` no necesita cambios.
