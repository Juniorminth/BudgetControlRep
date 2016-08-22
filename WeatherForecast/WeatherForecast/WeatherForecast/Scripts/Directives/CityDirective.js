myApp.directive('autoComplete', function ($timeout) {
    return function (scope, elem, attrs) {
        elem.autocomplete({
            source: {} ,
            select: function () {
                $timeout(function () {
                    elem.trigger('input');
                }, 0);
            }
        });
    };
});