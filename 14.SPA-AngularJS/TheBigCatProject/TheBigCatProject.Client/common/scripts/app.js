﻿(function () {
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
                templateUrl: 'home/home.html',
                controller: 'HomeController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/identity/register', {
                templateUrl: 'identity/register/register.html',
                controller: 'RegisterController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/identity/login', {
                templateUrl: 'identity/login/login.html',
                controller: 'LoginController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/cats/add', {
                templateUrl: 'cats/addCat.html',
                controller: 'AddCatController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME,
                resolve: routeResolvers.authenticationRequired
                })
            .otherwise('/', {
                redirectTo: '/'
            });
    };

    function run($cookies, $http, $rootScope, $location, auth) {

        $rootScope.$on('$routeChangeError', function (ev, current, previous, rejection) {
            if (rejection === 'Not authorized!') {
                $location.path('/');
            }
        });

        if (auth.isAuthenticated()) {
            $http.defaults.headers.common.Authorization = 'Bearer ' + $cookies.get('authentication');
            auth.getIdentity();
        }
    };

    angular
        .module('catApp', ['ngRoute', 'ngCookies', 'ngMessages', 'catApp.controllers'])
        .config(['$routeProvider', '$locationProvider', config])
        .run(['$cookies', '$http', '$rootScope', '$location', 'auth', run])
        .constant('baseUrl', 'http://localhost:56315');

    angular.module('catApp.controllers', ['toaster', 'ngAnimate', 'catApp.services']);

    angular.module('catApp.services', []);


}());