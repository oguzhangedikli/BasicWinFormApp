Imports System.ComponentModel
Imports FontAwesome.Sharp

Public Class Form1
    Private Sub dashboard_btn_Click(sender As Object, e As EventArgs) Handles dashboard_btn.Click
        dashboard_btn.IconColor = Color.GreenYellow
        dashboard_btn.ForeColor = Color.GreenYellow
        orders_btn.ForeColor = Color.White
        orders_btn.IconColor = Color.White
        products_btn.ForeColor = Color.White
        products_btn.IconColor = Color.White
        costumers_btn.ForeColor = Color.White
        costumers_btn.IconColor = Color.White
        marketing_btn.ForeColor = Color.White
        marketing_btn.IconColor = Color.White
        settings_btn.ForeColor = Color.White
        settings_btn.IconColor = Color.White
        home_icon_btn.ForeColor = Color.GreenYellow
        home_icon_btn.IconColor = Color.GreenYellow
        home_icon_btn.IconChar = IconChar.ChartLine
        home_lbl.Text = "Dashboard"
        home_lbl.ForeColor = Color.GreenYellow


    End Sub

    Private Sub orders_btn_Click(sender As Object, e As EventArgs) Handles orders_btn.Click
        dashboard_btn.IconColor = Color.White
        dashboard_btn.ForeColor = Color.White
        orders_btn.ForeColor = Color.Yellow
        orders_btn.IconColor = Color.Yellow
        products_btn.ForeColor = Color.White
        products_btn.IconColor = Color.White
        costumers_btn.ForeColor = Color.White
        costumers_btn.IconColor = Color.White
        marketing_btn.ForeColor = Color.White
        marketing_btn.IconColor = Color.White
        settings_btn.ForeColor = Color.White
        settings_btn.IconColor = Color.White
        home_icon_btn.ForeColor = Color.Yellow
        home_icon_btn.IconColor = Color.Yellow
        home_icon_btn.IconChar = IconChar.ShoppingBasket
        home_lbl.Text = "Orders"
        home_lbl.ForeColor = Color.Yellow
    End Sub

    Private Sub products_btn_Click(sender As Object, e As EventArgs) Handles products_btn.Click
        orders_btn.ForeColor = Color.White
        orders_btn.IconColor = Color.White
        dashboard_btn.IconColor = Color.White
        dashboard_btn.ForeColor = Color.White
        products_btn.ForeColor = Color.LightGreen
        products_btn.IconColor = Color.LightGreen
        costumers_btn.ForeColor = Color.White
        costumers_btn.IconColor = Color.White
        marketing_btn.ForeColor = Color.White
        marketing_btn.IconColor = Color.White
        settings_btn.ForeColor = Color.White
        settings_btn.IconColor = Color.White
        home_icon_btn.ForeColor = Color.LightGreen
        home_icon_btn.IconColor = Color.LightGreen
        home_icon_btn.IconChar = IconChar.PrescriptionBottleAlt
        home_lbl.Text = "Products"
        home_lbl.ForeColor = Color.LightGreen
    End Sub

    Private Sub costumers_btn_Click(sender As Object, e As EventArgs) Handles costumers_btn.Click
        orders_btn.ForeColor = Color.White
        orders_btn.IconColor = Color.White
        dashboard_btn.IconColor = Color.White
        dashboard_btn.ForeColor = Color.White
        products_btn.ForeColor = Color.White
        products_btn.IconColor = Color.White
        costumers_btn.ForeColor = Color.Orange
        costumers_btn.IconColor = Color.Orange
        marketing_btn.ForeColor = Color.White
        marketing_btn.IconColor = Color.White
        settings_btn.ForeColor = Color.White
        settings_btn.IconColor = Color.White
        home_icon_btn.ForeColor = Color.Orange
        home_icon_btn.IconColor = Color.Orange
        home_icon_btn.IconChar = IconChar.AddressBook
        home_lbl.Text = "Costumers"
        home_lbl.ForeColor = Color.Orange

    End Sub

    Private Sub marketing_btn_Click(sender As Object, e As EventArgs) Handles marketing_btn.Click
        orders_btn.ForeColor = Color.White
        orders_btn.IconColor = Color.White
        dashboard_btn.IconColor = Color.White
        dashboard_btn.ForeColor = Color.White
        products_btn.ForeColor = Color.White
        products_btn.IconColor = Color.White
        marketing_btn.ForeColor = Color.Red
        marketing_btn.IconColor = Color.Red
        costumers_btn.ForeColor = Color.White
        costumers_btn.IconColor = Color.White
        settings_btn.ForeColor = Color.White
        settings_btn.IconColor = Color.White
        home_icon_btn.ForeColor = Color.Red
        home_icon_btn.IconColor = Color.Red
        home_icon_btn.IconChar = IconChar.CreditCard
        home_lbl.Text = "Marketing"
        home_lbl.ForeColor = Color.Red
    End Sub

    Private Sub settings_btn_Click(sender As Object, e As EventArgs) Handles settings_btn.Click
        orders_btn.ForeColor = Color.White
        orders_btn.IconColor = Color.White
        dashboard_btn.IconColor = Color.White
        dashboard_btn.ForeColor = Color.White
        products_btn.ForeColor = Color.White
        products_btn.IconColor = Color.White
        settings_btn.ForeColor = Color.Gold
        settings_btn.IconColor = Color.Gold
        costumers_btn.ForeColor = Color.White
        costumers_btn.IconColor = Color.White
        marketing_btn.ForeColor = Color.White
        marketing_btn.IconColor = Color.White
        home_icon_btn.ForeColor = Color.Gold
        home_icon_btn.IconColor = Color.Gold
        home_icon_btn.IconChar = IconChar.Cog
        home_lbl.Text = "Settings"
        home_lbl.ForeColor = Color.Gold


    End Sub

    Private Sub home_btn_Click(sender As Object, e As EventArgs) Handles home_btn.Click
        orders_btn.ForeColor = Color.White
        orders_btn.IconColor = Color.White
        dashboard_btn.IconColor = Color.White
        dashboard_btn.ForeColor = Color.White
        products_btn.ForeColor = Color.White
        products_btn.IconColor = Color.White
        settings_btn.ForeColor = Color.White
        settings_btn.IconColor = Color.White
        costumers_btn.ForeColor = Color.White
        costumers_btn.IconColor = Color.White
        marketing_btn.ForeColor = Color.White
        marketing_btn.IconColor = Color.White
        home_icon_btn.ForeColor = Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        home_icon_btn.IconColor = Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        home_icon_btn.IconChar = IconChar.Home
        home_lbl.Text = "Home"
        home_lbl.ForeColor = Color.White
    End Sub
    Private Sub ıconPictureBox1_Click(sender As Object, e As EventArgs) Handles home_icon_btn.Click

    End Sub
End Class
