using System;

namespace Usuario_IFSP.Usuarios
{
    public abstract class Usuario
    {
        static int id = 0;

        public string Prontuario { get; } = "BI_";
        public string Tipo { get; } = "Usuário";

        int GeraID()
        {
            return ++id;
        }

        public Usuario()
        {
            this.Prontuario += string.Format("{0:D6}", GeraID());
        }

        public Usuario(string tipo) : this()
        {
            this.Tipo = tipo;
        }
    }
}
