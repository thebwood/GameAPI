﻿using AutoMapper;
using Game.API.Data;
using Game.API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.API.Domain.Services
{
    public class GameService : IGameService
    {
        private IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public GameService() { }
        public GameService(IGameRepository repo, IMapper mapper)
        {
            _gameRepository = repo;
            _mapper = mapper;
        }

        public IEnumerable<Games> GetGames() => _gameRepository.GetGames();
        public Games GetGame(long gameId) => _gameRepository.GetGame(gameId);

        public IEnumerable<GameRatings> GetGameRatings() => _gameRepository.GetGameRatings();
        public List<GameSearchResultsModel> SearchGames(GameSearchModel searchRequest) => _gameRepository.SearchGames(searchRequest);

        public List<string> SaveDetail(GamesModel Game)
        {
            var errors = ValidateGame(Game);
            if (errors.Count() == 0)
            {
                var existingGame = new Games();
                if (Game.Id > 0)
                    existingGame = _gameRepository.GetGame(Game.Id);

                _mapper.Map<GamesModel, Games>(Game, existingGame);
                _gameRepository.SaveDetail(existingGame);
            }

            return errors;
        }

        private List<string> ValidateGame(GamesModel game)
        {
            var errors = new List<string>();

            if (String.IsNullOrWhiteSpace(game.Title))
            {
                errors.Add("Title is required");
            }
            if (String.IsNullOrWhiteSpace(game.Description))
            {
                errors.Add("Description is required");
            }


            return errors;
        }
    }
}
