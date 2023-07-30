using Microsoft.AspNetCore.Mvc;
using WebAPI.Domain.Entities;

namespace WebAPI.Controllers
{
    public class EntriesController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Entry>> Create(Entry entry)
        {
            return null;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<Entry>>> GetAll()
        {
            return null;
        }
    }
}
