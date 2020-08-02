using Game.API.Data;
using Game.API.Domain.Models;
using System.Collections.Generic;

namespace Game.API.Domain.Services
{
    public interface IGameService
    {
        List<string> SaveDetail(GamesModel game);
        IEnumerable<Games> GetGames();
        Games GetGame(long movieId);
        IEnumerable<GameRatings> GetGameRatings();
        List<GameSearchResultsModel> SearchGames(GameSearchModel searchRequest);


    }
}