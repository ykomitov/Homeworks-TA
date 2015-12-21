(function () {
    'use strict';

    function HomeController(statistics, trips, drivers) {
        var vm = this;

        statistics.getStats()
                  .then(function (stats) {
                      vm.stats = stats;
                  });

        trips.getPublicTrips()
             .then(function (trips) {
                 vm.publicTrips = trips;
             });

        drivers.getPublicDrivers()
               .then(function (drivers) {
                   vm.publicDrivers = drivers;
               });
    }

    angular.module('myApp.controllers')
           .controller('HomeController', ['statistics', 'trips', 'drivers', HomeController]);

}());