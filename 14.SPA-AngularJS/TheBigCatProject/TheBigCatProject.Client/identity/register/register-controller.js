(function () {

    'use strict';

    function RegisterController(toaster, auth, $location) {
        var vm = this;

        vm.register = function (user, registerForm) {

            var user = user || {};

            if (!user.displayName) {
                user.displayName = user.email.substring(0, user.email.indexOf("@"));
            }

            if (registerForm.$valid && user.password === user.confirmPassword) {

                auth.register(user)
                .then(function () {
                    toaster.success("Registration successful!");
                    $location.path('/identity/login')
                });
            }
            else if (user.email === undefined) {
                toaster.error("Please enter a valid email!");
            }
            else if (user.password === undefined) {
                toaster.error("Please enter a password!");
            }
            else {
                toaster.error("Password & confirmation do not match!");
            }
        };
    };

    angular.module('catApp.controllers')
           .controller('RegisterController', ['toaster', 'auth', '$location', RegisterController]);
}());