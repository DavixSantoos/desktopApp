using GestaoDeEscalas.Models;
using Syncfusion.Maui.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Text;


namespace GestaoDeEscalas
{
    public partial class Escalas : ContentPage
    {

        public Escalas()
        {
            InitializeComponent();

            var escalas = new ObservableCollection<SchedulerAppointment>()
        {
            new SchedulerAppointment()
            {
                Subject = "Ana",
                StartTime = DateTime.Today.AddHours(7),
                EndTime = DateTime.Today.AddHours(19),
                Background = Colors.Green
            },

        };

            Agenda.AppointmentsSource = escalas;

        }
        async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("TelaInicial");
        }

       
    }
}
