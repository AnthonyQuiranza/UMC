Public Class Form3
    Dim detalle(50) As String
    Dim cantidad(50), precio(50), subtotal(50) As Double
    Dim stotal, IVA, total As Double
    Dim productoeliminar, j, k As Integer

    Private Sub BttnEliminarProductos_Click(sender As Object, e As EventArgs) Handles BttnEliminarProductos.Click
        productoeliminar = ListaDetalle.SelectedIndex
        detalle(productoeliminar) = detalle(productoeliminar + 1)
        If (detalle(productoeliminar + 1) Is Nothing) Then
            detalle(productoeliminar) = Nothing
            ListaDetalle.Items.RemoveAt(productoeliminar)
            cantidad(productoeliminar) = Nothing
            ListaCantidad.Items.RemoveAt(productoeliminar)
            precio(productoeliminar) = Nothing
            ListaPrecio.Items.RemoveAt(productoeliminar)
            subtotal(productoeliminar) = Nothing
            ListaSubtotal.Items.RemoveAt(productoeliminar)
        Else
            ListaDetalle.Items.RemoveAt(productoeliminar)
            ListaCantidad.Items.RemoveAt(productoeliminar)
            ListaPrecio.Items.RemoveAt(productoeliminar)
            ListaSubtotal.Items.RemoveAt(productoeliminar)
            For k = 0 To detalle.Length - 1
                If (detalle(i) Is Nothing) Then
                    j = k
                End If
            Next
            For k = productoeliminar To j - 1
                detalle(k) = detalle(k + 1)
                detalle(k + 1) = Nothing

                precio(k) = precio(k + 1)
                precio(k + 1) = Nothing

                cantidad(k) = cantidad(k + 1)
                cantidad(k + 1) = Nothing

                subtotal(k) = subtotal(k + 1)
                subtotal(k + 1) = Nothing

            Next

        End If
        For k = 0 To detalle.Length - 1
            If (detalle(k) Is Nothing) Then
                j = k
            End If
        Next
        Dim pal As String
        pal = ""
        For k = 0 To j
            pal = pal + "  " + detalle(k)
        Next
        MsgBox(pal)
        i = i - 1
        Call calcular()

    End Sub

    Private Sub BttnAñadir_Click(sender As Object, e As EventArgs) Handles BttnAñadir.Click
        detalle(i) = txtDetalle.Text
        ListaDetalle.Items.Add(detalle(i))
        cantidad(i) = txtCantidad.Text
        ListaCantidad.Items.Add(cantidad(i))
        precio(i) = TxtPrecio.Text
        ListaPrecio.Items.Add(precio(i))
        subtotal(i) = cantidad(i) * precio(i)
        ListaSubtotal.Items.Add(subtotal(i))
        stotal = stotal + subtotal(i)
        IVA = (stotal * 12) / 100
        TxtSubtotal.Text = stotal
        TxtIVA.Text = IVA
        TxtTotal.Text = stotal + IVA
        txtDetalle.Text = ""
        txtCantidad.Text = ""
        TxtPrecio.Text = ""
        txtDetalle.Focus()
        i = i + 1
    End Sub

    Dim i, limite As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 0
    End Sub
    Sub calcular()
        stotal = 0
        IVA = 0
        total = 0

        k = 0
        For k = 0 To detalle.Length
            If (detalle(k) Is Nothing) Then
                j = k
                k = detalle.Length

            End If
        Next
        For k = 0 To j
            stotal = stotal + subtotal(k)
        Next
        TxtSubtotal.Text = stotal
        IVA = (stotal * 12) / 100
        TxtIVA.Text = IVA

        total = stotal + IVA
        TxtTotal.Text = total

    End Sub
End Class