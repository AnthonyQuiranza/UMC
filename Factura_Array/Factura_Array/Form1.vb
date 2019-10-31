Public Class Form1
    Dim Detalle() As String
    Dim limite, Cantidad(), Precio(), Subtotal(), sTotal, IVA, TOTAL, nuevadim As Double

    Private Sub BttnEliminarProductos_Click(sender As Object, e As EventArgs) Handles BttnEliminarProductos.Click
        Dim posicion As Integer
        For i = 0 To Detalle.Length - 1
            If (Detalle(i) = ListaDetalle.SelectedItem) Then
                posicion = i
            End If
        Next
        If (posicion < Detalle.Length - 1) Then
            For i = posicion To Detalle.Length - 2
                Detalle(i) = Detalle(i + 1)
                Cantidad(i) = Cantidad(i + 1)
                Precio(i) = Precio(i + 1)
                Subtotal(i) = Subtotal(i + 1)
            Next
        End If

        ReDim Preserve Cantidad(Detalle.Length - 2), Precio(Detalle.Length - 2), Subtotal(Detalle.Length - 2), Detalle(Detalle.Length - 2)
        ListaCantidad.Items.Clear()
        ListaDetalle.Items.Clear()
        ListaPrecio.Items.Clear()
        ListaSubtotal.Items.Clear()
        For i = 0 To Cantidad.Length - 1
            ListaDetalle.Items.Add(Detalle(i))
            ListaCantidad.Items.Add(Cantidad(i))
            ListaPrecio.Items.Add(Precio(i))
            ListaSubtotal.Items.Add(Subtotal(i))
        Next
        Call calcular()
    End Sub

    Private Sub BttnAñadir_Click(sender As Object, e As EventArgs) Handles BttnAñadir.Click
        Dim aux As Integer
        aux = Detalle.Length
        nuevadim = Detalle.Length
        limite = InputBox("Ingrese la cantidad de productos que va a ingresar ")
        nuevadim = nuevadim + limite - 1
        MsgBox("El límite es: " & limite)
        ReDim Preserve Cantidad(nuevadim), Precio(nuevadim), Subtotal(nuevadim), Detalle(nuevadim)
        MsgBox(Detalle.Length)
        For i = aux To nuevadim
            Detalle(i) = InputBox("Ingrese el producto en la posición " & i + 1)
            ListaDetalle.Items.Add(Detalle(i))
            Cantidad(i) = InputBox("Ingrese la cantidad del producto " & Detalle(i))
            ListaCantidad.Items.Add(Cantidad(i))
            Precio(i) = InputBox("Ingrese el precio del producto " & Detalle(i))
            ListaPrecio.Items.Add(Precio(i))
            Subtotal(i) = Cantidad(i) * Precio(i)
            ListaSubtotal.Items.Add(Subtotal(i))
        Next
        Call calcular()
    End Sub

    Private Sub BttnIniciar_Click(sender As Object, e As EventArgs) Handles BttnIniciar.Click
        limite = InputBox("Por favor ingrese el número de productos")
        ReDim Cantidad(limite - 1), Precio(limite - 1), Subtotal(limite - 1), Detalle(limite - 1)
        MsgBox(Detalle.Length)
        For i = 0 To limite - 1
            Detalle(i) = InputBox("Ingrese el producto en la posición " & i + 1)
            ListaDetalle.Items.Add(Detalle(i))
            Cantidad(i) = InputBox("Ingrese la cantidad del producto " & Detalle(i))
            ListaCantidad.Items.Add(Cantidad(i))
            Precio(i) = InputBox("Ingrese el precio del producto " & Detalle(i))
            ListaPrecio.Items.Add(Precio(i))
            Subtotal(i) = Cantidad(i) * Precio(i)
            ListaSubtotal.Items.Add(Subtotal(i))
        Next
        Call calcular()
    End Sub
    Sub calcular()
        Dim subtotal2, iva As Double
        subtotal2 = 0
        limite = Detalle.Length - 1
        For i = 0 To limite
            subtotal2 = subtotal2 + Subtotal(i)
        Next
        TxtSubtotal.Text = subtotal2
        iva = subtotal2 * 0.12
        TxtIVA.Text = iva
        TxtTotal.Text = subtotal2 + iva
    End Sub
End Class
