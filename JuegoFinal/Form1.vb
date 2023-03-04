Imports System.Text

Public Class Form1


#Region "variables"

    Dim enemies(10) As Image
    Dim character() As String
    Dim coins As Integer
    Dim fuerza As Integer
    Dim agilidad As Integer
    Dim Destreza As Integer
    Dim Def_fisica As Integer
    Dim Def_Magica As Integer
    Dim randObj As New System.Random()
    Dim randobj2 As New System.Random()
    Dim arrList As New ArrayList()
    Dim NombreImagen1 As String
    Dim PictureImagen1 As PictureBox
    Dim sangre As Integer = 0
    Dim magia As Integer = 0
    Dim hit As String = 0
    Dim hit2 As String = 0
    Dim nombre2 As String


#End Region


#Region "Inicio"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBox = False
        hp2.Enabled = False
        mp2.Enabled = False
        PictureBox2.Enabled = False
        GroupBox1.Enabled = False
        GroupBox3.Enabled = False
        PictureBox2.Visible = False
        num_sang.Visible = False
        num_mp.Visible = False
        hp2.Visible = False
        mp2.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        nomb2.Visible = False
        MsgBox("Ve al menu y crea un personaje nuevo")
    End Sub
    Public Sub activar()
        GroupBox3.Enabled = True
    End Sub
    Public Sub Nombre_Caracteres(ByVal texto)
        nomb1.Text = texto
    End Sub
#End Region


#Region "Enemigos"
    Private Sub llamarEnemigos()
        ColocarImagen(PictureBox2)
        GroupBox1.Enabled = True
    End Sub
    Private Sub ColocarImagen(ByVal CajaImagen As PictureBox)
        Dim imgPictures(14) As Image
        Dim i As String
        i = randObj.Next(0, 16)
        CajaImagen.Image = My.Resources.ResourceManager.GetObject(i)
        Nombre_Enemigo(i)
    End Sub
    Private Sub Nombre_Enemigo(ByVal i)
        Select Case i
            Case 0 : nomb2.Text = "Lava Monster"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 50
                mp2.Minimum = 0
                mp2.Maximum = 10
                hp2.Value = 50
                mp2.Value = 10
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 1 : nomb2.Text = "Bone Horned Wolf"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 60
                mp2.Minimum = 0
                mp2.Maximum = 30
                hp2.Value = 60
                mp2.Value = 30
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 2 : nomb2.Text = "Diabolic Warrior"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 100
                mp2.Minimum = 0
                mp2.Maximum = 40
                hp2.Value = 100
                mp2.Value = 40
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 3 : nomb2.Text = "Headless Ghost"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 80
                mp2.Minimum = 0
                mp2.Maximum = 100
                hp2.Value = 80
                mp2.Value = 100
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 4 : nomb2.Text = "Axer Vermillion"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 180
                mp2.Minimum = 0
                mp2.Maximum = 50
                hp2.Value = 180
                mp2.Value = 50
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 5 : nomb2.Text = "Green Sea Bugg"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 70
                mp2.Minimum = 0
                mp2.Maximum = 20
                hp2.Value = 70
                mp2.Value = 20
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 6 : nomb2.Text = "Demon Fairy"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 120
                mp2.Minimum = 0
                mp2.Maximum = 110
                hp2.Value = 120
                mp2.Value = 110
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 7 : nomb2.Text = "Dark Guardian"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 190
                mp2.Minimum = 0
                mp2.Maximum = 90
                hp2.Value = 190
                mp2.Value = 90
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 8 : nomb2.Text = "Malevolent Bird"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 160
                mp2.Minimum = 0
                mp2.Maximum = 190
                hp2.Value = 160
                mp2.Value = 190
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 9 : nomb2.Text = "Dark Scorpion King"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 200
                mp2.Minimum = 0
                mp2.Maximum = 120
                hp2.Value = 200
                mp2.Value = 120
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 10 : nomb2.Text = "Emeral Mole"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 230
                mp2.Minimum = 0
                mp2.Maximum = 110
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                hp2.Value = 230
                mp2.Value = 110
                NombreImagen1 = i
            Case 11 : nomb2.Text = "Hellfire Skeleton"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 270
                mp2.Minimum = 0
                mp2.Maximum = 180
                hp2.Value = 270
                mp2.Value = 180
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 12 : nomb2.Text = "Underword Taurus"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 300
                mp2.Minimum = 0
                mp2.Maximum = 200
                hp2.Value = 300
                mp2.Value = 200
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 13 : nomb2.Text = "Infernal Flame"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 230
                mp2.Minimum = 0
                mp2.Maximum = 300
                hp2.Value = 230
                mp2.Value = 300
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 14 : nomb2.Text = "Thunderston"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 310
                mp2.Minimum = 0
                mp2.Maximum = 280
                hp2.Value = 310
                mp2.Value = 280
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case 15 : nomb2.Text = "Werewolf Underworld"
                nombre2 = nomb2.Text
                hp2.Minimum = 0
                hp2.Maximum = 330
                mp2.Minimum = 0
                mp2.Maximum = 240
                hp2.Value = 330
                mp2.Value = 240
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                NombreImagen1 = i
            Case Else : nomb2.Text = "No existe Enemigo"
        End Select
    End Sub
#End Region


#Region "Personajes"

    Public Sub imagen(ByVal k)
        Dim personajes(3) As Image
        Select Case (k)

            Case 1
                PictureBox1.Image = My.Resources.ResourceManager.GetObject(16)
                hp1.Minimum = 0
                hp1.Maximum = 500
                mp1.Minimum = 0
                mp1.Maximum = 200
                hp1.Value = 500
                mp1.Value = 200
                sangre = hp1.Value
                magia = mp1.Value
                num_sang1.Text = hp1.Value
                num_mp1.Text = mp1.Value
            Case 2
                PictureBox1.Image = My.Resources.ResourceManager.GetObject(17)
                hp1.Minimum = 0
                hp1.Maximum = 600
                mp1.Minimum = 0
                mp1.Maximum = 500
                hp1.Value = 600
                mp1.Value = 500
                sangre = hp1.Value
                magia = mp1.Value
                num_sang1.Text = hp1.Value
                num_mp1.Text = mp1.Value
            Case 3
                PictureBox1.Image = My.Resources.ResourceManager.GetObject(18)
                hp1.Minimum = 0
                hp1.Maximum = 500
                mp1.Minimum = 0
                mp1.Maximum = 200
                hp1.Value = 500
                mp1.Value = 200
                sangre = hp1.Value
                magia = mp1.Value
                num_sang1.Text = hp1.Value
                num_mp1.Text = mp1.Value
            Case 4
                hp1.Minimum = 0
                hp1.Maximum = 600
                mp1.Minimum = 0
                mp1.Maximum = 500
                hp1.Value = 600
                mp1.Value = 500
                sangre = hp1.Value
                magia = mp1.Value
                num_sang1.Text = hp1.Value
                num_mp1.Text = mp1.Value
                PictureBox1.Image = My.Resources.ResourceManager.GetObject(19)
        End Select

    End Sub


#End Region


#Region "Menu"
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim save As New SaveFileDialog
        Dim myStreamWriter As System.IO.StreamWriter
        save.Filter = "Agudmape Files(*.Agudmape)|*.Agudmape||Todos los archivos"
        save.CheckPathExists = True
        save.Title = "Save File"
        save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(save.FileName)
            myStreamWriter.Write(nomb2.Text)
            myStreamWriter.Flush()
        Catch ex As Exception
        End Try
        Close()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Form2.Show()
    End Sub
    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Form3.Show()
    End Sub
    Private Sub IntruccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntruccionesToolStripMenuItem.Click
        MsgBox("Al crear un caracter personalizado, podras batallar con mas de 9 diferentes monstruos, ¡CUIDADO!, porque solo puedes curarte una ves por turno.")
    End Sub
    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim open As New OpenFileDialog
        Dim myStreamreader As System.IO.StreamReader
        Dim i As Integer
        Dim arregloLectura() As String
        Dim abierto As String
        open.Filter = "Agudmape Files(*.Agudmape)|*.Agudmape||Todos los archivos"
        open.CheckFileExists = True
        open.Title = "Openfile"
        open.ShowDialog(Me)
        Try
            open.OpenFile()
            myStreamreader = System.IO.File.OpenText(open.FileName)
            abierto = myStreamreader.ReadToEnd

            arregloLectura = abierto.Split(",") 'separo los valores, la coma es el separador establecido al guardar

            'aqui llevo cada posicion del vector a su respectivo campo, cuando agreguen mas datos en el guardado deben tener en cuenta las posiciones al guardar.
            nomb1.Text = arregloLectura(0)
            hp1.Value = Convert.ToInt32(arregloLectura(1))
            mp1.Value = Convert.ToInt32(arregloLectura(2))

            GroupBox3.Enabled = True
            hp1.Enabled = True
            mp1.Enabled = True
            Label3.Text = "HP = " + arregloLectura(1)
            Label4.Text = "MP = " + arregloLectura(2)

        Catch ex As Exception
        End Try
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim save As New SaveFileDialog
        Dim myStreamWriter As System.IO.StreamWriter
        'Dim myStreamWriter2 As System.IO.StreamWriter
        'Dim myStreamWriter3 As System.IO.StreamWriter
        'Dim myStreamWriter4 As System.IO.StreamWriter

        Dim a_guardar As New StringBuilder() 'imports System.Text

        save.Filter = "Agudmape Files(*.Agudmape)|*.Agudmape||Todos los archivos"
        save.CheckPathExists = True
        save.Title = "Save File"
        save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(save.FileName)
            'myStreamWriter.Write(nomb1.Text)
            'myStreamWriter.Flush()
            'myStreamWriter2 = System.IO.File.AppendText(save.FileName)
            'myStreamWriter.Write(PictureBox1.Image)
            'myStreamWriter.Flush()
            'myStreamWriter3 = System.IO.File.AppendText(save.FileName)
            'myStreamWriter.Write(num_sang1.Text)
            'myStreamWriter.Flush()
            'myStreamWriter4 = System.IO.File.AppendText(save.FileName)
            'myStreamWriter.Write(num_mp1.Text)
            'myStreamWriter.Flush()

            a_guardar.Append(nomb1.Text + ",")
            a_guardar.Append(num_sang1.Text + ",")
            a_guardar.Append(num_mp1.Text)
            myStreamWriter.Write(a_guardar)
            myStreamWriter.Flush()


        Catch ex As Exception
        End Try
    End Sub
    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
#End Region


#Region "Botones"
    Private Sub Battle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Battle.Click
        llamarEnemigos()
        eventos1.Text = "Batalla contra " & nombre2
        GroupBox3.Enabled = False
        GroupBox1.Enabled = True
        attack.Enabled = True
        potts.Enabled = True
        MagicAtt.Enabled = True
        def.Enabled = True
        PictureBox2.Visible = True
        num_sang.Visible = True
        num_mp.Visible = True
        hp2.Visible = True
        mp2.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        nomb2.Visible = True
    End Sub


    Private Sub Attack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles attack.Click
        MagicAtt.Enabled = False
        potts.Enabled = False
        def.Enabled = False
        If hp2.Value = 0 Then
            MessageBox.Show("Enemigo eliminado")
            PictureBox2.Image = Nothing
            GroupBox3.Enabled = True
            hp2.Value = 0
            mp2.Value = 0
            nomb2.Text = Nothing
            GroupBox1.Enabled = False
            num_sang.Text = Nothing
            num_mp.Text = Nothing
            PictureBox2.Visible = False
            num_sang.Visible = False
            num_mp.Visible = False
            hp2.Visible = False
            mp2.Visible = False
            Label6.Visible = False
            Label7.Visible = False
        Else
            MagicAtt.Enabled = True
            potts.Enabled = True
            def.Enabled = True
            ataquealeatorio(NombreImagen1)
            randomhit(NombreImagen1)

            If hp1.Value = 0 Then
                MsgBox("Has perdido")
                GroupBox3.Enabled = True
                PictureBox2.Visible = False
                num_sang.Visible = False
                num_mp.Visible = False
                hp2.Visible = False
                mp2.Visible = False
                Label6.Visible = False
                Label7.Visible = False
                GroupBox1.Enabled = False
                hp1.Value = sangre
                mp1.Value = magia
                num_sang1.Text = hp1.Value
                num_mp1.Text = mp1.Value
            End If
        End If
    End Sub


    Private Sub MagicAtt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagicAtt.Click
        attack.Enabled = False
        potts.Enabled = False
        def.Enabled = False
        If hp2.Value = 0 Then
            MessageBox.Show("El Enemigo Ha Sido Eliminado")
            PictureBox2.Image = Nothing
            GroupBox3.Enabled = True
            hp2.Value = 0
            mp2.Value = 0
            nomb2.Text = Nothing
            GroupBox1.Enabled = False
            num_sang.Text = Nothing
            num_mp.Text = Nothing
            PictureBox2.Visible = False
            num_sang.Visible = False
            num_mp.Visible = False
            hp2.Visible = False
            mp2.Visible = False
            Label6.Visible = False
            Label7.Visible = False
        Else
            ataquealeatorio(NombreImagen1)
            magichit(NombreImagen1)
            attack.Enabled = True
            potts.Enabled = True
            def.Enabled = True
            If hp1.Value = 0 Then
                MsgBox("Has perdido")
                GroupBox3.Enabled = True
                PictureBox2.Visible = False
                num_sang.Visible = False
                num_mp.Visible = False
                hp2.Visible = False
                mp2.Visible = False
                Label6.Visible = False
                Label7.Visible = False
                GroupBox1.Enabled = False
                hp1.Value = sangre
                mp1.Value = magia
                num_sang1.Text = hp1.Value
                num_mp1.Text = mp1.Value
            End If
            If mp1.Value <= 0 Then
                MsgBox("No tienes energia magica")
            End If
        End If
    End Sub


    Private Sub potts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles potts.Click
        mp_pot.Visible = True
        hp_pot.Visible = True
        potts.Enabled = False
    End Sub

#End Region


#Region "Pocion"


    Private Sub picturebox3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mp_pot.Click
        If mp1.Value = magia Then
            MsgBox("Tienes toda la energia magica")
        End If

        If mp1.Value + 50 >= magia Then
            mp1.Value = magia
        Else
            mp1.Value = mp1.Value + 50
        End If
        num_mp1.Text = mp1.Value
        hp_pot.Visible = False
        mp_pot.Visible = False

    End Sub
    Private Sub picturebox4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hp_pot.Click
        If hp1.Value = sangre Then
            MsgBox("Tienes toda la Sangre")
        End If
        If hp1.Value + 100 >= sangre Then
            hp1.Value = sangre
        Else
            hp1.Value = hp1.Value + 100

        End If
        num_sang1.Text = hp1.Value
        hp_pot.Visible = False
        mp_pot.Visible = False
    End Sub

#End Region


#Region "Ataque Aleatorio"

    Private Sub ataquealeatorio(ByVal i)
        Select Case i
            Case 0
                hit = randobj2.Next(0, 5)
                hit2 = randobj2.Next(8, 18)
            Case 1
                hit = randobj2.Next(0, 5)
                hit2 = randobj2.Next(8, 18)
            Case 2
                hit = randobj2.Next(0, 5)
                hit2 = randobj2.Next(8, 18)
            Case 3
                hit = randobj2.Next(0, 7)
                hit2 = randobj2.Next(8, 18)
            Case 4
                hit = randobj2.Next(0, 7)
                hit2 = randobj2.Next(8, 18)
            Case 5
                hit = randobj2.Next(0, 11)
                hit2 = randobj2.Next(8, 17)
            Case 6
                hit = randobj2.Next(2, 11)
                hit2 = randobj2.Next(8, 16)
            Case 7
                hit = randobj2.Next(5, 16)
                hit2 = randobj2.Next(8, 16)
            Case 8
                hit = randobj2.Next(5, 17)
                hit2 = randobj2.Next(8, 15)
            Case 9
                hit = randobj2.Next(5, 17)
                hit2 = randobj2.Next(8, 15)
            Case 10
                hit = randobj2.Next(7, 20)
                hit2 = randobj2.Next(6, 14)
            Case 11
                hit = randobj2.Next(8, 27)
                hit2 = randobj2.Next(7, 15)
            Case 12
                hit = randobj2.Next(9, 28)
                hit2 = randobj2.Next(9, 12)
            Case 13
                hit = randobj2.Next(10, 30)
                hit2 = randobj2.Next(9, 12)
            Case 14
                hit = randobj2.Next(11, 35)
                hit2 = randobj2.Next(8, 12)
            Case 15
                hit = randobj2.Next(15, 40)
                hit2 = randobj2.Next(7, 13)
            Case Else : Close()
        End Select
    End Sub


    Private Sub randomhit(ByVal i)

        If hp2.Value > 0 Then
            Try
                hp2.Value = hp2.Value - hit2
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
                eventos1.Text = "ha recibido un golpe de " & hit2 & " de sangre"
            Catch
                hp2.Value = 0
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
            End Try
        End If
        If hp1.Value > 0 Then
            Try
                hp1.Value = hp1.Value - hit
                num_sang1.Text = hp1.Value
                eventos1.Text = "has perdido " & hit & " de sangre"
            Catch
                hp1.Value = 0
                num_sang1.Text = hp1.Value
            End Try
        End If
    End Sub
    Private Sub magichit(ByVal i)
        eventos1.Refresh()
        If mp1.Value > 0 Then
            Try
                mp1.Value = mp1.Value - 10
                hp2.Value = hp2.Value - hit2
                num_sang.Text = hp2.Value
                num_mp1.Text = mp1.Value
                eventos1.Text = "ha recibido un golpe de " & hit2 & " de sangre"
            Catch
                mp1.Value = 0
                num_sang.Text = hp2.Value
                num_mp.Text = mp2.Value
            End Try
        End If
        If mp2.Value > 0 Then
            Try
                hp1.Value = hp1.Value - hit
                mp2.Value = mp2.Value - 10
                num_mp.Text = mp2.Value
                eventos1.Text = "has perdido " & hit & " de sangre"
            Catch
                mp1.Value = 0
                num_mp1.Text = mp2.Value
            End Try
        End If
    End Sub
#End Region



End Class
