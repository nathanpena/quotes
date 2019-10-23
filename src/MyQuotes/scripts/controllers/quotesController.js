(function () {
    'use strict';

    angular
        .module('myQuotesApp')
        .controller('quotesController', quotesController);

    quotesController.$inject = ['$scope', 'Quotes']; 

    function quotesController($scope, Quotes) {
        $scope.quotes = Quotes.query();
    }
})();
