using AutoMapper;
using Game.API.Data;
using Game.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.API.Domain.Profiles
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<Games, GamesModel>();
            CreateMap<GameRatings, GameRatingsModel>();
        }
    }
}
