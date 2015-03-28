app.config(function ($routeProvider, $locationProvider) {
    $routeProvider.
        when('/', {
            controller: 'HomeCtrl',
            templateUrl: '/Templates/home.html'
        }).
        when('/about', {
            controller: 'HomeCtrl',
            templateUrl: '/Templates/about.html'
        }).
        when('/contact', {
            controller: 'HomeCtrl',
            templateUrl: '/Templates/contact.html'
        }).
        when('/contactUs', {
            controller: 'contactUsCtrl',
            templateUrl: '/Templates/contactUs.html'
        }).
        when('/angualrExamples', {
            controller: 'examplesCtrl',
            templateUrl: '/Templates/angualrExamples.html'
        }).
        when('/jasmine', {
            controller: 'jasmineCtrl',
            templateUrl: '/Jasmine/SpecRunner.html'
        });
});