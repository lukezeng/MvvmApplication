var controllers = angular.module("controllers", []);

controllers.controller("NavCtrl", ['$scope', "$location", function ($scope, $location) {
    $scope.isActive = function (route) {
        return route === $location.path();
    };
}]);

controllers.controller("HomeCtrl", ['$scope', function ($scope) {
    $scope.title = 'Hello HomeCtrl';
}]);