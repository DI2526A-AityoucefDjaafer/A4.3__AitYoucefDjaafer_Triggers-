using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5._1_PlantillaDatosComida.Models
{
    public partial class Plato:ObservableObject
    {
        // Se generan las propiedades gracias a la librería
        // CommunityToolKit.mvvm, por eso, ponemos que
        // la clase es parcial.
        
        [ObservableProperty]
        private string? _nombre;

        //public string Nombre { 
        //    get => _nombre; 
        //    set => SetProperty(ref _nombre, value);
        //}

        [ObservableProperty]
        private string? _imagen;

        [ObservableProperty]
        private string? _tipo;

        [ObservableProperty]
        private bool _gluten;

        [ObservableProperty]
        private bool _soja;

        [ObservableProperty]
        private bool _leche;

        [ObservableProperty]
        private bool _sulfitos;

        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Plato()
        {
            Nombre = "";
            Imagen = "";
            Tipo = "";
            Gluten = false;
            Soja = false;
            Leche = false;
            Sulfitos = false;
        }

    }
}
