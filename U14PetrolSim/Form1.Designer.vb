<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fr_main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fr_main))
        Me.lb_title = New System.Windows.Forms.Label()
        Me.gb_stats = New System.Windows.Forms.GroupBox()
        Me.lb_2dp_pound = New System.Windows.Forms.Label()
        Me.lb_2dp_value = New System.Windows.Forms.Label()
        Me.lb_fuel_remaining_value = New System.Windows.Forms.Label()
        Me.lb_total_fuel_litres = New System.Windows.Forms.Label()
        Me.lb_fuel_dispensed_litres = New System.Windows.Forms.Label()
        Me.lb_total_money_pound = New System.Windows.Forms.Label()
        Me.lb_amount_to_pay_pound = New System.Windows.Forms.Label()
        Me.lb_price_per_litre_pound = New System.Windows.Forms.Label()
        Me.lb_not_in_use = New System.Windows.Forms.Label()
        Me.lb_in_use = New System.Windows.Forms.Label()
        Me.lb_total_money_value = New System.Windows.Forms.Label()
        Me.lb_total_fuel_value = New System.Windows.Forms.Label()
        Me.lb_amount_to_pay_value = New System.Windows.Forms.Label()
        Me.lb_fuel_dispensed_value = New System.Windows.Forms.Label()
        Me.lb_0litres = New System.Windows.Forms.Label()
        Me.lb_100litres = New System.Windows.Forms.Label()
        Me.pb_fuel_remaining = New System.Windows.Forms.ProgressBar()
        Me.lb_of_100 = New System.Windows.Forms.Label()
        Me.lb_fuel_remaining = New System.Windows.Forms.Label()
        Me.lb_status = New System.Windows.Forms.Label()
        Me.lb_total_fuel = New System.Windows.Forms.Label()
        Me.lb_total_money = New System.Windows.Forms.Label()
        Me.lb_amount_to_pay = New System.Windows.Forms.Label()
        Me.lb_fuel_dispensed = New System.Windows.Forms.Label()
        Me.tb_price_per_litre = New System.Windows.Forms.TextBox()
        Me.lb_price_per_litre = New System.Windows.Forms.Label()
        Me.gb_instructions = New System.Windows.Forms.GroupBox()
        Me.bt_help = New System.Windows.Forms.Button()
        Me.lb_instructions = New System.Windows.Forms.Label()
        Me.bt_stop = New System.Windows.Forms.Button()
        Me.bt_dispense = New System.Windows.Forms.Button()
        Me.bt_reset = New System.Windows.Forms.Button()
        Me.bt_add = New System.Windows.Forms.Button()
        Me.tim_dispense = New System.Windows.Forms.Timer(Me.components)
        Me.tip_price = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_fuel_dispensed = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_amount_to_pay = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_total_fuel = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_total_money = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_status = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_fuel_remaining = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_help = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_stop = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_dispense = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_add = New System.Windows.Forms.ToolTip(Me.components)
        Me.tip_reset = New System.Windows.Forms.ToolTip(Me.components)
        Me.gb_stats.SuspendLayout()
        Me.gb_instructions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_title
        '
        Me.lb_title.AutoSize = True
        Me.lb_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_title.Location = New System.Drawing.Point(105, 10)
        Me.lb_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_title.Name = "lb_title"
        Me.lb_title.Size = New System.Drawing.Size(374, 39)
        Me.lb_title.TabIndex = 0
        Me.lb_title.Text = "Petrol Station Simulator"
        '
        'gb_stats
        '
        Me.gb_stats.Controls.Add(Me.lb_2dp_pound)
        Me.gb_stats.Controls.Add(Me.lb_2dp_value)
        Me.gb_stats.Controls.Add(Me.lb_fuel_remaining_value)
        Me.gb_stats.Controls.Add(Me.lb_total_fuel_litres)
        Me.gb_stats.Controls.Add(Me.lb_fuel_dispensed_litres)
        Me.gb_stats.Controls.Add(Me.lb_total_money_pound)
        Me.gb_stats.Controls.Add(Me.lb_amount_to_pay_pound)
        Me.gb_stats.Controls.Add(Me.lb_price_per_litre_pound)
        Me.gb_stats.Controls.Add(Me.lb_not_in_use)
        Me.gb_stats.Controls.Add(Me.lb_in_use)
        Me.gb_stats.Controls.Add(Me.lb_total_money_value)
        Me.gb_stats.Controls.Add(Me.lb_total_fuel_value)
        Me.gb_stats.Controls.Add(Me.lb_amount_to_pay_value)
        Me.gb_stats.Controls.Add(Me.lb_fuel_dispensed_value)
        Me.gb_stats.Controls.Add(Me.lb_0litres)
        Me.gb_stats.Controls.Add(Me.lb_100litres)
        Me.gb_stats.Controls.Add(Me.pb_fuel_remaining)
        Me.gb_stats.Controls.Add(Me.lb_of_100)
        Me.gb_stats.Controls.Add(Me.lb_fuel_remaining)
        Me.gb_stats.Controls.Add(Me.lb_status)
        Me.gb_stats.Controls.Add(Me.lb_total_fuel)
        Me.gb_stats.Controls.Add(Me.lb_total_money)
        Me.gb_stats.Controls.Add(Me.lb_amount_to_pay)
        Me.gb_stats.Controls.Add(Me.lb_fuel_dispensed)
        Me.gb_stats.Controls.Add(Me.tb_price_per_litre)
        Me.gb_stats.Controls.Add(Me.lb_price_per_litre)
        Me.gb_stats.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_stats.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gb_stats.Location = New System.Drawing.Point(16, 53)
        Me.gb_stats.Margin = New System.Windows.Forms.Padding(4)
        Me.gb_stats.Name = "gb_stats"
        Me.gb_stats.Padding = New System.Windows.Forms.Padding(4)
        Me.gb_stats.Size = New System.Drawing.Size(323, 351)
        Me.gb_stats.TabIndex = 1
        Me.gb_stats.TabStop = False
        Me.gb_stats.Text = "Stats"
        '
        'lb_2dp_pound
        '
        Me.lb_2dp_pound.AutoSize = True
        Me.lb_2dp_pound.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2dp_pound.Location = New System.Drawing.Point(147, 87)
        Me.lb_2dp_pound.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_2dp_pound.Name = "lb_2dp_pound"
        Me.lb_2dp_pound.Size = New System.Drawing.Size(18, 20)
        Me.lb_2dp_pound.TabIndex = 34
        Me.lb_2dp_pound.Text = "£"
        '
        'lb_2dp_value
        '
        Me.lb_2dp_value.AutoSize = True
        Me.lb_2dp_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_2dp_value.Location = New System.Drawing.Point(177, 87)
        Me.lb_2dp_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_2dp_value.Name = "lb_2dp_value"
        Me.lb_2dp_value.Size = New System.Drawing.Size(40, 20)
        Me.lb_2dp_value.TabIndex = 33
        Me.lb_2dp_value.Text = "0.00"
        '
        'lb_fuel_remaining_value
        '
        Me.lb_fuel_remaining_value.AutoSize = True
        Me.lb_fuel_remaining_value.ForeColor = System.Drawing.Color.Green
        Me.lb_fuel_remaining_value.Location = New System.Drawing.Point(147, 249)
        Me.lb_fuel_remaining_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_fuel_remaining_value.Name = "lb_fuel_remaining_value"
        Me.lb_fuel_remaining_value.Size = New System.Drawing.Size(51, 20)
        Me.lb_fuel_remaining_value.TabIndex = 31
        Me.lb_fuel_remaining_value.Text = "FULL"
        '
        'lb_total_fuel_litres
        '
        Me.lb_total_fuel_litres.AutoSize = True
        Me.lb_total_fuel_litres.Location = New System.Drawing.Point(267, 116)
        Me.lb_total_fuel_litres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_total_fuel_litres.Name = "lb_total_fuel_litres"
        Me.lb_total_fuel_litres.Size = New System.Drawing.Size(46, 20)
        Me.lb_total_fuel_litres.TabIndex = 30
        Me.lb_total_fuel_litres.Text = "litres"
        '
        'lb_fuel_dispensed_litres
        '
        Me.lb_fuel_dispensed_litres.AutoSize = True
        Me.lb_fuel_dispensed_litres.Location = New System.Drawing.Point(267, 57)
        Me.lb_fuel_dispensed_litres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_fuel_dispensed_litres.Name = "lb_fuel_dispensed_litres"
        Me.lb_fuel_dispensed_litres.Size = New System.Drawing.Size(46, 20)
        Me.lb_fuel_dispensed_litres.TabIndex = 29
        Me.lb_fuel_dispensed_litres.Text = "litres"
        '
        'lb_total_money_pound
        '
        Me.lb_total_money_pound.AutoSize = True
        Me.lb_total_money_pound.Location = New System.Drawing.Point(145, 149)
        Me.lb_total_money_pound.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_total_money_pound.Name = "lb_total_money_pound"
        Me.lb_total_money_pound.Size = New System.Drawing.Size(18, 20)
        Me.lb_total_money_pound.TabIndex = 28
        Me.lb_total_money_pound.Text = "£"
        '
        'lb_amount_to_pay_pound
        '
        Me.lb_amount_to_pay_pound.AutoSize = True
        Me.lb_amount_to_pay_pound.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_amount_to_pay_pound.Location = New System.Drawing.Point(253, 87)
        Me.lb_amount_to_pay_pound.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_amount_to_pay_pound.Name = "lb_amount_to_pay_pound"
        Me.lb_amount_to_pay_pound.Size = New System.Drawing.Size(16, 17)
        Me.lb_amount_to_pay_pound.TabIndex = 27
        Me.lb_amount_to_pay_pound.Text = "£"
        Me.lb_amount_to_pay_pound.Visible = False
        '
        'lb_price_per_litre_pound
        '
        Me.lb_price_per_litre_pound.AutoSize = True
        Me.lb_price_per_litre_pound.Location = New System.Drawing.Point(145, 25)
        Me.lb_price_per_litre_pound.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_price_per_litre_pound.Name = "lb_price_per_litre_pound"
        Me.lb_price_per_litre_pound.Size = New System.Drawing.Size(18, 20)
        Me.lb_price_per_litre_pound.TabIndex = 26
        Me.lb_price_per_litre_pound.Text = "£"
        '
        'lb_not_in_use
        '
        Me.lb_not_in_use.AutoSize = True
        Me.lb_not_in_use.Enabled = False
        Me.lb_not_in_use.ForeColor = System.Drawing.Color.Red
        Me.lb_not_in_use.Location = New System.Drawing.Point(145, 214)
        Me.lb_not_in_use.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_not_in_use.Name = "lb_not_in_use"
        Me.lb_not_in_use.Size = New System.Drawing.Size(97, 20)
        Me.lb_not_in_use.TabIndex = 25
        Me.lb_not_in_use.Text = "NOT In Use"
        '
        'lb_in_use
        '
        Me.lb_in_use.AutoSize = True
        Me.lb_in_use.Enabled = False
        Me.lb_in_use.ForeColor = System.Drawing.Color.Green
        Me.lb_in_use.Location = New System.Drawing.Point(147, 182)
        Me.lb_in_use.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_in_use.Name = "lb_in_use"
        Me.lb_in_use.Size = New System.Drawing.Size(57, 20)
        Me.lb_in_use.TabIndex = 24
        Me.lb_in_use.Text = "In Use"
        '
        'lb_total_money_value
        '
        Me.lb_total_money_value.AutoSize = True
        Me.lb_total_money_value.Location = New System.Drawing.Point(177, 149)
        Me.lb_total_money_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_total_money_value.Name = "lb_total_money_value"
        Me.lb_total_money_value.Size = New System.Drawing.Size(40, 20)
        Me.lb_total_money_value.TabIndex = 23
        Me.lb_total_money_value.Text = "0.00"
        '
        'lb_total_fuel_value
        '
        Me.lb_total_fuel_value.AutoSize = True
        Me.lb_total_fuel_value.Location = New System.Drawing.Point(177, 116)
        Me.lb_total_fuel_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_total_fuel_value.Name = "lb_total_fuel_value"
        Me.lb_total_fuel_value.Size = New System.Drawing.Size(40, 20)
        Me.lb_total_fuel_value.TabIndex = 22
        Me.lb_total_fuel_value.Text = "0.00"
        '
        'lb_amount_to_pay_value
        '
        Me.lb_amount_to_pay_value.AutoSize = True
        Me.lb_amount_to_pay_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_amount_to_pay_value.Location = New System.Drawing.Point(277, 87)
        Me.lb_amount_to_pay_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_amount_to_pay_value.Name = "lb_amount_to_pay_value"
        Me.lb_amount_to_pay_value.Size = New System.Drawing.Size(36, 17)
        Me.lb_amount_to_pay_value.TabIndex = 21
        Me.lb_amount_to_pay_value.Text = "0.00"
        Me.lb_amount_to_pay_value.Visible = False
        '
        'lb_fuel_dispensed_value
        '
        Me.lb_fuel_dispensed_value.AutoSize = True
        Me.lb_fuel_dispensed_value.Location = New System.Drawing.Point(177, 57)
        Me.lb_fuel_dispensed_value.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_fuel_dispensed_value.Name = "lb_fuel_dispensed_value"
        Me.lb_fuel_dispensed_value.Size = New System.Drawing.Size(40, 20)
        Me.lb_fuel_dispensed_value.TabIndex = 20
        Me.lb_fuel_dispensed_value.Text = "0.00"
        '
        'lb_0litres
        '
        Me.lb_0litres.AutoSize = True
        Me.lb_0litres.Location = New System.Drawing.Point(8, 314)
        Me.lb_0litres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_0litres.Name = "lb_0litres"
        Me.lb_0litres.Size = New System.Drawing.Size(60, 20)
        Me.lb_0litres.TabIndex = 19
        Me.lb_0litres.Text = "0 litres"
        '
        'lb_100litres
        '
        Me.lb_100litres.AutoSize = True
        Me.lb_100litres.Location = New System.Drawing.Point(227, 314)
        Me.lb_100litres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_100litres.Name = "lb_100litres"
        Me.lb_100litres.Size = New System.Drawing.Size(78, 20)
        Me.lb_100litres.TabIndex = 18
        Me.lb_100litres.Text = "100 litres"
        '
        'pb_fuel_remaining
        '
        Me.pb_fuel_remaining.BackColor = System.Drawing.Color.White
        Me.pb_fuel_remaining.Location = New System.Drawing.Point(11, 282)
        Me.pb_fuel_remaining.Margin = New System.Windows.Forms.Padding(4)
        Me.pb_fuel_remaining.MarqueeAnimationSpeed = 1
        Me.pb_fuel_remaining.Maximum = 10000
        Me.pb_fuel_remaining.Name = "pb_fuel_remaining"
        Me.pb_fuel_remaining.Size = New System.Drawing.Size(304, 28)
        Me.pb_fuel_remaining.Step = -1
        Me.pb_fuel_remaining.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pb_fuel_remaining.TabIndex = 17
        Me.pb_fuel_remaining.Value = 10000
        '
        'lb_of_100
        '
        Me.lb_of_100.AutoSize = True
        Me.lb_of_100.Location = New System.Drawing.Point(216, 249)
        Me.lb_of_100.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_of_100.Name = "lb_of_100"
        Me.lb_of_100.Size = New System.Drawing.Size(88, 20)
        Me.lb_of_100.TabIndex = 16
        Me.lb_of_100.Text = "/ 100 litres"
        '
        'lb_fuel_remaining
        '
        Me.lb_fuel_remaining.AutoSize = True
        Me.lb_fuel_remaining.Location = New System.Drawing.Point(8, 249)
        Me.lb_fuel_remaining.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_fuel_remaining.Name = "lb_fuel_remaining"
        Me.lb_fuel_remaining.Size = New System.Drawing.Size(119, 20)
        Me.lb_fuel_remaining.TabIndex = 9
        Me.lb_fuel_remaining.Text = "Fuel remaining"
        '
        'lb_status
        '
        Me.lb_status.AutoSize = True
        Me.lb_status.Location = New System.Drawing.Point(8, 182)
        Me.lb_status.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_status.Name = "lb_status"
        Me.lb_status.Size = New System.Drawing.Size(57, 20)
        Me.lb_status.TabIndex = 8
        Me.lb_status.Text = "Status"
        '
        'lb_total_fuel
        '
        Me.lb_total_fuel.AutoSize = True
        Me.lb_total_fuel.Location = New System.Drawing.Point(8, 116)
        Me.lb_total_fuel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_total_fuel.Name = "lb_total_fuel"
        Me.lb_total_fuel.Size = New System.Drawing.Size(78, 20)
        Me.lb_total_fuel.TabIndex = 7
        Me.lb_total_fuel.Text = "Total fuel"
        '
        'lb_total_money
        '
        Me.lb_total_money.AutoSize = True
        Me.lb_total_money.Location = New System.Drawing.Point(8, 149)
        Me.lb_total_money.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_total_money.Name = "lb_total_money"
        Me.lb_total_money.Size = New System.Drawing.Size(100, 20)
        Me.lb_total_money.TabIndex = 6
        Me.lb_total_money.Text = "Total money"
        '
        'lb_amount_to_pay
        '
        Me.lb_amount_to_pay.AutoSize = True
        Me.lb_amount_to_pay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_amount_to_pay.Location = New System.Drawing.Point(8, 87)
        Me.lb_amount_to_pay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_amount_to_pay.Name = "lb_amount_to_pay"
        Me.lb_amount_to_pay.Size = New System.Drawing.Size(116, 20)
        Me.lb_amount_to_pay.TabIndex = 5
        Me.lb_amount_to_pay.Text = "Amount to pay"
        '
        'lb_fuel_dispensed
        '
        Me.lb_fuel_dispensed.AutoSize = True
        Me.lb_fuel_dispensed.Location = New System.Drawing.Point(8, 57)
        Me.lb_fuel_dispensed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_fuel_dispensed.Name = "lb_fuel_dispensed"
        Me.lb_fuel_dispensed.Size = New System.Drawing.Size(122, 20)
        Me.lb_fuel_dispensed.TabIndex = 4
        Me.lb_fuel_dispensed.Text = "Fuel dispensed"
        '
        'tb_price_per_litre
        '
        Me.tb_price_per_litre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_price_per_litre.Location = New System.Drawing.Point(168, 20)
        Me.tb_price_per_litre.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_price_per_litre.Name = "tb_price_per_litre"
        Me.tb_price_per_litre.Size = New System.Drawing.Size(146, 27)
        Me.tb_price_per_litre.TabIndex = 3
        '
        'lb_price_per_litre
        '
        Me.lb_price_per_litre.AutoSize = True
        Me.lb_price_per_litre.Location = New System.Drawing.Point(8, 25)
        Me.lb_price_per_litre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_price_per_litre.Name = "lb_price_per_litre"
        Me.lb_price_per_litre.Size = New System.Drawing.Size(110, 20)
        Me.lb_price_per_litre.TabIndex = 2
        Me.lb_price_per_litre.Text = "Price per litre"
        '
        'gb_instructions
        '
        Me.gb_instructions.Controls.Add(Me.bt_help)
        Me.gb_instructions.Controls.Add(Me.lb_instructions)
        Me.gb_instructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_instructions.Location = New System.Drawing.Point(347, 53)
        Me.gb_instructions.Margin = New System.Windows.Forms.Padding(4)
        Me.gb_instructions.Name = "gb_instructions"
        Me.gb_instructions.Padding = New System.Windows.Forms.Padding(4)
        Me.gb_instructions.Size = New System.Drawing.Size(323, 351)
        Me.gb_instructions.TabIndex = 2
        Me.gb_instructions.TabStop = False
        Me.gb_instructions.Text = "Instructions"
        '
        'bt_help
        '
        Me.bt_help.BackColor = System.Drawing.SystemColors.Control
        Me.bt_help.Cursor = System.Windows.Forms.Cursors.Help
        Me.bt_help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.bt_help.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bt_help.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_help.ForeColor = System.Drawing.Color.Blue
        Me.bt_help.Location = New System.Drawing.Point(0, 298)
        Me.bt_help.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_help.Name = "bt_help"
        Me.bt_help.Size = New System.Drawing.Size(323, 33)
        Me.bt_help.TabIndex = 5
        Me.bt_help.Text = "Help"
        Me.bt_help.UseVisualStyleBackColor = False
        '
        'lb_instructions
        '
        Me.lb_instructions.AutoSize = True
        Me.lb_instructions.Location = New System.Drawing.Point(5, 25)
        Me.lb_instructions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_instructions.Name = "lb_instructions"
        Me.lb_instructions.Size = New System.Drawing.Size(292, 260)
        Me.lb_instructions.TabIndex = 0
        Me.lb_instructions.Text = resources.GetString("lb_instructions.Text")
        '
        'bt_stop
        '
        Me.bt_stop.BackColor = System.Drawing.SystemColors.Control
        Me.bt_stop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_stop.Enabled = False
        Me.bt_stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.bt_stop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bt_stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_stop.ForeColor = System.Drawing.Color.Red
        Me.bt_stop.Location = New System.Drawing.Point(347, 411)
        Me.bt_stop.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_stop.Name = "bt_stop"
        Me.bt_stop.Size = New System.Drawing.Size(323, 33)
        Me.bt_stop.TabIndex = 4
        Me.bt_stop.Text = "Stop"
        Me.bt_stop.UseVisualStyleBackColor = False
        '
        'bt_dispense
        '
        Me.bt_dispense.BackColor = System.Drawing.SystemColors.Control
        Me.bt_dispense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_dispense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.bt_dispense.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bt_dispense.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_dispense.ForeColor = System.Drawing.Color.Green
        Me.bt_dispense.Location = New System.Drawing.Point(16, 411)
        Me.bt_dispense.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_dispense.Name = "bt_dispense"
        Me.bt_dispense.Size = New System.Drawing.Size(323, 33)
        Me.bt_dispense.TabIndex = 3
        Me.bt_dispense.Text = "Dispense"
        Me.bt_dispense.UseVisualStyleBackColor = False
        '
        'bt_reset
        '
        Me.bt_reset.BackColor = System.Drawing.SystemColors.Control
        Me.bt_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.bt_reset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bt_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_reset.Location = New System.Drawing.Point(347, 452)
        Me.bt_reset.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_reset.Name = "bt_reset"
        Me.bt_reset.Size = New System.Drawing.Size(323, 33)
        Me.bt_reset.TabIndex = 2
        Me.bt_reset.Text = "Reset"
        Me.bt_reset.UseVisualStyleBackColor = False
        '
        'bt_add
        '
        Me.bt_add.BackColor = System.Drawing.SystemColors.Control
        Me.bt_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_add.Enabled = False
        Me.bt_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bt_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bt_add.Location = New System.Drawing.Point(16, 452)
        Me.bt_add.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_add.Name = "bt_add"
        Me.bt_add.Size = New System.Drawing.Size(323, 33)
        Me.bt_add.TabIndex = 1
        Me.bt_add.Text = "Add to Totals"
        Me.bt_add.UseVisualStyleBackColor = False
        '
        'tim_dispense
        '
        Me.tim_dispense.Interval = 1
        '
        'tip_price
        '
        Me.tip_price.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_price.ToolTipTitle = "Price Per Litre"
        '
        'tip_fuel_dispensed
        '
        Me.tip_fuel_dispensed.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_fuel_dispensed.ToolTipTitle = "Fuel Dispensed"
        '
        'tip_amount_to_pay
        '
        Me.tip_amount_to_pay.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_amount_to_pay.ToolTipTitle = "Amount to Pay"
        '
        'tip_total_fuel
        '
        Me.tip_total_fuel.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_total_fuel.ToolTipTitle = "Total Fuel"
        '
        'tip_total_money
        '
        Me.tip_total_money.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_total_money.ToolTipTitle = "Total Money"
        '
        'tip_status
        '
        Me.tip_status.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_status.ToolTipTitle = "Status"
        '
        'tip_fuel_remaining
        '
        Me.tip_fuel_remaining.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_fuel_remaining.ToolTipTitle = "Fuel Remaining"
        '
        'tip_help
        '
        Me.tip_help.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_help.ToolTipTitle = "Help"
        '
        'tip_stop
        '
        Me.tip_stop.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_stop.ToolTipTitle = "Stop"
        '
        'tip_dispense
        '
        Me.tip_dispense.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_dispense.ToolTipTitle = "Dispense"
        '
        'tip_add
        '
        Me.tip_add.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_add.ToolTipTitle = "Add to Totals"
        '
        'tip_reset
        '
        Me.tip_reset.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.tip_reset.ToolTipTitle = "Reset"
        '
        'fr_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(681, 503)
        Me.Controls.Add(Me.bt_stop)
        Me.Controls.Add(Me.gb_instructions)
        Me.Controls.Add(Me.bt_reset)
        Me.Controls.Add(Me.bt_dispense)
        Me.Controls.Add(Me.bt_add)
        Me.Controls.Add(Me.gb_stats)
        Me.Controls.Add(Me.lb_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "fr_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Petrol Station Simulator (v2021)"
        Me.gb_stats.ResumeLayout(False)
        Me.gb_stats.PerformLayout()
        Me.gb_instructions.ResumeLayout(False)
        Me.gb_instructions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_title As Label
    Friend WithEvents gb_stats As GroupBox
    Friend WithEvents lb_fuel_remaining As Label
    Friend WithEvents lb_status As Label
    Friend WithEvents lb_total_fuel As Label
    Friend WithEvents lb_total_money As Label
    Friend WithEvents lb_amount_to_pay As Label
    Friend WithEvents lb_fuel_dispensed As Label
    Friend WithEvents tb_price_per_litre As TextBox
    Friend WithEvents lb_price_per_litre As Label
    Friend WithEvents gb_instructions As GroupBox
    Friend WithEvents lb_instructions As Label
    Friend WithEvents lb_of_100 As Label
    Friend WithEvents pb_fuel_remaining As ProgressBar
    Friend WithEvents lb_0litres As Label
    Friend WithEvents lb_100litres As Label
    Friend WithEvents bt_reset As Button
    Friend WithEvents bt_add As Button
    Friend WithEvents lb_total_money_pound As Label
    Friend WithEvents lb_amount_to_pay_pound As Label
    Friend WithEvents lb_price_per_litre_pound As Label
    Friend WithEvents lb_not_in_use As Label
    Friend WithEvents lb_in_use As Label
    Friend WithEvents lb_total_money_value As Label
    Friend WithEvents lb_total_fuel_value As Label
    Friend WithEvents lb_amount_to_pay_value As Label
    Friend WithEvents lb_fuel_dispensed_value As Label
    Friend WithEvents lb_total_fuel_litres As Label
    Friend WithEvents lb_fuel_dispensed_litres As Label
    Friend WithEvents lb_fuel_remaining_value As Label
    Friend WithEvents bt_dispense As Button
    Friend WithEvents tim_dispense As Timer
    Friend WithEvents bt_stop As Button
    Friend WithEvents lb_2dp_value As Label
    Friend WithEvents lb_2dp_pound As Label
    Friend WithEvents bt_help As Button
    Friend WithEvents tip_price As ToolTip
    Friend WithEvents tip_fuel_dispensed As ToolTip
    Friend WithEvents tip_amount_to_pay As ToolTip
    Friend WithEvents tip_total_fuel As ToolTip
    Friend WithEvents tip_total_money As ToolTip
    Friend WithEvents tip_status As ToolTip
    Friend WithEvents tip_fuel_remaining As ToolTip
    Friend WithEvents tip_help As ToolTip
    Friend WithEvents tip_stop As ToolTip
    Friend WithEvents tip_dispense As ToolTip
    Friend WithEvents tip_add As ToolTip
    Friend WithEvents tip_reset As ToolTip
End Class
