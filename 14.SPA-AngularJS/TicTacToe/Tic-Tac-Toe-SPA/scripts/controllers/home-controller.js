(function () {

  'use strict';

  function HomeController() {
    var vm = this;

    vm.hi = 'Hi from home!';
  }

  angular.module('ticTacToe.controllers')
    .controller('HomeController', [HomeController]);

}());