angular.module('tutorialCtrlMod', [])

.controller('tutController', ['$scope', 'Math', function($scope, Math) {

	$scope.tutObject = {};
	$scope.tutObject.str1 = "Str1";
	$scope.tutObject.str2 = "Str2";
	$scope.tutObject.number = '2';
	
	$scope.timesTwo = function(){
		$scope.tutObject.number *=2;
	}

	$scope.sq = function(input) {
		$scope.tutObject.number = Math.sq(input);
	}

	}])

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