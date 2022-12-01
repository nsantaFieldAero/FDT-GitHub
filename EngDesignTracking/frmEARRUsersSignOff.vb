Public Class frmEARRUsersSignOff

    Dim da As SqlClient.SqlDataAdapter
    Dim ds As New DataSet

    Private Sub frmEARRUsersSignOff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SqlConnection1.ConnectionString = sqlString1

        SqlDataAdapter1.Fill(DsEARRUsersSignOff1.tblUsersCreateEARR)

        PopulateDropDowns()

    End Sub

    Private Sub btnSubstitute_Click(sender As Object, e As EventArgs) Handles btnSubstitute.Click

        RecordIDSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecordID")
        EmailSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Email")
        ProgramSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Program")
        ProgramTwoSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Program2")
        ProgramThreeSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Program3")
        ProgramFourSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Program4")
        TypeSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Type")
        TypeTwoSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Type2")

        PreviousUsernameSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Username")
        PreviousEmailSubEARR = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Email")

        Dim frmEARRSubSignOffUsers As New frmEARRSubSignOffUsers
        frmEARRSubSignOffUsers.Show()

        Me.Close()

    End Sub

    Private Sub btnUpdateGrid_Click(sender As Object, e As EventArgs) Handles btnUpdateGrid.Click

        SqlDataAdapter1.Update(DsEARRUsersSignOff1.tblUsersCreateEARR)

        u.ExecuteSQL(SqlConnection1, "Update tblUsersCreateEARR Set EnterEARR = 1")
        MsgBox("Updated")

        Me.Close()
        frmEARRGrid.SignOffUsersToolStripMenuItem.PerformClick()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'Delete Record Selected
        Dim RecordIDToDelete As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "RecordID")

        u.ExecuteSQL(SqlConnection1, "Delete From tblUsersCreateEARR Where RecordID = '" & RecordIDToDelete & "'")

        Me.Close()
        frmEARRGrid.SignOffUsersToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PopulateDropDowns()

        'Populate Programs dropdown
        RepositoryItemComboBox1.Items.Clear()
        RepositoryItemComboBox2.Items.Clear()
        RepositoryItemComboBox3.Items.Clear()
        RepositoryItemComboBox4.Items.Clear()
        da = New SqlClient.SqlDataAdapter("Select Distinct ProjectName From tblProjects Order by ProjectName", SqlConnection2)
        da.Fill(ds, "Programs")

        Dim i As Integer = 0
        While i <= ds.Tables("Programs").Rows.Count - 1
            RepositoryItemComboBox1.Items.Add(ds.Tables("Programs").Rows(i).Item("ProjectName"))
            RepositoryItemComboBox2.Items.Add(ds.Tables("Programs").Rows(i).Item("ProjectName"))
            RepositoryItemComboBox3.Items.Add(ds.Tables("Programs").Rows(i).Item("ProjectName"))
            RepositoryItemComboBox4.Items.Add(ds.Tables("Programs").Rows(i).Item("ProjectName"))
            i = i + 1
        End While

        ds.Tables("Programs").Clear()
        ds.Tables("Programs").Dispose()

        'Populate Type dropdown
        RepositoryItemComboBox5.Items.Clear()
        RepositoryItemComboBox6.Items.Clear()
        da = New SqlClient.SqlDataAdapter("Select Type From tblType Where RecordID < 3", SqlConnection2)
        da.Fill(ds, "Type")

        Dim a As Integer = 0
        While a <= ds.Tables("Type").Rows.Count - 1
            RepositoryItemComboBox5.Items.Add(ds.Tables("Type").Rows(a).Item("Type"))
            RepositoryItemComboBox6.Items.Add(ds.Tables("Type").Rows(a).Item("Type"))
            a = a + 1
        End While

        ds.Tables("Type").Clear()
        ds.Tables("Type").Dispose()

        'Populate Username dropdown
        RepositoryItemComboBox7.Items.Clear()
        da = New SqlClient.SqlDataAdapter("Select Username From tblUsers Order By Username", SqlConnection1)
        da.Fill(ds, "Username")

        Dim b As Integer = 0
        While b <= ds.Tables("Username").Rows.Count - 1
            RepositoryItemComboBox7.Items.Add(ds.Tables("Username").Rows(b).Item("Username"))
            b = b + 1
        End While

        ds.Tables("Username").Clear()
        ds.Tables("Username").Dispose()

        'Populate Email dropdown
        RepositoryItemComboBox8.Items.Clear()
        da = New SqlClient.SqlDataAdapter("Select Email From tblUsers Order By Email", SqlConnection1)
        da.Fill(ds, "Email")

        Dim c As Integer = 0
        While c <= ds.Tables("Email").Rows.Count - 1
            RepositoryItemComboBox8.Items.Add(ds.Tables("Email").Rows(c).Item("Email"))
            c = c + 1
        End While

        ds.Tables("Email").Clear()
        ds.Tables("Email").Dispose()

    End Sub
End Class