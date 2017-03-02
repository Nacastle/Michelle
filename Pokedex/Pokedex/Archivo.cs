using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    class Archivo
    {
        private String nombre;
        StreamReader sr;
        StreamWriter sw;
        Pokemon pokemon = new Pokemon();

        LinkedList<Pokemon> listaPokemon = new LinkedList<Pokemon>();

        public void crearArchivo(String nombre)
        {
            this.nombre = nombre;
            sw = new StreamWriter(nombre);
            sw.Close();
        }

        public void agregarRegistro(String nuevoRegistro)
        {
            sw = new StreamWriter("C/" + nombre + ".txt", true);
            sw.WriteLine(nuevoRegistro);
            String n = nuevoRegistro;
            sw.Close();
        }

        public void borrar (String pokemon){
            
        }


        public Pokemon buscar(String pokemonBuscado)
        {
            sr = new StreamReader("C/" + nombre +".txt");
            String datosPokemon;
            
            String[] datos;
            while ((datosPokemon = sr.ReadLine()) != null)
            {
                datos = datosPokemon.Split('|');
                if (datos[0] == pokemonBuscado)
                {
                    if (datosPokemon.Length > 1)
                    {
                        pokemon.setNombre(datos[0]);
                        pokemon.setApodo(datos[1]);
                        pokemon.setDescripcion(datos[2]);
                        pokemon.setPeso(Convert.ToDouble(datos[3]));
                        pokemon.setAltura(Convert.ToDouble(datos[4]));
                        pokemon.setCategoria(datos[5]);
                        pokemon.setHabilidades(datos[6]);
                        pokemon.setGenero(datos[7]);
                        pokemon.setTipos(datos[8]);
                        pokemon.setDebilidades(datos[9]);
                        pokemon.setHp(Int32.Parse(datos[10]));
                        pokemon.setAtaque(Int32.Parse(datos[11]));
                        pokemon.setDefensa(Int32.Parse(datos[12]));
                        pokemon.setAtaqueEspecial(Int32.Parse(datos[13]));
                        pokemon.setDefensaEspecial(Int32.Parse(datos[14]));
                        pokemon.setVelocidad(Int32.Parse(datos[15]));
                        if (datos[16].Equals("False"))
                        {
                            pokemon.setEvolucion(false);
                            pokemon.setImagen(datos[19]);
                            pokemon.setEvolucion1(datos[17]);
                            pokemon.setEvolucion2(datos[18]);
                        }
                        else if(!datos[16].Equals(false) && datos.Length == 19)
                        {
                            pokemon.setEvolucion1(datos[17]);
                            pokemon.setEvolucion2(datos[18]);
                            pokemon.setImagen(datos[19]);
                        }
                    }
                }
            }
            sr.Close();
            return pokemon;
        }

        public LinkedList<Pokemon> listar()
        {
            sr = new StreamReader("C/" + nombre + ".txt");
            String datosPokemon;
            
            String[] datos;
            while ((datosPokemon = sr.ReadLine()) != null)
            {
                Pokemon pokemonAgregado = new Pokemon();
                if (datosPokemon.Length > 1)
                {
                    datos = datosPokemon.Split('|');
                    pokemonAgregado.setNombre(datos[0]);
                    pokemonAgregado.setApodo(datos[1]);
                    pokemonAgregado.setDescripcion(datos[2]);
                    pokemonAgregado.setPeso(Convert.ToDouble(datos[3]));
                    pokemonAgregado.setAltura(Convert.ToDouble(datos[4]));
                    pokemonAgregado.setCategoria(datos[5]);
                    pokemonAgregado.setHabilidades(datos[6]);
                    pokemonAgregado.setGenero(datos[7]);
                    pokemonAgregado.setTipos(datos[8]);
                    pokemonAgregado.setDebilidades(datos[9]);
                    pokemonAgregado.setHp(Int32.Parse(datos[10]));
                    pokemonAgregado.setAtaque(Int32.Parse(datos[11]));
                    pokemonAgregado.setDefensa(Int32.Parse(datos[12]));
                    pokemonAgregado.setAtaqueEspecial(Int32.Parse(datos[13]));
                    pokemonAgregado.setDefensaEspecial(Int32.Parse(datos[14]));
                    pokemonAgregado.setVelocidad(Int32.Parse(datos[15]));
                    if (datos[16].Equals("False"))
                    {
                        pokemonAgregado.setImagen(datos[19]);
                        pokemonAgregado.setEvolucion(false);
                        pokemonAgregado.setEvolucion1("no");
                        pokemonAgregado.setEvolucion2("no");
                        
                    }
                    else if(!datos[16].Equals(false) && datos.Length == 19)
                    {
                        pokemonAgregado.setEvolucion1(datos[17]);
                        pokemonAgregado.setEvolucion2(datos[18]);
                        pokemonAgregado.setImagen(datos[19]);
                    }
                    listaPokemon.AddLast(pokemonAgregado);
                }
            }
            sr.Close();
            return listaPokemon;
        }

        public void modificar(String pokemon, String pokemonModificado)
        {
            String text = File.ReadAllText("C/" + nombre + ".txt");
            text = text.Replace(buscar(pokemon).toString(), pokemonModificado);
            File.WriteAllText("C/" + nombre + ".txt", text);
        }

        public void eliminar()
        {
            sr = new StreamReader("C/" + nombre + ".txt");
            String contenido = sr.ReadToEnd();
            sr.Close();
            String text = File.ReadAllText("C/" + nombre + ".txt");
            try
            {
                text = text.Replace(contenido, null);
                File.WriteAllText("C/" + nombre + ".txt", text);
            }
            catch (ArgumentException)
            {

            }
            
        }

        public void setUser(String nombre)
        {
            this.nombre = nombre;
        }
        public String getUser()
        {
            return nombre;
        }
    }
}
