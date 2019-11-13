var app = angular.module('tutorialApp', ["ngRoute","tutorialCtrlMod"]);

app.config(function ($routeProvider) {
    
    $routeProvider

        .when('/', {
            templateUrl: 'home.html',
            controller: 'tutController'
        })
        .when('/tutorial', {
            templateUrl: 'tutorial.html',
            controller: 'tutController'
        })
        .when("/tutorialSecond", {
            templateUrl: "tutorialSecond.html",
            controller: "tutController"
        })
        .otherwise({
            templateUrl: 'notFound.html'
        });
});