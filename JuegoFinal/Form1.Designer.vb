<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Battle = New System.Windows.Forms.Button()
        Me.shop = New System.Windows.Forms.Button()
        Me.equip = New System.Windows.Forms.Button()
        Me.hp1 = New System.Windows.Forms.ProgressBar()
        Me.nomb1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mp1 = New System.Windows.Forms.ProgressBar()
        Me.hp2 = New System.Windows.Forms.ProgressBar()
        Me.nomb2 = New System.Windows.Forms.Label()
        Me.mp2 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MagicAtt = New System.Windows.Forms.Button()
        Me.potts = New System.Windows.Forms.Button()
        Me.def = New System.Windows.Forms.Button()
        Me.attack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntruccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.num_sang = New System.Windows.Forms.Label()
        Me.num_mp = New System.Windows.Forms.Label()
        Me.num_sang1 = New System.Windows.Forms.Label()
        Me.num_mp1 = New System.Windows.Forms.Label()
        Me.mp_pot = New System.Windows.Forms.PictureBox()
        Me.hp_pot = New System.Windows.Forms.PictureBox()
        Me.eventos1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mp_pot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hp_pot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Battle
        '
        Me.Battle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Battle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Battle.Location = New System.Drawing.Point(12, 20)
        Me.Battle.Name = "Battle"
        Me.Battle.Size = New System.Drawing.Size(75, 23)
        Me.Battle.TabIndex = 0
        Me.Battle.Text = "Batallar"
        Me.Battle.UseVisualStyleBackColor = True
        '
        'shop
        '
        Me.shop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shop.Location = New System.Drawing.Point(12, 49)
        Me.shop.Name = "shop"
        Me.shop.Size = New System.Drawing.Size(75, 23)
        Me.shop.TabIndex = 1
        Me.shop.Text = "Tienda"
        Me.shop.UseVisualStyleBackColor = True
        '
        'equip
        '
        Me.equip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equip.Location = New System.Drawing.Point(12, 78)
        Me.equip.Name = "equip"
        Me.equip.Size = New System.Drawing.Size(75, 23)
        Me.equip.TabIndex = 2
        Me.equip.Text = "Equipos"
        Me.equip.UseVisualStyleBackColor = True
        '
        'hp1
        '
        Me.hp1.Location = New System.Drawing.Point(120, 120)
        Me.hp1.Name = "hp1"
        Me.hp1.Size = New System.Drawing.Size(206, 23)
        Me.hp1.TabIndex = 6
        '
        'nomb1
        '
        Me.nomb1.AutoSize = True
        Me.nomb1.BackColor = System.Drawing.Color.Transparent
        Me.nomb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nomb1.Location = New System.Drawing.Point(145, 44)
        Me.nomb1.Name = "nomb1"
        Me.nomb1.Size = New System.Drawing.Size(57, 16)
        Me.nomb1.TabIndex = 7
        Me.nomb1.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(332, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "HP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(332, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "MP"
        '
        'mp1
        '
        Me.mp1.Location = New System.Drawing.Point(120, 149)
        Me.mp1.Name = "mp1"
        Me.mp1.Size = New System.Drawing.Size(206, 23)
        Me.mp1.TabIndex = 11
        '
        'hp2
        '
        Me.hp2.Location = New System.Drawing.Point(191, 333)
        Me.hp2.Name = "hp2"
        Me.hp2.Size = New System.Drawing.Size(206, 23)
        Me.hp2.TabIndex = 1
        '
        'nomb2
        '
        Me.nomb2.AutoSize = True
        Me.nomb2.BackColor = System.Drawing.Color.Transparent
        Me.nomb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nomb2.Location = New System.Drawing.Point(362, 251)
        Me.nomb2.Name = "nomb2"
        Me.nomb2.Size = New System.Drawing.Size(57, 16)
        Me.nomb2.TabIndex = 13
        Me.nomb2.Text = "Nombre"
        '
        'mp2
        '
        Me.mp2.Location = New System.Drawing.Point(191, 362)
        Me.mp2.Name = "mp2"
        Me.mp2.Size = New System.Drawing.Size(206, 23)
        Me.mp2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(163, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "HP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(163, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "MP"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.MagicAtt)
        Me.GroupBox1.Controls.Add(Me.potts)
        Me.GroupBox1.Controls.Add(Me.def)
        Me.GroupBox1.Controls.Add(Me.attack)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(405, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(91, 142)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lucha"
        '
        'MagicAtt
        '
        Me.MagicAtt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MagicAtt.Location = New System.Drawing.Point(6, 78)
        Me.MagicAtt.Name = "MagicAtt"
        Me.MagicAtt.Size = New System.Drawing.Size(75, 23)
        Me.MagicAtt.TabIndex = 4
        Me.MagicAtt.Text = "Magia"
        Me.MagicAtt.UseVisualStyleBackColor = True
        '
        'potts
        '
        Me.potts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.potts.Location = New System.Drawing.Point(7, 105)
        Me.potts.Name = "potts"
        Me.potts.Size = New System.Drawing.Size(75, 23)
        Me.potts.TabIndex = 3
        Me.potts.Text = "Pociones"
        Me.potts.UseVisualStyleBackColor = True
        '
        'def
        '
        Me.def.ForeColor = System.Drawing.SystemColors.ControlText
        Me.def.Location = New System.Drawing.Point(7, 49)
        Me.def.Name = "def"
        Me.def.Size = New System.Drawing.Size(75, 23)
        Me.def.TabIndex = 1
        Me.def.Text = "Defender"
        Me.def.UseVisualStyleBackColor = True
        '
        'attack
        '
        Me.attack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.attack.Location = New System.Drawing.Point(7, 20)
        Me.attack.Name = "attack"
        Me.attack.Size = New System.Drawing.Size(75, 23)
        Me.attack.TabIndex = 0
        Me.attack.Text = "Atacar"
        Me.attack.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(541, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.SalirToolStripMenuItem.Text = "Salir y Guardar"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IntruccionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'IntruccionesToolStripMenuItem
        '
        Me.IntruccionesToolStripMenuItem.Name = "IntruccionesToolStripMenuItem"
        Me.IntruccionesToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.IntruccionesToolStripMenuItem.Text = "Intrucciones"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Battle)
        Me.GroupBox3.Controls.Add(Me.shop)
        Me.GroupBox3.Controls.Add(Me.equip)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 289)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(97, 113)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Comienzo"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(441, 273)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 160)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(14, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'num_sang
        '
        Me.num_sang.AutoSize = True
        Me.num_sang.BackColor = System.Drawing.Color.Transparent
        Me.num_sang.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.num_sang.Location = New System.Drawing.Point(117, 333)
        Me.num_sang.Name = "num_sang"
        Me.num_sang.Size = New System.Drawing.Size(0, 13)
        Me.num_sang.TabIndex = 26
        '
        'num_mp
        '
        Me.num_mp.AutoSize = True
        Me.num_mp.BackColor = System.Drawing.Color.Transparent
        Me.num_mp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.num_mp.Location = New System.Drawing.Point(115, 362)
        Me.num_mp.Name = "num_mp"
        Me.num_mp.Size = New System.Drawing.Size(0, 13)
        Me.num_mp.TabIndex = 27
        '
        'num_sang1
        '
        Me.num_sang1.AutoSize = True
        Me.num_sang1.BackColor = System.Drawing.Color.Transparent
        Me.num_sang1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.num_sang1.Location = New System.Drawing.Point(361, 120)
        Me.num_sang1.Name = "num_sang1"
        Me.num_sang1.Size = New System.Drawing.Size(0, 13)
        Me.num_sang1.TabIndex = 28
        '
        'num_mp1
        '
        Me.num_mp1.AutoSize = True
        Me.num_mp1.BackColor = System.Drawing.Color.Transparent
        Me.num_mp1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.num_mp1.Location = New System.Drawing.Point(362, 149)
        Me.num_mp1.Name = "num_mp1"
        Me.num_mp1.Size = New System.Drawing.Size(0, 13)
        Me.num_mp1.TabIndex = 29
        '
        'mp_pot
        '
        Me.mp_pot.BackColor = System.Drawing.Color.Transparent
        Me.mp_pot.Image = Global.WindowsApplication1.My.Resources.Resources.blue
        Me.mp_pot.Location = New System.Drawing.Point(405, 193)
        Me.mp_pot.Name = "mp_pot"
        Me.mp_pot.Size = New System.Drawing.Size(22, 23)
        Me.mp_pot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mp_pot.TabIndex = 30
        Me.mp_pot.TabStop = False
        Me.mp_pot.Visible = False
        '
        'hp_pot
        '
        Me.hp_pot.Image = Global.WindowsApplication1.My.Resources.Resources.red
        Me.hp_pot.Location = New System.Drawing.Point(433, 193)
        Me.hp_pot.Name = "hp_pot"
        Me.hp_pot.Size = New System.Drawing.Size(22, 23)
        Me.hp_pot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hp_pot.TabIndex = 31
        Me.hp_pot.TabStop = False
        Me.hp_pot.Visible = False
        '
        'eventos1
        '
        Me.eventos1.AutoSize = True
        Me.eventos1.BackColor = System.Drawing.Color.Transparent
        Me.eventos1.Font = New System.Drawing.Font("Lucida Calligraphy", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventos1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.eventos1.Location = New System.Drawing.Point(120, 416)
        Me.eventos1.Name = "eventos1"
        Me.eventos1.Size = New System.Drawing.Size(0, 15)
        Me.eventos1.TabIndex = 32
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.batallas9_02_09
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(541, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.eventos1)
        Me.Controls.Add(Me.hp_pot)
        Me.Controls.Add(Me.mp_pot)
        Me.Controls.Add(Me.num_mp1)
        Me.Controls.Add(Me.num_sang1)
        Me.Controls.Add(Me.num_mp)
        Me.Controls.Add(Me.num_sang)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mp2)
        Me.Controls.Add(Me.nomb2)
        Me.Controls.Add(Me.hp2)
        Me.Controls.Add(Me.mp1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nomb1)
        Me.Controls.Add(Me.hp1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(557, 475)
        Me.MinimumSize = New System.Drawing.Size(557, 475)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fight"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mp_pot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hp_pot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Battle As System.Windows.Forms.Button
    Friend WithEvents shop As System.Windows.Forms.Button
    Friend WithEvents equip As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents hp1 As System.Windows.Forms.ProgressBar
    Friend WithEvents nomb1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mp1 As System.Windows.Forms.ProgressBar
    Friend WithEvents hp2 As System.Windows.Forms.ProgressBar
    Friend WithEvents nomb2 As System.Windows.Forms.Label
    Friend WithEvents mp2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents potts As System.Windows.Forms.Button
    Friend WithEvents def As System.Windows.Forms.Button
    Friend WithEvents attack As System.Windows.Forms.Button
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntruccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents num_sang As System.Windows.Forms.Label
    Friend WithEvents num_mp As System.Windows.Forms.Label
    Friend WithEvents num_sang1 As System.Windows.Forms.Label
    Friend WithEvents num_mp1 As System.Windows.Forms.Label
    Friend WithEvents MagicAtt As System.Windows.Forms.Button
    Friend WithEvents mp_pot As System.Windows.Forms.PictureBox
    Friend WithEvents hp_pot As System.Windows.Forms.PictureBox
    Friend WithEvents eventos1 As System.Windows.Forms.Label

End Class
