﻿using System.Collections.Generic;

namespace Capitulo03.Models
{
    public class Instituicao
    {
        public long? InstituicaoID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public virtual ICollection<Departamento> Departamentos { get; set; }
    }
}
