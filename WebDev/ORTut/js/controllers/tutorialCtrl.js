angular.module('tutorialCtrlMod', [])

.controller('tutController', ['$scope', function($scope) {

	$scope.tutObject = {};
	$scope.tutObject.str1 = "Str1";
	$scope.tutObject.str2 = "Str2";
	$scope.tutObject.number = '2';

	$scope.timesTwo = function(){
		$scope.tutObject.number *=2;
	}

	}]);