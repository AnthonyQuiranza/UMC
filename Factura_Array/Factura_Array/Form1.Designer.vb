<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListaDetalle = New System.Windows.Forms.ListBox()
        Me.ListaCantidad = New System.Windows.Forms.ListBox()
        Me.ListaPrecio = New System.Windows.Forms.ListBox()
        Me.ListaSubtotal = New System.Windows.Forms.ListBox()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.TxtIVA = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BttnIniciar = New System.Windows.Forms.Button()
        Me.BttnAñadir = New System.Windows.Forms.Button()
        Me.BttnEliminarProductos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detalle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(221, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(411, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Subtotal"
        '
        'ListaDetalle
        '
        Me.ListaDetalle.FormattingEnabled = True
        Me.ListaDetalle.Location = New System.Drawing.Point(13, 62)
        Me.ListaDetalle.Name = "ListaDetalle"
        Me.ListaDetalle.Size = New System.Drawing.Size(196, 251)
        Me.ListaDetalle.TabIndex = 4
        '
        'ListaCantidad
        '
        Me.ListaCantidad.FormattingEnabled = True
        Me.ListaCantidad.Location = New System.Drawing.Point(224, 62)
        Me.ListaCantidad.Name = "ListaCantidad"
        Me.ListaCantidad.Size = New System.Drawing.Size(76, 251)
        Me.ListaCantidad.TabIndex = 5
        '
        'ListaPrecio
        '
        Me.ListaPrecio.FormattingEnabled = True
        Me.ListaPrecio.Location = New System.Drawing.Point(317, 62)
        Me.ListaPrecio.Name = "ListaPrecio"
        Me.ListaPrecio.Size = New System.Drawing.Size(76, 251)
        Me.ListaPrecio.TabIndex = 6
        '
        'ListaSubtotal
        '
        Me.ListaSubtotal.FormattingEnabled = True
        Me.ListaSubtotal.Location = New System.Drawing.Point(414, 62)
        Me.ListaSubtotal.Name = "ListaSubtotal"
        Me.ListaSubtotal.Size = New System.Drawing.Size(76, 251)
        Me.ListaSubtotal.TabIndex = 7
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Location = New System.Drawing.Point(414, 319)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.Size = New System.Drawing.Size(76, 20)
        Me.TxtSubtotal.TabIndex = 8
        '
        'TxtIVA
        '
        Me.TxtIVA.Location = New System.Drawing.Point(414, 345)
        Me.TxtIVA.Name = "TxtIVA"
        Me.TxtIVA.Size = New System.Drawing.Size(76, 20)
        Me.TxtIVA.TabIndex = 9
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(414, 371)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(76, 20)
        Me.TxtTotal.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(314, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Subtotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(314, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "IVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(314, 373)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total"
        '
        'BttnIniciar
        '
        Me.BttnIniciar.Location = New System.Drawing.Point(524, 62)
        Me.BttnIniciar.Name = "BttnIniciar"
        Me.BttnIniciar.Size = New System.Drawing.Size(104, 28)
        Me.BttnIniciar.TabIndex = 14
        Me.BttnIniciar.Text = "Iniciar"
        Me.BttnIniciar.UseVisualStyleBackColor = True
        '
        'BttnAñadir
        '
        Me.BttnAñadir.Location = New System.Drawing.Point(524, 96)
        Me.BttnAñadir.Name = "BttnAñadir"
        Me.BttnAñadir.Size = New System.Drawing.Size(104, 54)
        Me.BttnAñadir.TabIndex = 15
        Me.BttnAñadir.Text = "Añadir Productos"
        Me.BttnAñadir.UseVisualStyleBackColor = True
        '
        'BttnEliminarProductos
        '
        Me.BttnEliminarProductos.Location = New System.Drawing.Point(524, 156)
        Me.BttnEliminarProductos.Name = "BttnEliminarProductos"
        Me.BttnEliminarProductos.Size = New System.Drawing.Size(104, 54)
        Me.BttnEliminarProductos.TabIndex = 16
        Me.BttnEliminarProductos.Text = "Eliminar Productos"
        Me.BttnEliminarProductos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 431)
        Me.Controls.Add(Me.BttnEliminarProductos)
        Me.Controls.Add(Me.BttnAñadir)
        Me.Controls.Add(Me.BttnIniciar)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListaDetalle As ListBox
    Friend WithEvents ListaCantidad As ListBox
    Friend WithEvents ListaPrecio As ListBox
    Friend WithEvents ListaSubtotal As ListBox
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents TxtIVA As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BttnIniciar As Button
    Friend WithEvents BttnAñadir As Button
    Friend WithEvents BttnEliminarProductos As Button
End Class
