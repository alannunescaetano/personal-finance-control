using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Application.Services.Interfaces;
using WebAPI.Domain.Entities;

namespace WebAPI.Web.Controllers
{
    public class EntriesController
    {
        private IEntryService _entryService;

        public EntriesController(IEntryService entryService)
        {
            _entryService = entryService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Entry>> Add(Entry entry)
        {
            return await _entryService.Add(entry);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Entry>> GetById(long id)
        {
            return await _entryService.GetById(id);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<Entry>>> GetAll()
        {
            return await _entryService.GetAll();
        }
    }
}
