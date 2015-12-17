(function () {
    'use strict';

    function AddCatController(cats) {

        var vm = this;

        vm.addCat = function (cat, catForm) {
            if (catForm.$valid) {
                cats.addCat(cat)
                .then(function () {
                    console.log('Cat added!');
                });
            }
        };
    };

    angular.module('catApp.controllers')
           .controller('AddCatController', ['cats', AddCatController]);
}());