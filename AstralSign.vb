Public Class AstralSign
    Private mstrIndex As Integer
    Public Property Index() As Integer
        Get
            Return mstrIndex
        End Get
        Set(ByVal value As Integer)
            Me.mstrIndex = value
        End Set
    End Property
    Public Sub New(ByVal i As Integer)
        mstrIndex = i
    End Sub
    Private Times() As String = {"21.03 - 20.04.",
                            "21.04 - 21.05.",
                            "22.05 - 21.06.",
                            "22.06 - 22.07.",
                            "23.07 - 23.08.",
                            "24.08 - 23.09.",
                            "24.09 - 23.10.",
                            "24.10 - 22.11.",
                            "23.11 - 21.12.",
                            "22.12 - 20.01.",
                            "21.-1 - 19.02.",
                            "20.02 - 20.03."}
    Private Elements() As String = {"fire.",
                                "earth.",
                                "air.",
                                "water.",
                                "fire.",
                                "earth.",
                                "air.",
                                "water.",
                                "fire.",
                                "earth.",
                                "air.",
                                "water."}

    Private Sayings() As String = {"I am.",
                                 "I own.",
                                 "I think.",
                                 "I doubt.",
                                 "I want.",
                                 "I analyze.",
                                 "I contemplate.",
                                 "I desire.",
                                 "I see.",
                                 "I do.",
                                 "I can.",
                                 "I hope."}
    Private Colors() As String = {"red",
                                 "yellow, green, pink, blue.",
                                 "yellow, violet, gray.",
                                 "white, silver, green.",
                                 "yellow, orange, blue.",
                                 "brown.",
                                 "indigo, pink, blue, green.",
                                 "dark-red, indigo, black.",
                                 "blue, violet.",
                                 "green, brown, black.",
                                 "dark-blue, sea-green, beige.",
                                 "blue, pink, light-gray."}
    Private Planets() As String = {"Mars.",
                                  "Venus.",
                                  "Mercury.",
                                  "Moon.",
                                  "Sun.",
                                  "Mercury.",
                                  "Venus.",
                                  "Pluto and Mars.",
                                  "Jupiter.",
                                  "Saturn.",
                                  "Uranus and Saturn.",
                                  "Neptune and Jupiter."}
    Private Images() As String = {"aries.png",
                                  "taurus.png",
                                  "gemini.png",
                                  "cancer.png",
                                  "leo.png",
                                  "virgo.png",
                                  "libra.png",
                                  "scorpio.png",
                                  "sagittarius.png",
                                  "capricorn.png",
                                  "aquarius.png",
                                  "pisces.png"}

    Public Function GetTime() As String
        Return Times(mstrIndex)
    End Function
    Public Function GetElement() As String
        Return Elements(mstrIndex)
    End Function
    Public Function GetSaying() As String
        Return Sayings(mstrIndex)
    End Function
    Public Function GetColor() As String
        Return Colors(mstrIndex)
    End Function
    Public Function GetPlanet() As String
        Return Planets(mstrIndex)
    End Function
    Public Function GetImage() As String
        Return Images(mstrIndex)
    End Function
End Class
