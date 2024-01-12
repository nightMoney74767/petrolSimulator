<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fr_help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fr_help))
        Me.bt_exit = New System.Windows.Forms.Button()
        Me.tabcon_help = New System.Windows.Forms.TabControl()
        Me.tab_intro = New System.Windows.Forms.TabPage()
        Me.pn_pump = New System.Windows.Forms.Panel()
        Me.lb_text_intro = New System.Windows.Forms.Label()
        Me.tab_price = New System.Windows.Forms.TabPage()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lb_text_price = New System.Windows.Forms.Label()
        Me.tab_dispense = New System.Windows.Forms.TabPage()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lb_text_dispensing = New System.Windows.Forms.Label()
        Me.tab_adding_to_totals = New System.Windows.Forms.TabPage()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.lb_text_adding_to_totals = New System.Windows.Forms.Label()
        Me.tab_no_fuel = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lb_text_no_fuel = New System.Windows.Forms.Label()
        Me.tab_reset = New System.Windows.Forms.TabPage()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.lb_text_reset = New System.Windows.Forms.Label()
        Me.tab_new = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabcon_help.SuspendLayout()
        Me.tab_intro.SuspendLayout()
        Me.tab_price.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_dispense.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_adding_to_totals.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_no_fuel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_reset.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_new.SuspendLayout()
        Me.SuspendLayout()
        '
        'bt_exit
        '
        Me.bt_exit.BackColor = System.Drawing.SystemColors.Control
        Me.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bt_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.bt_exit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bt_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_exit.ForeColor = System.Drawing.Color.Red
        Me.bt_exit.Location = New System.Drawing.Point(13, 624)
        Me.bt_exit.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_exit.Name = "bt_exit"
        Me.bt_exit.Size = New System.Drawing.Size(323, 33)
        Me.bt_exit.TabIndex = 5
        Me.bt_exit.Text = "Exit"
        Me.bt_exit.UseVisualStyleBackColor = False
        '
        'tabcon_help
        '
        Me.tabcon_help.Controls.Add(Me.tab_intro)
        Me.tabcon_help.Controls.Add(Me.tab_price)
        Me.tabcon_help.Controls.Add(Me.tab_dispense)
        Me.tabcon_help.Controls.Add(Me.tab_adding_to_totals)
        Me.tabcon_help.Controls.Add(Me.tab_no_fuel)
        Me.tabcon_help.Controls.Add(Me.tab_reset)
        Me.tabcon_help.Controls.Add(Me.tab_new)
        Me.tabcon_help.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabcon_help.Location = New System.Drawing.Point(13, 12)
        Me.tabcon_help.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tabcon_help.Multiline = True
        Me.tabcon_help.Name = "tabcon_help"
        Me.tabcon_help.SelectedIndex = 0
        Me.tabcon_help.Size = New System.Drawing.Size(897, 606)
        Me.tabcon_help.TabIndex = 6
        '
        'tab_intro
        '
        Me.tab_intro.Controls.Add(Me.pn_pump)
        Me.tab_intro.Controls.Add(Me.lb_text_intro)
        Me.tab_intro.Location = New System.Drawing.Point(4, 54)
        Me.tab_intro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_intro.Name = "tab_intro"
        Me.tab_intro.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_intro.Size = New System.Drawing.Size(889, 548)
        Me.tab_intro.TabIndex = 0
        Me.tab_intro.Text = "1) Introduction"
        Me.tab_intro.UseVisualStyleBackColor = True
        '
        'pn_pump
        '
        Me.pn_pump.BackgroundImage = CType(resources.GetObject("pn_pump.BackgroundImage"), System.Drawing.Image)
        Me.pn_pump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pn_pump.Location = New System.Drawing.Point(215, 91)
        Me.pn_pump.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pn_pump.Name = "pn_pump"
        Me.pn_pump.Size = New System.Drawing.Size(460, 410)
        Me.pn_pump.TabIndex = 1
        '
        'lb_text_intro
        '
        Me.lb_text_intro.Location = New System.Drawing.Point(5, 2)
        Me.lb_text_intro.Name = "lb_text_intro"
        Me.lb_text_intro.Size = New System.Drawing.Size(876, 69)
        Me.lb_text_intro.TabIndex = 0
        Me.lb_text_intro.Text = resources.GetString("lb_text_intro.Text")
        '
        'tab_price
        '
        Me.tab_price.Controls.Add(Me.PictureBox9)
        Me.tab_price.Controls.Add(Me.PictureBox4)
        Me.tab_price.Controls.Add(Me.PictureBox3)
        Me.tab_price.Controls.Add(Me.lb_text_price)
        Me.tab_price.Location = New System.Drawing.Point(4, 29)
        Me.tab_price.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_price.Name = "tab_price"
        Me.tab_price.Size = New System.Drawing.Size(889, 573)
        Me.tab_price.TabIndex = 1
        Me.tab_price.Text = "2) Entering the Price"
        Me.tab_price.UseVisualStyleBackColor = True
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(389, 145)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(476, 116)
        Me.PictureBox9.TabIndex = 4
        Me.PictureBox9.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(389, 290)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(467, 218)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(9, 129)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(363, 176)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'lb_text_price
        '
        Me.lb_text_price.Location = New System.Drawing.Point(5, 2)
        Me.lb_text_price.Name = "lb_text_price"
        Me.lb_text_price.Size = New System.Drawing.Size(873, 123)
        Me.lb_text_price.TabIndex = 1
        Me.lb_text_price.Text = resources.GetString("lb_text_price.Text")
        '
        'tab_dispense
        '
        Me.tab_dispense.Controls.Add(Me.PictureBox8)
        Me.tab_dispense.Controls.Add(Me.PictureBox7)
        Me.tab_dispense.Controls.Add(Me.PictureBox6)
        Me.tab_dispense.Controls.Add(Me.PictureBox5)
        Me.tab_dispense.Controls.Add(Me.lb_text_dispensing)
        Me.tab_dispense.Location = New System.Drawing.Point(4, 29)
        Me.tab_dispense.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_dispense.Name = "tab_dispense"
        Me.tab_dispense.Size = New System.Drawing.Size(889, 573)
        Me.tab_dispense.TabIndex = 2
        Me.tab_dispense.Text = "3) Dispensing the Fuel"
        Me.tab_dispense.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(381, 330)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(331, 73)
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(469, 426)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(331, 74)
        Me.PictureBox7.TabIndex = 5
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(508, 197)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(343, 114)
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(9, 197)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(337, 217)
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'lb_text_dispensing
        '
        Me.lb_text_dispensing.Location = New System.Drawing.Point(5, 2)
        Me.lb_text_dispensing.Name = "lb_text_dispensing"
        Me.lb_text_dispensing.Size = New System.Drawing.Size(873, 222)
        Me.lb_text_dispensing.TabIndex = 2
        Me.lb_text_dispensing.Text = resources.GetString("lb_text_dispensing.Text")
        '
        'tab_adding_to_totals
        '
        Me.tab_adding_to_totals.Controls.Add(Me.PictureBox10)
        Me.tab_adding_to_totals.Controls.Add(Me.lb_text_adding_to_totals)
        Me.tab_adding_to_totals.Location = New System.Drawing.Point(4, 29)
        Me.tab_adding_to_totals.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_adding_to_totals.Name = "tab_adding_to_totals"
        Me.tab_adding_to_totals.Size = New System.Drawing.Size(889, 573)
        Me.tab_adding_to_totals.TabIndex = 3
        Me.tab_adding_to_totals.Text = "4) Adding Transactions to Totals"
        Me.tab_adding_to_totals.UseVisualStyleBackColor = True
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(249, 100)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(409, 78)
        Me.PictureBox10.TabIndex = 4
        Me.PictureBox10.TabStop = False
        '
        'lb_text_adding_to_totals
        '
        Me.lb_text_adding_to_totals.Location = New System.Drawing.Point(5, 2)
        Me.lb_text_adding_to_totals.Name = "lb_text_adding_to_totals"
        Me.lb_text_adding_to_totals.Size = New System.Drawing.Size(873, 94)
        Me.lb_text_adding_to_totals.TabIndex = 3
        Me.lb_text_adding_to_totals.Text = resources.GetString("lb_text_adding_to_totals.Text")
        '
        'tab_no_fuel
        '
        Me.tab_no_fuel.Controls.Add(Me.PictureBox2)
        Me.tab_no_fuel.Controls.Add(Me.PictureBox1)
        Me.tab_no_fuel.Controls.Add(Me.lb_text_no_fuel)
        Me.tab_no_fuel.Location = New System.Drawing.Point(4, 54)
        Me.tab_no_fuel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_no_fuel.Name = "tab_no_fuel"
        Me.tab_no_fuel.Size = New System.Drawing.Size(889, 548)
        Me.tab_no_fuel.TabIndex = 4
        Me.tab_no_fuel.Text = "5) When there's no Fuel to Dispense"
        Me.tab_no_fuel.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(289, 302)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(572, 223)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 182)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 112)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lb_text_no_fuel
        '
        Me.lb_text_no_fuel.Location = New System.Drawing.Point(5, 2)
        Me.lb_text_no_fuel.Name = "lb_text_no_fuel"
        Me.lb_text_no_fuel.Size = New System.Drawing.Size(873, 176)
        Me.lb_text_no_fuel.TabIndex = 3
        Me.lb_text_no_fuel.Text = resources.GetString("lb_text_no_fuel.Text")
        '
        'tab_reset
        '
        Me.tab_reset.Controls.Add(Me.PictureBox11)
        Me.tab_reset.Controls.Add(Me.lb_text_reset)
        Me.tab_reset.Location = New System.Drawing.Point(4, 54)
        Me.tab_reset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tab_reset.Name = "tab_reset"
        Me.tab_reset.Size = New System.Drawing.Size(889, 548)
        Me.tab_reset.TabIndex = 5
        Me.tab_reset.Text = "6) Resetting the Simulator"
        Me.tab_reset.UseVisualStyleBackColor = True
        '
        'PictureBox11
        '
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(280, 54)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(383, 108)
        Me.PictureBox11.TabIndex = 1
        Me.PictureBox11.TabStop = False
        '
        'lb_text_reset
        '
        Me.lb_text_reset.Location = New System.Drawing.Point(4, 0)
        Me.lb_text_reset.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_text_reset.Name = "lb_text_reset"
        Me.lb_text_reset.Size = New System.Drawing.Size(873, 78)
        Me.lb_text_reset.TabIndex = 0
        Me.lb_text_reset.Text = resources.GetString("lb_text_reset.Text")
        '
        'tab_new
        '
        Me.tab_new.Controls.Add(Me.Label1)
        Me.tab_new.Location = New System.Drawing.Point(4, 54)
        Me.tab_new.Name = "tab_new"
        Me.tab_new.Size = New System.Drawing.Size(889, 548)
        Me.tab_new.TabIndex = 6
        Me.tab_new.Text = "7) What's New?"
        Me.tab_new.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(876, 182)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'fr_help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(920, 667)
        Me.Controls.Add(Me.tabcon_help)
        Me.Controls.Add(Me.bt_exit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fr_help"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help - Petrol Station Simulator (v2021)"
        Me.tabcon_help.ResumeLayout(False)
        Me.tab_intro.ResumeLayout(False)
        Me.tab_price.ResumeLayout(False)
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_dispense.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_adding_to_totals.ResumeLayout(False)
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_no_fuel.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_reset.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_new.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bt_exit As Button
    Friend WithEvents tabcon_help As TabControl
    Friend WithEvents tab_intro As TabPage
    Friend WithEvents tab_price As TabPage
    Friend WithEvents tab_dispense As TabPage
    Friend WithEvents tab_adding_to_totals As TabPage
    Friend WithEvents tab_no_fuel As TabPage
    Friend WithEvents tab_reset As TabPage
    Friend WithEvents lb_text_intro As Label
    Friend WithEvents pn_pump As Panel
    Friend WithEvents lb_text_price As Label
    Friend WithEvents lb_text_dispensing As Label
    Friend WithEvents lb_text_adding_to_totals As Label
    Friend WithEvents lb_text_no_fuel As Label
    Friend WithEvents lb_text_reset As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents tab_new As TabPage
    Friend WithEvents Label1 As Label
End Class
