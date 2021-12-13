Imports System.Data.SqlClient
Public Module SolicitudEquipos
    Public nombreActividad As String
    Public fechaActividad, horaInicio, minutoInicio, minutoFinal, horaFinal, nomSolicitante, unidad, correo, telefono, celular As String
    Public fechaRetiro, nombreRetiro, nombreEntrega, fechaDevolucion, nombreDevuelve, nombreRecibe As String
    Public idLugar, idFacultad, idActividad, idUsuario As Integer

    Sub Main()

        'Form_SEquipo
        nombreActividad = ""
        fechaActividad = ""
        correo = ""
        telefono = ""
        celular = ""
        horaInicio = ""
        minutoInicio = ""
        horaFinal = ""
        minutoFinal = ""
        unidad = ""
        correo = ""
        telefono = ""
        celular = ""

        idLugar = 0
        idFacultad = 0
        idActividad = 0
        idUsuario = 0

        'Form_SEquipo3
        fechaRetiro = ""
        nombreRetiro = ""
        nombreEntrega = ""
        fechaDevolucion = ""
        nombreDevuelve = ""
        nombreRecibe = ""

    End Sub
End Module
