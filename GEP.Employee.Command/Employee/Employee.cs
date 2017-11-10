using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEP.Employee.Command
{
    /// <summary>
    /// Represents the employee data
    /// </summary>
    public class EmployeeData
    {
        /// <summary>
        /// Gets or sets the Employee Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Employee Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Employee SurName
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// Gets or sets the Employee JoiningDate
        /// </summary>
        public string JoiningDate { get; set; }

        /// <summary>
        /// Gets or sets the Employee Id - Status Id
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// Gets or sets the Employee Id - Status Name
        /// </summary>
        public string StatusName { get; set; }

        /// <summary>
        /// Gets or sets the Employee Birth Date
        /// </summary>
        public string BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the Employee Id - Department Id
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the Employee Id - Department Name
        /// </summary>
        public string DepartmentName { get; set; }

    }
}
