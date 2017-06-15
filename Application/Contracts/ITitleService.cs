using Application.Dtos;
using System.Collections.Generic;

namespace Application.Contracts
{
    public interface ITitleService
    {
        IEnumerable<TituloDto> GetAllTitles();

        IEnumerable<TituloDto> GetTitlesBySearchTerm(string searchTerm);

        TituloDto GetById(int id);
        void Insert(TituloDto titulo);
        void Update(TituloDto titulo);
        void delete(int id);
    }
}
