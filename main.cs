using System;
using System.Collections.Generic;
using System.Linq;

//una variable o primitivo se almacena en el stack, ocupa un lugar de espacio en la memoria 
//en el caso de una clase, se crea un objeto y tambien ocupa un espacio en la memoria, se almacena en la memoria heap
//por cada variable se crea una referencia en la memoria y por cada objeto se almacena en el heap ocupando un espacio por cada objeto
//se usa struct para unir los objetos almacenados en el heap convirtiedolo en uno solo, se explica a continuacion su uso
/*cuando creamos una instancia u objeto con struct ya no se almacena en el heap sino en el stack, se crea una referencia por cada objeto 
su respectiva copia en el stack asi sucesivamente en los siguientes instancias, es decir que los cambios que hagamos en esa instancia u objeto 
se aplican en las copias sin que se alteren las referencia originales, guardandola la estructura del objeto o instancia originalmente*/
public class Program
{
  public static void Main()
  {
    Empleado empleado1 = new Empleado(1200, 250);
    empleado1.cambiaSalario(100);
    Console.WriteLine(empleado1);
  }

  //public class Empleado{
  //se cambia la palabra reservada class por la palabra struc
  public struct Empleado{
    public double salarioBase, comision;

    public Empleado (int salarioBase, int comision){
      this.salarioBase = salarioBase;
      this.comision = comision;
    }
    public override string ToString(){
      return string.Format("Salario y comisión del empleado ({0}, {1})", this.salarioBase, this.comision);
    }

    public void cambiaSalario(double incremento){
      salarioBase += incremento;
      comision += incremento;

    }
  }
}
