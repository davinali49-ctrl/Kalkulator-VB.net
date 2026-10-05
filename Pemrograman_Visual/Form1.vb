Public Class Form1
    Dim angkaPertama As Double
    Dim angkaKedua As Double
    Dim operasi As String
    Dim isOperasiKlik As Boolean = False

    Private Sub TombolAngka_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim b As Button = CType(sender, Button)

        If isOperasiKlik Then
            txtLayar.Text = ""
            isOperasiKlik = False
        End If

        txtLayar.Text = txtLayar.Text & b.Text

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ProsesOperasi("+")
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        ProsesOperasi("-")
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        ProsesOperasi("*")
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        ProsesOperasi("/")
    End Sub

    Private Sub ProsesOperasi(op As String)
        If txtLayar.Text <> "" Then
            angkaPertama = Val(txtLayar.Text)
            operasi = op
            isOperasiKlik = True
        End If
    End Sub

    Private Sub btnSamaDengan_Click(sender As Object, e As EventArgs) Handles btnSamaDengan.Click
        If txtLayar.Text <> "" Then
            angkaKedua = Val(txtLayar.Text)
            Dim hasil As Double = 0

            Select Case operasi
                Case "+"
                    hasil = angkaPertama + angkaKedua
                Case "-"
                    hasil = angkaPertama - angkaKedua
                Case "*"
                    hasil = angkaPertama * angkaKedua
                Case "/"
                    If angkaKedua <> 0 Then
                        hasil = angkaPertama / angkaKedua
                    Else
                        MessageBox.Show("Tidak bisa membagi dengan angka nol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
            End Select

            txtLayar.Text = hasil.ToString()
            isOperasiKlik = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLayar.Clear()
        angkaPertama = 0
        angkaKedua = 0
        operasi = ""
        isOperasiKlik = False
    End Sub

End Class