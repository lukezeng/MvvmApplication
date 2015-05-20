app.config(function($routeProvider, $locationProvider) {
    $routeProvider.
        when("/", {
            controller: "HomeCtrl",
            templateUrl: "/Templates/home.html"
        }).
        when("/about", {
            controller: "AboutCtrl",
            templateUrl: "/Templates/about.html"
        }).
        when("/contact", {
            controller: "ContactCtrl",
            templateUrl: "/Templates/contact.html"
        }).
        when("/theme", {
            controller: "ThemeCtrl",
            templateUrl: "/Templates/theme.html"
        }).
        when("/topCompanies", {
            controller: "topCompaniesCtrl",
            templateUrl: "/Templates/topCompanies.html"
        });
});