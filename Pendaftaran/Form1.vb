Imports MySql.Data.MySqlClient

Public Class Form1

    Sub tampilData()
        'buka koneksi database
        konek()
        da = New MySqlDataAdapter("SELECT * FROM tmahasiswa", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        DGV.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            DGV.Rows.Add(dt.Rows(i).Item(0))
            DGV.Rows(i).Cells(1).Value = dt.Rows(i).Item(1)
            DGV.Rows(i).Cells(2).Value = dt.Rows(i).Item(2)
            DGV.Rows(i).Cells(3).Value = dt.Rows(i).Item(3)
            DGV.Rows(i).Cells(4).Value = dt.Rows(i).Item(4)
        Next
        'tutup koneksi database
        Diskonek()
    End Sub
    Private Sub bkeluar_Click(sender As Object, e As EventArgs) Handles bkeluar.Click
        Me.Close()
    End Sub

    Private Sub bkosongkan_Click(sender As Object, e As EventArgs) Handles bkosongkan.Click
        tnim.Text = ""
        tnama.Text = ""
        rpria.Checked = False
        rwanita.Checked = False
        cprodi.Text = ""
        talamat.Text = ""
        tnim.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'panggil sub tampilkan data
        tampilData()

    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        Dim jekel As String
        If rpria.Checked = True Then
            jekel = "Pria"
        ElseIf rwanita.Checked = True Then
            jekel = "Wanita"
        End If

        'uji jika ketemu = true, maka edit data, selain itu simpan baru
        If ketemu = True Then
            'ubah data
            Try
                konek()
                cmd = New MySqlCommand("UPDATE tmahasiswa SET nama= '" & tnama.Text & "',  jekel= '" & jekel & "', prodi= '" & cprodi.Text & "',  alamat= '" & talamat.Text & "' WHERE nim= '" & tnim.Text & "'", Koneksi)
                cmd.ExecuteNonQuery()
                MsgBox("Ubah Data Sukses!!")
                Diskonek()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            'simpan baru
            Try
                konek()
                cmd = New MySqlCommand("INSERT INTO tmahasiswa (nim,nama,jekel,prodi,alamat) VALUES('" & tnim.Text & "','" & tnama.Text & "', '" & jekel & "', '" & cprodi.Text & "', '" & talamat.Text & "' )", Koneksi)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan Data Sukses!!")
                Diskonek()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        tampilData()
        bkosongkan_Click(sender, e)
    End Sub

    Private Sub tnim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnim.KeyPress
        If e.KeyChar = Chr(13) Then
            konek()
            Dim jekel As String
            cmd = New MySqlCommand("SELECT * FROM tmahasiswa WHERE nim= '" & tnim.Text & "'", Koneksi)
            dr = cmd.ExecuteReader
            If dr.Read Then
                tnim.Text = dr.Item(0)
                tnama.Text = dr.Item(1)
                jekel = dr.Item(2)
                If jekel = "Pria" Then
                    rpria.Checked = True
                Else
                    rwanita.Checked = True
                End If
                cprodi.Text = dr.Item(3)
                talamat.Text = dr.Item(4)
                MsgBox("Data Ditemukan!")
                ketemu = True
            Else
                MsgBox("Maaf,Data tidak ditemukan")
                tnim.Focus()
                ketemu = False
            End If
            Diskonek()
        End If
    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        If ketemu = True Then
            Try
                konek()
                If MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data Ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    cmd = New MySqlCommand("DELETE FROM tmahasiswa WHERE nim='" & tnim.Text & "'", Koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Hapus Data Sukses")
                    tampilData()
                    bkosongkan_Click(sender, e)

                End If

                Diskonek()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    ' Event ketika baris di DataGridView diklik dua kali
    Private Sub DGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellDoubleClick
        ' Cek apakah ada baris yang diklik
        If e.RowIndex >= 0 Then
            ' Ambil nilai dari DataGridView ke dalam variabel form
            Dim row As DataGridViewRow = DGV.Rows(e.RowIndex)

            tnim.Text = row.Cells(0).Value.ToString() ' NIM
            tnama.Text = row.Cells(1).Value.ToString() ' Nama

            ' Atur gender sesuai data
            If row.Cells(2).Value.ToString() = "Pria" Then
                rpria.Checked = True
            ElseIf row.Cells(2).Value.ToString() = "Wanita" Then
                rwanita.Checked = True
            End If

            ' Prodi dan Alamat
            cprodi.Text = row.Cells(3).Value.ToString() ' Prodi
            talamat.Text = row.Cells(4).Value.ToString() ' Alamat
        End If
    End Sub

End Class
