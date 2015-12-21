(function () {
    'use strict';

    function config($routeProvider) {
        var CONTROLLER_AS_VIEW_MODEL = 'vm';

        $routeProvider
             .when('/', {
                 templateUrl: 'views/partials/home/home.html',
                 controller: 'HomeController',
                 controllerAs: CONTROLLER_AS_VIEW_MODEL
             })
             .when('/unauthorized', {
                 template: '<div><h1 class="text-center">You are not authorized!</h1></div>'
             })
            .when('/trips', {
                templateUrl: 'views/partials/trips/trips.html',
                controller: 'TripsController',
                controllerAs: CONTROLLER_AS_VIEW_MODEL
            })
            .when('/trips/create', {
                templateUrl: 'views/partials/trips/create-trips.html',
                controller: 'CreateTripsController',
                controllerAs: CONTROLLER_AS_VIEW_MODEL
            })
            .when('/drivers', {
                templateUrl: 'views/partials/drivers/drivers.html',
                controller: 'DriversController',
                controllerAs: CONTROLLER_AS_VIEW_MODEL
            })
            .when('/register', {
                templateUrl: 'views/partials/identity/register.html',
                controller: 'SignUpCtrl'
            })
            .otherwise({ redirectTo: '/' });
    }

    angular.module('myApp.services', []);
    angular.module('myApp.directives', []);
    angular.module('myApp.controllers', ['myApp.services']);
    angular.module('myApp', ['ngRoute', 'ngCookies', 'myApp.controllers', 'myApp.directives']).
        config(['$routeProvider', config])
        .value('toastr', toastr)
        .constant('baseServiceUrl', 'http://spa2014.bgcoder.com');
}());