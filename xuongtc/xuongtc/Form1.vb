Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Form1
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=.;Initial Catalog=xuongtcp;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refresh As SqlDataAdapter = New SqlDataAdapter("select MAKH, TENKH, SOLUONG, HOADON, SOLUONG * HOADON as THANHTIEN  from KHACHHANG", conn)
        db.Clear()
        refresh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtMAKH.Text = "" Then
            MessageBox.Show("nhap MAKH")
            txtMAKH.Focus()
        ElseIf txtTENKH.Text = "" Then
            MessageBox.Show("nhap TENKH")
            txtTENKH.Focus()
        ElseIf txtSOLUONG.Text = "" Then
            MessageBox.Show("nhap SOLUONG")
            txtSOLUONG.Focus()
        ElseIf txtHOADON.Text = "" Then
            MessageBox.Show("nhap HOADON")
            txtHOADON.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into KHACHHANG values(@MAKH, @TENKH, @SOLUONG, @HOADON)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@TENKH", txtTENKH.Text)
            save.Parameters.AddWithValue("@SOLUONG", txtSOLUONG.Text)
            save.Parameters.AddWithValue("@HOADON", txtHOADON.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Thanh cong")
            LoadData()
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sua" Then
            txtMAKH.ReadOnly = True
            btnSua.Text = "Update"
            txtTENKH.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update KHACHHANG set MAKH=@MAKH, TENKH=@TENKH, SOLUONG=@SOLUONG, HOADON=@HOADON where MAKH=@MAKH"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@TENKH", txtTENKH.Text)
            save.Parameters.AddWithValue("@SOLUONG", txtSOLUONG.Text)
            save.Parameters.AddWithValue("@HOADON", txtHOADON.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Xong")
            txtMAKH.ReadOnly = False
            btnSua.Text = "Sua"
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMAKH.Text = "" Then
            MessageBox.Show("nhap MAKH")
            txtMAKH.Focus()
        Else
            Dim delquery As String = "delete from KHACHHANG where MAKH=@MAKH"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("xoa ko", "xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("OK")
                LoadData()
            End If
        End If
    End Sub

    Private Sub Reset()
        txtMAKH.Text = ""
        txtTENKH.Text = ""
        txtSOLUONG.Text = ""
        txtHOADON.Text = ""
    End Sub
    Private Sub btnNhaplai_Click(sender As Object, e As EventArgs) Handles btnNhaplai.Click
        Reset()
    End Sub
End Class
