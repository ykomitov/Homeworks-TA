(function () {
  'use strict';

  var identityService = function identityService($q) {
    var currentUser = {};
    var deferred = $q.defer();

    return {
      getUser: function () {
        if (this.isAuthenticated()) {
          return $q.resolve(currentUser);
        }

        return deferred.promise;
      },
      isAuthenticated: function () {
        // return Object.getOwnPropertyNames(currentUser).length !== 0;

        return localStorage.currentUser;
      },
      setUser: function (user) {
        localStorage.currentUser = user.email;
        currentUser = user;
        deferred.resolve(user);
      },
      removeUser: function () {
        currentUser = {};
        localStorage.clear();
        deferred = $q.defer();
      }
    };
  };

  angular
    .module('ticTacToe.services')
    .factory('identity', ['$q', identityService]);
}());