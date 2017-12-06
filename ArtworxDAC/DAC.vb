Imports System.Data.SqlClient

Public Class DAC
    Public Shared Function ExecuteDataTable(
            ByVal storedProcedureName As String) As DataTable
        Return ExecuteDataTable(storedProcedureName, Nothing)
    End Function

    Public Shared Function ExecuteDataTable(
            ByVal storedProcedureName As String,
            ByVal ParamArray arrParam() As SqlParameter) As DataTable
        Dim dt As DataTable
        ' Open the connection
        Using cnn As New SqlConnection(My.Settings.ConnectionString)
            cnn.Open()
            Dim cmd As New SqlCommand ' Define the command
            cmd.Connection = cnn
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = storedProcedureName
            If arrParam IsNot Nothing Then ' Handle the parameters
                For Each param As SqlParameter In arrParam
                    cmd.Parameters.Add(param)
                Next
            End If
            ' Define the data adapter and fill the dataset
            Dim da As New SqlDataAdapter(cmd)
            dt = New DataTable
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Shared Function Parameter(ByVal parameterName As String,
                    ByVal parameterValue As Object) As SqlParameter
        Dim param As New SqlParameter
        param.ParameterName = parameterName
        param.Value = parameterValue
        Return param
    End Function

End Class
