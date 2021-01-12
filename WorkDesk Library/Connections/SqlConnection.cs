using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkDesk_Library.Models;
using WorkDesk_Library.Models.Admin_Info;
using WorkDesk_Library.Models.Employee_Info;
using WorkDesk_Library.Models.Equipment_Info;
using static WorkDesk_Library.Models.Employee_Info.EmployeeModel;

namespace WorkDesk_Library.Connections
{
    class SqlConnection : IDataConnection
    {

        public EmployeeModel CreateEmployee(EmployeeModel NewEmployeeRecord) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))

            {
                var p = new DynamicParameters();
                p.Add("@LastName", NewEmployeeRecord.LastName);
                p.Add("@FirstName", NewEmployeeRecord.FirstName);
                p.Add("@HireDate", NewEmployeeRecord.HireDate);
                p.Add("@Email", NewEmployeeRecord.EmailList);
                p.Add("@Phone", NewEmployeeRecord.PhoneList);
                p.Add("@Nickname", NewEmployeeRecord.Nickname);
                p.Add("@JobTitleID", NewEmployeeRecord.JobTitle);
                p.Add(@"Department", NewEmployeeRecord.Department);
                p.Add(@"ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.Employees_Insert", p, commandType: CommandType.StoredProcedure);
                NewEmployeeRecord.ID = p.Get<int>("@ID");
                return NewEmployeeRecord;
            }
        }

        public EmailModel CreateEmail(EmailModel NewEmailRecord)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Address", NewEmailRecord.Address);
                p.Add("@Type", NewEmailRecord.Type);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spEmail_Insert", p, commandType: CommandType.StoredProcedure);

                NewEmailRecord.ID = p.Get<int>("@ID");
                return NewEmailRecord;

            }
        }

        public PhoneModel CreatePhone(PhoneModel NewPhoneRecord)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Number", NewPhoneRecord.Number);
                p.Add("@Type", NewPhoneRecord.Type);
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPhone_Insert", p, commandType: CommandType.StoredProcedure);
                NewPhoneRecord.ID = p.Get<int>("@ID");
                return NewPhoneRecord;
            }
        }

        public DepartmentModel CreateDepartment(DepartmentModel newDepartmentRecord)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Name");
                p.Add("#ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                newDepartmentRecord.ID = p.Get<int>("@ID");

                connection.Execute("dbo.spDepartment_Insert");

                return newDepartmentRecord;
            }
        }

        public TitleModel CreateTitle(TitleModel newTitleRecord)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Name");
                p.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                newTitleRecord.ID = p.Get<int>("@ID");

                connection.Execute("dbo.spTitle_Insert");

                return newTitleRecord;
            }
        }

        public EquipmentModel CreateEquipment(EquipmentModel newEquipmentRecord)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var p = new DynamicParameters();
                p.Add("@Inventoryid");
                p.Add("@Description");
                p.Add("@PurchaseDate");
                p.Add("@PONumber");
                p.Add("@Cost");
                p.Add("@Class");
                p.Add("@SerialNumber");
                p.Add("@Department");
                p.Add("@CICRequired");
                p.Add("@WarrantyMonths");
                p.Add("@Vendor");
                p.Add("@Note");

                p.Add("@ID", dbType: DbType.Int32, direction: ParameterDirection.Output);

                newEquipmentRecord.ID = p.Get<int>("@id");

                return newEquipmentRecord;
            }
        }

        public async Task<List<EmployeeModel>> GetEmployeeList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var sql = @"SELECT e.id, e.FirstName, e.LastName, e.Nickname,
                                   em.EmployeeID, em.Address, em.Type, 
                                   e.JobTitleID, jt.id, jt.Name, 
                                   p.EmployeeID, p.Number, p.Type,
                                   ect.EmployeeID, ect.NameID, ect.InitialDate, ect.ExpirationDate,
                                   ct.id, ct.Name,
                                   ecit.EmployeeID, ecit.CitationTypeID, ecit.Description, ecit.Date,
                                   cit.id, cit.Name,
                                   e.DepartmentID, d.DepartmentName
                                   

                          FROM dbo.Employees e 
                          LEFT JOIN dbo.Emails em
                          ON em.EmployeeID = e.id
                          LEFT JOIN dbo.JobTitles jt                           
                          ON e.JobTitleID = jt.id
                          LEFT JOIN Phones p
                          ON p.EmployeeID = e.id
                          LEFT JOIN dbo.EmployeeCertificationType ect
                          ON ect.EmployeeID = e.id
                          LEFT JOIN dbo.CertificationType ct
                          ON ect.NameID = ct.id
                          LEFT JOIN dbo.EmployeeCitationType ecit
                          ON ecit.EmployeeID = e.id
                          LEFT JOIN dbo.CitationTypes cit
                          ON ecit.CitationTypeID = cit.id
                          LEFT JOIN dbo.Departments d
                          ON e.DepartmentID = d.id"; 

                var employees = await connection.QueryAsync<EmployeeModel, EmailModel, TitleModel, PhoneModel, CertificationModel, CitationModel, DepartmentModel, EmployeeModel>(sql, (e, em, t, p, c, ci, d) =>
                {
                    e.EmailList.Add(em);
                    e.JobTitle = t;
                    e.Department = d;
                    e.PhoneList.Add(p);
                    e.CertificationList.Add(c);
                    e.CitationsList.Add(ci);
                    return e;
                }, splitOn: "EmployeeID, JobTitleID, EmployeeID, EmployeeID, EmployeeID, DepartmentID");

                var result = employees.GroupBy(e => e.ID).Select(g =>
                {
                    var groupedEmployee = g.First();
                    groupedEmployee.EmailList = g.Select(e => e.EmailList.Single()).ToList();
                    groupedEmployee.PhoneList = g.Select(e => e.PhoneList.Single()).ToList();
                    groupedEmployee.CertificationList = g.Select(e => e.CertificationList.Single()).ToList();
                    groupedEmployee.CitationsList = g.Select(e => e.CitationsList.Single()).ToList();
                    return groupedEmployee;
                });
                return result.ToList();
            }
        }

        public async Task<List<EmployeeModel>> GetSelectedEmployee(int selectedEmployeeID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var par = new
                {
                    SelectedEmployeeID = selectedEmployeeID
                };

                var sql = @"SELECT e.id, e.FirstName, e.LastName, e.Nickname, 
                                   em.EmployeeID, em.Address, em.Type, 
                                   e.JobTitleID, jt.id, jt.Name, 
                                   p.EmployeeID, p.Number, p.Type,
                                   ect.EmployeeID, ect.NameID, ect.InitialDate, ect.ExpirationDate,
                                   ct.id, ct.Name
                          
                          FROM dbo.Employees e 
                          LEFT JOIN dbo.Emails em
                          ON em.EmployeeID = e.id
                          LEFT JOIN dbo.JobTitles jt  
                          ON e.JobTitleID = jt.id
                          LEFT JOIN Phones p
                          ON p.EmployeeID = e.id
                          LEFT JOIN dbo.EmployeeCertificationType ect
                          ON ect.EmployeeID = e.id
                          LEFT JOIN dbo.CertificationType ct
                          ON ect.NameID = ct.id
                          WHERE e.id = @SelectedEmployeeID";

                List<EmployeeModel> selectedEmployee = new List<EmployeeModel>();

                var employees = await connection.QueryAsync<EmployeeModel, EmailModel, TitleModel, PhoneModel, CertificationModel, EmployeeModel>(sql, (e, em, t, p, c) =>
                {
                    e.EmailList.Add(em);
                    e.JobTitle = t;
                    e.PhoneList.Add(p);
                    e.CertificationList.Add(c);
                    return e;
                },
                    par, splitOn: "EmployeeID, JobTitleID, EmployeeID, EmployeeID");

                var groupedEmployees = employees.GroupBy(x => x.ID);
                
                foreach (EmployeeModel empmod in groupedEmployees)
                {
                    empmod.EmailList.GroupBy(eml => eml.Address);
                    empmod.CertificationList.GroupBy(clm => clm.Name);
                    empmod.PhoneList.GroupBy(plm => plm.Number);
                }

                IEnumerable<EmployeeModel> groupedEmployeeList = groupedEmployees.SelectMany(group => group);

                return groupedEmployeeList.ToList();
            
            }

            
        }
        public async Task<List<EquipmentModel>> GetEquipmentList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var sql = @"SELECT e.id, e.InventoryID, e.Description, e.Brand, c.EquipmentID, c.Note
                            FROM Equipment e
                            LEFT JOIN Comments c
                            ON c.EquipmentID = e.id";

                var equipment = await connection.QueryAsync<EquipmentModel, CommentModel, EquipmentModel>(sql, (equipmentItem, comment) =>
                {
                    equipmentItem.CommentList.Add(comment);
                    return equipmentItem;
                }, splitOn: "EquipmentID");

                var result = equipment.GroupBy(e => e.ID).Select(g =>
                {
                    var groupedEquipmentItem = g.First();
                    groupedEquipmentItem.CommentList = g.Select(e => e.CommentList.Single()).ToList();
                    return groupedEquipmentItem;
                });
                return result.ToList();
            }
        }

    }
 }

 

//I have a list of PersonModel in an IEnumerable.  I want to group it on ID.
//I would, presumably, then have only one Person ID, and the EmailList and 


