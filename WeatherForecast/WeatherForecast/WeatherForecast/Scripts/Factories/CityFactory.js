myApp.factory("CityFactory", ["$http",function ($http,short) {
        return $http.get('/Home/GetCity', {
                        shortCut: short
                    }
                    ).success(function (data) {
                        return data;
                    }
                    ).error(function (e, r, o) {
                        return e;
                    });
    }
]);
