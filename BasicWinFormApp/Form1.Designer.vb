<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.dashboard_pnl = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.orders_tbl = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.orders_pnl = New System.Windows.Forms.Panel()
        Me.dashboard_panel_3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dashboard_panel_2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dashboard_panel_1 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cost_predıcted_lbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        ust_Panel = New System.Windows.Forms.Panel()
        ust_Panel.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.home_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.title_panel.SuspendLayout()
        CType(Me.home_icon_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dashboard_pnl.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.orders_tbl.SuspendLayout()
        Me.dashboard_panel_3.SuspendLayout()
        Me.dashboard_panel_2.SuspendLayout()
        Me.dashboard_panel_1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        ust_Panel.Size = New System.Drawing.Size(227, 510)
        ust_Panel.TabIndex = 0
        '
        'settings_btn
        '
        Me.settings_btn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.marketing_btn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.costumers_btn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.products_btn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.orders_btn.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand
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
        'dashboard_pnl
        '
        Me.dashboard_pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.dashboard_pnl.Controls.Add(Me.Panel4)
        Me.dashboard_pnl.Controls.Add(Me.orders_pnl)
        Me.dashboard_pnl.Controls.Add(Me.dashboard_panel_3)
        Me.dashboard_pnl.Controls.Add(Me.dashboard_panel_2)
        Me.dashboard_pnl.Controls.Add(Me.dashboard_panel_1)
        Me.dashboard_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dashboard_pnl.Location = New System.Drawing.Point(227, 75)
        Me.dashboard_pnl.Name = "dashboard_pnl"
        Me.dashboard_pnl.Size = New System.Drawing.Size(730, 435)
        Me.dashboard_pnl.TabIndex = 2
        Me.dashboard_pnl.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel4.Controls.Add(Me.orders_tbl)
        Me.Panel4.Location = New System.Drawing.Point(34, 18)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(665, 394)
        Me.Panel4.TabIndex = 0
        '
        'orders_tbl
        '
        Me.orders_tbl.ColumnCount = 5
        Me.orders_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.58943!))
        Me.orders_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.98947!))
        Me.orders_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.81012!))
        Me.orders_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.22113!))
        Me.orders_tbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.38985!))
        Me.orders_tbl.Controls.Add(Me.Label7, 4, 0)
        Me.orders_tbl.Controls.Add(Me.Label6, 3, 0)
        Me.orders_tbl.Controls.Add(Me.Label5, 2, 0)
        Me.orders_tbl.Controls.Add(Me.Label4, 1, 0)
        Me.orders_tbl.Controls.Add(Me.Label3, 0, 0)
        Me.orders_tbl.Location = New System.Drawing.Point(0, 0)
        Me.orders_tbl.Name = "orders_tbl"
        Me.orders_tbl.RowCount = 2
        Me.orders_tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.67513!))
        Me.orders_tbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.32487!))
        Me.orders_tbl.Size = New System.Drawing.Size(665, 394)
        Me.orders_tbl.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(590, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 46)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Country"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(523, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 46)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(345, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 46)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Status"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(179, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 46)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Date"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 46)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Orders"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'orders_pnl
        '
        Me.orders_pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.orders_pnl.Location = New System.Drawing.Point(0, 0)
        Me.orders_pnl.Name = "orders_pnl"
        Me.orders_pnl.Size = New System.Drawing.Size(730, 435)
        Me.orders_pnl.TabIndex = 3
        Me.orders_pnl.Visible = False
        '
        'dashboard_panel_3
        '
        Me.dashboard_panel_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dashboard_panel_3.Controls.Add(Me.Panel2)
        Me.dashboard_panel_3.Controls.Add(Me.Label1)
        Me.dashboard_panel_3.Location = New System.Drawing.Point(380, 18)
        Me.dashboard_panel_3.Name = "dashboard_panel_3"
        Me.dashboard_panel_3.Size = New System.Drawing.Size(312, 394)
        Me.dashboard_panel_3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 4)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COST PREDICTED"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dashboard_panel_2
        '
        Me.dashboard_panel_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dashboard_panel_2.Controls.Add(Me.Panel3)
        Me.dashboard_panel_2.Controls.Add(Me.Label2)
        Me.dashboard_panel_2.Location = New System.Drawing.Point(34, 237)
        Me.dashboard_panel_2.Name = "dashboard_panel_2"
        Me.dashboard_panel_2.Size = New System.Drawing.Size(302, 175)
        Me.dashboard_panel_2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(302, 4)
        Me.Panel3.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "USAGE ESTIMATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dashboard_panel_1
        '
        Me.dashboard_panel_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dashboard_panel_1.Controls.Add(Me.Panel1)
        Me.dashboard_panel_1.Controls.Add(Me.cost_predıcted_lbl)
        Me.dashboard_panel_1.Location = New System.Drawing.Point(34, 18)
        Me.dashboard_panel_1.Name = "dashboard_panel_1"
        Me.dashboard_panel_1.Size = New System.Drawing.Size(302, 204)
        Me.dashboard_panel_1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 4)
        Me.Panel1.TabIndex = 1
        '
        'cost_predıcted_lbl
        '
        Me.cost_predıcted_lbl.AutoSize = True
        Me.cost_predıcted_lbl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cost_predıcted_lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.cost_predıcted_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cost_predıcted_lbl.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cost_predıcted_lbl.ForeColor = System.Drawing.Color.Silver
        Me.cost_predıcted_lbl.Location = New System.Drawing.Point(0, 0)
        Me.cost_predıcted_lbl.Name = "cost_predıcted_lbl"
        Me.cost_predıcted_lbl.Size = New System.Drawing.Size(176, 30)
        Me.cost_predıcted_lbl.TabIndex = 0
        Me.cost_predıcted_lbl.Text = "COST PREDICTED"
        Me.cost_predıcted_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(358, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(451, 293)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(957, 510)
        Me.ControlBox = False
        Me.Controls.Add(Me.dashboard_pnl)
        Me.Controls.Add(Me.title_panel)
        Me.Controls.Add(ust_Panel)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        Me.dashboard_pnl.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.orders_tbl.ResumeLayout(False)
        Me.orders_tbl.PerformLayout()
        Me.dashboard_panel_3.ResumeLayout(False)
        Me.dashboard_panel_3.PerformLayout()
        Me.dashboard_panel_2.ResumeLayout(False)
        Me.dashboard_panel_2.PerformLayout()
        Me.dashboard_panel_1.ResumeLayout(False)
        Me.dashboard_panel_1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dashboard_pnl As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dashboard_panel_3 As Panel
    Friend WithEvents dashboard_panel_2 As Panel
    Friend WithEvents dashboard_panel_1 As Panel
    Friend WithEvents cost_predıcted_lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents orders_pnl As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents orders_tbl As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
