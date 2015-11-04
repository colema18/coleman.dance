(function () {
    'use strict';

    angular
        .module('performancesServices', ['ngResource'])
        .factory('Performance', Performance);

    Performance.$inject = ['$resource'];

    function Performance($resource) {
        return $resource('/api/performances/:id');
    }
})();