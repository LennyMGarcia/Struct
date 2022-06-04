using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado(1200, 2150);

            empleado1.cambiaSalario(empleado1, 100);

            Console.WriteLine(empleado1);
        }
    }
    //Cuando se trabaja con una clase esta almacena sus objetos en el Heap y las referencias o punteros en el stack
    //el stack o pila es para apilar todo los datos como variables y argumentos que no se cambiaran de forma dinamica durante la ejecucion
    //El heap por el contrario amontona todo y hace sus cambios dinamicamente
    //El struct es recomendable cuando se sabe que no se haran muchas cosas dinamicamente como una especie de modoluacion para cosas inmutables
    struct Empleado
    {
        public double salarioBase, comision;

        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;
            this.comision = comision;
        }

        public override string ToString()
        {
            return string.Format("Salario y comision del empleado ({0},{1})", this.salarioBase, this.comision);
        }

        public void cambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;

            emp.comision += incremento;
        }
    }
}
