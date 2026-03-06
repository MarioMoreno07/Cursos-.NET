using System;

namespace PrincipiosPOO
{
    /*
     * ==========================================================
     * PRINCIPIOS POO - EJEMPLO PEDAGÓGICO
     * ==========================================================
     * En este proyecto veremos:
     *  - Encapsulamiento: proteger datos internos con private + propiedades.
     *  - Abstracción: definir un concepto general (Empleado) sin detalles.
     *  - Herencia: crear tipos de empleado reutilizando lo común.
     *  - Polimorfismo: mismo método, resultados distintos según el objeto.
     */

    // ===============================
    // ABSTRACCIÓN
    // ===============================
    // "Empleado" es un concepto general.
    // No existe un único modo de calcular el salario para todos.
    // Por eso, dejamos el cálculo como "abstract": cada tipo lo hará a su forma.
    public abstract class Empleado
    {
        // ===============================
        // ENCAPSULAMIENTO
        // ===============================
        // Campo privado: solo se puede tocar desde dentro de la clase.
        private string _nombre;

        // Propiedad pública: forma segura de acceder/modificar el nombre.
        // Aquí podemos VALIDAR antes de guardar el dato.
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío.");
                _nombre = value;
            }
        }

        protected Empleado(string nombre)
        {
            // Usamos la propiedad para aplicar la validación.
            Nombre = nombre;
        }

        // ===============================
        // POLIMORFISMO (preparación)
        // ===============================
        // Cada clase hija debe implementar su versión.
        public abstract decimal CalcularSalario();
    }
}
