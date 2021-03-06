angular.module('tutorialCtrlMod', [])

.controller('tutController', ['$scope', '$routeParams', 'Math', function($scope, $routeParams, Math) {

	$scope.tutObject = {};
	$scope.tutObject.str1 = "Str1";
	$scope.tutObject.str2 = "Str2";
	$scope.tutObject.number = 2;
	
	$scope.timesTwo = function(){
		$scope.tutObject.number *=2;
	}

	$scope.sq = function(input) {
		$scope.tutObject.number = Math.sq(input);
	}

	$scope.param = $routeParams.param;

}]) // end of tutController

.controller('tutController2' ["$scope", function($scope) {

	$scope.secondTutorial = "This is the second tutorial!";

}])// end of tutController2

.directive("nkWelcomeMessage", function() {

	return {
		restrict: "E",
		template: "<div>Hello!</div>"
	}


})

.factory("Math", function() {
	var result = {};
	result.sq = function(input) {

		return result = input * input;

	};

	return result; // final return

});