Imports System.ComponentModel
Imports FontAwesome.Sharp

Public Class Form1
    Private this As Object

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
        PictureBox1.Visible = False
        dashboard_pnl.Visible = True
        orders_pnl.Visible = False
        Panel4.Visible = False
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
        PictureBox1.Visible = False
        dashboard_pnl.Visible = True
        orders_pnl.Visible = True
        orders_tbl.Visible = True
        Panel4.Visible = True

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
        PictureBox1.Visible = False

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
        PictureBox1.Visible = False

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
        PictureBox1.Visible = False

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
        PictureBox1.Visible = False

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
        PictureBox1.Visible = True
        dashboard_pnl.Visible = False
        PictureBox1.Visible = False

    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        If MsgBox("Çıkmak istediğinize emin misiniz?", MsgBoxStyle.YesNo, Title:="Uyarı!") = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub minimize_btn_Click(sender As Object, e As EventArgs) Handles minimize_btn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub dashboard_btn_MouseClick(sender As Object, e As MouseEventArgs) Handles dashboard_btn.MouseClick
        dashboard_pnl.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
