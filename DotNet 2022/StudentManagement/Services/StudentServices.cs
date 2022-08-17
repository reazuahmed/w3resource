using Dapper;
using StudentManagement.Models;
using System.Data;
using System.Data.SqlClient;


namespace StudentManagement.Services
{
    public class StudentServices : IStudentServices
    {
        private readonly IConfiguration _configuration;

        public StudentServices(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("DBConnection");
            providerName = "System.Data.SqlClient";
        }

        public string ConnectionString { get;}
        public string providerName { get;} 
        public IDbConnection Connection
        {
            get { return new SqlConnection(ConnectionString); }
        }

        public string DeleteStudent(int StudentId)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentsList()
        {
            List<Student> students = new List<Student>();
            try
            {
                using(IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    students=dbConnection.Query<Student>("GetStudentList", CommandType.StoredProcedure).ToList();
                    dbConnection.Close();
                    return students;
                }
            }
            catch(Exception ex)
            {
                string errorMsg = ex.Message;
                return students;

            }
        }

        public string InsertStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public string UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
