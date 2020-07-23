using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Game.API.Domain.Models;
using Game.API.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Game.API.Controllers
{
    [Route("api/games")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private IGameRepository _repository;
        private readonly IMapper _mapper;
        public GameController(IGameRepository repo, IMapper mapper)
        {
            _repository = repo ??
                throw new ArgumentNullException(nameof(repo));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }


        [HttpGet]
        [ProducesResponseType(typeof(GamesModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GamesModel), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(GamesModel), (int)HttpStatusCode.InternalServerError)]
        public IActionResult GetGames()
        {
            try
            {
                var data = _repository.GetGames();

                var retVal = _mapper.Map<IEnumerable<GamesModel>>(data);

                if (retVal.Count() > 0)
                {
                    return Ok(retVal);
                }
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "A problem happened while handling your request.");
            }
        }

        [HttpGet("ratings")]
        [ProducesResponseType(typeof(GameRatingsModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(GameRatingsModel), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(GameRatingsModel), (int)HttpStatusCode.InternalServerError)]
        public IActionResult GetMovieRatings()
        {
            try
            {
                var data = _repository.GetGameRatings();

                var retVal = _mapper.Map<IEnumerable<GameRatingsModel>>(data);

                if (retVal.Count() > 0)
                {
                    return Ok(retVal);
                }
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "A problem happened while handling your request.");
            }
        }

    }
}
