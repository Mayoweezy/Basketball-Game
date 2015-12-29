Imports System.Xml.Serialization

Public Class SaveGameClass
    Property Prop1 As String
    Property Prop2 As String
    Property Prop3 As String
    Property Prop4 As String
    Sub Save(filename As String)
        Using fs As New System.IO.FileStream(filename, IO.FileMode.OpenOrCreate)
            Dim xs As New XmlSerializer(GetType(SaveGameClass))
            xs.Serialize(fs, Me)
        End Using
    End Sub

    Shared Function Load(filename As String) As SaveGameClass
        Using fs As New System.IO.FileStream(filename, IO.FileMode.OpenOrCreate)
            Dim xs As New XmlSerializer(GetType(SaveGameClass))
            Return xs.Deserialize(fs)
        End Using
    End Function
End Class
