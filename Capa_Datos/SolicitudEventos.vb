Imports System.Data.SqlClient
Public Module SolicitudEventos
    Public nombreEvento As String
    Public fechaEvento, horaInicio, horaFinal, observacion As String
    Public idLugar, idFacultad, idActividad, idUsuario As Integer

    Sub Main()
        nombreEvento = ""
        fechaEvento = ""
        horaInicio = ""
        horaFinal = ""
        observacion = ""
        idLugar = 0
        idFacultad = 0
        idActividad = 0
        idUsuario = 0
    End Sub
End Module
