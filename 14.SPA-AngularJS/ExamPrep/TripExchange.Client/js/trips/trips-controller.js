(function () {
    'use strict';

    function TripsController(trips, cities, identity) {
        var vm = this;
        vm.identity = identity;
        vm.request = {
            page: 1
        };

        vm.filterTrips = function () {
            trips.filterTrips(vm.request)
            .then(function (filteredTrips) {
                vm.trips = filteredTrips;
            });
        }

        vm.prevPage = function () {
            if (vm.request.page == 1) {
                return;
            }
            vm.request.page--;
            vm.filterTrips();
        }

        vm.nextPage = function () {
            vm.request.page++;
            vm.filterTrips();
        }

        trips.getPublicTrips()
             .then(function (trips) {
                 vm.trips = trips;
             });

        cities.getAllCities()
              .then(function (allCities) {
                  vm.cities = allCities;
              });
    }

    angular.module('myApp.controllers')
           .controller('TripsController', ['trips', 'cities', 'identity', TripsController]);

}());