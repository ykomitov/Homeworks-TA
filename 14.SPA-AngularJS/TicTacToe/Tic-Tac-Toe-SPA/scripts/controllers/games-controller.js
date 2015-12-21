(function () {

  'use strict';

  function GamesController($http, $rootScope, baseUrl, $q, $route) {
    var vm = this;

    vm.games = "List of games you can join:";
    vm.createGame = createGame;

    getGames();

    function getGames() {
      var deferred = $q.defer();

      $http.get(baseUrl + '/api/games/list')
        .then(function (response) {
          vm.gamesList = response.data;
          console.log('Games received successfully!');
          deferred.resolve(response);
          $rootScope.$$phase || $rootScope.$apply();
        }, function (err) {
          console.log('Error getting games from server!');
        });
    }

    function createGame() {
      var deferred = $q.defer();

      $http.post(baseUrl + '/api/games/create')
        .then(function (response) {
          console.log('Games created successfully!');
          deferred.resolve(response);
        }, function (err) {
          console.log('Error creating game!');
        });

      $route.reload();
    }
  }


  angular.module('ticTacToe.controllers')
    .controller('GamesController', ['$http', '$rootScope', 'baseUrl', '$q', '$route', GamesController]);

}());