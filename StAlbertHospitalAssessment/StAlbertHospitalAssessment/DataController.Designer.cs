
namespace StAlbertHospitalAssessment
{
    partial class DataController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataController));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.ctnStAlbert = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.DaAdmission = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.DaAllocation = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.DaDoctor = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.DaMedication = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
            this.DaPatient = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
            this.DaPayment = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand8 = new System.Data.OleDb.OleDbCommand();
            this.DaResearchProject = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand9 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand9 = new System.Data.OleDb.OleDbCommand();
            this.DaResearchTopic = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand10 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand10 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand10 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand10 = new System.Data.OleDb.OleDbCommand();
            this.DaWard = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand7 = new System.Data.OleDb.OleDbCommand();
            this.DaPrescription = new System.Data.OleDb.OleDbDataAdapter();
            this.dsStAlbert = new StAlbertHospitalAssessment.StAlbertDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dsStAlbert)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT AdmissionID, Description, AdmissionDate, Status, PatientID, WardID\r\nFROM  " +
    "   Admissions\r\nORDER BY AdmissionID, PatientID, WardID";
            this.oleDbSelectCommand1.Connection = this.ctnStAlbert;
            // 
            // ctnStAlbert
            // 
            this.ctnStAlbert.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\5607\\StAlbert.accdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Admissions` (`Description`, `AdmissionDate`, `Status`, `PatientID`, " +
    "`WardID`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.ctnStAlbert;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("AdmissionDate", System.Data.OleDb.OleDbType.Date, 0, "AdmissionDate"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.Integer, 0, "PatientID"),
            new System.Data.OleDb.OleDbParameter("WardID", System.Data.OleDb.OleDbType.Integer, 0, "WardID")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.ctnStAlbert;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("AdmissionDate", System.Data.OleDb.OleDbType.Date, 0, "AdmissionDate"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("PatientID", System.Data.OleDb.OleDbType.Integer, 0, "PatientID"),
            new System.Data.OleDb.OleDbParameter("WardID", System.Data.OleDb.OleDbType.Integer, 0, "WardID"),
            new System.Data.OleDb.OleDbParameter("Original_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_AdmissionDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdmissionDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_AdmissionDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdmissionDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PatientID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PatientID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_WardID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WardID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_WardID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WardID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.ctnStAlbert;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_AdmissionDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdmissionDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_AdmissionDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdmissionDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PatientID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PatientID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_WardID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WardID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_WardID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WardID", System.Data.DataRowVersion.Original, null)});
            // 
            // DaAdmission
            // 
            this.DaAdmission.DeleteCommand = this.oleDbDeleteCommand1;
            this.DaAdmission.InsertCommand = this.oleDbInsertCommand1;
            this.DaAdmission.SelectCommand = this.oleDbSelectCommand1;
            this.DaAdmission.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Admissions", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("AdmissionID", "AdmissionID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("AdmissionDate", "AdmissionDate"),
                        new System.Data.Common.DataColumnMapping("Status", "Status"),
                        new System.Data.Common.DataColumnMapping("PatientID", "PatientID"),
                        new System.Data.Common.DataColumnMapping("WardID", "WardID")})});
            this.DaAdmission.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT AllocationID, JobFee, Role, AdmissionID, DoctorID\r\nFROM     Allocation\r\nOR" +
    "DER BY AllocationID, AdmissionID, DoctorID";
            this.oleDbSelectCommand2.Connection = this.ctnStAlbert;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `Allocation` (`JobFee`, `Role`, `AdmissionID`, `DoctorID`) VALUES (?," +
    " ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.ctnStAlbert;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("JobFee", System.Data.OleDb.OleDbType.Currency, 0, "JobFee"),
            new System.Data.OleDb.OleDbParameter("Role", System.Data.OleDb.OleDbType.VarWChar, 0, "Role"),
            new System.Data.OleDb.OleDbParameter("AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, "AdmissionID"),
            new System.Data.OleDb.OleDbParameter("DoctorID", System.Data.OleDb.OleDbType.Integer, 0, "DoctorID")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.ctnStAlbert;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("JobFee", System.Data.OleDb.OleDbType.Currency, 0, "JobFee"),
            new System.Data.OleDb.OleDbParameter("Role", System.Data.OleDb.OleDbType.VarWChar, 0, "Role"),
            new System.Data.OleDb.OleDbParameter("AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, "AdmissionID"),
            new System.Data.OleDb.OleDbParameter("DoctorID", System.Data.OleDb.OleDbType.Integer, 0, "DoctorID"),
            new System.Data.OleDb.OleDbParameter("Original_AllocationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AllocationID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_JobFee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "JobFee", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_JobFee", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JobFee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Role", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Role", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Role", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Role", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DoctorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DoctorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.ctnStAlbert;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_AllocationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AllocationID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_JobFee", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "JobFee", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_JobFee", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JobFee", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Role", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Role", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Role", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Role", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DoctorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DoctorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, null)});
            // 
            // DaAllocation
            // 
            this.DaAllocation.DeleteCommand = this.oleDbDeleteCommand2;
            this.DaAllocation.InsertCommand = this.oleDbInsertCommand2;
            this.DaAllocation.SelectCommand = this.oleDbSelectCommand2;
            this.DaAllocation.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Allocation", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("AllocationID", "AllocationID"),
                        new System.Data.Common.DataColumnMapping("JobFee", "JobFee"),
                        new System.Data.Common.DataColumnMapping("Role", "Role"),
                        new System.Data.Common.DataColumnMapping("AdmissionID", "AdmissionID"),
                        new System.Data.Common.DataColumnMapping("DoctorID", "DoctorID")})});
            this.DaAllocation.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT DoctorID, LastName, FirstName, StreetAddress, Suburb, City, Specialty, Pho" +
    "neNumber, Salary\r\nFROM     Doctors\r\nORDER BY DoctorID";
            this.oleDbSelectCommand3.Connection = this.ctnStAlbert;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `Doctors` (`LastName`, `FirstName`, `StreetAddress`, `Suburb`, `City`" +
    ", `Specialty`, `PhoneNumber`, `Salary`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            this.oleDbInsertCommand3.Connection = this.ctnStAlbert;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("Specialty", System.Data.OleDb.OleDbType.VarWChar, 0, "Specialty"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("Salary", System.Data.OleDb.OleDbType.Integer, 0, "Salary")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = resources.GetString("oleDbUpdateCommand3.CommandText");
            this.oleDbUpdateCommand3.Connection = this.ctnStAlbert;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("Specialty", System.Data.OleDb.OleDbType.VarWChar, 0, "Specialty"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("Salary", System.Data.OleDb.OleDbType.Integer, 0, "Salary"),
            new System.Data.OleDb.OleDbParameter("Original_DoctorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Specialty", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Specialty", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Specialty", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Specialty", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Salary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Salary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = resources.GetString("oleDbDeleteCommand3.CommandText");
            this.oleDbDeleteCommand3.Connection = this.ctnStAlbert;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_DoctorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Specialty", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Specialty", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Specialty", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Specialty", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Salary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Salary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, null)});
            // 
            // DaDoctor
            // 
            this.DaDoctor.DeleteCommand = this.oleDbDeleteCommand3;
            this.DaDoctor.InsertCommand = this.oleDbInsertCommand3;
            this.DaDoctor.SelectCommand = this.oleDbSelectCommand3;
            this.DaDoctor.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Doctors", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("DoctorID", "DoctorID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("StreetAddress", "StreetAddress"),
                        new System.Data.Common.DataColumnMapping("Suburb", "Suburb"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("Specialty", "Specialty"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber"),
                        new System.Data.Common.DataColumnMapping("Salary", "Salary")})});
            this.DaDoctor.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT MedicationID, MedicationName, Cost\r\nFROM     Medication\r\nORDER BY Medicati" +
    "onID";
            this.oleDbSelectCommand4.Connection = this.ctnStAlbert;
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = "INSERT INTO `Medication` (`MedicationName`, `Cost`) VALUES (?, ?)";
            this.oleDbInsertCommand4.Connection = this.ctnStAlbert;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("MedicationName", System.Data.OleDb.OleDbType.VarWChar, 0, "MedicationName"),
            new System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Currency, 0, "Cost")});
            // 
            // oleDbUpdateCommand4
            // 
            this.oleDbUpdateCommand4.CommandText = resources.GetString("oleDbUpdateCommand4.CommandText");
            this.oleDbUpdateCommand4.Connection = this.ctnStAlbert;
            this.oleDbUpdateCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("MedicationName", System.Data.OleDb.OleDbType.VarWChar, 0, "MedicationName"),
            new System.Data.OleDb.OleDbParameter("Cost", System.Data.OleDb.OleDbType.Currency, 0, "Cost"),
            new System.Data.OleDb.OleDbParameter("Original_MedicationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MedicationID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MedicationName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MedicationName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MedicationName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MedicationName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cost", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cost", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = "DELETE FROM `Medication` WHERE ((`MedicationID` = ?) AND ((? = 1 AND `MedicationN" +
    "ame` IS NULL) OR (`MedicationName` = ?)) AND ((? = 1 AND `Cost` IS NULL) OR (`Co" +
    "st` = ?)))";
            this.oleDbDeleteCommand4.Connection = this.ctnStAlbert;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_MedicationID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MedicationID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MedicationName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MedicationName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MedicationName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MedicationName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cost", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cost", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cost", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cost", System.Data.DataRowVersion.Original, null)});
            // 
            // DaMedication
            // 
            this.DaMedication.DeleteCommand = this.oleDbDeleteCommand4;
            this.DaMedication.InsertCommand = this.oleDbInsertCommand4;
            this.DaMedication.SelectCommand = this.oleDbSelectCommand4;
            this.DaMedication.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Medication", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("MedicationID", "MedicationID"),
                        new System.Data.Common.DataColumnMapping("MedicationName", "MedicationName"),
                        new System.Data.Common.DataColumnMapping("Cost", "Cost")})});
            this.DaMedication.UpdateCommand = this.oleDbUpdateCommand4;
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = "SELECT PatientID, LastName, FirstName, StreetAddress, Suburb, City, EmailAddress," +
    " PhoneNumber, InsuranceCode\r\nFROM     Patients\r\nORDER BY PatientID";
            this.oleDbSelectCommand5.Connection = this.ctnStAlbert;
            // 
            // oleDbInsertCommand5
            // 
            this.oleDbInsertCommand5.CommandText = "INSERT INTO `Patients` (`LastName`, `FirstName`, `StreetAddress`, `Suburb`, `City" +
    "`, `EmailAddress`, `PhoneNumber`, `InsuranceCode`) VALUES (?, ?, ?, ?, ?, ?, ?, " +
    "?)";
            this.oleDbInsertCommand5.Connection = this.ctnStAlbert;
            this.oleDbInsertCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("InsuranceCode", System.Data.OleDb.OleDbType.VarWChar, 0, "InsuranceCode")});
            // 
            // oleDbUpdateCommand5
            // 
            this.oleDbUpdateCommand5.CommandText = resources.GetString("oleDbUpdateCommand5.CommandText");
            this.oleDbUpdateCommand5.Connection = this.ctnStAlbert;
            this.oleDbUpdateCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 0, "City"),
            new System.Data.OleDb.OleDbParameter("EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "EmailAddress"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("InsuranceCode", System.Data.OleDb.OleDbType.VarWChar, 0, "InsuranceCode"),
            new System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PatientID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_InsuranceCode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InsuranceCode", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_InsuranceCode", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InsuranceCode", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand5
            // 
            this.oleDbDeleteCommand5.CommandText = resources.GetString("oleDbDeleteCommand5.CommandText");
            this.oleDbDeleteCommand5.Connection = this.ctnStAlbert;
            this.oleDbDeleteCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_PatientID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PatientID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_City", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "City", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmailAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmailAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmailAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_InsuranceCode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InsuranceCode", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_InsuranceCode", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InsuranceCode", System.Data.DataRowVersion.Original, null)});
            // 
            // DaPatient
            // 
            this.DaPatient.DeleteCommand = this.oleDbDeleteCommand5;
            this.DaPatient.InsertCommand = this.oleDbInsertCommand5;
            this.DaPatient.SelectCommand = this.oleDbSelectCommand5;
            this.DaPatient.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Patients", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PatientID", "PatientID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("StreetAddress", "StreetAddress"),
                        new System.Data.Common.DataColumnMapping("Suburb", "Suburb"),
                        new System.Data.Common.DataColumnMapping("City", "City"),
                        new System.Data.Common.DataColumnMapping("EmailAddress", "EmailAddress"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber"),
                        new System.Data.Common.DataColumnMapping("InsuranceCode", "InsuranceCode")})});
            this.DaPatient.UpdateCommand = this.oleDbUpdateCommand5;
            // 
            // oleDbSelectCommand6
            // 
            this.oleDbSelectCommand6.CommandText = "SELECT PaymentCode, Amount, [Date], AdmissionID\r\nFROM     Payments\r\nORDER BY Paym" +
    "entCode, AdmissionID";
            this.oleDbSelectCommand6.Connection = this.ctnStAlbert;
            // 
            // oleDbInsertCommand6
            // 
            this.oleDbInsertCommand6.CommandText = "INSERT INTO `Payments` (`Amount`, `Date`, `AdmissionID`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand6.Connection = this.ctnStAlbert;
            this.oleDbInsertCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Currency, 0, "Amount"),
            new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.Date, 0, "Date"),
            new System.Data.OleDb.OleDbParameter("AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, "AdmissionID")});
            // 
            // oleDbUpdateCommand6
            // 
            this.oleDbUpdateCommand6.CommandText = resources.GetString("oleDbUpdateCommand6.CommandText");
            this.oleDbUpdateCommand6.Connection = this.ctnStAlbert;
            this.oleDbUpdateCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Currency, 0, "Amount"),
            new System.Data.OleDb.OleDbParameter("Date", System.Data.OleDb.OleDbType.Date, 0, "Date"),
            new System.Data.OleDb.OleDbParameter("AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, "AdmissionID"),
            new System.Data.OleDb.OleDbParameter("Original_PaymentCode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PaymentCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Amount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Date", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand6
            // 
            this.oleDbDeleteCommand6.CommandText = resources.GetString("oleDbDeleteCommand6.CommandText");
            this.oleDbDeleteCommand6.Connection = this.ctnStAlbert;
            this.oleDbDeleteCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_PaymentCode", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PaymentCode", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Amount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Date", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Date", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Date", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, null)});
            // 
            // DaPayment
            // 
            this.DaPayment.DeleteCommand = this.oleDbDeleteCommand6;
            this.DaPayment.InsertCommand = this.oleDbInsertCommand6;
            this.DaPayment.SelectCommand = this.oleDbSelectCommand6;
            this.DaPayment.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Payments", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PaymentCode", "PaymentCode"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("Date", "Date"),
                        new System.Data.Common.DataColumnMapping("AdmissionID", "AdmissionID")})});
            this.DaPayment.UpdateCommand = this.oleDbUpdateCommand6;
            // 
            // oleDbSelectCommand8
            // 
            this.oleDbSelectCommand8.CommandText = "SELECT ResearchProjectID, Outcome, EndDate, Budget, ResearchTopicID, DoctorID\r\nFR" +
    "OM     [Research Project]\r\nORDER BY ResearchProjectID, ResearchTopicID, DoctorID" +
    "";
            this.oleDbSelectCommand8.Connection = this.ctnStAlbert;
            // 
            // oleDbInsertCommand8
            // 
            this.oleDbInsertCommand8.CommandText = "INSERT INTO `Research Project` (`Outcome`, `EndDate`, `Budget`, `ResearchTopicID`" +
    ", `DoctorID`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand8.Connection = this.ctnStAlbert;
            this.oleDbInsertCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Outcome", System.Data.OleDb.OleDbType.VarWChar, 0, "Outcome"),
            new System.Data.OleDb.OleDbParameter("EndDate", System.Data.OleDb.OleDbType.Date, 0, "EndDate"),
            new System.Data.OleDb.OleDbParameter("Budget", System.Data.OleDb.OleDbType.Currency, 0, "Budget"),
            new System.Data.OleDb.OleDbParameter("ResearchTopicID", System.Data.OleDb.OleDbType.Integer, 0, "ResearchTopicID"),
            new System.Data.OleDb.OleDbParameter("DoctorID", System.Data.OleDb.OleDbType.Integer, 0, "DoctorID")});
            // 
            // oleDbUpdateCommand8
            // 
            this.oleDbUpdateCommand8.CommandText = resources.GetString("oleDbUpdateCommand8.CommandText");
            this.oleDbUpdateCommand8.Connection = this.ctnStAlbert;
            this.oleDbUpdateCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Outcome", System.Data.OleDb.OleDbType.VarWChar, 0, "Outcome"),
            new System.Data.OleDb.OleDbParameter("EndDate", System.Data.OleDb.OleDbType.Date, 0, "EndDate"),
            new System.Data.OleDb.OleDbParameter("Budget", System.Data.OleDb.OleDbType.Currency, 0, "Budget"),
            new System.Data.OleDb.OleDbParameter("ResearchTopicID", System.Data.OleDb.OleDbType.Integer, 0, "ResearchTopicID"),
            new System.Data.OleDb.OleDbParameter("DoctorID", System.Data.OleDb.OleDbType.Integer, 0, "DoctorID"),
            new System.Data.OleDb.OleDbParameter("Original_ResearchProjectID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResearchProjectID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Outcome", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Outcome", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Outcome", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Outcome", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EndDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EndDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EndDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Budget", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Budget", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Budget", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Budget", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ResearchTopicID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ResearchTopicID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ResearchTopicID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResearchTopicID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DoctorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DoctorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand8
            // 
            this.oleDbDeleteCommand8.CommandText = resources.GetString("oleDbDeleteCommand8.CommandText");
            this.oleDbDeleteCommand8.Connection = this.ctnStAlbert;
            this.oleDbDeleteCommand8.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ResearchProjectID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResearchProjectID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Outcome", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Outcome", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Outcome", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Outcome", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EndDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EndDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EndDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EndDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Budget", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Budget", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Budget", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Budget", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_ResearchTopicID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ResearchTopicID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_ResearchTopicID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResearchTopicID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_DoctorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_DoctorID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoctorID", System.Data.DataRowVersion.Original, null)});
            // 
            // DaResearchProject
            // 
            this.DaResearchProject.DeleteCommand = this.oleDbDeleteCommand8;
            this.DaResearchProject.InsertCommand = this.oleDbInsertCommand8;
            this.DaResearchProject.SelectCommand = this.oleDbSelectCommand8;
            this.DaResearchProject.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Research Project", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ResearchProjectID", "ResearchProjectID"),
                        new System.Data.Common.DataColumnMapping("Outcome", "Outcome"),
                        new System.Data.Common.DataColumnMapping("EndDate", "EndDate"),
                        new System.Data.Common.DataColumnMapping("Budget", "Budget"),
                        new System.Data.Common.DataColumnMapping("ResearchTopicID", "ResearchTopicID"),
                        new System.Data.Common.DataColumnMapping("DoctorID", "DoctorID")})});
            this.DaResearchProject.UpdateCommand = this.oleDbUpdateCommand8;
            // 
            // oleDbSelectCommand9
            // 
            this.oleDbSelectCommand9.CommandText = "SELECT ResearchTopicID, Description, [Level]\r\nFROM     [Research Topic]\r\nORDER BY" +
    " ResearchTopicID";
            this.oleDbSelectCommand9.Connection = this.ctnStAlbert;
            // 
            // oleDbInsertCommand9
            // 
            this.oleDbInsertCommand9.CommandText = "INSERT INTO `Research Topic` (`Description`, `Level`) VALUES (?, ?)";
            this.oleDbInsertCommand9.Connection = this.ctnStAlbert;
            this.oleDbInsertCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Level", System.Data.OleDb.OleDbType.Integer, 0, "Level")});
            // 
            // oleDbUpdateCommand9
            // 
            this.oleDbUpdateCommand9.CommandText = resources.GetString("oleDbUpdateCommand9.CommandText");
            this.oleDbUpdateCommand9.Connection = this.ctnStAlbert;
            this.oleDbUpdateCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Level", System.Data.OleDb.OleDbType.Integer, 0, "Level"),
            new System.Data.OleDb.OleDbParameter("Original_ResearchTopicID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResearchTopicID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Level", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Level", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Level", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Level", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand9
            // 
            this.oleDbDeleteCommand9.CommandText = "DELETE FROM `Research Topic` WHERE ((`ResearchTopicID` = ?) AND ((? = 1 AND `Desc" +
    "ription` IS NULL) OR (`Description` = ?)) AND ((? = 1 AND `Level` IS NULL) OR (`" +
    "Level` = ?)))";
            this.oleDbDeleteCommand9.Connection = this.ctnStAlbert;
            this.oleDbDeleteCommand9.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ResearchTopicID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ResearchTopicID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Level", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Level", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Level", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Level", System.Data.DataRowVersion.Original, null)});
            // 
            // DaResearchTopic
            // 
            this.DaResearchTopic.DeleteCommand = this.oleDbDeleteCommand9;
            this.DaResearchTopic.InsertCommand = this.oleDbInsertCommand9;
            this.DaResearchTopic.SelectCommand = this.oleDbSelectCommand9;
            this.DaResearchTopic.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Research Topic", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ResearchTopicID", "ResearchTopicID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Level", "Level")})});
            this.DaResearchTopic.UpdateCommand = this.oleDbUpdateCommand9;
            // 
            // oleDbSelectCommand10
            // 
            this.oleDbSelectCommand10.CommandText = "SELECT WardID, WardName, Location, Capacity\r\nFROM     Wards\r\nORDER BY WardID";
            this.oleDbSelectCommand10.Connection = this.ctnStAlbert;
            // 
            // oleDbInsertCommand10
            // 
            this.oleDbInsertCommand10.CommandText = "INSERT INTO `Wards` (`WardName`, `Location`, `Capacity`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand10.Connection = this.ctnStAlbert;
            this.oleDbInsertCommand10.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("WardName", System.Data.OleDb.OleDbType.VarWChar, 0, "WardName"),
            new System.Data.OleDb.OleDbParameter("Location", System.Data.OleDb.OleDbType.VarWChar, 0, "Location"),
            new System.Data.OleDb.OleDbParameter("Capacity", System.Data.OleDb.OleDbType.Integer, 0, "Capacity")});
            // 
            // oleDbUpdateCommand10
            // 
            this.oleDbUpdateCommand10.CommandText = resources.GetString("oleDbUpdateCommand10.CommandText");
            this.oleDbUpdateCommand10.Connection = this.ctnStAlbert;
            this.oleDbUpdateCommand10.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("WardName", System.Data.OleDb.OleDbType.VarWChar, 0, "WardName"),
            new System.Data.OleDb.OleDbParameter("Location", System.Data.OleDb.OleDbType.VarWChar, 0, "Location"),
            new System.Data.OleDb.OleDbParameter("Capacity", System.Data.OleDb.OleDbType.Integer, 0, "Capacity"),
            new System.Data.OleDb.OleDbParameter("Original_WardID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WardID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_WardName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WardName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_WardName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WardName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Location", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Location", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Location", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Location", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Capacity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Capacity", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Capacity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Capacity", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand10
            // 
            this.oleDbDeleteCommand10.CommandText = resources.GetString("oleDbDeleteCommand10.CommandText");
            this.oleDbDeleteCommand10.Connection = this.ctnStAlbert;
            this.oleDbDeleteCommand10.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_WardID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WardID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_WardName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "WardName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_WardName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WardName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Location", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Location", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Location", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Location", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Capacity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Capacity", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Capacity", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Capacity", System.Data.DataRowVersion.Original, null)});
            // 
            // DaWard
            // 
            this.DaWard.DeleteCommand = this.oleDbDeleteCommand10;
            this.DaWard.InsertCommand = this.oleDbInsertCommand10;
            this.DaWard.SelectCommand = this.oleDbSelectCommand10;
            this.DaWard.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Wards", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("WardID", "WardID"),
                        new System.Data.Common.DataColumnMapping("WardName", "WardName"),
                        new System.Data.Common.DataColumnMapping("Location", "Location"),
                        new System.Data.Common.DataColumnMapping("Capacity", "Capacity")})});
            this.DaWard.UpdateCommand = this.oleDbUpdateCommand10;
            // 
            // oleDbSelectCommand7
            // 
            this.oleDbSelectCommand7.CommandText = "SELECT PrescriptionID, MedicationName, PrescriptionDate, AdmissionID, Amount\r\nFRO" +
    "M     Prescriptions\r\nORDER BY PrescriptionID, AdmissionID, MedicationName";
            this.oleDbSelectCommand7.Connection = this.ctnStAlbert;
            // 
            // oleDbInsertCommand7
            // 
            this.oleDbInsertCommand7.CommandText = "INSERT INTO `Prescriptions` (`MedicationName`, `PrescriptionDate`, `AdmissionID`," +
    " `Amount`) VALUES (?, ?, ?, ?)";
            this.oleDbInsertCommand7.Connection = this.ctnStAlbert;
            this.oleDbInsertCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("MedicationName", System.Data.OleDb.OleDbType.Integer, 0, "MedicationName"),
            new System.Data.OleDb.OleDbParameter("PrescriptionDate", System.Data.OleDb.OleDbType.Date, 0, "PrescriptionDate"),
            new System.Data.OleDb.OleDbParameter("AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, "AdmissionID"),
            new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Integer, 0, "Amount")});
            // 
            // oleDbUpdateCommand7
            // 
            this.oleDbUpdateCommand7.CommandText = resources.GetString("oleDbUpdateCommand7.CommandText");
            this.oleDbUpdateCommand7.Connection = this.ctnStAlbert;
            this.oleDbUpdateCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("MedicationName", System.Data.OleDb.OleDbType.Integer, 0, "MedicationName"),
            new System.Data.OleDb.OleDbParameter("PrescriptionDate", System.Data.OleDb.OleDbType.Date, 0, "PrescriptionDate"),
            new System.Data.OleDb.OleDbParameter("AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, "AdmissionID"),
            new System.Data.OleDb.OleDbParameter("Amount", System.Data.OleDb.OleDbType.Integer, 0, "Amount"),
            new System.Data.OleDb.OleDbParameter("Original_PrescriptionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PrescriptionID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MedicationName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MedicationName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MedicationName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MedicationName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PrescriptionDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PrescriptionDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PrescriptionDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PrescriptionDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Amount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand7
            // 
            this.oleDbDeleteCommand7.CommandText = resources.GetString("oleDbDeleteCommand7.CommandText");
            this.oleDbDeleteCommand7.Connection = this.ctnStAlbert;
            this.oleDbDeleteCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_PrescriptionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PrescriptionID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_MedicationName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "MedicationName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_MedicationName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "MedicationName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PrescriptionDate", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PrescriptionDate", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PrescriptionDate", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PrescriptionDate", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_AdmissionID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AdmissionID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Amount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Amount", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null)});
            // 
            // DaPrescription
            // 
            this.DaPrescription.DeleteCommand = this.oleDbDeleteCommand7;
            this.DaPrescription.InsertCommand = this.oleDbInsertCommand7;
            this.DaPrescription.SelectCommand = this.oleDbSelectCommand7;
            this.DaPrescription.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Prescriptions", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PrescriptionID", "PrescriptionID"),
                        new System.Data.Common.DataColumnMapping("MedicationName", "MedicationName"),
                        new System.Data.Common.DataColumnMapping("PrescriptionDate", "PrescriptionDate"),
                        new System.Data.Common.DataColumnMapping("AdmissionID", "AdmissionID"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount")})});
            this.DaPrescription.UpdateCommand = this.oleDbUpdateCommand7;
            // 
            // dsStAlbert
            // 
            this.dsStAlbert.DataSetName = "StAlbertDataSet";
            this.dsStAlbert.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "DataController";
            this.Text = "DataController";
            ((System.ComponentModel.ISupportInitialize)(this.dsStAlbert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection ctnStAlbert;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter DaAdmission;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter DaAllocation;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter DaDoctor;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
        private System.Data.OleDb.OleDbDataAdapter DaMedication;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
        private System.Data.OleDb.OleDbDataAdapter DaPatient;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
        private System.Data.OleDb.OleDbDataAdapter DaPayment;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand8;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand8;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand8;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand8;
        private System.Data.OleDb.OleDbDataAdapter DaResearchProject;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand9;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand9;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand9;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand9;
        private System.Data.OleDb.OleDbDataAdapter DaResearchTopic;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand10;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand10;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand10;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand10;
        private System.Data.OleDb.OleDbDataAdapter DaWard;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand7;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand7;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand7;
        private System.Data.OleDb.OleDbDataAdapter DaPrescription;
        private StAlbertDataSet dsStAlbert;
    }
}