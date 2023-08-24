
using EventLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventLibrary
{
    public class Cliente:Persona
    {

        public string email { get; set; }
        public EstadoClienteEnum estado { get; set; }


    }
}
