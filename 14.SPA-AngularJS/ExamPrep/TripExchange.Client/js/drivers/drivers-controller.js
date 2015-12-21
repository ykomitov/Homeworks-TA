(function () {
    'use strict';

    function DriversController(drivers) {
        var vm = this;

        drivers.getPublicDrivers()
               .then(function (drivers) {
                   vm.publicDrivers = drivers;
               });
    }

    angular.module('myApp.controllers')
           .controller('DriversController', ['drivers', DriversController]);

}());