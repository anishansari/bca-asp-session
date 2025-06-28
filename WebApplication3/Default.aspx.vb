Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub Session_Add(sender As Object, e As EventArgs)
        Session("MySession") = text1.Text
        span1.Text = "Session data updated! <br />Your session contains: <font color='red'>" & Session("MySession").ToString() & "</font>"
    End Sub

    Protected Sub CheckSession(sender As Object, e As EventArgs)
        If Session("MySession") Is Nothing OrElse Session("MySession").ToString() = "" Then
            span1.Text = "NOTHING, SESSION DATA LOST"
        Else
            span1.Text = "Your session contains: <font color='red'>" & Session("MySession").ToString() & "</font>"
        End If
    End Sub
End Class