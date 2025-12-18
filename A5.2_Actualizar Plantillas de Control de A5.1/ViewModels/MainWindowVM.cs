using A5._1_PlantillaDatosComida.Models;
using A5._1_PlantillaDatosComida.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5._2_Actualizar_Plantillas_de_Control_de_A5._1.ViewModels
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Plato>? _listaPlatos;

        [ObservableProperty]
        private Plato? _platoSeleccionado;

        [ObservableProperty]
        private ObservableCollection<String>? _listaTipos;
        public MainWindowVM()
        {
            ListaPlatos = DataService.GetSamples();
            ListaTipos = DataService.GetTipos();

            LimpiarSelección();
        }

        [RelayCommand]
        public void LimpiarSelección()
        {
            PlatoSeleccionado = null;
        }
    }
}
