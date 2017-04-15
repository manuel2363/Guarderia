<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form22
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnRepre = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaskedTxtCed = New System.Windows.Forms.MaskedTextBox()
        Me.RdoVzla = New System.Windows.Forms.RadioButton()
        Me.RdoExtr = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ParámetrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InscripciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasYReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichaDelRepresentanteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FichaDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeLaGuarderíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblNomRepre = New System.Windows.Forms.Label()
        Me.LblMonIn = New System.Windows.Forms.Label()
        Me.LblMespa = New System.Windows.Forms.Label()
        Me.LblMontotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.LblMontotal)
        Me.GroupBox1.Controls.Add(Me.LblMespa)
        Me.GroupBox1.Controls.Add(Me.LblMonIn)
        Me.GroupBox1.Controls.Add(Me.LblNomRepre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.BtnRepre)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(83, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 307)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ficha de pago"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Monto total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 17)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Monto de inscripción:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(292, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 45)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Por favor introduzca la cédula" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del representante para iniciar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "su búsqueda"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnRepre
        '
        Me.BtnRepre.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRepre.Location = New System.Drawing.Point(331, 33)
        Me.BtnRepre.Name = "BtnRepre"
        Me.BtnRepre.Size = New System.Drawing.Size(113, 42)
        Me.BtnRepre.TabIndex = 73
        Me.BtnRepre.Text = "Buscar representante"
        Me.BtnRepre.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MaskedTxtCed)
        Me.Panel1.Controls.Add(Me.RdoVzla)
        Me.Panel1.Controls.Add(Me.RdoExtr)
        Me.Panel1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(162, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(116, 65)
        Me.Panel1.TabIndex = 72
        '
        'MaskedTxtCed
        '
        Me.MaskedTxtCed.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTxtCed.Location = New System.Drawing.Point(11, 28)
        Me.MaskedTxtCed.Mask = "00000000"
        Me.MaskedTxtCed.Name = "MaskedTxtCed"
        Me.MaskedTxtCed.Size = New System.Drawing.Size(100, 21)
        Me.MaskedTxtCed.TabIndex = 2
        '
        'RdoVzla
        '
        Me.RdoVzla.AutoSize = True
        Me.RdoVzla.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoVzla.Location = New System.Drawing.Point(12, 3)
        Me.RdoVzla.Name = "RdoVzla"
        Me.RdoVzla.Size = New System.Drawing.Size(33, 19)
        Me.RdoVzla.TabIndex = 1
        Me.RdoVzla.TabStop = True
        Me.RdoVzla.Text = "V"
        Me.RdoVzla.UseVisualStyleBackColor = True
        '
        'RdoExtr
        '
        Me.RdoExtr.AutoSize = True
        Me.RdoExtr.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdoExtr.Location = New System.Drawing.Point(65, 3)
        Me.RdoExtr.Name = "RdoExtr"
        Me.RdoExtr.Size = New System.Drawing.Size(32, 19)
        Me.RdoExtr.TabIndex = 0
        Me.RdoExtr.TabStop = True
        Me.RdoExtr.Text = "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RdoExtr.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Cédula de identidad: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nombre del representante:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = " Meses pagados:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParámetrosToolStripMenuItem, Me.InscripciónToolStripMenuItem, Me.ControlDePagoToolStripMenuItem, Me.ConsultasYReportesToolStripMenuItem, Me.SeguridadToolStripMenuItem, Me.AyudaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 26)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(615, 25)
        Me.MenuStrip1.TabIndex = 66
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ParámetrosToolStripMenuItem
        '
        Me.ParámetrosToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.ParámetrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargoToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.EmpleadosToolStripMenuItem})
        Me.ParámetrosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParámetrosToolStripMenuItem.Name = "ParámetrosToolStripMenuItem"
        Me.ParámetrosToolStripMenuItem.Size = New System.Drawing.Size(87, 21)
        Me.ParámetrosToolStripMenuItem.Text = "Parámetros"
        '
        'CargoToolStripMenuItem
        '
        Me.CargoToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.CargoToolStripMenuItem.Name = "CargoToolStripMenuItem"
        Me.CargoToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CargoToolStripMenuItem.Text = "Cargo"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'InscripciónToolStripMenuItem
        '
        Me.InscripciónToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.InscripciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.InscripciónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InscripciónToolStripMenuItem.Name = "InscripciónToolStripMenuItem"
        Me.InscripciónToolStripMenuItem.Size = New System.Drawing.Size(82, 21)
        Me.InscripciónToolStripMenuItem.Text = "Inscripción"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NuevoToolStripMenuItem.Text = "Incorporar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ControlDePagoToolStripMenuItem
        '
        Me.ControlDePagoToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.ControlDePagoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.ModificarToolStripMenuItem1})
        Me.ControlDePagoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlDePagoToolStripMenuItem.Name = "ControlDePagoToolStripMenuItem"
        Me.ControlDePagoToolStripMenuItem.Size = New System.Drawing.Size(117, 21)
        Me.ControlDePagoToolStripMenuItem.Text = "Control de pago"
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.NuevoToolStripMenuItem1.Text = "Incorporar"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.BackColor = System.Drawing.Color.AliceBlue
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.ModificarToolStripMenuItem1.Text = "Modificar "
        '
        'ConsultasYReportesToolStripMenuItem
        '
        Me.ConsultasYReportesToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.ConsultasYReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem2, Me.FichaDelRepresentanteToolStripMenuItem, Me.FichaDePagoToolStripMenuItem})
        Me.ConsultasYReportesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConsultasYReportesToolStripMenuItem.Name = "ConsultasYReportesToolStripMenuItem"
        Me.ConsultasYReportesToolStripMenuItem.Size = New System.Drawing.Size(140, 21)
        Me.ConsultasYReportesToolStripMenuItem.Text = "Consultas y reportes"
        '
        'NuevoToolStripMenuItem2
        '
        Me.NuevoToolStripMenuItem2.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoToolStripMenuItem2.Name = "NuevoToolStripMenuItem2"
        Me.NuevoToolStripMenuItem2.Size = New System.Drawing.Size(212, 22)
        Me.NuevoToolStripMenuItem2.Text = "Ficha del niño"
        '
        'FichaDelRepresentanteToolStripMenuItem
        '
        Me.FichaDelRepresentanteToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.FichaDelRepresentanteToolStripMenuItem.Name = "FichaDelRepresentanteToolStripMenuItem"
        Me.FichaDelRepresentanteToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.FichaDelRepresentanteToolStripMenuItem.Text = "Ficha del representante"
        '
        'FichaDePagoToolStripMenuItem
        '
        Me.FichaDePagoToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.FichaDePagoToolStripMenuItem.Name = "FichaDePagoToolStripMenuItem"
        Me.FichaDePagoToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.FichaDePagoToolStripMenuItem.Text = "Ficha de pago"
        '
        'SeguridadToolStripMenuItem
        '
        Me.SeguridadToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.SeguridadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.CambioDeContraseñaToolStripMenuItem})
        Me.SeguridadToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeguridadToolStripMenuItem.Name = "SeguridadToolStripMenuItem"
        Me.SeguridadToolStripMenuItem.Size = New System.Drawing.Size(80, 21)
        Me.SeguridadToolStripMenuItem.Text = "Seguridad"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.NuevoUsuarioToolStripMenuItem.Text = "Nuevo usuario"
        '
        'CambioDeContraseñaToolStripMenuItem
        '
        Me.CambioDeContraseñaToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.CambioDeContraseñaToolStripMenuItem.Name = "CambioDeContraseñaToolStripMenuItem"
        Me.CambioDeContraseñaToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CambioDeContraseñaToolStripMenuItem.Text = "Cambio de contraseña"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeLaGuarderíaToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(56, 21)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeLaGuarderíaToolStripMenuItem
        '
        Me.AcercaDeLaGuarderíaToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.AcercaDeLaGuarderíaToolStripMenuItem.Name = "AcercaDeLaGuarderíaToolStripMenuItem"
        Me.AcercaDeLaGuarderíaToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AcercaDeLaGuarderíaToolStripMenuItem.Text = "Acerca de la guardería"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(45, 21)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.BackColor = System.Drawing.Color.AliceBlue
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(497, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 45)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Atrás"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblNomRepre
        '
        Me.LblNomRepre.AutoSize = True
        Me.LblNomRepre.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblNomRepre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNomRepre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomRepre.Location = New System.Drawing.Point(194, 130)
        Me.LblNomRepre.Name = "LblNomRepre"
        Me.LblNomRepre.Size = New System.Drawing.Size(2, 18)
        Me.LblNomRepre.TabIndex = 90
        '
        'LblMonIn
        '
        Me.LblMonIn.AutoSize = True
        Me.LblMonIn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblMonIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMonIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonIn.Location = New System.Drawing.Point(160, 173)
        Me.LblMonIn.Name = "LblMonIn"
        Me.LblMonIn.Size = New System.Drawing.Size(2, 18)
        Me.LblMonIn.TabIndex = 91
        '
        'LblMespa
        '
        Me.LblMespa.AutoSize = True
        Me.LblMespa.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblMespa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMespa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMespa.Location = New System.Drawing.Point(135, 218)
        Me.LblMespa.Name = "LblMespa"
        Me.LblMespa.Size = New System.Drawing.Size(2, 18)
        Me.LblMespa.TabIndex = 92
        '
        'LblMontotal
        '
        Me.LblMontotal.AutoSize = True
        Me.LblMontotal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblMontotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMontotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontotal.Location = New System.Drawing.Point(107, 267)
        Me.LblMontotal.Name = "LblMontotal"
        Me.LblMontotal.Size = New System.Drawing.Size(2, 18)
        Me.LblMontotal.TabIndex = 93
        '
        'Form22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.imagenesanimalesparabebes1
        Me.ClientSize = New System.Drawing.Size(753, 458)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form22"
        Me.Text = "Consulta Ficha de pago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ParámetrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InscripciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDePagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasYReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FichaDelRepresentanteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FichaDePagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguridadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioDeContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeLaGuarderíaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnRepre As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MaskedTxtCed As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RdoVzla As System.Windows.Forms.RadioButton
    Friend WithEvents RdoExtr As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LblNomRepre As System.Windows.Forms.Label
    Friend WithEvents LblMontotal As System.Windows.Forms.Label
    Friend WithEvents LblMespa As System.Windows.Forms.Label
    Friend WithEvents LblMonIn As System.Windows.Forms.Label
End Class
