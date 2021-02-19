<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ust_Panel As System.Windows.Forms.Panel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.settings_btn = New FontAwesome.Sharp.IconButton()
        Me.marketing_btn = New FontAwesome.Sharp.IconButton()
        Me.costumers_btn = New FontAwesome.Sharp.IconButton()
        Me.products_btn = New FontAwesome.Sharp.IconButton()
        Me.orders_btn = New FontAwesome.Sharp.IconButton()
        Me.dashboard_btn = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.home_btn = New System.Windows.Forms.PictureBox()
        Me.title_panel = New System.Windows.Forms.Panel()
        Me.minimize_btn = New FontAwesome.Sharp.IconButton()
        Me.close_btn = New FontAwesome.Sharp.IconButton()
        Me.home_lbl = New System.Windows.Forms.Label()
        Me.home_icon_btn = New FontAwesome.Sharp.IconPictureBox()
        ust_Panel = New System.Windows.Forms.Panel()
        ust_Panel.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.home_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.title_panel.SuspendLayout()
        CType(Me.home_icon_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ust_Panel
        '
        ust_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(71, Byte), Integer))
        ust_Panel.Controls.Add(Me.settings_btn)
        ust_Panel.Controls.Add(Me.marketing_btn)
        ust_Panel.Controls.Add(Me.costumers_btn)
        ust_Panel.Controls.Add(Me.products_btn)
        ust_Panel.Controls.Add(Me.orders_btn)
        ust_Panel.Controls.Add(Me.dashboard_btn)
        ust_Panel.Controls.Add(Me.PanelLogo)
        ust_Panel.Dock = System.Windows.Forms.DockStyle.Left
        ust_Panel.Location = New System.Drawing.Point(0, 0)
        ust_Panel.Name = "ust_Panel"
        ust_Panel.Size = New System.Drawing.Size(227, 583)
        ust_Panel.TabIndex = 0
        '
        'settings_btn
        '
        Me.settings_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.settings_btn.FlatAppearance.BorderSize = 0
        Me.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settings_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.settings_btn.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.settings_btn.IconColor = System.Drawing.Color.White
        Me.settings_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.settings_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settings_btn.Location = New System.Drawing.Point(0, 440)
        Me.settings_btn.Name = "settings_btn"
        Me.settings_btn.Size = New System.Drawing.Size(227, 60)
        Me.settings_btn.TabIndex = 6
        Me.settings_btn.Text = "Settings"
        Me.settings_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settings_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.settings_btn.UseVisualStyleBackColor = True
        '
        'marketing_btn
        '
        Me.marketing_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.marketing_btn.FlatAppearance.BorderSize = 0
        Me.marketing_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.marketing_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.marketing_btn.IconChar = FontAwesome.Sharp.IconChar.CreditCard
        Me.marketing_btn.IconColor = System.Drawing.Color.White
        Me.marketing_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.marketing_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.marketing_btn.Location = New System.Drawing.Point(0, 380)
        Me.marketing_btn.Name = "marketing_btn"
        Me.marketing_btn.Size = New System.Drawing.Size(227, 60)
        Me.marketing_btn.TabIndex = 5
        Me.marketing_btn.Text = "Marketing"
        Me.marketing_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.marketing_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.marketing_btn.UseVisualStyleBackColor = True
        '
        'costumers_btn
        '
        Me.costumers_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.costumers_btn.FlatAppearance.BorderSize = 0
        Me.costumers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.costumers_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.costumers_btn.IconChar = FontAwesome.Sharp.IconChar.AddressBook
        Me.costumers_btn.IconColor = System.Drawing.Color.White
        Me.costumers_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.costumers_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.costumers_btn.Location = New System.Drawing.Point(0, 320)
        Me.costumers_btn.Name = "costumers_btn"
        Me.costumers_btn.Size = New System.Drawing.Size(227, 60)
        Me.costumers_btn.TabIndex = 4
        Me.costumers_btn.Text = "Costumers"
        Me.costumers_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.costumers_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.costumers_btn.UseVisualStyleBackColor = True
        '
        'products_btn
        '
        Me.products_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.products_btn.FlatAppearance.BorderSize = 0
        Me.products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.products_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.products_btn.IconChar = FontAwesome.Sharp.IconChar.PrescriptionBottleAlt
        Me.products_btn.IconColor = System.Drawing.Color.White
        Me.products_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.products_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.products_btn.Location = New System.Drawing.Point(0, 260)
        Me.products_btn.Name = "products_btn"
        Me.products_btn.Size = New System.Drawing.Size(227, 60)
        Me.products_btn.TabIndex = 3
        Me.products_btn.Text = "Products"
        Me.products_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.products_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.products_btn.UseVisualStyleBackColor = True
        '
        'orders_btn
        '
        Me.orders_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.orders_btn.FlatAppearance.BorderSize = 0
        Me.orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orders_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.orders_btn.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket
        Me.orders_btn.IconColor = System.Drawing.Color.White
        Me.orders_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.orders_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.orders_btn.Location = New System.Drawing.Point(0, 200)
        Me.orders_btn.Name = "orders_btn"
        Me.orders_btn.Size = New System.Drawing.Size(227, 60)
        Me.orders_btn.TabIndex = 2
        Me.orders_btn.Text = "Orders"
        Me.orders_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.orders_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.orders_btn.UseVisualStyleBackColor = True
        '
        'dashboard_btn
        '
        Me.dashboard_btn.Dock = System.Windows.Forms.DockStyle.Top
        Me.dashboard_btn.FlatAppearance.BorderSize = 0
        Me.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboard_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dashboard_btn.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.dashboard_btn.IconColor = System.Drawing.Color.White
        Me.dashboard_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboard_btn.Location = New System.Drawing.Point(0, 140)
        Me.dashboard_btn.Name = "dashboard_btn"
        Me.dashboard_btn.Size = New System.Drawing.Size(227, 60)
        Me.dashboard_btn.TabIndex = 1
        Me.dashboard_btn.Text = "Dashboard"
        Me.dashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboard_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.dashboard_btn.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.home_btn)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(227, 140)
        Me.PanelLogo.TabIndex = 0
        '
        'home_btn
        '
        Me.home_btn.Image = CType(resources.GetObject("home_btn.Image"), System.Drawing.Image)
        Me.home_btn.Location = New System.Drawing.Point(45, 36)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(141, 69)
        Me.home_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.home_btn.TabIndex = 0
        Me.home_btn.TabStop = False
        '
        'title_panel
        '
        Me.title_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.title_panel.Controls.Add(Me.minimize_btn)
        Me.title_panel.Controls.Add(Me.close_btn)
        Me.title_panel.Controls.Add(Me.home_lbl)
        Me.title_panel.Controls.Add(Me.home_icon_btn)
        Me.title_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.title_panel.Location = New System.Drawing.Point(227, 0)
        Me.title_panel.Name = "title_panel"
        Me.title_panel.Size = New System.Drawing.Size(730, 75)
        Me.title_panel.TabIndex = 1
        '
        'minimize_btn
        '
        Me.minimize_btn.FlatAppearance.BorderSize = 0
        Me.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimize_btn.ForeColor = System.Drawing.Color.White
        Me.minimize_btn.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.minimize_btn.IconColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.minimize_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.minimize_btn.Location = New System.Drawing.Point(650, 31)
        Me.minimize_btn.Name = "minimize_btn"
        Me.minimize_btn.Size = New System.Drawing.Size(29, 24)
        Me.minimize_btn.TabIndex = 3
        Me.minimize_btn.UseVisualStyleBackColor = True
        '
        'close_btn
        '
        Me.close_btn.FlatAppearance.BorderSize = 0
        Me.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_btn.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.close_btn.IconColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.close_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.close_btn.IconSize = 38
        Me.close_btn.Location = New System.Drawing.Point(685, 29)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(33, 34)
        Me.close_btn.TabIndex = 2
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'home_lbl
        '
        Me.home_lbl.AutoSize = True
        Me.home_lbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.home_lbl.Location = New System.Drawing.Point(68, 32)
        Me.home_lbl.Name = "home_lbl"
        Me.home_lbl.Size = New System.Drawing.Size(55, 21)
        Me.home_lbl.TabIndex = 1
        Me.home_lbl.Text = "Home"
        '
        'home_icon_btn
        '
        Me.home_icon_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.home_icon_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.home_icon_btn.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.home_icon_btn.IconColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.home_icon_btn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.home_icon_btn.IconSize = 41
        Me.home_icon_btn.Location = New System.Drawing.Point(17, 22)
        Me.home_icon_btn.Name = "home_icon_btn"
        Me.home_icon_btn.Size = New System.Drawing.Size(45, 41)
        Me.home_icon_btn.TabIndex = 0
        Me.home_icon_btn.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(957, 583)
        Me.ControlBox = False
        Me.Controls.Add(Me.title_panel)
        Me.Controls.Add(ust_Panel)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        ust_Panel.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.home_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.title_panel.ResumeLayout(False)
        Me.title_panel.PerformLayout()
        CType(Me.home_icon_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ust_Panel As Panel
    Friend WithEvents settings_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents marketing_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents costumers_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents products_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents orders_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents dashboard_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents home_btn As PictureBox
    Friend WithEvents title_panel As Panel
    Friend WithEvents home_icon_btn As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents home_lbl As Label
    Friend WithEvents close_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents minimize_btn As FontAwesome.Sharp.IconButton
End Class
