using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
                p.Add("@Email", NewEmployeeRecord.Emails);
                p.Add("@Phone", NewEmployeeRecord.Phones);
                p.Add("@Nickname", NewEmployeeRecord.NickName);
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

        public async Task<ObservableCollection<EmployeeModel>> GetEmployeeList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var sql = @"SELECT e.id, e.FirstName, e.LastName, e.Nickname, e.HireDate,
                                em.id as ID, em.Address, em.Type, 
                                jt.id as ID, jt.Name, 
                                p.id as ID, p.Number, p.Type,
                                d.id as ID, d.Name,
                                es.id as ID, es.Name,
						        ecitt.id as ID, cit.Name, ecitt.Date, ecitt.Description,
                                ecert.id as ID, cet.Name, cet.Description, ecert.InitialDate, ecert.EmployeeID,
						        eqa.id as ID, eq.InventoryID, eq.Description, eqa.DateOut, eqa.DateIn, eqa.ConditionOut, eqa.ConditionIn, eqa.DueDate   


                        FROM dbo.Employees e 
                        LEFT JOIN dbo.Emails em
                        ON em.EmployeeID = e.id
                        LEFT JOIN dbo.JobTitles jt                           
                        ON e.JobTitleID = jt.id
                        LEFT JOIN Phones p
                        ON p.EmployeeID = e.id
                        LEFT JOIN dbo.Departments d
                        ON e.DepartmentID = d.id
                        LEFT JOIN dbo.EmployeeStatus es  
                        ON e.StatusID = es.id
				        LEFT JOIN dbo.EmployeeCitationType ecitt
				        ON e.id = ecitt.EmployeeID
				        LEFT JOIN dbo.CitationTypes cit
				        ON ecitt.CitationTypeID = cit.id
				        LEFT JOIN dbo.EmployeeCertificationType ecert
				        ON e.id = ecert.EmployeeID
				        LEFT JOIN dbo.CertificationType cet
				        ON ecert.NameID = cet.id
				        LEFT JOIN EquipmentAssignments eqa
				        ON eqa.EmployeeID = e.id
				        LEFT JOIN Equipment eq
				        ON eqa.EquipmentID = eq.id";
                var employees = new Dictionary<int, EmployeeModel>();
                await connection.QueryAsync<EmployeeModel>
            (sql,
            new[]
            {
                    typeof(EmployeeModel),
                    typeof(EmailModel),
                    typeof(TitleModel),
                    typeof(PhoneModel),
                    typeof(DepartmentModel),
                    typeof(EmployeeStatusModel),
                    typeof(CitationModel),
                    typeof(CertificationModel),
                    typeof(EquipmentAssignmentRecordModel)
            }
            , obj =>
            {
                EmployeeModel employeeModel = obj[0] as EmployeeModel;
                EmailModel emailModel = obj[1] as EmailModel;
                TitleModel titleModel = obj[2] as TitleModel;
                PhoneModel phoneModel = obj[3] as PhoneModel;
                DepartmentModel departmentModel = obj[4] as DepartmentModel;
                EmployeeStatusModel statusModel = obj[5] as EmployeeStatusModel;
                CitationModel citationModel = obj[6] as CitationModel;
                CertificationModel certificationModel = obj[7] as CertificationModel;
                EquipmentAssignmentRecordModel equipmentAssignmentRecord = obj[8] as EquipmentAssignmentRecordModel;

                //employeemodel
                EmployeeModel employeeEntity = new EmployeeModel();
                if (!employees.TryGetValue(employeeModel.ID, out employeeEntity))
                {
                    employees.Add(employeeModel.ID, employeeEntity = employeeModel);
                }

                //list<emailmodel>
                if (employeeEntity.Emails == null)
                {
                    employeeEntity.Emails = new ObservableCollection<EmailModel>();
                }
                if (emailModel != null)
                {
                    if (!employeeEntity.Emails.Any(x => x.ID == emailModel.ID))
                    {
                        employeeEntity.Emails.Add(emailModel);
                    }
                }

                //phonemodel
                if (employeeEntity.Phones == null)
                {
                    employeeEntity.Phones = new ObservableCollection<PhoneModel>();
                }
                if (phoneModel != null)
                {
                    if (!employeeEntity.Phones.Any(x => x.ID == phoneModel.ID))
                    {
                        employeeEntity.Phones.Add(phoneModel);
                    }
                }

                //title
                if (employeeEntity.JobTitle == null)
                {
                    if (titleModel != null)
                    {
                        employeeEntity.JobTitle = titleModel;
                    }
                }

                //department
                if (employeeEntity.Department == null)
                {
                    if (departmentModel != null)
                    {
                        employeeEntity.Department = departmentModel;
                    }
                }

                //status
                if (employeeEntity.JobStatus == null)
                {
                    if (statusModel != null)
                    {
                        employeeEntity.JobStatus = statusModel;
                    }
                }

                //citation
                if (employeeEntity.Citations == null)
                {
                    employeeEntity.Citations = new ObservableCollection<CitationModel>();
                }
                if (citationModel != null)
                {
                    if (!employeeEntity.Citations.Any(x => x.ID == citationModel.ID))
                    {
                        employeeEntity.Citations.Add(citationModel);
                    }
                }

                //certification
                if (employeeEntity.Certifications == null)
                {
                    employeeEntity.Certifications = new ObservableCollection<CertificationModel>();
                }
                if (certificationModel != null)
                {
                    if (!employeeEntity.Certifications.Any(x => x.ID == certificationModel.ID))
                    {
                        employeeEntity.Certifications.Add(certificationModel);
                    }
                }

                //equipment record
                if (employeeEntity.EquipmentAssignments == null)
                {
                    employeeEntity.EquipmentAssignments = new ObservableCollection<EquipmentAssignmentRecordModel>();
                }
                if (equipmentAssignmentRecord != null)
                {
                    if (!employeeEntity.EquipmentAssignments.Any(x => x.ID == equipmentAssignmentRecord.ID))
                    {
                        employeeEntity.EquipmentAssignments.Add(equipmentAssignmentRecord);
                    }
                }
                return employeeEntity;
            }); ;

                var result = employees.Values.ToList();
                ObservableCollection<EmployeeModel> employeeCollection = new ObservableCollection<EmployeeModel>(result);
                return employeeCollection;
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
                    equipmentItem.Comments.Add(comment);
                    return equipmentItem;
                }, splitOn: "EquipmentID");

                var result = equipment.GroupBy(e => e.ID).Select(g =>
                {
                    var groupedEquipmentItem = g.First();
                    groupedEquipmentItem.Comments = g.Select(e => e.Comments.Single()).ToList();
                    return groupedEquipmentItem;
                });
                return result.ToList();
            }
        }

        public Task<List<EmployeeModel>> GetSelectedEmployee(int selectedEmployeeID)
        {
            throw new NotImplementedException();
        }

        public List<CertificationModel> GetCertificationTypes()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var sql = @"SELECT *
                          FROM dbo.CertificationType";
                var certificationTypes = connection.Query<CertificationModel>(sql).ToList();
                return certificationTypes;
            }
        }

        public List<EmployeeStatusModel> GetEmployeeStatusTypes()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var sql = @"SELECT *
                          FROM dbo.EmployeeStatus";
                var employeeStatusTypes = connection.Query<EmployeeStatusModel>(sql).ToList();
                return employeeStatusTypes;
            }
        }

        public List<DepartmentModel> GetDepartmentTypes()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var sql = @"SELECT *
                          FROM dbo.Departments";
                var departmentNames = connection.Query<DepartmentModel>(sql).ToList();
                return departmentNames;
            }
        }

        public List<TitleModel> GetJobTitleTypes()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("WorkDeskDB")))
            {
                var sql = @"SELECT *
                          FROM dbo.JobTitles";
                var jobTitleNames = connection.Query<TitleModel>(sql).ToList();
                return jobTitleNames;
            }
        }


    }
}


