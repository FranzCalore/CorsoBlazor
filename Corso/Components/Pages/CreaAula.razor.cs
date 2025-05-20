using Corso.Models;
using Corso.Services;
using Corso.Services.DTOs;
using Mapster;
using Microsoft.AspNetCore.Components;

namespace Corso.Components.Pages
{
    public partial class CreaAula
    {

        [Inject]
        private  NavigationManager Navigation { get; set; } = default!;
        [Inject]
        private IAulaService aulaService { get; set; } = default!;

        private CreateAulaModel aula = new();

        private void OnSubmit()
        {
            aulaService.AddAulaAsync(aula.Adapt<CreateAulaDTO>());
            Navigation.NavigateTo("/Aule");
        }
    }
}
