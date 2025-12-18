using A5._1_PlantillaDatosComida.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5._1_PlantillaDatosComida.Services
{
    public static class DataService
    {
        public static ObservableCollection<Plato> GetSamples()
        {
            ObservableCollection<Plato> lista = new ObservableCollection<Plato>();

            lista.Add(new Plato("Hamburguesa", @"..\Assets\burguer.jpg", "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", @"..\Assets\dumplings.jpg", "China", true, true, false, false));
            lista.Add(new Plato("Tacos", @"..\Assets\tacos.jpg", "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", @"..\Assets\cerdoagridulce.jpg", "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", @"..\Assets\hotdog.jpg", "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", @"..\Assets\fajitas.jpg", "Mexicana", true, false, false, true));

            return lista;
        }

        public static ObservableCollection<String> GetTipos()
        {
            ObservableCollection<string> listaTipos = new ObservableCollection<String>();
            
            listaTipos.Add("Americana");
            listaTipos.Add("China");
            listaTipos.Add("Mexicana");
            
            return listaTipos;
        }

    }
}
