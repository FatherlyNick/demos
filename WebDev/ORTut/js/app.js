var app = angular.module('tutorialApp', ["ngRoute","tutorialCtrlMod"]);

app.controller("HomeController", ["$scope", function($scope){
    $scope.page = {};
    $scope.page.name = "!PLACEHOLDER!";
    $scope.page.Home = "Home";
    $scope.page.sp = "Second Page";
    $scope.page.tp = "Third Page";

}]);

app.controller("ListCtrl", ["$scope", function($scope) {

    $scope.myItems = [

        { itemName: 'Item 1'},
        { itemName: 'Item 2'},
        { itemName: 'Item 3'},
        { itemName: 'Item 4'},
        { itemName: 'Item 5'}
    ]

}]);

app.config(function ($routeProvider) {
    
    $routeProvider

        .when('/', {
            //$scope.page.title: 'Home';
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
        .when("/rpPage/:param", {
            templateUrl: "rpPage.html",
            controller: "tutController"
        })
        .otherwise({
            templateUrl: 'notFound.html'
        });
});