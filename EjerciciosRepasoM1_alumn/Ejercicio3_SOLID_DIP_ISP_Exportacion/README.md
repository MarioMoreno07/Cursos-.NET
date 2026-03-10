# Ejercicio 3 – Exportación de informes (DIP + ISP)

## Qué trabaja
- Dependency Inversion Principle (DIP)
- Interface Segregation Principle (ISP)
- Interfaces pequeñas
- Bajo acoplamiento

## Enunciado
Una aplicación genera informes y puede exportarlos en distintos formatos.

El servicio de alto nivel debe depender de una abstracción (`IExportador`) y no de una implementación concreta.

## Tareas
1. Ejecuta el proyecto con exportación CSV y PDF.
2. Explica por qué `ServicioInformes` no depende de una clase concreta. 
3. Añade `ExportadorJson`.
4. Comprueba que no es necesario modificar `ServicioInformes`.
