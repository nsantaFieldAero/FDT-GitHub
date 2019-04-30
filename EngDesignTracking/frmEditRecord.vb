﻿Public Class frmEditRecord
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Public CalField As String
    Private Sub Label22_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmEditRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString

        da = New SqlClient.SqlDataAdapter("Select * from tblRevisionsLookup Order By Sort Asc", SqlConnection1)
        da.Fill(ds, "Revisions")

        Me.cboDrawingRevision.DataSource = ds.Tables("Revisions")
        Me.cboDrawingRevision.DisplayMember = "Rev"

        Search()
    End Sub

    Public Function Search()

        'Me.txtQuoteNo.Enabled = False
        Dim SqlString As String
        'MsgBox(Me.txtLastName.Text)

        ''If Me.cboSchoolYearEnrolledIn.Text = "2016" And txtLastNameSearch.Text = "" Then
        SqlString = SqlString + " Where RecordID = '" & Val(RecordToEdit) & "'"
        ''End If

        'SqlString = SqlString + " ORDER BY StudentLast Asc"

        Me.DataSet31.tblDrawings.Clear()

        Me.txtRecordID.DataBindings.Clear()
        Me.cboStatus.DataBindings.Clear()
        Me.txtActualFinishDate.DataBindings.Clear()
        Me.txtPlannedFinishDate.DataBindings.Clear()
        Me.txtForecastFinishDate.DataBindings.Clear()
        Me.txtPercentComplete.DataBindings.Clear()
        Me.txtDrawingFolderAssignDate.DataBindings.Clear()
        Me.txtDesignWIPDate.DataBindings.Clear()
        Me.txtNotes.DataBindings.Clear()
        Me.txtModelTemplateDate.DataBindings.Clear()
        Me.cboDrafter.DataBindings.Clear()
        Me.cboDrafterComplete.DataBindings.Clear()
        Me.cboEngineer.DataBindings.Clear()
        Me.cboEngineerComplete.DataBindings.Clear()
        Me.cboSrEngineer.DataBindings.Clear()
        Me.cboSrEngineerComplete.DataBindings.Clear()
        Me.cboReleaser.DataBindings.Clear()
        Me.cboReleaserComplete.DataBindings.Clear()
        Me.cboFlammability.DataBindings.Clear()
        Me.cboFlammabilityComplete.DataBindings.Clear()
        Me.cboStress.DataBindings.Clear()
        Me.cboStressComplete.DataBindings.Clear()
        Me.cboDrafterPlannedCompleteDate.DataBindings.Clear()
        Me.cboEngineerPlannedCompleteDate.DataBindings.Clear()
        Me.cboSrEngineerPlannedCompleteDate.DataBindings.Clear()
        Me.cboFlammabilityPlannedCompleteDate.DataBindings.Clear()
        Me.cboStressPlannedCompleteDate.DataBindings.Clear()
        Me.cboReleaserPlannedCompleteDate.DataBindings.Clear()
        Me.txtLocation.DataBindings.Clear()
        Me.txtDrawingNumber.DataBindings.Clear()
        Me.cboAvionics.DataBindings.Clear()
        Me.cboAvionicsComplete.DataBindings.Clear()
        Me.cboAvionicsPlannedComplete.DataBindings.Clear()
        Me.cboMechanical.DataBindings.Clear()
        Me.cboMechanicalComplete.DataBindings.Clear()
        Me.cboMechanicalPlannedComplete.DataBindings.Clear()
        Me.txtDrawingTitle.DataBindings.Clear()
        Me.cboDrawingRevision.DataBindings.Clear()
        Me.txtWONumber.DataBindings.Clear()




        Dim cmdSave As String

        cmdSave = Me.SqlDataAdapter1.SelectCommand.CommandText
        Me.SqlDataAdapter1.SelectCommand.CommandText() += SqlString


        ''If Me.cboSchoolYearEnrolledIn.Text = "2013" And Me.txtLastNameSearch.Text = "" And BackToPerson = 0 Then
        ''	Me.SqlDataAdapter1.SelectCommand.CommandText() = "SELECT * FROM vwStudents  A INNER JOIN tblStudents B ON  A.RecordID = B.RecordID INNER JOIN  tblClassEnrollment C ON B.RecordID = C.StudentID Where C.SchoolYear = '2013' ORDER BY C.StudentLast Asc"
        ''End If

        Try
            Me.SqlDataAdapter1.Fill(DataSet31.tblDrawings)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlDataAdapter1.SelectCommand.CommandText = cmdSave

        If Me.DataSet31.Tables("tblDrawings").Rows.Count <> 0 Then
            'Me.btnSavePerson.Enabled = True
            Search = True

            'Create DataBindings
            Me.txtRecordID.DataBindings.Add("Text",
                Me.BindingSource1, "RecordID")
            Me.cboStatus.DataBindings.Add("Text",
                Me.BindingSource1, "Status")
            Me.txtActualFinishDate.DataBindings.Add("Value",
                Me.BindingSource1, "ActualFinishDate")
            Me.txtPlannedFinishDate.DataBindings.Add("Value",
                Me.BindingSource1, "ForecastFinishDate")
            Me.txtForecastFinishDate.DataBindings.Add("Value",
                Me.BindingSource1, "PlannedFinishDate")
            Me.txtPercentComplete.DataBindings.Add("Text",
                Me.BindingSource1, "PercentComplete")
            Me.txtDrawingFolderAssignDate.DataBindings.Add("Text",
                Me.BindingSource1, "DrawingFolderAssignDate")
            Me.txtDesignWIPDate.DataBindings.Add("Text",
                Me.BindingSource1, "DesignWIPDate")
            Me.txtNotes.DataBindings.Add("Text",
                Me.BindingSource1, "Notes")
            Me.txtModelTemplateDate.DataBindings.Add("Text",
                Me.BindingSource1, "ModelTemplateDate")
            Me.cboDrafter.DataBindings.Add("Text",
                Me.BindingSource1, "Drafter")
            Me.cboDrafterComplete.DataBindings.Add("Value",
                Me.BindingSource1, "DrafterComplete")
            Me.cboEngineer.DataBindings.Add("Text",
                Me.BindingSource1, "Engineer")
            Me.cboEngineerComplete.DataBindings.Add("Value",
                Me.BindingSource1, "EngineerComplete")
            Me.cboSrEngineer.DataBindings.Add("Text",
                Me.BindingSource1, "SrEngineer")
            Me.cboSrEngineerComplete.DataBindings.Add("Value",
                Me.BindingSource1, "SrEngineerComplete")
            Me.cboReleaser.DataBindings.Add("Text",
                Me.BindingSource1, "Releaser")
            Me.cboReleaserComplete.DataBindings.Add("Value",
                Me.BindingSource1, "ReleaserCompelte")
            Me.cboFlammability.DataBindings.Add("Text",
                Me.BindingSource1, "Flammability")
            Me.cboFlammabilityComplete.DataBindings.Add("Value",
                Me.BindingSource1, "FlammabilityComplete")
            Me.cboStress.DataBindings.Add("Text",
                Me.BindingSource1, "Stress")
            Me.cboStressComplete.DataBindings.Add("Value",
                Me.BindingSource1, "StressComplete")
            Me.cboEngineerPlannedCompleteDate.DataBindings.Add("Value",
                Me.BindingSource1, "EngineerPlannedCompleteDate")
            Me.cboDrafterPlannedCompleteDate.DataBindings.Add("Value",
                Me.BindingSource1, "DrafterPlannedCompleteDate")
            Me.cboSrEngineerPlannedCompleteDate.DataBindings.Add("Value",
                Me.BindingSource1, "SrEngineerPlannedCompleteDate")
            Me.cboFlammabilityPlannedCompleteDate.DataBindings.Add("Value",
                Me.BindingSource1, "FlammabilityPlannedCompleteDate")
            Me.cboStressPlannedCompleteDate.DataBindings.Add("Value",
                Me.BindingSource1, "StressPlannedCompleteDate")
            Me.cboReleaserPlannedCompleteDate.DataBindings.Add("Value",
                Me.BindingSource1, "ReleaserPlannedCompleteDate")
            Me.txtLocation.DataBindings.Add("Text",
                Me.BindingSource1, "Location")
            Me.txtDrawingNumber.DataBindings.Add("Text",
                Me.BindingSource1, "DrawingNumber")
            Me.cboAvionics.DataBindings.Add("Text",
                Me.BindingSource1, "Avionics")
            Me.cboAvionicsComplete.DataBindings.Add("Value",
                Me.BindingSource1, "AvionicsComplete")
            Me.cboAvionicsPlannedComplete.DataBindings.Add("Value",
                Me.BindingSource1, "AvionicsPlannedComplete")
            Me.cboMechanical.DataBindings.Add("Text",
                Me.BindingSource1, "Mechanical")
            Me.cboMechanicalComplete.DataBindings.Add("Value",
                Me.BindingSource1, "MechanicalComplete")
            Me.cboMechanicalPlannedComplete.DataBindings.Add("Value",
                Me.BindingSource1, "MechanicalPlannedComplete")
            Me.txtDrawingTitle.DataBindings.Add("Text",
                Me.BindingSource1, "DrawingTitle")
            Me.cboDrawingRevision.DataBindings.Add("Text",
                Me.BindingSource1, "DWGRevision")
            Me.txtWONumber.DataBindings.Add("Text",
                Me.BindingSource1, "WONumber")


        Else
            MsgBox("No Records Exist.  You may perform a new search or enter a new person.")
            'Dim frmMain As New frmMain
            'frmMain.Show()
            'Me.Close()
        End If
    End Function

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click

        Me.SqlDataAdapter1.Update(DataSet31.tblDrawings)

        Dim frmGridLookup As New frmGridLookUp
        If Me.txtDrawingNumber.Text <> "" Then
            da = New SqlClient.SqlDataAdapter("Select * from tblDrawings where DrawingNumber = '" & Me.txtDrawingNumber.Text & "' And DwgRevision = '" & Me.cboDrawingRevision.Text & "'", SqlConnection1)
            da.Fill(ds, "DwgExist")

            If ds.Tables("DwgExist").Rows.Count > 1 Then
                MsgBox("The Drawing Number/Revision Combo Exists Already.  You must specify a different drawing number/revision.")
                Exit Sub
            Else
                u.ExecuteSQL(SqlConnection1, "UPDATE tblDrawings Set DrawingNumber = '" & txtDrawingNumber.Text & "', Status = '" & u.FTM(Me.cboStatus.Text) & "', ActualFinishDate = '" & Me.txtActualFinishDate.Value & "', ForecastStartDate = '" & Me.txtForecastStartDate.Value & "', ForecastFinishDate = '" & Me.txtForecastFinishDate.Value & "', PlannedFinishDate = '" & Me.txtPlannedFinishDate.Value & "', EstimatedDurationHours = '" & Me.txtboxEstimatedDuration.Text & "', PercentComplete = '" & Me.txtPercentComplete.Text & "', DrawingFolderAssignDate = '" & Me.txtDrawingFolderAssignDate.Text & "', DesignWIPDate = '" & Me.txtDesignWIPDate.Text & "', Notes = '" & u.FTM(Me.txtNotes.Text) & "', ModelTemplateDate = '" & Me.txtModelTemplateDate.Text & "', Drafter = '" & u.FTM(Me.cboDrafter.Text) & "', DrafterComplete = '" & Me.cboDrafterComplete.Value & "', Engineer = '" & u.FTM(Me.cboEngineer.Text) & "', EngineerComplete = '" & Me.cboEngineerComplete.Value & "', SrEngineer = '" & u.FTM(Me.cboSrEngineer.Text) & "', SrEngineerComplete = '" & Me.cboSrEngineerComplete.Value & "', Releaser = '" & u.FTM(Me.cboReleaser.Text) & "', ReleaserCompelte = '" & Me.cboReleaserComplete.Value & "', Flammability = '" & u.FTM(Me.cboFlammability.Text) & "', FlammabilityComplete = '" & Me.cboFlammabilityComplete.Value & "', Stress = '" & u.FTM(Me.cboStress.Text) & "', StressComplete = '" & u.FTM(Me.cboStressComplete.Value) & "', DrafterPlannedCompleteDate = '" & Me.cboDrafterPlannedCompleteDate.Value & "', EngineerPlannedCompleteDate = '" & Me.cboEngineerPlannedCompleteDate.Value & "', SrEngineerPlannedCompleteDate = '" & Me.cboSrEngineerPlannedCompleteDate.Value & "', FlammabilityPlannedCompleteDate = '" & Me.cboFlammabilityPlannedCompleteDate.Value & "', StressPlannedCompleteDate = '" & Me.cboStressPlannedCompleteDate.Value & "', ReleaserPlannedCompleteDate = '" & Me.cboReleaserPlannedCompleteDate.Value & "', Avionics = '" & u.FTM(Me.cboAvionics.Text) & "', AvionicsComplete = '" & Me.cboAvionicsComplete.Value & "', AvionicsPlannedComplete = '" & Me.cboAvionicsPlannedComplete.Value & "', Mechanical = '" & u.FTM(Me.cboMechanical.Text) & "', MechanicalComplete = '" & Me.cboMechanicalComplete.Value & "', DWGRevision = '" & Me.cboDrawingRevision.Text & "', DrawingTitle = '" & u.FTM(Me.txtDrawingTitle.Text) & "', MechanicalPlannedComplete = '" & Me.cboMechanicalPlannedComplete.Value & "', WONumber = '" & u.FTM(Me.txtWONumber.Text) & "', NextHigherAssembly = '" & u.FTM(Me.txtboxNextHigherAssembly.Text) & "' WHERE RecordID = '" & Val(Me.txtRecordID.Text) & "'")
                MsgBox("Record Updated.")

                'frmGridLookup.Show()
                Me.Close()
            End If

        Else
            u.ExecuteSQL(SqlConnection1, "UPDATE tblDrawings Set DrawingNumber = '" & txtDrawingNumber.Text & "', Status = '" & Me.cboStatus.Text & "', ActualFinishDate = '" & Me.txtActualFinishDate.Value & "', ForecastStartDate = '" & Me.txtForecastStartDate.Value & "', ForecastFinishDate = '" & Me.txtForecastFinishDate.Value & "', PlannedFinishDate = '" & Me.txtPlannedFinishDate.Value & "', EstimatedDurationHours = '" & Me.txtboxEstimatedDuration.Text & "', PercentComplete = '" & Me.txtPercentComplete.Text & "', DrawingFolderAssignDate = '" & Me.txtDrawingFolderAssignDate.Text & "', DesignWIPDate = '" & Me.txtDesignWIPDate.Text & "', Notes = '" & u.FTM(Me.txtNotes.Text) & "', ModelTemplateDate = '" & Me.txtModelTemplateDate.Text & "', Drafter = '" & u.FTM(Me.cboDrafter.Text) & "', DrafterComplete = '" & Me.cboDrafterComplete.Value & "', Engineer = '" & u.FTM(Me.cboEngineer.Text) & "', EngineerComplete = '" & Me.cboEngineerComplete.Value & "', SrEngineer = '" & u.FTM(Me.cboSrEngineer.Text) & "', SrEngineerComplete = '" & Me.cboSrEngineerComplete.Value & "', Releaser = '" & u.FTM(Me.cboReleaser.Text) & "', ReleaserCompelte = '" & Me.cboReleaserComplete.Value & "', Flammability = '" & u.FTM(Me.cboFlammability.Text) & "', FlammabilityComplete = '" & Me.cboFlammabilityComplete.Value & "', Stress = '" & u.FTM(Me.cboStress.Text) & "', StressComplete = '" & u.FTM(Me.cboStressComplete.Value) & "', DrafterPlannedCompleteDate = '" & Me.cboDrafterPlannedCompleteDate.Value & "', EngineerPlannedCompleteDate = '" & Me.cboEngineerPlannedCompleteDate.Value & "', SrEngineerPlannedCompleteDate = '" & Me.cboSrEngineerPlannedCompleteDate.Value & "', FlammabilityPlannedCompleteDate = '" & Me.cboFlammabilityPlannedCompleteDate.Value & "', StressPlannedCompleteDate = '" & Me.cboStressPlannedCompleteDate.Value & "', ReleaserPlannedCompleteDate = '" & Me.cboReleaserPlannedCompleteDate.Value & "', Avionics = '" & u.FTM(Me.cboAvionics.Text) & "', AvionicsComplete = '" & Me.cboAvionicsComplete.Value & "', AvionicsPlannedComplete = '" & Me.cboAvionicsPlannedComplete.Value & "', Mechanical = '" & u.FTM(Me.cboMechanical.Text) & "', MechanicalComplete = '" & Me.cboMechanicalComplete.Value & "', DWGRevision = '" & Me.cboDrawingRevision.Text & "', DrawingTitle = '" & u.FTM(Me.txtDrawingTitle.Text) & "', MechanicalPlannedComplete = '" & Me.cboMechanicalPlannedComplete.Value & "', WONumber = '" & u.FTM(Me.txtWONumber.Text) & "', NextHigherAssembly = '" & u.FTM(Me.txtboxNextHigherAssembly.Text) & "' WHERE RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            MsgBox("Record Updated.")
            'frmGridLookup.Show()
            Me.Close()
        End If

    End Sub

    Private Sub txtLocation_TextChanged(sender As Object, e As EventArgs) Handles txtLocation.TextChanged
        Me.cboStatus.Items.Clear()
        Me.cboSrEngineer.Visible = True
        Me.cboSrEngineerComplete.Visible = True
        Me.cboSrEngineerPlannedCompleteDate.Visible = True
        Me.cboFlammability.Visible = True
        Me.cboFlammabilityComplete.Visible = True
        Me.cboFlammabilityPlannedCompleteDate.Visible = True
        Me.cboStress.Visible = True
        Me.cboStressComplete.Visible = True
        Me.cboStressPlannedCompleteDate.Visible = True
        Me.cboAvionics.Visible = True
        Me.cboAvionicsComplete.Visible = True
        Me.cboAvionicsPlannedComplete.Visible = True
        Me.cboMechanical.Visible = True
        Me.cboMechanicalComplete.Visible = True
        Me.cboMechanicalPlannedComplete.Visible = True


        If txtLocation.Text = "Toronto" Or txtLocation.Text = "Calgary" Then
            cboStatus.Items.Add("GATE 0: CM Needs To Assign DWG Number")
            cboStatus.Items.Add("GATE 1: DWG Ready For Drafter")
            cboStatus.Items.Add("GATE 2: DWG Ready For Checker/Engineer")
            cboStatus.Items.Add("GATE 3: DWG Ready For Flammability")
            cboStatus.Items.Add("GATE 4: DWG Ready For Stress")
            cboStatus.Items.Add("GATE 5: DWG Ready For Avionics")
            cboStatus.Items.Add("GATE 6: DWG Ready For Mechanical")
            cboStatus.Items.Add("GATE 7: DWG Ready For Release")
            cboStatus.Items.Add("GATE 8: DWG Released")
            cboStatus.Items.Add("GATE 9: Complete")
            Me.cboSrEngineer.Visible = False
            Me.cboSrEngineerComplete.Visible = False
            Me.cboSrEngineerPlannedCompleteDate.Visible = False
        ElseIf txtLocation.Text = "OKC" Then
            cboStatus.Items.Add("GATE 0: CM Needs To Assign DWG Number")
            cboStatus.Items.Add("GATE 1: DWG Ready For Drafter")
            cboStatus.Items.Add("GATE 2: DWG Ready For Checker/Engineer")
            cboStatus.Items.Add("GATE 3: DWG Ready For Sr Engineer")
            cboStatus.Items.Add("GATE 4: DWG Ready For Release")
            cboStatus.Items.Add("GATE 5: DWG Released")
            cboStatus.Items.Add("GATE 6: Complete")
            'EDIT 4/17/19:  Flammability, Stress, Avionics and Mechanical cbo's were set to visible=false when the location is OKC.  I made them visible commenting "....Visible = False"
            'Me.cboFlammability.Visible = False
            Me.cboFlammabilityComplete.Visible = False
            Me.cboFlammabilityPlannedCompleteDate.Visible = False
            'Me.cboStress.Visible = False
            Me.cboStressComplete.Visible = False
            Me.cboStressPlannedCompleteDate.Visible = False
            'Me.cboAvionics.Visible = False
            Me.cboAvionicsComplete.Visible = False
            Me.cboAvionicsPlannedComplete.Visible = False
            'Me.cboMechanical.Visible = False
            Me.cboMechanicalComplete.Visible = False
            Me.cboMechanicalPlannedComplete.Visible = False


        End If



        'GATE 0: CM Needs To Assign DWG Number
        'GATE 1: WIP
        '		GATE 2: DWG Ready For Drafter
        'GATE 3: DWG Ready For Checker/Engineer
        'GATE 4: DWG Ready For Stress
        'GATE 5: DWG Ready For Flammability
        'GATE 6: DWG Ready For Sr Engineer
        'GATE 7: DWG Ready For Release
        'GATE 8 : DWG Released
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ConfirmSave()
        'frmGridLookUp.Show()
        Me.Close()
    End Sub

    Public Function ConfirmSave()
        Dim result As DialogResult = MessageBox.Show("Would you like to save changes before closing?",
                      "Title",
                      MessageBoxButtons.YesNo)

        If (result = DialogResult.Yes) Then
            u.ExecuteSQL(SqlConnection1, "UPDATE tblDrawings Set DrawingNumber = '" & txtDrawingNumber.Text & "', Status = '" & Me.cboStatus.Text & "', ActualFinishDate = '" & Me.txtActualFinishDate.Text & "', ForecastStartDate = '" & Me.txtForecastStartDate.Text & "', ForecastFinishDate = '" & Me.txtForecastFinishDate.Text & "', PlannedFinishDate = '" & Me.txtPlannedFinishDate.Text & "', EstimatedDurationHours = '" & Me.txtboxEstimatedDuration.Text & "', PercentComplete = '" & Me.txtPercentComplete.Text & "', DrawingFolderAssignDate = '" & Me.txtDrawingFolderAssignDate.Text & "', DesignWIPDate = '" & Me.txtDesignWIPDate.Text & "', Notes = '" & u.FTM(Me.txtNotes.Text) & "', ModelTemplateDate = '" & Me.txtModelTemplateDate.Text & "', Drafter = '" & Me.cboDrafter.Text & "', DrafterComplete = '" & Me.cboDrafterComplete.Text & "', Engineer = '" & Me.cboEngineer.Text & "', EngineerComplete = '" & Me.cboEngineerComplete.Text & "', SrEngineer = '" & Me.cboSrEngineer.Text & "', SrEngineerComplete = '" & Me.cboSrEngineerComplete.Text & "', Releaser = '" & Me.cboReleaser.Text & "', ReleaserCompelte = '" & Me.cboReleaserComplete.Text & "', Flammability = '" & Me.cboFlammability.Text & "', FlammabilityComplete = '" & Me.cboFlammabilityComplete.Text & "', Stress = '" & Me.cboStress.Text & "', StressComplete = '" & Me.cboStressComplete.Text & "', DrafterPlannedCompleteDate = '" & Me.cboDrafterPlannedCompleteDate.Text & "', EngineerPlannedCompleteDate = '" & Me.cboEngineerPlannedCompleteDate.Text & "', SrEngineerPlannedCompleteDate = '" & Me.cboSrEngineerPlannedCompleteDate.Text & "', FlammabilityPlannedCompleteDate = '" & Me.cboFlammabilityPlannedCompleteDate.Text & "', StressPlannedCompleteDate = '" & Me.cboStressPlannedCompleteDate.Text & "', ReleaserPlannedCompleteDate = '" & Me.cboReleaserPlannedCompleteDate.Text & "', Avionics = '" & Me.cboAvionics.Text & "', AvionicsComplete = '" & Me.cboAvionicsComplete.Text & "', AvionicsPlannedComplete = '" & Me.cboAvionicsPlannedComplete.Text & "', Mechanical = '" & Me.cboMechanical.Text & "', MechanicalComplete = '" & Me.cboMechanicalComplete.Text & "', DrawingTitle = '" & Me.txtDrawingTitle.Text & "', WONumber = '" & u.FTM(Me.txtWONumber.Text) & "', NextHigherAssembly = '" & u.FTM(Me.txtboxNextHigherAssembly.Text) & "' WHERE RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            'Below is code before 04/23/19
            'u.ExecuteSQL(SqlConnection1, "UPDATE tblDrawings Set DrawingNumber = '" & txtDrawingNumber.Text & "', Status = '" & Me.cboStatus.Text & "', ActualFinishDate = '" & Me.txtActualFinishDate.Text & "', ForecastFinishDate = '" & Me.txtPlannedFinishDate.Text & "', PlannedFinishDate = '" & Me.txtForecastFinishDate.Text & "', PercentComplete = '" & Me.txtPercentComplete.Text & "', DrawingFolderAssignDate = '" & Me.txtDrawingFolderAssignDate.Text & "', DesignWIPDate = '" & Me.txtDesignWIPDate.Text & "', Notes = '" & u.FTM(Me.txtNotes.Text) & "', ModelTemplateDate = '" & Me.txtModelTemplateDate.Text & "', Drafter = '" & Me.cboDrafter.Text & "', DrafterComplete = '" & Me.cboDrafterComplete.Text & "', Engineer = '" & Me.cboEngineer.Text & "', EngineerComplete = '" & Me.cboEngineerComplete.Text & "', SrEngineer = '" & Me.cboSrEngineer.Text & "', SrEngineerComplete = '" & Me.cboSrEngineerComplete.Text & "', Releaser = '" & Me.cboReleaser.Text & "', ReleaserCompelte = '" & Me.cboReleaserComplete.Text & "', Flammability = '" & Me.cboFlammability.Text & "', FlammabilityComplete = '" & Me.cboFlammabilityComplete.Text & "', Stress = '" & Me.cboStress.Text & "', StressComplete = '" & Me.cboStressComplete.Text & "', DrafterPlannedCompleteDate = '" & Me.cboDrafterPlannedCompleteDate.Text & "', EngineerPlannedCompleteDate = '" & Me.cboEngineerPlannedCompleteDate.Text & "', SrEngineerPlannedCompleteDate = '" & Me.cboSrEngineerPlannedCompleteDate.Text & "', FlammabilityPlannedCompleteDate = '" & Me.cboFlammabilityPlannedCompleteDate.Text & "', StressPlannedCompleteDate = '" & Me.cboStressPlannedCompleteDate.Text & "', ReleaserPlannedCompleteDate = '" & Me.cboReleaserPlannedCompleteDate.Text & "', Avionics = '" & Me.cboAvionics.Text & "', AvionicsComplete = '" & Me.cboAvionicsComplete.Text & "', AvionicsPlannedComplete = '" & Me.cboAvionicsPlannedComplete.Text & "', Mechanical = '" & Me.cboMechanical.Text & "', MechanicalComplete = '" & Me.cboMechanicalComplete.Text & "', DrawingTitle = '" & Me.txtDrawingTitle.Text & "', WONumber = '" & u.FTM(Me.txtWONumber.Text) & "' WHERE RecordID = '" & Val(Me.txtRecordID.Text) & "'")
            MsgBox("Record Updated.")
            Dim frmGridLookup As New frmGridLookUp

        Else
            'Nothing
        End If
    End Function



    ''Private Sub cboDrafterComplete_Click(sender As Object, e As EventArgs) Handles cboDrafterComplete.Click
    ''	CalField = "cboDrafterComplete"
    ''	Me.CalendarControl1.Visible = True
    ''End Sub

    ''Private Sub CalendarControl1_DateTimeChanged(sender As Object, e As EventArgs) Handles CalendarControl1.DateTimeChanged
    ''	If CalField = "cboDrafterComplete" Then
    ''		cboDrafterComplete.Text = CalendarControl1.DateTime
    ''		CalendarControl1.Visible = False
    ''	End If
    ''End Sub
End Class