(function () {
  'use strict';

  function AddCommitsController($location, $routeParams, identity, commits, notifier) {
    var vm = this;
    vm.identity = identity;
    vm.id = $routeParams.id;

    vm.addCommit = function (commit) {
      commit.projectId = vm.id;
      commits.createCommit(commit)
        .then(function () {
          notifier.success('Commit added successfully!');
          $location.path('/projects/' + vm.id);
        });
    }
  }

  angular.module('myApp.controllers')
    .controller('AddCommitsController', ['$location', '$routeParams', 'identity', 'commits', 'notifier', AddCommitsController]);

}());