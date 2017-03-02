using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    class Usuario
    {
        private String nombre;
        private String user;
        private String password;
        private Archivo archivo;

        public Usuario(String nombre, String user, String password, Archivo archivo)
        {
            this.nombre = nombre;
            this.user = user;
            this.password = password;
            this.archivo = archivo;
        }
        public Usuario() { }

        public String getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public String getUser()
        {
            return user;
        }

        public void setUser(String user)
        {
            this.user = user;
        }
        public String getPassword()
        {
            return password;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }

        public Archivo getArchivo()
        {
            return archivo;
        }

        public void setArchivo(Archivo archivo)
        {
            this.archivo = archivo;
        }

        public String toString()
        {
            return user + "|" + password;
        }
    }
}
