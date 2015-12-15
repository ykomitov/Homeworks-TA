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
                });
            }
        };
    };

    angular.module('catApp.controllers')
           .controller('LoginController', ['toaster', 'auth', '$location', LoginController]);
}());