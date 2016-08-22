myApp.controller('CityController', ['$scope', 'CityFactory', function ($scope, CityFactory) {
    CityFactory.success(function(data){
        $scope.Cities = data;
        $scope.SelectedCity = '';
        $scope.SetSelected = function (city) {
            $scope.SelectedCity = city;
        }
    });
     
}]);
