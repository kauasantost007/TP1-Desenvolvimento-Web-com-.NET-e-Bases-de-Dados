using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercicio12.Pages
{
    public class AddEventModel : PageModel
    {
        [BindProperty]
        public Event NovoEvento { get; set; } = new Event();

        public void OnPost()
        {
            Action<Event> registrar = RegistrarEvento;

            registrar(NovoEvento);
        }

        static void RegistrarEvento(Event evento)
        {
            Console.WriteLine("Evento criado: " + evento.Titulo);
            Console.WriteLine("Data: " + evento.Data.ToString("dd/MM/yyyy"));
            Console.WriteLine("Local: " + evento.Local);
        }
    }
}