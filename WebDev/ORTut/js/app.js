var app = angular.module('tutorialApp', ["ngRoute","tutorialCtrlMod"]);

var routeConfig = function ($routeProvider) {

    $routeProvider.when('/', {
            templateUrl: 'home.html',
            controller: 'tutController'
        });
        $routeProvider.when('/tutorial', {
            templateUrl: 'tutorial.html',
            controller: 'tutController'
        });
        $routeProvider.when("/tutorialSecond", {
            templateUrl: "tutorialSecond.html",
            controller: "tutController"
        });
        $routeProvider.when("/", {
            templateUrl: "home.html",
            controller: "tutController"
        });
        $routeProvider.otherwise({
            templateUrl: 'notFound.html'
        });
};

app.config(routeConfig);