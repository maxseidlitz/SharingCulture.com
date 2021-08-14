Public Class GegenstandViewModel
    Private mGegenstand As Gegenstand
    Private mKategorieAlle As List(Of Kategorie)

    Public Property Gegenstand As Gegenstand
        Get
            Return mGegenstand
        End Get
        Set(value As Gegenstand)
            mGegenstand = value
        End Set
    End Property

    Public Property KategorienAlle() As List(Of Kategorie)
        Get
            Return mKategorieAlle
        End Get
        Set(value As List(Of Kategorie))
            mKategorieAlle = value
        End Set
    End Property
End Class
