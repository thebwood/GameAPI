using Game.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.API.Domain.Services
{
    public class GameRepository : IGameRepository
    {
        private GamesContext _context;

        public GameRepository(GamesContext context) => _context = context;

        public IEnumerable<Games> GetGames() => _context.Games;
        public Games GetGame(int gameId) => _context.Games.Where(x => x.Id == gameId).Single();
        public IEnumerable<GameRatings> GetGameRatings() => _context.GameRatings;
        public void SaveDetail(Games game)
        {
            if (game.Id > 0)
                _context.Games.Update(game);
            else
                _context.Games.Add(game);
            _context.SaveChanges();
        }


    }
}
