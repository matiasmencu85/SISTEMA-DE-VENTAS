




Public Class vproducto


    Dim idproducto, idcategoria As Integer
    Dim nombre, descripcion, nom_categoria As String
    Dim stock, precio_compra, precio_venta As Double
    Dim fecha_vencimiento As Date
    Dim imagen() As Byte


    Public Property gidproducto
        Get
            Return idproducto
        End Get
        Set(ByVal value)
            idproducto = value
        End Set
    End Property

    Public Property gidcategoria
        Get
            Return idcategoria
        End Get
        Set(ByVal value)
            idcategoria = value
        End Set
    End Property

    Public Property gnom_categoria
        Get
            Return nom_categoria
        End Get
        Set(ByVal value)
            nom_categoria = value
        End Set
    End Property











    Public Property gnombre
        Get
            Return nombre
        End Get
        Set(ByVal value)
            nombre = value
        End Set
    End Property

    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(ByVal value)
            descripcion = value
        End Set
    End Property

    Public Property gstock
        Get
            Return stock
        End Get
        Set(ByVal value)
            stock = value
        End Set
    End Property

    Public Property gprecio_compra
        Get
            Return precio_compra
        End Get
        Set(ByVal value)
            precio_compra = value
        End Set
    End Property

    Public Property gprecio_venta
        Get
            Return precio_venta
        End Get
        Set(ByVal value)
            precio_venta = value
        End Set
    End Property


    Public Property gfecha_vencimiento
        Get
            Return fecha_vencimiento
        End Get
        Set(ByVal value)
            fecha_vencimiento = value
        End Set
    End Property

    Public Property gimagen
        Get
            Return imagen
        End Get
        Set(ByVal value)
            imagen = value
        End Set
    End Property




    Public Sub New()

    End Sub


    Public Sub New(ByVal idproducto As Integer, ByVal idcategoria As Integer, ByVal nom_categoria As String, ByVal nombre As String, ByVal descripcion As String, ByVal stock As Double, ByVal precio_compra As Double, ByVal precio_venta As Double, ByVal fecha_vencimiento As Date, ByVal imagen() As Byte)
        gidproducto = idproducto
        gnombre = nombre
        gidcategoria = idcategoria
        gnom_categoria = nom_categoria
        gdescripcion = descripcion
        gstock = stock
        gprecio_compra = precio_compra
        gprecio_venta = precio_venta
        gfecha_vencimiento = fecha_vencimiento
        gimagen = imagen

    End Sub





End Class
