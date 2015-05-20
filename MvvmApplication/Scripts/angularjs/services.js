var services = angular.module("services", []);

services.factory("companies", [
    "$resource", function($resource) {
        var webApi = "rest/Company/:id";
        return {
            get: function() { return $resource(webApi).query() },
            save: function(company) { return $resource(webApi).save(company) },
            remove: function(id) { return $resource(webApi, { id: id }).delete() }
        };
    }
]);