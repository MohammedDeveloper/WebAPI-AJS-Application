
/// app employee service...
myApp.service("employeeService", ["$http", function ($http) {

    /// set the url api
    this.baseDataApi = "/api/GEPEmployee/getbasedata";

    /// Get base data
    this.getBaseData = function () {

        /// return the http response
        return $http.get(this.baseDataApi).then(function (response) {

            /// return the response
            return response.data;
        }, function (errorResponse) {

            /// log the error response
            console.log(errorResponse)
        });
    };

    /// Get base employees by Status and Dept
    this.getEmployees = function (statusId, deptId) {
        
        /// set the uri
        this.getEmployeesApi = "/api/gepemployee/getemployees" + "?statusId=" + statusId + "&deptId=" + deptId;

        /// return the http response
        return $http.get(this.getEmployeesApi)
            .then(function (response) {

            /// return the response
            return response.data;
        }, function (errorResponse) {

            /// log the error response
            console.log(errorResponse)
        });
    };
}]);
