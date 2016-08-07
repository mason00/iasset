angular.module("iassetApp")
    .controller("appController", function ($scope, $http, $routeParams) {
        $scope.Title = "MyTest";
        $scope.gates = {};
        $scope.currentGate = {};

        $http.get('/api/Gate/Test')
        .success(function (data) {
            $scope.gates = data;
            $scope.currentGate = $scope.gates[0];
            for (var i = 0; i < $scope.gates.length; i++) {
                for (var j = 0; j < $scope.gates[i].Flights.length; j++) {
                    $scope.gates[i].Flights[j].Arrival = new Date($scope.gates[i].Flights[j].Arrival).toLocaleTimeString();
                    $scope.gates[i].Flights[j].Depature = new Date($scope.gates[i].Flights[j].Depature).toLocaleTimeString();
                }
            }

        })
        .error(function (data) {
            console.log('get gates data error');
        });
    });
            
           