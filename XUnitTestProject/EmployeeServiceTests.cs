using EmployeeAPI.Interfaces;
using EmployeeAPI.Services;

namespace XUnitTestProject
{
    public class EmployeeServiceTests
    {
        private readonly IEmployeeService _employeeService;
        bool is_disposed = false;

        public EmployeeServiceTests()
        {
            _employeeService = new EmployeeService();
        }

        [Fact]
        public void Add_NullEmployee_ThrowsException()
        {
            Assert.False(true);
        }

        [Fact]
        public void Add_ValidEmployee_ReturnsAllEmployees()
        {
            Assert.False(true);
        }

        [Fact]
        public void Delete_InvalidId_ThrowsException()
        {
            Assert.False(true);
        }

        [Fact]
        public void Delete_ValidId_ReturnsAllEmployees()
        {
            Assert.False(true);
        }

        [Fact]
        public void GetAll_ReturnsAllEmployees()
        {
            var result = _employeeService.GetAll();
            Assert.Equal(5, result.Count);
;        }

        [Fact]
        public void GetById_InvalidId_ReturnsNotFound()
        {
            Assert.False(true);
        }

        [Fact]
        public void GetById_ValidId_ReturnsEmployee()
        {
            Assert.False(true);
        }

        [Fact]
        public void Update_NullEmployee_ThrowsExpection()
        {
            Assert.False(true);
        }

        [Fact]
        public void Update_InvalidId_ReturnsNotFound()
        {
            Assert.False(true);
        }

        [Fact]
        public void Update_ValidEmployee_ReturnsAllEmployees()
        {
            Assert.False(true);
        }

        [Fact]
        public void ValidateEmail_InvalidFormat_ReturnsFalse()
        {
            Assert.False(true);
        }

        [Fact]
        public void ValidateEmail_ValidFormat_ReturnsTrue()
        {
            Assert.False(true);
        }

        [Fact]
        public void GetEmployeeCount_ReturnsCountOfEmployees()
        {
            var result = _employeeService.GetEmployeeCount();
            Assert.False(result == 0);
        }

        public void Dispose()
        {
            // Clean up tasks
            Dispose(true);
            // Tell the GC not to finalize
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!is_disposed) // only dispose once!
            {
                if (disposing)
                {
                    // Not in destructor, OK to reference other objects
                }
                // Perform clean up for this object
                // Disposing
            }
            this.is_disposed = true;
        }

        ~EmployeeServiceTests()
        {
            Dispose(false);
        }
    }
}