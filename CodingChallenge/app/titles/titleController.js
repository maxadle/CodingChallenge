(function () {
    "use strict";

    angular.module('app')
            .controller("titleController",
                       ["$scope",
                        "titleResource",
                        titleController]);

    function titleController($scope, titleResource) {

        $scope.findTitleByDescription = function (descripcion) {
            return titleResource.query({
                $filter: "substringof('" + descripcion + "', Descripcion)"
            }).$promise;

        };
    }
}());