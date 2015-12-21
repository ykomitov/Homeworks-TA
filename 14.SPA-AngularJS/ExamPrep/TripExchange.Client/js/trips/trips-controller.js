(function () {
    'use strict';

    function TripsController(trips, identity) {
        var vm = this;
        vm.identity = identity;

        trips.getPublicTrips()
             .then(function (trips) {
                 vm.publicTrips = trips;
             });
    }

    angular.module('myApp.controllers')
           .controller('TripsController', ['trips', 'identity', TripsController]);

}());