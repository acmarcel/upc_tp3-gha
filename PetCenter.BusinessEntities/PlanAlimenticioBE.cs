﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCenter.BusinessEntities
{
    public class PlanAlimenticioBE
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int especie { get; set; }
        public int condicionMedica { get; set; }
        public string fechaRegistro { get; set; }
    }
}
