(function () {
    'use strict';

    function MainController($location, identity, auth) {

        var vm = this;

        // for initial load of the page
        waitForLogin();

        vm.logout = function Logout() {
            auth.logout();
            vm.currentUser = undefined;

            // for second login
            waitForLogin();

            $location.path('/');
        };

        function waitForLogin() {
            identity.getUser()
              .then(function (user) {
                  vm.currentUser = user;
              });
        };
    };

    angular.module('catApp')
           .controller('MainController', ['$location', 'identity', 'auth', MainController]);
}());