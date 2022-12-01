<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEARRUsersSignOff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEARRUsersSignOff))
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.DsEARRUsersSignOff1 = New EngDesignTrackingTest.dsEARRUsersSignOff()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox7 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colSignedName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox8 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colProgram = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colProgram2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colProgram3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colProgram4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox5 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colType2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox6 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colFabShop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLiaison = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLiaisonBackup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEngineerBackup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQCBackup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanner1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlanner2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReadOnly = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnterEARR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSubstitute = New System.Windows.Forms.Button()
        Me.btnUpdateGrid = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        CType(Me.DsEARRUsersSignOff1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=172.16.3.7\getsmart;Initial Catalog=EARR;Persist Security Info=True;U" &
    "ser ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NVarChar, 0, "Username"), New System.Data.SqlClient.SqlParameter("@SignedName", System.Data.SqlDbType.NVarChar, 0, "SignedName"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@Program2", System.Data.SqlDbType.NVarChar, 0, "Program2"), New System.Data.SqlClient.SqlParameter("@Program3", System.Data.SqlDbType.NVarChar, 0, "Program3"), New System.Data.SqlClient.SqlParameter("@Program4", System.Data.SqlDbType.NVarChar, 0, "Program4"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@Type2", System.Data.SqlDbType.NVarChar, 0, "Type2"), New System.Data.SqlClient.SqlParameter("@FabShop", System.Data.SqlDbType.Bit, 0, "FabShop"), New System.Data.SqlClient.SqlParameter("@Liaison", System.Data.SqlDbType.Bit, 0, "Liaison"), New System.Data.SqlClient.SqlParameter("@LiaisonBackup", System.Data.SqlDbType.Bit, 0, "LiaisonBackup"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.Bit, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerBackup", System.Data.SqlDbType.Bit, 0, "EngineerBackup"), New System.Data.SqlClient.SqlParameter("@QC", System.Data.SqlDbType.Bit, 0, "QC"), New System.Data.SqlClient.SqlParameter("@QCBackup", System.Data.SqlDbType.Bit, 0, "QCBackup"), New System.Data.SqlClient.SqlParameter("@Planner1", System.Data.SqlDbType.Bit, 0, "Planner1"), New System.Data.SqlClient.SqlParameter("@Planner2", System.Data.SqlDbType.Bit, 0, "Planner2"), New System.Data.SqlClient.SqlParameter("@ReadOnly", System.Data.SqlDbType.Bit, 0, "ReadOnly"), New System.Data.SqlClient.SqlParameter("@EnterEARR", System.Data.SqlDbType.Bit, 0, "EnterEARR")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Username", System.Data.SqlDbType.NVarChar, 0, "Username"), New System.Data.SqlClient.SqlParameter("@SignedName", System.Data.SqlDbType.NVarChar, 0, "SignedName"), New System.Data.SqlClient.SqlParameter("@Email", System.Data.SqlDbType.NVarChar, 0, "Email"), New System.Data.SqlClient.SqlParameter("@Program", System.Data.SqlDbType.NVarChar, 0, "Program"), New System.Data.SqlClient.SqlParameter("@Program2", System.Data.SqlDbType.NVarChar, 0, "Program2"), New System.Data.SqlClient.SqlParameter("@Program3", System.Data.SqlDbType.NVarChar, 0, "Program3"), New System.Data.SqlClient.SqlParameter("@Program4", System.Data.SqlDbType.NVarChar, 0, "Program4"), New System.Data.SqlClient.SqlParameter("@Type", System.Data.SqlDbType.NVarChar, 0, "Type"), New System.Data.SqlClient.SqlParameter("@Type2", System.Data.SqlDbType.NVarChar, 0, "Type2"), New System.Data.SqlClient.SqlParameter("@FabShop", System.Data.SqlDbType.Bit, 0, "FabShop"), New System.Data.SqlClient.SqlParameter("@Liaison", System.Data.SqlDbType.Bit, 0, "Liaison"), New System.Data.SqlClient.SqlParameter("@LiaisonBackup", System.Data.SqlDbType.Bit, 0, "LiaisonBackup"), New System.Data.SqlClient.SqlParameter("@Engineer", System.Data.SqlDbType.Bit, 0, "Engineer"), New System.Data.SqlClient.SqlParameter("@EngineerBackup", System.Data.SqlDbType.Bit, 0, "EngineerBackup"), New System.Data.SqlClient.SqlParameter("@QC", System.Data.SqlDbType.Bit, 0, "QC"), New System.Data.SqlClient.SqlParameter("@QCBackup", System.Data.SqlDbType.Bit, 0, "QCBackup"), New System.Data.SqlClient.SqlParameter("@Planner1", System.Data.SqlDbType.Bit, 0, "Planner1"), New System.Data.SqlClient.SqlParameter("@Planner2", System.Data.SqlDbType.Bit, 0, "Planner2"), New System.Data.SqlClient.SqlParameter("@ReadOnly", System.Data.SqlDbType.Bit, 0, "ReadOnly"), New System.Data.SqlClient.SqlParameter("@EnterEARR", System.Data.SqlDbType.Bit, 0, "EnterEARR"), New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignedName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignedName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program3", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program4", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FabShop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FabShop", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Liaison", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Liaison", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Liaison", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Liaison", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QC", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QC", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReadOnly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReadOnly", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EnterEARR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EnterEARR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@RecordID", System.Data.SqlDbType.Int, 4, "RecordID")})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_RecordID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RecordID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Username", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Username", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_SignedName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_SignedName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SignedName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Email", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Email", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Email", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program3", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program3", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Program4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Program4", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Program4", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Program4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Type2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Type2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Type2", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Type2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_FabShop", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_FabShop", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FabShop", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Liaison", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Liaison", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Liaison", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Liaison", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_LiaisonBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "LiaisonBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_LiaisonBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "LiaisonBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Engineer", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Engineer", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Engineer", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EngineerBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EngineerBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EngineerBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EngineerBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QC", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QC", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QC", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_QCBackup", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "QCBackup", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_QCBackup", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QCBackup", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner1", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Planner2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Planner2", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Planner2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_ReadOnly", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_ReadOnly", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReadOnly", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_EnterEARR", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_EnterEARR", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EnterEARR", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "tblUsersCreateEARR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RecordID", "RecordID"), New System.Data.Common.DataColumnMapping("Username", "Username"), New System.Data.Common.DataColumnMapping("SignedName", "SignedName"), New System.Data.Common.DataColumnMapping("Email", "Email"), New System.Data.Common.DataColumnMapping("Program", "Program"), New System.Data.Common.DataColumnMapping("Program2", "Program2"), New System.Data.Common.DataColumnMapping("Program3", "Program3"), New System.Data.Common.DataColumnMapping("Program4", "Program4"), New System.Data.Common.DataColumnMapping("Type", "Type"), New System.Data.Common.DataColumnMapping("Type2", "Type2"), New System.Data.Common.DataColumnMapping("FabShop", "FabShop"), New System.Data.Common.DataColumnMapping("Liaison", "Liaison"), New System.Data.Common.DataColumnMapping("LiaisonBackup", "LiaisonBackup"), New System.Data.Common.DataColumnMapping("Engineer", "Engineer"), New System.Data.Common.DataColumnMapping("EngineerBackup", "EngineerBackup"), New System.Data.Common.DataColumnMapping("QC", "QC"), New System.Data.Common.DataColumnMapping("QCBackup", "QCBackup"), New System.Data.Common.DataColumnMapping("Planner1", "Planner1"), New System.Data.Common.DataColumnMapping("Planner2", "Planner2"), New System.Data.Common.DataColumnMapping("ReadOnly", "ReadOnly"), New System.Data.Common.DataColumnMapping("EnterEARR", "EnterEARR")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DsEARRUsersSignOff1
        '
        Me.DsEARRUsersSignOff1.DataSetName = "dsEARRUsersSignOff"
        Me.DsEARRUsersSignOff1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblUsersCreateEARR"
        Me.BindingSource1.DataSource = Me.DsEARRUsersSignOff1
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.BindingSource1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6)
        Me.GridControl1.Location = New System.Drawing.Point(10, 23)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4, Me.RepositoryItemComboBox5, Me.RepositoryItemComboBox6, Me.RepositoryItemComboBox7, Me.RepositoryItemComboBox8})
        Me.GridControl1.Size = New System.Drawing.Size(2556, 1344)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRecordID, Me.colUsername, Me.colSignedName, Me.colEmail, Me.colProgram, Me.colProgram2, Me.colProgram3, Me.colProgram4, Me.colType, Me.colType2, Me.colFabShop, Me.colLiaison, Me.colLiaisonBackup, Me.colEngineer, Me.colEngineerBackup, Me.colQC, Me.colQCBackup, Me.colPlanner1, Me.colPlanner2, Me.colReadOnly, Me.colEnterEARR})
        Me.GridView1.DetailHeight = 673
        Me.GridView1.FixedLineWidth = 4
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        '
        'colRecordID
        '
        Me.colRecordID.FieldName = "RecordID"
        Me.colRecordID.MinWidth = 40
        Me.colRecordID.Name = "colRecordID"
        Me.colRecordID.Width = 150
        '
        'colUsername
        '
        Me.colUsername.ColumnEdit = Me.RepositoryItemComboBox7
        Me.colUsername.FieldName = "Username"
        Me.colUsername.MinWidth = 40
        Me.colUsername.Name = "colUsername"
        Me.colUsername.Visible = True
        Me.colUsername.VisibleIndex = 0
        Me.colUsername.Width = 210
        '
        'RepositoryItemComboBox7
        '
        Me.RepositoryItemComboBox7.AutoHeight = False
        Me.RepositoryItemComboBox7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox7.Name = "RepositoryItemComboBox7"
        Me.RepositoryItemComboBox7.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colSignedName
        '
        Me.colSignedName.FieldName = "SignedName"
        Me.colSignedName.MinWidth = 40
        Me.colSignedName.Name = "colSignedName"
        Me.colSignedName.Width = 150
        '
        'colEmail
        '
        Me.colEmail.ColumnEdit = Me.RepositoryItemComboBox8
        Me.colEmail.FieldName = "Email"
        Me.colEmail.MinWidth = 40
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 1
        Me.colEmail.Width = 208
        '
        'RepositoryItemComboBox8
        '
        Me.RepositoryItemComboBox8.AutoHeight = False
        Me.RepositoryItemComboBox8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox8.Name = "RepositoryItemComboBox8"
        Me.RepositoryItemComboBox8.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colProgram
        '
        Me.colProgram.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colProgram.FieldName = "Program"
        Me.colProgram.MinWidth = 40
        Me.colProgram.Name = "colProgram"
        Me.colProgram.Visible = True
        Me.colProgram.VisibleIndex = 2
        Me.colProgram.Width = 240
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colProgram2
        '
        Me.colProgram2.ColumnEdit = Me.RepositoryItemComboBox2
        Me.colProgram2.FieldName = "Program2"
        Me.colProgram2.MinWidth = 40
        Me.colProgram2.Name = "colProgram2"
        Me.colProgram2.Visible = True
        Me.colProgram2.VisibleIndex = 3
        Me.colProgram2.Width = 238
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        Me.RepositoryItemComboBox2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colProgram3
        '
        Me.colProgram3.ColumnEdit = Me.RepositoryItemComboBox3
        Me.colProgram3.FieldName = "Program3"
        Me.colProgram3.MinWidth = 40
        Me.colProgram3.Name = "colProgram3"
        Me.colProgram3.Visible = True
        Me.colProgram3.VisibleIndex = 4
        Me.colProgram3.Width = 228
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        Me.RepositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colProgram4
        '
        Me.colProgram4.ColumnEdit = Me.RepositoryItemComboBox4
        Me.colProgram4.FieldName = "Program4"
        Me.colProgram4.MinWidth = 40
        Me.colProgram4.Name = "colProgram4"
        Me.colProgram4.Visible = True
        Me.colProgram4.VisibleIndex = 5
        Me.colProgram4.Width = 204
        '
        'RepositoryItemComboBox4
        '
        Me.RepositoryItemComboBox4.AutoHeight = False
        Me.RepositoryItemComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox4.Name = "RepositoryItemComboBox4"
        Me.RepositoryItemComboBox4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colType
        '
        Me.colType.ColumnEdit = Me.RepositoryItemComboBox5
        Me.colType.FieldName = "Type"
        Me.colType.MinWidth = 40
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 6
        Me.colType.Width = 138
        '
        'RepositoryItemComboBox5
        '
        Me.RepositoryItemComboBox5.AutoHeight = False
        Me.RepositoryItemComboBox5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox5.Name = "RepositoryItemComboBox5"
        Me.RepositoryItemComboBox5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colType2
        '
        Me.colType2.ColumnEdit = Me.RepositoryItemComboBox6
        Me.colType2.FieldName = "Type2"
        Me.colType2.MinWidth = 40
        Me.colType2.Name = "colType2"
        Me.colType2.Visible = True
        Me.colType2.VisibleIndex = 7
        Me.colType2.Width = 120
        '
        'RepositoryItemComboBox6
        '
        Me.RepositoryItemComboBox6.AutoHeight = False
        Me.RepositoryItemComboBox6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox6.Name = "RepositoryItemComboBox6"
        Me.RepositoryItemComboBox6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colFabShop
        '
        Me.colFabShop.FieldName = "FabShop"
        Me.colFabShop.MinWidth = 40
        Me.colFabShop.Name = "colFabShop"
        Me.colFabShop.Visible = True
        Me.colFabShop.VisibleIndex = 8
        Me.colFabShop.Width = 110
        '
        'colLiaison
        '
        Me.colLiaison.FieldName = "Liaison"
        Me.colLiaison.MinWidth = 40
        Me.colLiaison.Name = "colLiaison"
        Me.colLiaison.Visible = True
        Me.colLiaison.VisibleIndex = 9
        Me.colLiaison.Width = 80
        '
        'colLiaisonBackup
        '
        Me.colLiaisonBackup.FieldName = "LiaisonBackup"
        Me.colLiaisonBackup.MinWidth = 40
        Me.colLiaisonBackup.Name = "colLiaisonBackup"
        Me.colLiaisonBackup.Visible = True
        Me.colLiaisonBackup.VisibleIndex = 10
        Me.colLiaisonBackup.Width = 154
        '
        'colEngineer
        '
        Me.colEngineer.Caption = "Eng"
        Me.colEngineer.FieldName = "Engineer"
        Me.colEngineer.MinWidth = 40
        Me.colEngineer.Name = "colEngineer"
        Me.colEngineer.Visible = True
        Me.colEngineer.VisibleIndex = 11
        Me.colEngineer.Width = 62
        '
        'colEngineerBackup
        '
        Me.colEngineerBackup.Caption = "Eng Backup"
        Me.colEngineerBackup.FieldName = "EngineerBackup"
        Me.colEngineerBackup.MinWidth = 40
        Me.colEngineerBackup.Name = "colEngineerBackup"
        Me.colEngineerBackup.Visible = True
        Me.colEngineerBackup.VisibleIndex = 12
        Me.colEngineerBackup.Width = 128
        '
        'colQC
        '
        Me.colQC.FieldName = "QC"
        Me.colQC.MinWidth = 40
        Me.colQC.Name = "colQC"
        Me.colQC.Visible = True
        Me.colQC.VisibleIndex = 13
        Me.colQC.Width = 50
        '
        'colQCBackup
        '
        Me.colQCBackup.FieldName = "QCBackup"
        Me.colQCBackup.MinWidth = 40
        Me.colQCBackup.Name = "colQCBackup"
        Me.colQCBackup.Visible = True
        Me.colQCBackup.VisibleIndex = 14
        Me.colQCBackup.Width = 126
        '
        'colPlanner1
        '
        Me.colPlanner1.Caption = "Plan1"
        Me.colPlanner1.FieldName = "Planner1"
        Me.colPlanner1.MinWidth = 40
        Me.colPlanner1.Name = "colPlanner1"
        Me.colPlanner1.Visible = True
        Me.colPlanner1.VisibleIndex = 15
        Me.colPlanner1.Width = 88
        '
        'colPlanner2
        '
        Me.colPlanner2.Caption = "Plan2"
        Me.colPlanner2.FieldName = "Planner2"
        Me.colPlanner2.MinWidth = 40
        Me.colPlanner2.Name = "colPlanner2"
        Me.colPlanner2.Visible = True
        Me.colPlanner2.VisibleIndex = 16
        Me.colPlanner2.Width = 122
        '
        'colReadOnly
        '
        Me.colReadOnly.FieldName = "ReadOnly"
        Me.colReadOnly.MinWidth = 40
        Me.colReadOnly.Name = "colReadOnly"
        Me.colReadOnly.Width = 150
        '
        'colEnterEARR
        '
        Me.colEnterEARR.FieldName = "EnterEARR"
        Me.colEnterEARR.MinWidth = 40
        Me.colEnterEARR.Name = "colEnterEARR"
        Me.colEnterEARR.Width = 150
        '
        'btnSubstitute
        '
        Me.btnSubstitute.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubstitute.Location = New System.Drawing.Point(1553, 1379)
        Me.btnSubstitute.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSubstitute.Name = "btnSubstitute"
        Me.btnSubstitute.Size = New System.Drawing.Size(604, 83)
        Me.btnSubstitute.TabIndex = 1
        Me.btnSubstitute.Text = "Substitute Selected Users"
        Me.btnSubstitute.UseVisualStyleBackColor = True
        '
        'btnUpdateGrid
        '
        Me.btnUpdateGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateGrid.Location = New System.Drawing.Point(10, 1379)
        Me.btnUpdateGrid.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUpdateGrid.Name = "btnUpdateGrid"
        Me.btnUpdateGrid.Size = New System.Drawing.Size(604, 83)
        Me.btnUpdateGrid.TabIndex = 2
        Me.btnUpdateGrid.Text = "Update Grid"
        Me.btnUpdateGrid.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(623, 1379)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(604, 83)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete Selected"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "Data Source=172.16.3.7\GETSMART;Initial Catalog=ENGDWG;Persist Security Info=True" &
    ";User ID=sa1;Password=""The water is wet!"""
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'frmEARRUsersSignOff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2568, 1472)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdateGrid)
        Me.Controls.Add(Me.btnSubstitute)
        Me.Controls.Add(Me.GridControl1)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmEARRUsersSignOff"
        Me.Text = "frmEARRUsersSignOff"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsEARRUsersSignOff1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents DsEARRUsersSignOff1 As dsEARRUsersSignOff
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsername As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSignedName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProgram4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFabShop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLiaison As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLiaisonBackup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEngineerBackup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQCBackup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanner1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlanner2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReadOnly As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnterEARR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSubstitute As Button
    Friend WithEvents btnUpdateGrid As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents SqlConnection2 As SqlClient.SqlConnection
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox5 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox6 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox7 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemComboBox8 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
