﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacionesMatematicas
{
    public class Numeros
    {
        private double numero2;
        private double numero1;
              

        public void setNumero1(double valor) {
            this.numero1 = valor;
        }
        public double getNumero1() {
            return this.numero1;
        }

        public void setNumero2(double valo) {
            this.numero2 =valo;
        }

        public double getNumero2() {
            return this.numero2;
        }
    }
}
