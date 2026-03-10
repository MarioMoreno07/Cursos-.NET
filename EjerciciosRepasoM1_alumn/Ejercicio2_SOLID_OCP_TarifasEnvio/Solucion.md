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
1. Ejecuta el proyecto. Se puede ver los diferentes costes de envia el producto
2. Identifica por qué está cerrado a modificación y abierto a extensión. Porque todos los envios herendan de TarifaEnvios
3. Añade una nueva clase `EnvioRecogidaTienda`.
4. Comprueba que `Program` no necesita cambios. Necesita que añadamos un nuevo tipo de envio
