using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        public MemberDAO() { }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }

                    return instance;
                }
            }
        }

        public IEnumerable<MemberObject> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Member";
            var Members = new List<MemberObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    Members.Add(new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return Members;
        }


        public MemberObject GetMemberByID(int memberId)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * " +
                "from Member where MemberId = @MemberId";
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }
        public void insertMember(MemberObject member)
        {
            try
            {
                MemberObject pro = GetMemberByID(member.MemberId);
                if (pro == null)
                {
                    string SQLInsert = "Insert Member values(@MemberId,@Email,@CompanyName,@City,@Country,@Password)";
                    var parameters = new List<SqlParameter>
                    {
                        dataProvider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32),
                        dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String),
                        dataProvider.CreateParameter("@CompanyName", 50, member.CompanyName, DbType.String),
                        dataProvider.CreateParameter("@City", 50, member.City, DbType.String),
                        dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String),
                        dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String)
                    };
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());

                }
                else
                {
                    throw new Exception("The member is already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(MemberObject member)
        {
            try
            {
                MemberObject pro = GetMemberByID(member.MemberId);
                if (pro != null)
                {
                    string SQLUpdate = "Update Member set Email = @Email,CompanyName = @CompanyName," +
                        "City = @City,Country=@Country,Password=@Password where MemberId=@MemberId";
                    var parameters = new List<SqlParameter>
                    {
                        dataProvider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32),
                        dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String),
                        dataProvider.CreateParameter("@CompanyName", 50, member.CompanyName, DbType.String),
                        dataProvider.CreateParameter("@City", 50, member.City, DbType.String),
                        dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String),
                        dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String)
                    };
                    dataProvider.Insert(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member does not exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int memberId)
        {
            try
            {
                MemberObject member = GetMemberByID(memberId);
                if (member != null)
                {
                    string SQLDelete = "Delete Member where MemberId = @MemberId";
                    var param = dataProvider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The member does not already exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public MemberObject GetMemberByEmailAndPassword(string email, string password)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select * from Member where Email=@Email and Password=@Password";
            try
            {
                var param = new SqlParameter[]
                {
                    dataProvider.CreateParameter("@Email", 50, email, DbType.String),
                    dataProvider.CreateParameter("@Password", 50, password, DbType.String)
                };                
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }
    }
}

