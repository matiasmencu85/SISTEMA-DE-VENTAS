




Public Class vventas


    Dim idventa, idcliente As Integer
    Dim fecha_venta As Date
    Dim tipo_documento, num_documento As String

    'seeter y getter


    Public Property gidventa
        Get
            Return idventa
        End Get
        Set(ByVal value)
            idventa = value
        End Set
    End Property






    Public Property gidcliente
        Get
            Return idcliente
        End Get
        Set(ByVal value)
            idcliente = value
        End Set
    End Property

    Public Property gfecha_venta
        Get
            Return fecha_venta
        End Get
        Set(ByVal value)
            fecha_venta = value
        End Set
    End Property

    Public Property gtipo_documento
        Get
            Return tipo_documento
        End Get
        Set(ByVal value)
            tipo_documento = value
        End Set
    End Property

    Public Property gnum_documento
        Get
            Return num_documento
        End Get
        Set(ByVal value)
            num_documento = value
        End Set
    End Property


    'constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal idventa As Integer, ByVal idcliente As Integer, ByVal fecha_venta As Date, ByVal tipo_documento As String, ByVal num_documento As String)
        gidventa = idventa
        gidcliente = idcliente
        gfecha_venta = fecha_venta
        gtipo_documento = tipo_documento
        gnum_documento = num_documento


    End Sub




End Class
