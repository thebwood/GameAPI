using Game.API.Data;
using System.Collections.Generic;

namespace Game.API.Domain.Services
{
    public interface IGameRepository
    {
        IEnumerable<Games> GetGames();
        IEnumerable<GameRatings> GetGameRatings();
    }
}