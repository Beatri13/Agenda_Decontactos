﻿using System;

    public class Direccion
    {
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Colonia { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }

        
        public Direccion(string calle, string numero, string colonia, string ciudad, string departamento)
        {
            Calle = calle;
            Numero = numero;
            Colonia = colonia;
            Ciudad = ciudad;
            Departamento = departamento;

        }
    }


    


	

