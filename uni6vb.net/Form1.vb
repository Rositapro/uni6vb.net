Imports System.IO

Public Class Form1
    Public Sub New()
        InitializeComponent()
        ConfigureListView()
        AttachKeyPressEvents()
    End Sub

    Private Sub ConfigureListView()
        lsvContent.View = View.Details
        lsvContent.Columns.Add("Name", 100)
        lsvContent.Columns.Add("Spanish", 100)
        lsvContent.Columns.Add("Mathematics", 100)
        lsvContent.Columns.Add("English", 100)
        lsvContent.Columns.Add("Science", 50)
        lsvContent.Columns.Add("Physics", 100)
        lsvContent.Columns.Add("Avarage", 100)
    End Sub

    Private Sub AttachKeyPressEvents()
        AddHandler txtName.KeyPress, AddressOf TextBox_KeyPress
        AddHandler txtSpanish.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler txtMathematics.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler txtEnglish.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler txtScience.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler txtPhysics.KeyPress, AddressOf NumericTextBox_KeyPress
    End Sub

    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NumericTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim textBox As TextBox = TryCast(sender, TextBox)

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        Else
            e.Handled = False

            If Char.IsDigit(e.KeyChar) Then
                Dim currentText As String = textBox.Text.Insert(textBox.SelectionStart, e.KeyChar.ToString())
                Dim value As Double

                If Double.TryParse(currentText, value) Then
                    If value > 10 Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ClearTextBoxes()
        txtName.Clear()
        txtSpanish.Clear()
        txtMathematics.Clear()
        txtEnglish.Clear()
        txtScience.Clear()
        txtPhysics.Clear()
        txtAvarage.Clear()
    End Sub

    Private Sub ibtnSave_Click(sender As Object, e As EventArgs) Handles ibtnSave.Click
        Dim datos(6) As String
        datos(0) = txtName.Text
        datos(1) = txtSpanish.Text
        datos(2) = txtMathematics.Text
        datos(3) = txtEnglish.Text
        datos(4) = txtScience.Text
        datos(5) = txtPhysics.Text
        datos(6) = txtAvarage.Text

        Dim item As New ListViewItem(datos(0))

        For i As Integer = 1 To datos.Length - 1
            item.SubItems.Add(datos(i))
        Next

        lsvContent.Items.Add(item)
        ClearTextBoxes()
    End Sub

    Private Sub ibtnCalculateAvarage_Click(sender As Object, e As EventArgs) Handles ibtnCalculateAvarage.Click
        Try
            Dim spanish As Double = Double.Parse(txtSpanish.Text)
            Dim mathematics As Double = Double.Parse(txtMathematics.Text)
            Dim english As Double = Double.Parse(txtEnglish.Text)
            Dim science As Double = Double.Parse(txtScience.Text)
            Dim physics As Double = Double.Parse(txtPhysics.Text)

            Dim average As Double = (spanish + mathematics + english + science + physics) / 5
            txtAvarage.Text = average.ToString("F2")
        Catch ex As FormatException
            MessageBox.Show("Please enter valid ratings in all fields.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ibtnSaveTxt_Click(sender As Object, e As EventArgs) Handles ibtnSaveTxt.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivo de Texto|*.txt"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

            Using writer As New StreamWriter(filePath)
                For Each column As ColumnHeader In lsvContent.Columns
                    writer.Write(column.Text)
                    writer.Write(", ")
                Next
                writer.WriteLine()

                For Each item As ListViewItem In lsvContent.Items
                    For i As Integer = 0 To item.SubItems.Count - 1
                        writer.Write(item.SubItems(i).Text)
                        If i < item.SubItems.Count - 1 Then
                            writer.Write(", ")
                        End If
                    Next
                    writer.WriteLine()
                Next
            End Using

            MessageBox.Show("Data successfully saved to TXT file.", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Process.Start(New ProcessStartInfo() With {
                .FileName = filePath,
                .UseShellExecute = True
            })
        End If
    End Sub
End Class
