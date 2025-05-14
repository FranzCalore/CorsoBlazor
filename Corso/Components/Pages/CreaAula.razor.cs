using Corso.Models;
using Corso.Services;
using Corso.Services.DTOs;
using Mapster;
using Microsoft.AspNetCore.Components;

namespace Corso.Components.Pages
{
    public partial class CreaAula
    {

        private readonly NavigationManager Navigation;
        private readonly IAulaService aulaService;

        public CreaAula(NavigationManager navigation, IAulaService aulaService)
        {
            Navigation = navigation;
            this.aulaService = aulaService;
        }

        private CreateAulaModel aula = new();

        private void OnSubmit()
        {
            aulaService.AddAulaAsync(aula.Adapt<CreateAulaDTO>());
            Navigation.NavigateTo("/Aule");
        }
    }
}
