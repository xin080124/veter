namespace Looking
{
    partial class DataModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataModule));
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbLooking = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.daApplication = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.daCandidate = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand3 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand3 = new System.Data.OleDb.OleDbCommand();
            this.daCandidateSkill = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand4 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand4 = new System.Data.OleDb.OleDbCommand();
            this.daEmployer = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand5 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand5 = new System.Data.OleDb.OleDbCommand();
            this.daSkill = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand6 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand6 = new System.Data.OleDb.OleDbCommand();
            this.daVacancy = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand7 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand7 = new System.Data.OleDb.OleDbCommand();
            this.daVacancySkill = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbSelectCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand8 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.dsLooking1 = new Looking.DSLooking();
            ((System.ComponentModel.ISupportInitialize)(this.dsLooking1)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT        VacancyID, CandidateID\r\nFROM            APPLICATION\r\nORDER BY Vacan" +
    "cyID";
            this.oleDbSelectCommand1.Connection = this.oleDbLooking;
            // 
            // oleDbLooking
            // 
            this.oleDbLooking.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Temp\\LookingGlass.mdb";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `APPLICATION` (`VacancyID`, `CandidateID`) VALUES (?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbLooking;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("VacancyID", System.Data.OleDb.OleDbType.Integer, 0, "VacancyID"),
            new System.Data.OleDb.OleDbParameter("CandidateID", System.Data.OleDb.OleDbType.Integer, 0, "CandidateID")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = "UPDATE `APPLICATION` SET `VacancyID` = ?, `CandidateID` = ? WHERE ((`VacancyID` =" +
    " ?) AND (`CandidateID` = ?))";
            this.oleDbUpdateCommand1.Connection = this.oleDbLooking;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("VacancyID", System.Data.OleDb.OleDbType.Integer, 0, "VacancyID"),
            new System.Data.OleDb.OleDbParameter("CandidateID", System.Data.OleDb.OleDbType.Integer, 0, "CandidateID"),
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = "DELETE FROM `APPLICATION` WHERE ((`VacancyID` = ?) AND (`CandidateID` = ?))";
            this.oleDbDeleteCommand1.Connection = this.oleDbLooking;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null)});
            // 
            // daApplication
            // 
            this.daApplication.DeleteCommand = this.oleDbDeleteCommand1;
            this.daApplication.InsertCommand = this.oleDbInsertCommand1;
            this.daApplication.SelectCommand = this.oleDbSelectCommand1;
            this.daApplication.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "APPLICATION", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("VacancyID", "VacancyID"),
                        new System.Data.Common.DataColumnMapping("CandidateID", "CandidateID")})});
            this.daApplication.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT        CandidateID, LastName, FirstName, StreetAddress, Suburb, PhoneNumbe" +
    "r\r\nFROM            CANDIDATE\r\nORDER BY CandidateID";
            this.oleDbSelectCommand2.Connection = this.oleDbLooking;
            // 
            // oleDbInsertCommand2
            // 
            this.oleDbInsertCommand2.CommandText = "INSERT INTO `CANDIDATE` (`LastName`, `FirstName`, `StreetAddress`, `Suburb`, `Pho" +
    "neNumber`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand2.Connection = this.oleDbLooking;
            this.oleDbInsertCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber")});
            // 
            // oleDbUpdateCommand2
            // 
            this.oleDbUpdateCommand2.CommandText = resources.GetString("oleDbUpdateCommand2.CommandText");
            this.oleDbUpdateCommand2.Connection = this.oleDbLooking;
            this.oleDbUpdateCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("LastName", System.Data.OleDb.OleDbType.VarWChar, 0, "LastName"),
            new System.Data.OleDb.OleDbParameter("FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, "FirstName"),
            new System.Data.OleDb.OleDbParameter("StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, "StreetAddress"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand2
            // 
            this.oleDbDeleteCommand2.CommandText = resources.GetString("oleDbDeleteCommand2.CommandText");
            this.oleDbDeleteCommand2.Connection = this.oleDbLooking;
            this.oleDbDeleteCommand2.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_LastName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_LastName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_FirstName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_FirstName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_StreetAddress", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_StreetAddress", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "StreetAddress", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null)});
            // 
            // daCandidate
            // 
            this.daCandidate.DeleteCommand = this.oleDbDeleteCommand2;
            this.daCandidate.InsertCommand = this.oleDbInsertCommand2;
            this.daCandidate.SelectCommand = this.oleDbSelectCommand2;
            this.daCandidate.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CANDIDATE", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CandidateID", "CandidateID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("StreetAddress", "StreetAddress"),
                        new System.Data.Common.DataColumnMapping("Suburb", "Suburb"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber")})});
            this.daCandidate.UpdateCommand = this.oleDbUpdateCommand2;
            // 
            // oleDbSelectCommand3
            // 
            this.oleDbSelectCommand3.CommandText = "SELECT        CandidateID, SkillID, Years\r\nFROM            CANDIDATESKILL\r\nORDER " +
    "BY SkillID";
            this.oleDbSelectCommand3.Connection = this.oleDbLooking;
            // 
            // oleDbInsertCommand3
            // 
            this.oleDbInsertCommand3.CommandText = "INSERT INTO `CANDIDATESKILL` (`CandidateID`, `SkillID`, `Years`) VALUES (?, ?, ?)" +
    "";
            this.oleDbInsertCommand3.Connection = this.oleDbLooking;
            this.oleDbInsertCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CandidateID", System.Data.OleDb.OleDbType.Integer, 0, "CandidateID"),
            new System.Data.OleDb.OleDbParameter("SkillID", System.Data.OleDb.OleDbType.Integer, 0, "SkillID"),
            new System.Data.OleDb.OleDbParameter("Years", System.Data.OleDb.OleDbType.Integer, 0, "Years")});
            // 
            // oleDbUpdateCommand3
            // 
            this.oleDbUpdateCommand3.CommandText = "UPDATE `CANDIDATESKILL` SET `CandidateID` = ?, `SkillID` = ?, `Years` = ? WHERE (" +
    "(`CandidateID` = ?) AND (`SkillID` = ?) AND ((? = 1 AND `Years` IS NULL) OR (`Ye" +
    "ars` = ?)))";
            this.oleDbUpdateCommand3.Connection = this.oleDbLooking;
            this.oleDbUpdateCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("CandidateID", System.Data.OleDb.OleDbType.Integer, 0, "CandidateID"),
            new System.Data.OleDb.OleDbParameter("SkillID", System.Data.OleDb.OleDbType.Integer, 0, "SkillID"),
            new System.Data.OleDb.OleDbParameter("Years", System.Data.OleDb.OleDbType.Integer, 0, "Years"),
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Years", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Years", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Years", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Years", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand3
            // 
            this.oleDbDeleteCommand3.CommandText = "DELETE FROM `CANDIDATESKILL` WHERE ((`CandidateID` = ?) AND (`SkillID` = ?) AND (" +
    "(? = 1 AND `Years` IS NULL) OR (`Years` = ?)))";
            this.oleDbDeleteCommand3.Connection = this.oleDbLooking;
            this.oleDbDeleteCommand3.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_CandidateID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CandidateID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Years", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Years", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Years", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Years", System.Data.DataRowVersion.Original, null)});
            // 
            // daCandidateSkill
            // 
            this.daCandidateSkill.DeleteCommand = this.oleDbDeleteCommand3;
            this.daCandidateSkill.InsertCommand = this.oleDbInsertCommand3;
            this.daCandidateSkill.SelectCommand = this.oleDbSelectCommand3;
            this.daCandidateSkill.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "CANDIDATESKILL", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CandidateID", "CandidateID"),
                        new System.Data.Common.DataColumnMapping("SkillID", "SkillID"),
                        new System.Data.Common.DataColumnMapping("Years", "Years")})});
            this.daCandidateSkill.UpdateCommand = this.oleDbUpdateCommand3;
            // 
            // oleDbSelectCommand4
            // 
            this.oleDbSelectCommand4.CommandText = "SELECT        EmployerID, EmployerName, [Street Address], Suburb, PhoneNumber\r\nFR" +
    "OM            EMPLOYER\r\nORDER BY EmployerID";
            this.oleDbSelectCommand4.Connection = this.oleDbLooking;
            // 
            // oleDbInsertCommand4
            // 
            this.oleDbInsertCommand4.CommandText = "INSERT INTO `EMPLOYER` (`EmployerName`, `Street Address`, `Suburb`, `PhoneNumber`" +
    ") VALUES (?, ?, ?, ?)";
            this.oleDbInsertCommand4.Connection = this.oleDbLooking;
            this.oleDbInsertCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmployerName", System.Data.OleDb.OleDbType.VarWChar, 0, "EmployerName"),
            new System.Data.OleDb.OleDbParameter("Street_Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Street Address"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber")});
            // 
            // oleDbUpdateCommand4
            // 
            this.oleDbUpdateCommand4.CommandText = resources.GetString("oleDbUpdateCommand4.CommandText");
            this.oleDbUpdateCommand4.Connection = this.oleDbLooking;
            this.oleDbUpdateCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("EmployerName", System.Data.OleDb.OleDbType.VarWChar, 0, "EmployerName"),
            new System.Data.OleDb.OleDbParameter("Street_Address", System.Data.OleDb.OleDbType.VarWChar, 0, "Street Address"),
            new System.Data.OleDb.OleDbParameter("Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, "Suburb"),
            new System.Data.OleDb.OleDbParameter("PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, "PhoneNumber"),
            new System.Data.OleDb.OleDbParameter("Original_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployerName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployerName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployerName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Street_Address", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Street Address", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Street_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Street Address", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand4
            // 
            this.oleDbDeleteCommand4.CommandText = resources.GetString("oleDbDeleteCommand4.CommandText");
            this.oleDbDeleteCommand4.Connection = this.oleDbLooking;
            this.oleDbDeleteCommand4.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployerName", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployerName", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployerName", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerName", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Street_Address", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Street Address", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Street_Address", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Street Address", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Suburb", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Suburb", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Suburb", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PhoneNumber", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PhoneNumber", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PhoneNumber", System.Data.DataRowVersion.Original, null)});
            // 
            // daEmployer
            // 
            this.daEmployer.DeleteCommand = this.oleDbDeleteCommand4;
            this.daEmployer.InsertCommand = this.oleDbInsertCommand4;
            this.daEmployer.SelectCommand = this.oleDbSelectCommand4;
            this.daEmployer.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "EMPLOYER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("EmployerID", "EmployerID"),
                        new System.Data.Common.DataColumnMapping("EmployerName", "EmployerName"),
                        new System.Data.Common.DataColumnMapping("Street Address", "Street Address"),
                        new System.Data.Common.DataColumnMapping("Suburb", "Suburb"),
                        new System.Data.Common.DataColumnMapping("PhoneNumber", "PhoneNumber")})});
            this.daEmployer.UpdateCommand = this.oleDbUpdateCommand4;
            // 
            // oleDbSelectCommand5
            // 
            this.oleDbSelectCommand5.CommandText = "SELECT        SkillID, Description\r\nFROM            SKILL\r\nORDER BY SkillID";
            this.oleDbSelectCommand5.Connection = this.oleDbLooking;
            // 
            // oleDbInsertCommand5
            // 
            this.oleDbInsertCommand5.CommandText = "INSERT INTO `SKILL` (`Description`) VALUES (?)";
            this.oleDbInsertCommand5.Connection = this.oleDbLooking;
            this.oleDbInsertCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description")});
            // 
            // oleDbUpdateCommand5
            // 
            this.oleDbUpdateCommand5.CommandText = "UPDATE `SKILL` SET `Description` = ? WHERE ((`SkillID` = ?) AND ((? = 1 AND `Desc" +
    "ription` IS NULL) OR (`Description` = ?)))";
            this.oleDbUpdateCommand5.Connection = this.oleDbLooking;
            this.oleDbUpdateCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand5
            // 
            this.oleDbDeleteCommand5.CommandText = "DELETE FROM `SKILL` WHERE ((`SkillID` = ?) AND ((? = 1 AND `Description` IS NULL)" +
    " OR (`Description` = ?)))";
            this.oleDbDeleteCommand5.Connection = this.oleDbLooking;
            this.oleDbDeleteCommand5.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null)});
            // 
            // daSkill
            // 
            this.daSkill.DeleteCommand = this.oleDbDeleteCommand5;
            this.daSkill.InsertCommand = this.oleDbInsertCommand5;
            this.daSkill.SelectCommand = this.oleDbSelectCommand5;
            this.daSkill.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "SKILL", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("SkillID", "SkillID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description")})});
            this.daSkill.UpdateCommand = this.oleDbUpdateCommand5;
            // 
            // oleDbSelectCommand6
            // 
            this.oleDbSelectCommand6.CommandText = "SELECT        VacancyID, Description, Status, Salary, EmployerID\r\nFROM           " +
    " VACANCY\r\nORDER BY VacancyID";
            this.oleDbSelectCommand6.Connection = this.oleDbLooking;
            // 
            // oleDbInsertCommand6
            // 
            this.oleDbInsertCommand6.CommandText = "INSERT INTO `VACANCY` (`Description`, `Status`, `Salary`, `EmployerID`) VALUES (?" +
    ", ?, ?, ?)";
            this.oleDbInsertCommand6.Connection = this.oleDbLooking;
            this.oleDbInsertCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("Salary", System.Data.OleDb.OleDbType.Currency, 0, "Salary"),
            new System.Data.OleDb.OleDbParameter("EmployerID", System.Data.OleDb.OleDbType.Integer, 0, "EmployerID")});
            // 
            // oleDbUpdateCommand6
            // 
            this.oleDbUpdateCommand6.CommandText = resources.GetString("oleDbUpdateCommand6.CommandText");
            this.oleDbUpdateCommand6.Connection = this.oleDbLooking;
            this.oleDbUpdateCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"),
            new System.Data.OleDb.OleDbParameter("Status", System.Data.OleDb.OleDbType.VarWChar, 0, "Status"),
            new System.Data.OleDb.OleDbParameter("Salary", System.Data.OleDb.OleDbType.Currency, 0, "Salary"),
            new System.Data.OleDb.OleDbParameter("EmployerID", System.Data.OleDb.OleDbType.Integer, 0, "EmployerID"),
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Salary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Salary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand6
            // 
            this.oleDbDeleteCommand6.CommandText = resources.GetString("oleDbDeleteCommand6.CommandText");
            this.oleDbDeleteCommand6.Connection = this.oleDbLooking;
            this.oleDbDeleteCommand6.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Description", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Description", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Status", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Status", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Status", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Salary", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Salary", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Salary", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EmployerID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EmployerID", System.Data.DataRowVersion.Original, null)});
            // 
            // daVacancy
            // 
            this.daVacancy.DeleteCommand = this.oleDbDeleteCommand6;
            this.daVacancy.InsertCommand = this.oleDbInsertCommand6;
            this.daVacancy.SelectCommand = this.oleDbSelectCommand6;
            this.daVacancy.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "VACANCY", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("VacancyID", "VacancyID"),
                        new System.Data.Common.DataColumnMapping("Description", "Description"),
                        new System.Data.Common.DataColumnMapping("Status", "Status"),
                        new System.Data.Common.DataColumnMapping("Salary", "Salary"),
                        new System.Data.Common.DataColumnMapping("EmployerID", "EmployerID")})});
            this.daVacancy.UpdateCommand = this.oleDbUpdateCommand6;
            // 
            // oleDbSelectCommand7
            // 
            this.oleDbSelectCommand7.CommandText = "SELECT        VacancyID, SkillID, Years\r\nFROM            VACANCYSKILL\r\nORDER BY V" +
    "acancyID";
            this.oleDbSelectCommand7.Connection = this.oleDbLooking;
            // 
            // oleDbInsertCommand7
            // 
            this.oleDbInsertCommand7.CommandText = "INSERT INTO `VACANCYSKILL` (`VacancyID`, `SkillID`, `Years`) VALUES (?, ?, ?)";
            this.oleDbInsertCommand7.Connection = this.oleDbLooking;
            this.oleDbInsertCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("VacancyID", System.Data.OleDb.OleDbType.Integer, 0, "VacancyID"),
            new System.Data.OleDb.OleDbParameter("SkillID", System.Data.OleDb.OleDbType.Integer, 0, "SkillID"),
            new System.Data.OleDb.OleDbParameter("Years", System.Data.OleDb.OleDbType.Integer, 0, "Years")});
            // 
            // oleDbUpdateCommand7
            // 
            this.oleDbUpdateCommand7.CommandText = "UPDATE `VACANCYSKILL` SET `VacancyID` = ?, `SkillID` = ?, `Years` = ? WHERE ((`Va" +
    "cancyID` = ?) AND (`SkillID` = ?) AND ((? = 1 AND `Years` IS NULL) OR (`Years` =" +
    " ?)))";
            this.oleDbUpdateCommand7.Connection = this.oleDbLooking;
            this.oleDbUpdateCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("VacancyID", System.Data.OleDb.OleDbType.Integer, 0, "VacancyID"),
            new System.Data.OleDb.OleDbParameter("SkillID", System.Data.OleDb.OleDbType.Integer, 0, "SkillID"),
            new System.Data.OleDb.OleDbParameter("Years", System.Data.OleDb.OleDbType.Integer, 0, "Years"),
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Years", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Years", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Years", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Years", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand7
            // 
            this.oleDbDeleteCommand7.CommandText = "DELETE FROM `VACANCYSKILL` WHERE ((`VacancyID` = ?) AND (`SkillID` = ?) AND ((? =" +
    " 1 AND `Years` IS NULL) OR (`Years` = ?)))";
            this.oleDbDeleteCommand7.Connection = this.oleDbLooking;
            this.oleDbDeleteCommand7.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_VacancyID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "VacancyID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_SkillID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SkillID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Years", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Years", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Years", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Years", System.Data.DataRowVersion.Original, null)});
            // 
            // daVacancySkill
            // 
            this.daVacancySkill.DeleteCommand = this.oleDbDeleteCommand7;
            this.daVacancySkill.InsertCommand = this.oleDbInsertCommand7;
            this.daVacancySkill.SelectCommand = this.oleDbSelectCommand7;
            this.daVacancySkill.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "VACANCYSKILL", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("VacancyID", "VacancyID"),
                        new System.Data.Common.DataColumnMapping("SkillID", "SkillID"),
                        new System.Data.Common.DataColumnMapping("Years", "Years")})});
            this.daVacancySkill.UpdateCommand = this.oleDbUpdateCommand7;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand8;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand8;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand8;
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand8;
            // 
            // dsLooking1
            // 
            this.dsLooking1.DataSetName = "DSLooking";
            this.dsLooking1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "DataModule";
            this.Text = "DataModule";
            ((System.ComponentModel.ISupportInitialize)(this.dsLooking1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbLooking;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter daApplication;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand2;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand2;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand2;
        private System.Data.OleDb.OleDbDataAdapter daCandidate;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand3;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand3;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand3;
        private System.Data.OleDb.OleDbDataAdapter daCandidateSkill;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand4;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand4;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand4;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand4;
        private System.Data.OleDb.OleDbDataAdapter daEmployer;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand5;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand5;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand5;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand5;
        private System.Data.OleDb.OleDbDataAdapter daSkill;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand6;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand6;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand6;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand6;
        private System.Data.OleDb.OleDbDataAdapter daVacancy;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand7;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand7;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand7;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand7;
        private System.Data.OleDb.OleDbDataAdapter daVacancySkill;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand8;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand8;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand8;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand8;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        public DSLooking dsLooking1;
    }
}