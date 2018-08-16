using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Operaciones
    {
        public int Edad(int FechaN) {
            int edad = 2018 - FechaN;
            return  edad;
        }
    }
}