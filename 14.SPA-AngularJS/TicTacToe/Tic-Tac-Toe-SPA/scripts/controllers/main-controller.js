(function () {
  'use strict';

  function MainController($location, identity, auth) {

    var vm = this;

    // for initial load of the page

    if (localStorage.currentUser) {
      vm.currentUser = {};
      vm.currentUser.email = localStorage.currentUser;
    }

    waitForLogin();

    vm.logout = function Logout() {
      auth.logout();
      vm.currentUser = undefined;

      // for second login
      waitForLogin();

      $location.path('/');
    };

    function waitForLogin() {
      if (vm.currentUser) {
        return;
      }

      identity.getUser()
        .then(function (user) {
          vm.currentUser = user;
        });
    }
  }

  angular.module('ticTacToe')
    .controller('MainController', ['$location', 'identity', 'auth', MainController]);
}());