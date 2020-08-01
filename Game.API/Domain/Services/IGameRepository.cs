using Game.API.Data;
using Game.API.Domain.Models;
using System.Collections.Generic;

namespace Game.API.Domain.Services
{
    public interface IGameRepository
    {
        IEnumerable<Games> GetGames();
        Games GetGame(long gameId);
        void SaveDetail(Games game);
        IEnumerable<GameRatings> GetGameRatings();
        List<GameSearchResultsModel> SearchGames(GameSearchModel searchRequest);
    }
}