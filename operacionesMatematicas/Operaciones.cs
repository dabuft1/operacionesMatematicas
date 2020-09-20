using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionesMatematicas
{
    public class Operaciones : Numeros
    {
        public double calcularSuma() {
            return (this.getNumero1() + this.getNumero2());
        }

        public double calcularResta(){
            return (this.getNumero1() - this.getNumero2());
        }

        public double calcularMultiplicacion(){
            return (this.getNumero1() * this.getNumero2());
        }

        public double calcularDivision(){
            return (this.getNumero1() / this.getNumero2());
        }
    }
}

