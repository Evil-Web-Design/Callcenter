Imports System
Imports System.Data
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class Frm_MySQL

  ' Copyright (C) 2004-2005 MySQL AB
  '
  ' This program is free software; you can redistribute it and/or modify
  ' it under the terms of the GNU General Public License version 2 as published by
  ' the Free Software Foundation
  '
  ' There are special exceptions to the terms and conditions of the GPL 
  ' as it is applied to this software. View the full text of the 
  ' exception in file EXCEPTIONS in the directory of this software 
  ' distribution.
  '
  ' This program is distributed in the hope that it will be useful,
  ' but WITHOUT ANY WARRANTY; without even the implied warranty of
  ' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  ' GNU General Public License for more details.
  '
  ' You should have received a copy of the GNU General Public License
  ' along with this program; if not, write to the Free Software
  ' Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA 

  Inherits System.Windows.Forms.Form

  Dim conn As MySqlConnection
  Dim data As DataTable
  Dim da As MySqlDataAdapter
  Dim cb As MySqlCommandBuilder

  Private Sub connectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connectBtn.Click
    If Not conn Is Nothing Then conn.Close()

    Dim connStr As String
    connStr = String.Format("server={0}; Port={1}; user id={2}; password={3}; pooling=false; Convert Zero Datetime=true;", _
        server.Text, Port.Text, userid.Text, password.Text)

    Try
      conn = New MySqlConnection(connStr)
      conn.Open()

      GetDatabases()
    Catch ex As MySqlException
      MessageBox.Show("Error connecting to the server: " + ex.Message)
    End Try
  End Sub

  Private Sub GetDatabases()
    Dim reader As MySqlDataReader
    reader = Nothing

    Dim cmd As New MySqlCommand("SHOW DATABASES", conn)
    Try
      reader = cmd.ExecuteReader()
      databaseList.Items.Clear()

      While (reader.Read())
        databaseList.Items.Add(reader.GetString(0))
      End While
      databaseList.Enabled = True
      tables.Enabled = True
      updateBtn.Enabled = True
      dataGrid.Enabled = True
    Catch ex As MySqlException
      MessageBox.Show("Failed to populate database list: " + ex.Message)
    Finally
      If Not reader Is Nothing Then reader.Close()
    End Try

  End Sub

  Private Sub databaseList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles databaseList.SelectedIndexChanged
    Dim reader As MySqlDataReader
    reader = Nothing
    conn.ChangeDatabase(databaseList.SelectedItem.ToString())

    Dim cmd As New MySqlCommand("SHOW TABLES", conn)

    Try
      reader = cmd.ExecuteReader()
      tables.Items.Clear()

      While (reader.Read())
        tables.Items.Add(reader.GetString(0))
      End While

    Catch ex As MySqlException
      MessageBox.Show("Failed to populate table list: " + ex.Message)
    Finally
      If Not reader Is Nothing Then reader.Close()
    End Try
  End Sub

  Private Sub tables_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tables.SelectedIndexChanged
    data = New DataTable

    da = New MySqlDataAdapter("SELECT * FROM " + tables.SelectedItem.ToString(), conn)
    cb = New MySqlCommandBuilder(da)

    da.Fill(data)

    dataGrid.DataSource = data
  End Sub

  Private Sub updateBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles updateBtn.Click
    Dim changes As DataTable = data.GetChanges()
    da.Update(changes)
    data.AcceptChanges()
  End Sub

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub
End Class
