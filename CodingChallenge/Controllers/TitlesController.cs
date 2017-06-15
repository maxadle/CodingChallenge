using Application.Contracts;
using Application.Dtos;
using Application.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace CodingChallenge.Controllers
{
    public class TitlesController : ApiController
    {
        private ITitleService _titleService;

        public TitlesController()
        {
            _titleService = new TitleService();
        }

        //GET api/<controller>
        public IEnumerable<TituloDto> Get()
        {
            return _titleService.GetAllTitles();
        }

        public IEnumerable<TituloDto> Get(string searchTerm)
        {
            return _titleService.GetTitlesBySearchTerm(searchTerm);
        }

        // POST api/<controller>
        public void Post([FromBody]TituloDto titulo)
        {
            _titleService.Insert(titulo);
        }

        // PUT api/<controller>/5
        public void Put([FromBody]TituloDto titulo)
        {
            _titleService.Update(titulo);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            _titleService.delete(id);
        }
    }
}