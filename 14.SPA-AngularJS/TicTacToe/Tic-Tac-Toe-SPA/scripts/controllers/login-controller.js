(function () {

  'use strict';

  function LoginController(toaster, auth, $location) {
    var vm = this;

    vm.login = function (login, loginForm) {

      var user = login || {};

      if (loginForm.$valid) {

        auth.login(user)
          .then(function () {
            toaster.success("Login successful!");
            $location.path('/')
          }, function(){
            toaster.error("Please try again!");
          });
      }
    };
  }

  angular.module('ticTacToe.controllers')
    .controller('LoginController', ['toaster', 'auth', '$location', LoginController]);
}());