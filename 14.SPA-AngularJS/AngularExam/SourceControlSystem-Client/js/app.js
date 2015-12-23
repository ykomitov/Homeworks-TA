(function () {
  'use strict';

  function config($routeProvider) {
    var CONTROLLER_AS_VIEW_MODEL = 'vm';

    var routeResolvers = {
      authenticationRequired: {
        authenticate: ['$q', 'identity', function ($q, identity) {
          if (identity.isAuthenticated()) {
            return true;
          }

          return $q.reject('Not authorized!');
        }]
      }
    };

    $routeProvider
      .when('/', {
        templateUrl: 'views/partials/home/home.html',
        controller: 'HomeController',
        controllerAs: CONTROLLER_AS_VIEW_MODEL
      })
      .when('/unauthorized', {
        template: '<div><h1 class="text-center">You are not authorized!</h1></div>'
      })
      .when('/projects', {
        templateUrl: 'views/partials/projects/projects.html',
        controller: 'ProjectsController',
        controllerAs: CONTROLLER_AS_VIEW_MODEL
      })
      .when('/projects/add', {
        templateUrl: 'views/partials/projects/add-project.html',
        controller: 'AddProjectController',
        controllerAs: CONTROLLER_AS_VIEW_MODEL,
        resolve: routeResolvers.authenticationRequired
      })
      .when('/projects/:id', {
        templateUrl: 'views/partials/projects/project-info.html',
        controller: 'ProjectInfoController',
        controllerAs: CONTROLLER_AS_VIEW_MODEL,
        resolve: routeResolvers.authenticationRequired
      })
      .when('/projects/:id/addcommits', {
        templateUrl: 'views/partials/commits/add-commit.html',
        controller: 'AddCommitsController',
        controllerAs: CONTROLLER_AS_VIEW_MODEL,
        resolve: routeResolvers.authenticationRequired
      })
      .when('/commits', {
        templateUrl: 'views/partials/commits/commits.html',
        controller: 'CommitsController',
        controllerAs: CONTROLLER_AS_VIEW_MODEL
      })
      .when('/commits/:id', {
        templateUrl: 'views/partials/commits/commits-info.html',
        controller: 'CommitsInfoController',
        controllerAs: CONTROLLER_AS_VIEW_MODEL,
        resolve: routeResolvers.authenticationRequired
      })
      .when('/register', {
        templateUrl: 'views/partials/identity/register.html',
        controller: 'SignUpCtrl'
      })
      .otherwise({redirectTo: '/'});
  }

  function run($rootScope, $location) {

    $rootScope.$on('$routeChangeError', function (ev, current, previous, rejection) {
      if (rejection === 'Not authorized!') {
        $location.path('/unauthorized');
      }
    });

  }

  angular.module('myApp.services', []);
  angular.module('myApp.directives', []);
  angular.module('myApp.filters', []);
  angular.module('myApp.controllers', ['myApp.services']);
  angular.module('myApp', ['ngRoute', 'ngCookies', 'kendo.directives', 'myApp.controllers', 'myApp.directives', 'myApp.filters']).
    config(['$routeProvider', config])
    .run(['$rootScope', '$location', run])
    .value('toastr', toastr)
    .constant('baseServiceUrl', 'http://spa.bgcoder.com');
}());