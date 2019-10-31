<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.BttnEliminarProductos = New System.Windows.Forms.Button()
        Me.BttnAñadir = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtIVA = New System.Windows.Forms.TextBox()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.ListaSubtotal = New System.Windows.Forms.ListBox()
        Me.ListaPrecio = New System.Windows.Forms.ListBox()
        Me.ListaCantidad = New System.Windows.Forms.ListBox()
        Me.ListaDetalle = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BttnEliminarProductos
        '
        Me.BttnEliminarProductos.Location = New System.Drawing.Point(553, 209)
        Me.BttnEliminarProductos.Name = "BttnEliminarProductos"
        Me.BttnEliminarProductos.Size = New System.Drawing.Size(104, 54)
        Me.BttnEliminarProductos.TabIndex = 33
        Me.BttnEliminarProductos.Text = "Eliminar Productos"
        Me.BttnEliminarProductos.UseVisualStyleBackColor = True
        '
        'BttnAñadir
        '
        Me.BttnAñadir.Location = New System.Drawing.Point(553, 149)
        Me.BttnAñadir.Name = "BttnAñadir"
        Me.BttnAñadir.Size = New System.Drawing.Size(104, 54)
        Me.BttnAñadir.TabIndex = 32
        Me.BttnAñadir.Text = "Añadir Productos"
        Me.BttnAñadir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(343, 426)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(343, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(343, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Subtotal"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(443, 424)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(76, 20)
        Me.TxtTotal.TabIndex = 27
        '
        'TxtIVA
        '
        Me.TxtIVA.Location = New System.Drawing.Point(443, 398)
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.Size = New System.Drawing.Size(76, 20)
        Me.TxtIVA.TabIndex = 26
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Location = New System.Drawing.Point(443, 372)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(76, 20)
        Me.TxtSubtotal.TabIndex = 25
        '
        'ListaSubtotal
        '
        Me.ListaSubtotal.FormattingEnabled = True
        Me.ListaSubtotal.Location = New System.Drawing.Point(443, 115)
        Me.ListaSubtotal.Name = "ListaSubtotal"
        Me.ListaSubtotal.Size = New System.Drawing.Size(76, 251)
        Me.ListaSubtotal.TabIndex = 24
        '
        'ListaPrecio
        '
        Me.ListaPrecio.FormattingEnabled = True
        Me.ListaPrecio.Location = New System.Drawing.Point(346, 115)
        Me.ListaPrecio.Name = "ListaPrecio"
        Me.ListaPrecio.Size = New System.Drawing.Size(76, 251)
        Me.ListaPrecio.TabIndex = 23
        '
        'ListaCantidad
        '
        Me.ListaCantidad.FormattingEnabled = True
        Me.ListaCantidad.Location = New System.Drawing.Point(253, 115)
        Me.ListaCantidad.Name = "ListaCantidad"
        Me.ListaCantidad.Size = New System.Drawing.Size(76, 251)
        Me.ListaCantidad.TabIndex = 22
        '
        'ListaDetalle
        '
        Me.ListaDetalle.FormattingEnabled = True
        Me.ListaDetalle.Location = New System.Drawing.Point(42, 115)
        Me.ListaDetalle.Name = "ListaDetalle"
        Me.ListaDetalle.Size = New System.Drawing.Size(196, 251)
        Me.ListaDetalle.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(440, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Subtotal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(250, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Detalle"
        '
        'txtDetalle
        '
        Me.txtDetalle.Location = New System.Drawing.Point(42, 61)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(194, 20)
        Me.txtDetalle.TabIndex = 34
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(253, 61)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(76, 20)
        Me.txtCantidad.TabIndex = 35
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(346, 61)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(76, 20)
        Me.TxtPrecio.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(343, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 18)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Precio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(250, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 18)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Cantidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 18)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Detalle"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtDetalle)
        Me.Controls.Add(Me.BttnEliminarProductos)
        Me.Controls.Add(Me.BttnAñadir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.TxtIVA)
        Me.Controls.Add(Me.TxtSubtotal)
        Me.Controls.Add(Me.ListaSubtotal)
        Me.Controls.Add(Me.ListaPrecio)
        Me.Controls.Add(Me.ListaCantidad)
        Me.Controls.Add(Me.ListaDetalle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BttnEliminarProductos As Button
    Friend WithEvents BttnAñadir As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtIVA As TextBox
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents ListaSubtotal As ListBox
    Friend WithEvents ListaPrecio As ListBox
    Friend WithEvents ListaCantidad As ListBox
    Friend WithEvents ListaDetalle As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
