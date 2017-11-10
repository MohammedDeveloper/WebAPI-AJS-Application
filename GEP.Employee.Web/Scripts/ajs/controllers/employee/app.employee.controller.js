
/// app employee controller...
myApp.controller("employeeCtrl", ["$scope", "employeeService", function ($scope, $employeeService) {

    /// set the base variables
    $scope.isSelected = false;

    /// get base data...
    $scope.getBaseData = function () {

        /// call the service and get the base data
        $employeeService.getBaseData().then(function (data) {

            /// set the departments and status
            $scope.departments = data.departments;
            $scope.statuses = data.status;
        });

        /// call the service and get Employees
        $employeeService.getEmployees(null, null).then(function (data) {

            /// set the employees
            $scope.employees = data.employees;
        });
    };

    /// fetch employees...
    $scope.fetchEmployees = function () {
        
        /// call the service and get Employees
        $employeeService.getEmployees($scope.status, $scope.department).then(function (data) {

            /// set the employees
            $scope.employees = data.employees;
        });
        
        /// set this by default
        $scope.isSelected = false;
        $scope.closeDetails();
    };

    /// view employee info...
    $scope.viewEmployee = function (emp) {

        /// set this to employee
        $scope.employee = emp;
        $scope.isSelected = true;
    };

    /// close view employee info...
    $scope.closeDetails = function (emp) {

        /// set this to employee
        $scope.employee = null;
        $scope.isSelected = false;
    };

    /// call in onload
    $scope.getBaseData();
}]);
