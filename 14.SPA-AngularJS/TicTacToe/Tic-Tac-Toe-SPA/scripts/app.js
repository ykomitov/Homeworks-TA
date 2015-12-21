(function () {
  'use strict';

  function config($routeProvider, $locationProvider) {

    var CONTROLLER_VIEW_MODEL_NAME = "vm";

    $locationProvider.html5Mode(true);

    var routeResolvers = {
      authenticationRequired: {
        authenticate: ['$q', 'auth', function ($q, auth) {
          if (auth.isAuthenticated()) {
            return true;
          }

          return $q.reject('Not authorized!');
        }]
      }
    };

    $routeProvider
      .when('/', {
        templateUrl: 'partials/home.html',
        controller: 'HomeController',
        controllerAs: CONTROLLER_VIEW_MODEL_NAME
      })
      .when('/identity/register', {
        templateUrl: 'partials/register.html',
        controller: 'RegisterController',
        controllerAs: CONTROLLER_VIEW_MODEL_NAME
      })
      .when('/identity/login', {
        templateUrl: 'partials/login.html',
        controller: 'LoginController',
        controllerAs: CONTROLLER_VIEW_MODEL_NAME
      })
      .when('/games', {
        templateUrl: 'partials/games.html',
        controller: 'GamesController',
        controllerAs: CONTROLLER_VIEW_MODEL_NAME
      })
      .otherwise('/', {
        redirectTo: '/'
      });
  }

  function run($cookies, $http, $rootScope, $location, auth) {

    $rootScope.$on('$routeChangeError', function (ev, current, previous, rejection) {
      if (rejection === 'Not authorized!') {
        $location.path('/');
      }
    });

    if (auth.isAuthenticated()) {
      $http.defaults.headers.common.Authorization = 'Bearer ' + $cookies.get('authentication');
      //auth.getIdentity();
    }
  }

  angular
    .module('ticTacToe', ['ngRoute', 'ngCookies', 'ngMessages', 'ticTacToe.controllers'])
    .config(['$routeProvider', '$locationProvider', config])
    .run(['$cookies', '$http', '$rootScope', '$location', 'auth', run])
    .constant('baseUrl', 'http://localhost:1234')
    .filter('ticTacFilter', function () {

      return function (input) {

        if (input === 'X') {
          return 'X';
        }

        if (input === 'O') {
          return 'O';
        }

        return ' ';
      }

    })
    .directive('ticTacBoard', function () {
      return {
        restrict: 'E',
        templateUrl: '/partials/board.html'
      };
    });

  angular.module('ticTacToe.controllers', ['toaster', 'ngAnimate', 'ticTacToe.services']);

  angular.module('ticTacToe.services', []);

  //angular.directive('ticTacBoard', function () {
  //  return {
  //    restrict: 'E',
  //    template: '<div>This is a directive</div>'
  //  };
  //});

}());