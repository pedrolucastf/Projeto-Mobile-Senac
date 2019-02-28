using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProjeto
{
    public class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public Guid ID { get; set; }

        [MaxLength(50), NotNull]
        public string Nome { get; set; }

        [MaxLength(100), NotNull]
        public string Usuario { get; set; }

        [MaxLength(255), NotNull]
        public string Senha { get; set; }

    }
}
