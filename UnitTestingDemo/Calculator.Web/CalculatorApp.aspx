<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorApp.aspx.cs" Inherits="Calculator.Web.CalculatorApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>Numerator</td>
                    <td>
                        <asp:TextBox ID="txtNumerator" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Denominator</td>
                    <td>
                        <asp:TextBox ID="txtDenominator" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btnDivide" runat="server" OnClick="btnDivide_Click" style="height: 26px" Text="Divide" />
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="txtResult" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
