Module ModuloGeneral
    Public RutaArchivos As String = "C:\Publico\Seguimiento\Archivos\"

    Public Contador As Integer
    Public BusquedaPor As String
    Public Mensaje As String
    Public Respuesta As Byte

    Public Productor As String
    Public IdProductor As Integer
    Public Existente As Byte

    Public Asegurado As String
    Public IdAsegurado As Integer

    Public Empleado As String
    Public IdEmpleado As Integer

    Public Controlado As Byte
    Public PolizaExistente As String
    Public CotizacionExistente As String

    Public IdEstadoCotizacion, IdEstadoPoliza As Integer

    Public Titulo As String
    Public Grupo As String
    Public Poliza, Cotizacion As String
    Public Estado, NuevoEstado As String

    Public Asunto, TextoMensaje As String
    Public TareasPendientes As String


    Public IdTema, IdInstancia, IdEstado As Integer
    Public FechaInstancia As String

    Public NombreArchivo As String
    Public RutaOrigen, RutaDestino As String

    Public Participante_Tipo As String 'indica cual es el participante a trabajar
    Public Datos As String
    Public IdEncontrado As Integer 'es para cuando se desea editar productor, asegurado o empleado. Si  este ID es igual al ID del participante
    'que se quiere modificar, entonces, acepta el cambio, sino informa que el participante ya existe

    Public TextoAAnalizar As String




End Module
