angular.module("iassetApp")
    .controller("flightController", function ($scope, $http, $routeParams) {
        $scope.Title = "Edit flight";
        $scope.FlightNo = $routeParams.flightNo;
        $scope.GateNo = $routeParams.gateNo

        angular.forEach($scope.gates[$scope.GateNo].Flights, function (val, key) {
                if (val.FlightNo == $scope.FlightNo) {
                    $scope.currentFlight = val;
                }
        });

        $scope.save = function (flight) {
            console.log(flight);
        };
    });