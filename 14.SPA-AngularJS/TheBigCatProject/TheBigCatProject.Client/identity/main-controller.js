(function () {
    'use strict';

    function MainController(identity, auth) {

        var vm = this;

        // for initial load of the page
        waitForLogin();

        vm.logout = function Logout() {
            auth.logout();
            vm.currentUser = undefined;

            // for second login
            waitForLogin();
        };

        function waitForLogin() {
            identity.getUser()
              .then(function (user) {
                  vm.currentUser = user;
              });
        };
    };

    angular.module('catApp')
           .controller('MainController', ['identity', 'auth', MainController]);
}());