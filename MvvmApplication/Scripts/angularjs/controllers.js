var controllers = angular.module("controllers", []);

controllers.controller("HomeCtrl", ['$scope', function ($scope) {
    $scope.title = 'Hello HomeCtrl';
}]);