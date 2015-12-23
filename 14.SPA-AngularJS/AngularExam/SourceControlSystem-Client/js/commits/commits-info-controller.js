(function () {
  'use strict';

  function CommitsInfoController($routeParams, identity, commits) {
    var vm = this;
    vm.identity = identity;
    vm.id = $routeParams.id;

    commits.getCommitsById(vm.id)
      .then(function (info) {
        vm.commitInfo = info;
      });

  }

  angular.module('myApp.controllers')
    .controller('CommitsInfoController', ['$routeParams', 'identity', 'commits', CommitsInfoController]);

}());