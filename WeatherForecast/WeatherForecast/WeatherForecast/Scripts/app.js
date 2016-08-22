var myApp = angular.module("myApp", ["ngRoute"]);

//myApp.directive('autocomp', ['CityFactory',function (CityFactory) {
//    return {
//        restrict: 'AE',
//        link: function (scope, elem, attr, ctrl) {
//            console.log(elem);
//            console.log(attr);
//            console.log(ctrl);
//            elem.autocomplete({
//                source: CityFactory.search(attr),
//                minLength: 3
//            });
//        }
//    };
//}]);

//myApp.factory('autoCompleteDataService', [function () {
//    return {
//        getSource: function () {
//            //this is where you'd set up your source... could be an external source, I suppose. 'something.php'
//            return ['apples', 'oranges', 'bananas'];
//        }
//    }
//}]);

//myApp.directive('autoComplete', function (autoCompleteDataService) {
//    return {
//        restrict: 'A',
//        link: function (scope, elem, attr, ctrl) {
//            // elem is a jquery lite object if jquery is not present,
//            // but with jquery and jquery ui, it will be a full jquery object.
//            elem.autocomplete({
//                source: autoCompleteDataService.getSource(), //from your service
//                minLength: 2
//            });
//        }
//    };
//});

