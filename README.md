# ASP.NET Web Forms Project with Session

This project demonstrates how to use ASP.NET Web Forms with:
---
- ✅ Session handling
---
## 📁 Prerequisites
- Visual Studio 2022

## 📦 Project Structure

- `Default.aspx` - UI markup
- `Default.aspx.vb` - Code-behind logic

---

## 🔐 Session Code Example

### Default.aspx
```aspx
<asp:TextBox ID="text1" runat="server"></asp:TextBox><br /><br />
<asp:Button ID="Submit1" runat="server" Text="Add to Session State" OnClick="Session_Add" /><br /><br />
<asp:Button ID="Submit2" runat="server" Text="View Session State" OnClick="CheckSession" /><br /><br />
<asp:Label ID="span1" runat="server" Font-Bold="true" ForeColor="DarkBlue" />
```

### Default.aspx.vb
```vb
Protected Sub Session_Add(sender As Object, e As EventArgs)
    Session("MySession") = text1.Text
    span1.Text = "Session saved: " & Session("MySession")
End Sub

Protected Sub CheckSession(sender As Object, e As EventArgs)
    If Session("MySession") Is Nothing Then
        span1.Text = "Session is empty."
    Else
        span1.Text = "Session contains: " & Session("MySession")
    End If
End Sub
```

---
