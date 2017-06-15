using System.Collections.Generic;
using Application.Contracts;
using CodingChallenge.Data.DataAccess;
using Application.Dtos;
using System.Linq;
using System;

namespace Application.Services
{
    public class TitleService : ITitleService
    {
        public IEnumerable<TituloDto> GetAllTitles()
        {
            var titleRepository = new MockRepository().TituloRepository;
            var titles = titleRepository.GetTitulos();

            return titles.Select(x => new TituloDto
            {
                Id = x.Id,
                Descripcion = x.Descripcion,
                Detalle = x.Detalle,
                Moneda = x.Moneda.ToString(),
                Simbolo = x.Simbolo,
                Tipo = x.Tipo.ToString()                
            });
        }

        public TituloDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TituloDto titulo)
        {
            throw new NotImplementedException();
        }

        public void Update(TituloDto titulo)
        {
            throw new NotImplementedException();
        }

        public void delete(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
