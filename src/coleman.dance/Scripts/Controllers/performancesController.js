(function () {
    'use strict';

    angular
        .module('app')
        .controller('PerformancesListController', PerformancesListController);

    /* Performance List Controller  */
    PerformancesListController.$inject = ['$scope', 'Performance'];

    function PerformancesListController($scope, Performance) {
        $scope.performances = Performance.query();
    }

})();
