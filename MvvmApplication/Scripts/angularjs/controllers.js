var controllers = angular.module("controllers", []);

controllers.controller("NavCtrl", [
    "$scope", "$location", function($scope, $location) {
        $scope.isActive = function(route) {
            return route === $location.path();
        };
    }
]);

controllers.controller("HomeCtrl", [
    "$scope", function($scope) {
        $scope.title = "Hello HomeCtrl";
    }
]);

controllers.controller("AboutCtrl", [
    "$scope", function($scope) {
        $scope.title = "Hello AboutCtrl";
    }
]);

controllers.controller("ContactCtrl", [
    "$scope", function($scope) {
        $scope.title = "Hello ContactCtrl";
    }
]);

controllers.controller("ThemeCtrl", [
    "$scope", function($scope) {
        $scope.title = "Hello ThemeCtrl";
    }
]);

controllers.controller("topCompaniesCtrl", [
    "$scope", "$http", "companies", function($scope, $http, companies) {

        $scope.company = {};
        $scope.companies = companies.get();
        $scope.companiesPerPage = 900;
        $scope.currentPage = 0;

        $scope.Save = function(company) {
            companies.save(company).$promise.then(
                function() {
                    $scope.companies.push(company);
                },
                function() { alert("NONO"); });
            $scope.company = {};
        };
        $scope.DeleteCompany = function(id) {
            companies.remove(id).$promise.then(
                function() {
                    $scope.companies = companies.get();
                });
        };
        $scope.prevPage = function() {
            if ($scope.currentPage > 0) {
                $scope.currentPage--;
            }
        };

        $scope.prevPageDisabled = function() {
            return $scope.currentPage === 0 ? "disabled" : "";
        };

        $scope.pageCount = function() {
            return Math.ceil($scope.companies.length / $scope.companiesPerPage) - 1;
        };

        $scope.nextPage = function() {
            if ($scope.currentPage < $scope.pageCount()) {
                $scope.currentPage++;
            }
        };

        $scope.nextPageDisabled = function() {
            return $scope.currentPage === $scope.pageCount() ? "disabled" : "";
        };

        $scope.setPage = function(n) {
            $scope.currentPage = n;
        };

        $scope.range = function() {
            var rangeSize = 4;
            var ret = [];
            var start;

            start = $scope.currentPage;
            if (start > $scope.pageCount() - rangeSize) {
                start = $scope.pageCount() - rangeSize + 1;
            }

            for (var i = start; i < start + rangeSize; i++) {
                if (i - 1 < $scope.pageCount() && i >= 0) {
                    ret.push(i);
                }
            }
            return ret;
        };

    }
]);