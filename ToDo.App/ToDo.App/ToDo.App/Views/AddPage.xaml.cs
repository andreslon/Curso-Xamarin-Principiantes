using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.App.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDo.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        private async void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var item = new ToDoItem
                {
                    Name = nombre.Text,
                    Description = descripcion.Text,
                    Date = fecha.Date,
                    Time = hora.Time
                };
                var result = await App.Context.InsertItemAsync(item);
                if (result == 1)
                {
                    await Navigation.PopAsync();
                }
                else {
                    await DisplayAlert("Error", "No se pudo guardar la tarea", "Aceptar");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Aceptar");
            }

        }
    }
}