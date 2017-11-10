using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Employee.API.Base
{
    using GEP.Employee.Command;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Formatting;
    using System.Web.Http;

    /// <summary>
    /// Represents the GEP Employee API Controller
    /// </summary>
    public class GEPEmployeeController : ApiController
    {
        /// <summary>
        /// Set the static data to be used for the application - Employees
        /// </summary>
        public List<EmployeeData> listOfEmployees = new List<EmployeeData>()
        {
            new EmployeeData() { Id = 11111, Name = "TST-GEP-101", SurName = "TST-GEP-SUR-101", JoiningDate = "04/25/2010", StatusId = 1, StatusName = "Present", DepartmentId = 1, DepartmentName = "HR", BirthDate = "04/25/1990" },
            new EmployeeData() { Id = 22222, Name = "TST-GEP-102", SurName = "TST-GEP-SUR-102", JoiningDate = "05/22/2010", StatusId = 2, StatusName = "Absent", DepartmentId = 2, DepartmentName = "Development",BirthDate = "07/25/1995" },
            new EmployeeData() { Id = 33333, Name = "TST-GEP-103", SurName = "TST-GEP-SUR-103", JoiningDate = "06/05/2017", StatusId = 2, StatusName = "Absent",DepartmentId = 1, DepartmentName = "HR", BirthDate = "05/25/1989" },
            new EmployeeData() { Id = 44444, Name = "TST-GEP-104", SurName = "TST-GEP-SUR-104", JoiningDate = "04/15/2010", StatusId = 1, StatusName = "Present",DepartmentId = 3, DepartmentName = "Testing", BirthDate = "12/25/1985" },
            new EmployeeData() { Id = 55555, Name = "TST-GEP-105", SurName = "TST-GEP-SUR-105", JoiningDate = "07/09/2013", StatusId = 2, StatusName = "Absent", DepartmentId = 2, DepartmentName = "Development",BirthDate = "08/25/1987" },
            new EmployeeData() { Id = 66666, Name = "TST-GEP-106", SurName = "TST-GEP-SUR-106", JoiningDate = "09/08/2004", StatusId = 1, StatusName = "Present",DepartmentId = 1, DepartmentName = "HR", BirthDate ="04/22/1990" },
            new EmployeeData() { Id = 77777, Name = "TST-GEP-107", SurName = "TST-GEP-SUR-107", JoiningDate = "01/04/2017", StatusId = 1, StatusName = "Present", DepartmentId = 2, DepartmentName = "Development",BirthDate = "06/25/1992" }
        };

        /// <summary>
        /// Set the static data to be used for the application - Departments
        /// </summary>
        public List<DepartmentData> listOfDepartments = new List<DepartmentData>()
        {
            new DepartmentData() { Id = 1, Name = "HR" },
            new DepartmentData() { Id = 2, Name = "Development" },
            new DepartmentData() { Id = 3, Name = "Testing" },
            new DepartmentData() { Id = 4, Name = "Manager" }
        };

        /// <summary>
        /// Set the static data to be used for the application - Status
        /// </summary>
        public List<StatusData> listOfStatus = new List<StatusData>()
        {
            new StatusData() { Id = 1, Name = "Present" },
            new StatusData() { Id = 2, Name = "Absent" },
            new StatusData() { Id = 3, Name = "N/A" }
        };

        /// <summary>
        /// Constructor
        /// </summary>
        public GEPEmployeeController()
        {
        }


        /// <summary>
        /// Represents the API to query employees information
        /// </summary>
        /// <returns>
        /// Employees data
        /// </returns>
        [ActionName("GetEmployees")]
        public HttpResponseMessage GetEmployees(int? statusId, int? deptId)
        {
            try
            {
                /// Query based on the params passed...
                List<EmployeeData> listOfEmployeesTemp = (from employee in listOfEmployees
                                                          where

                                                          /// for the Status Id
                                                          (statusId.HasValue ? employee.StatusId == statusId : true)

                                                          &&

                                                          /// for the Department Id
                                                          (deptId.HasValue ? employee.DepartmentId == deptId : true)

                                                          /// select the items
                                                          select employee).ToList();

                /// Create the response...
                var response = Request.CreateResponse(HttpStatusCode.OK, new
                {
                    message = string.Empty,
                    status = HttpStatusCode.OK,
                    employees = listOfEmployeesTemp
                }, Configuration.Formatters.JsonFormatter);

                /// return the response
                return response;
            }
            catch (Exception ex)
            {
                /// returns the error response...
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        /// <summary>
        /// Represents the API to send Base data - Departments & Status
        /// </summary>
        /// <returns>
        /// Base data -  Departments & Status
        /// </returns>
        [ActionName("GetBaseData")]
        public HttpResponseMessage GetBaseData()
        {
            try
            {
                /// Create the response...
                var response = Request.CreateResponse(HttpStatusCode.OK, new
                {
                    message = string.Empty,
                    departments = listOfDepartments,
                    status = listOfStatus
                }, Configuration.Formatters.JsonFormatter);

                /// return the response
                return response;
            }
            catch (Exception ex)
            {
                /// returns the error response...
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
