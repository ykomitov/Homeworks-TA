(function () {
  'use strict';

  function filteredProjects() {

    return {
      restrict: 'A',
      templateUrl: 'views/directives/filtered-projects-directive.html'
    }
  }

  angular.module('myApp.directives')
    .directive('filteredProjects', [filteredProjects]);
}());