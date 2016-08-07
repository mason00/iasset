angular.module("iassetApp", ['ngRoute'])
    .controller("flightController", function ($scope, $http, $routeParams) {
        $scope.Title = "Edit flight";
        $scope.FlightNo = $routeParams.flightNo;

        init = function () {
            angular.forEach($scope.currentGate.Flights, function (val, key) {
                if (val.FlightNo == $scope.FlightNo) {
                    $scope.currentFlight = val;
                }
            });
        }

        init();

        $scope.save = function (flight) {
            console.log(flight);
        };
    });