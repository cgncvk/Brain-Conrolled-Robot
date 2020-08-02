'Yazılım Geliştirme By ROBİMEK - 2015
'Yazılım Lisans By Robimek
'www.robimek.com
Imports System.IO
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports




Public Class Form2
    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Shared _continue As Boolean
    Shared _serialPort As SerialPort

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.A) Then
            Button1.PerformClick()
            Button1.BackColor = Color.Red
            TextBox1.Text = "SOLA GİDİYOR"

        Else
            Button1.BackColor = Color.Yellow


        End If
        If (e.KeyCode = Keys.D) Then
            Button3.PerformClick()
            Button3.BackColor = Color.Red
            TextBox1.Text = "SAĞA GİDİYOR"
        Else
            Button3.BackColor = Color.Yellow


        End If
        If (e.KeyCode = Keys.W) Then
            Button2.PerformClick()
            Button2.BackColor = Color.Red
            TextBox1.Text = "İLERİ GİDİYOR"
        Else
            Button2.BackColor = Color.Yellow
        End If
        If (e.KeyCode = Keys.S) Then
            Button4.PerformClick()
            Button4.BackColor = Color.Red
            TextBox1.Text = "GERİ GİDİYOR"


        Else
            Button4.BackColor = Color.Yellow
        End If
        If (e.KeyCode = Keys.F) Then
            Button5.PerformClick()
            Button5.BackColor = Color.Green
            Button6.BackColor = Color.White
        End If
        If (e.KeyCode = Keys.G) Then
            Button6.PerformClick()
            Button6.BackColor = Color.Red
            Button5.BackColor = Color.White
        End If
        If (e.KeyCode = Keys.Q) Then
            Button7.PerformClick()
            Button7.BackColor = Color.Red
            TextBox1.Text = "SOLA İLERİ GİDİYOR"
        Else
            Button7.BackColor = Color.Teal
        End If
        If (e.KeyCode = Keys.E) Then
            Button8.PerformClick()
            Button8.BackColor = Color.Red
            TextBox1.Text = "SAĞA İLERİ GİDİYOR"
        Else
            Button8.BackColor = Color.Teal
        End If
        If (e.KeyCode = Keys.X) Then
            Button9.PerformClick()
            Button9.BackColor = Color.Red
            TextBox1.Text = "SOLA GERİ GİDİYOR"
        Else
            Button9.BackColor = Color.Teal
        End If
        If (e.KeyCode = Keys.Z) Then
            Button10.PerformClick()
            Button10.BackColor = Color.Red
            TextBox1.Text = "SOLA GERİ GİDİYOR"
        Else
            Button10.BackColor = Color.Teal
        End If
        If (e.KeyCode = Keys.Space) Then
            Button11.PerformClick()
            Button11.BackColor = Color.Red
            TextBox1.Text = "DURUYOR"
        Else
            Button11.BackColor = Color.Red
        End If


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        SerialPort1.Write("2")

   
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        SerialPort1.Write("3")

        
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        SerialPort1.Write("4")

       
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        SerialPort1.Write("1")

    End Sub



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox2.Items.Add(9600)
        ComboBox2.Items.Add(19200)
        ComboBox2.Items.Add(38400)
        ComboBox2.Items.Add(57600)
        ComboBox2.Items.Add(115200)
        For i = 0 To UBound(myPort)
            ComboBox1.Items.Add(myPort(i))
        Next
        ComboBox1.Text = ComboBox1.Items.Item(0)
        ComboBox2.Text = ComboBox2.Items.Item(0)
        Button12.Enabled = False
       
    End Sub
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.BaudRate = ComboBox2.Text
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.Open()
        Button13.Enabled = False
        Button12.Enabled = True
    End Sub
    'Connect Button Code Ends Here ….
    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        SerialPort1.Close()
        Button13.Enabled = True
        Button12.Enabled = False
    End Sub
    'Disconnect Button Code Starts Here ….
    

    Private Sub cmbPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = ComboBox1.Text
        Else
            MsgBox("BAĞLANTIYI, KAPALIYKEN DEĞİŞTİRİNİZ", vbCritical)
        End If
    End Sub
    'Com Port Change Warning Code Ends Here ….

    'Baud Rate Change Warning Code Starts Here ….
    Private Sub cmbBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.BaudRate = ComboBox2.Text
        Else
            MsgBox("BAĞLANTIYI, KAPALIYKEN DEĞİŞTİRİNİZ", vbCritical)
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        SerialPort1.Write("9")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        SerialPort1.Write("8")

       
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        SerialPort1.Write("5")

       
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        SerialPort1.Write("6")

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click


        SerialPort1.Write("7")

       
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        SerialPort1.Write("0")

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click


        SerialPort1.Write("10")

    End Sub


   
End Class
