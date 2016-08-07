angular.module("iassetApp", ['ngRoute'])
.controller('gateController', function ($scope, $http, $routeParams) {
    $scope.Title = "Gate management app";

        
    $scope.unAssignedFlights = [];

    console.log($routeParams.flightNo);

    $scope.cancel = function (FlightNo) {
        $scope.currentGate.Flights = $scope.currentGate.Flights.filter(function (flight) {
            var result = flight.FlightNo != FlightNo;
            if (!result) {
                $scope.unAssignedFlights.push(flight);
            }
            return result;
        });
    };

    $scope.edit = function () {
        console.log($routeParams.flightNo)
    }

    $scope.select = function (gate) {
        $scope.currentGate = gate;
    };

    $scope.AddToCurrentGate = function (FlightNo) {
        var no = FlightNo;
        $scope.unAssignedFlights = $scope.unAssignedFlights.filter(function (flight) {
            if (flight.FlightNo == no) {
                $scope.currentGate.Flights.push(flight);
            }
            return flight.FlightNo != no;
        });
    }
});