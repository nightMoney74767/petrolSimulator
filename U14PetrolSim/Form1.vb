Public Class fr_main
    'for latest changes, search for "/2021" in the source files
    'where the text colour for a control is set to black, it instead uses the ControlText system colour (to observe high contrast themes)
    'app.manifest added
    'Declaring variables with data type Decimal
    Dim var_price_per_litre As Decimal 'Price per litre
    Dim var_fuel_dispensed As Decimal 'Fuel dispensed
    Dim var_amount_to_pay As Decimal 'Amount to pay
    Dim var_2_dp As Decimal 'Amount to pay to 2 decimal places
    Dim var_total_fuel As Decimal 'Total fuel dispensed for all transactions
    Dim var_total_money As Decimal 'Total amount of money made for all transactions
    Dim var_fuel_remaining As Decimal 'Amount of fuel remaining. Decreases.

    Sub pro_default() 'Procedure that sets the default values when reset button is clicked or the form loads
        lb_of_100.Visible = False 'Hides label lb_of_100
        lb_fuel_remaining_value.ForeColor = Color.Green 'changes text colour of lb_fuel_remaining_value to green.
        var_fuel_dispensed = 0 'sets value of variable to 0
        var_amount_to_pay = 0 'sets value of variable to 0
        var_2_dp = 0 'sets value of variable to 0
        var_total_fuel = 0 'sets value of variable to 0
        var_total_money = 0 'sets value of variable to 0
        var_fuel_remaining = 100 'sets value of variable to 100
        lb_fuel_remaining_value.Text = "FULL" 'sets the text of label lb_fuel_remaining_value to FULL.
        pb_fuel_remaining.Value = 10000 'sets value of progress bar to 10000
        tb_price_per_litre.Text = "" 'Makes the textbox blank.
        bt_add.Enabled = False 'Disables button bt_add
        bt_reset.Enabled = False 'Disables button bt_reset
        bt_dispense.Enabled = True 'Enables button bt_dispense
        bt_stop.Enabled = False 'Disables button bt_stop
        tb_price_per_litre.Enabled = True 'Disables text box
        lb_not_in_use.Text = "NOT In Use" 'Sets the text of label lb_not_in_use to NOT In Use
        pro_update() 'Triggers label update procedure
        pro_not_in_use() 'Triggers not in use procedure
    End Sub

    Sub pro_dispense() 'Procedure that occurs when user is refuelling
        If IsNumeric(tb_price_per_litre.Text) Then 'if the text in texbox is a number
            lb_of_100.Visible = True 'makes label lb_of_100 appear
            lb_fuel_remaining_value.ForeColor = SystemColors.ControlText 'Sets the text colour of lb_fuel_remaining_value to black
            tim_dispense.Enabled = True 'Starts the timer
            bt_dispense.Enabled = False 'Disables button bt_dispense
            bt_stop.Enabled = True 'Enables button bt_stop
            bt_reset.Enabled = False 'Disables button bt_reset
            bt_add.Enabled = False 'Disables button bt_add
            tb_price_per_litre.Enabled = False 'Disables text box
            tb_price_per_litre.ForeColor = SystemColors.ControlText 'Sets font colour of text box to black
            lb_price_per_litre.ForeColor = SystemColors.ControlText 'Sets the font colour of label lb_price_per_litre to black
            lb_price_per_litre_pound.ForeColor = SystemColors.ControlText 'Sets the font colour of label lb_price_per_litre_pound to black
            pro_in_use() 'Triggers in use procedure
        Else
            pro_error() 'Triggers error procedure
        End If
    End Sub

    Sub pro_stop() 'Procedure that occurs when user stops refuelling
        tim_dispense.Stop() 'Stops timer
        bt_dispense.Enabled = True 'Enables button bt_dispense
        bt_stop.Enabled = False 'Disables button bt_stop
        bt_add.Enabled = True 'Enables button bt_add
        bt_reset.Enabled = True 'Enables button by_reset
        pro_not_in_use() 'Triggers in use procedure
        If var_fuel_remaining = 0 Then 'If the value of variable var_fuel_remaining is 0
            bt_dispense.Enabled = False 'Disables button bt_dispense

        End If
    End Sub

    Sub pro_add() 'Procedure that occurs when a user clicks add to totals to save a transaction
        var_total_fuel = var_total_fuel + var_fuel_dispensed 'Adds fuel dispensed for the current transaction to the totals
        var_total_money = var_total_money + var_2_dp 'Adds the amount of money to pay for the current transaction to the totals
        lb_total_fuel_value.Text = var_total_fuel 'Sets the text of label lb_total_fuel_value to the value of var_total_fuel
        lb_total_money_value.Text = var_total_money 'Sets the text of label lb_total_money_value to the value of var_total_money
        bt_add.Enabled = False 'Disables button bt_add
        var_amount_to_pay = 0.00 'Sets the value of var_amount_to_pay to 0.00
        var_fuel_dispensed = 0.00 'Sets the value of var_fuel_dispensed to 0.00
        var_2_dp = 0.00 'Sets the value of var_2_dp to 0.00
        pro_update() 'Triggers label update procedure
        If var_fuel_remaining = 0 Then 'If the value of variable var_fuel_remaining is 0
            bt_dispense.Enabled = False 'Disables button bt_dispense
        End If
    End Sub

    Sub pro_zero() 'Procedure that occurs when there is no more fuel to dispense
        lb_fuel_remaining_value.Text = "EMPTY" 'Sets the text of label lb_fuel_remaining_value to EMPTY
        lb_of_100.Visible = False 'Makes label invisible
        lb_fuel_remaining_value.ForeColor = Color.Red 'Sets the font colour of label lb_fuel_remaining_value to red
        lb_not_in_use.Text = "CLOSED" 'Sets the text of label lb_not_in_use to CLOSED
        MsgBox("There's no more fuel to dispense. Please click Add to Totals to add your final transaction then click Reset.", MsgBoxStyle.Information, "Out of Fuel") 'Shows a dialogue box, which indicates that there's no more fuel to dispense
        ' all messages show appropriate icons using MsgBoxStyle and a string that is displayed in the title bar - 3/6/2021
    End Sub

    Sub pro_error() 'Procedure that occurs in the event of an error in the input
        tb_price_per_litre.Text = "" 'Makes the text of the text box blank
        tb_price_per_litre.ForeColor = Color.Red() 'Sets the font colour of text box to red
        lb_price_per_litre.ForeColor = Color.Red() 'Sets the font colour of label lb_price_per_pitre
        lb_price_per_litre_pound.ForeColor = Color.Red() 'Sets the font colour of label lb_price_per_litre_pound to red
        MsgBox("An invalid price has been entered. Please enter a price in pounds and pence.", MsgBoxStyle.Critical, "Invalid Input") 'Shows a dialogue box that tells the user that the input is invalid (changed to advise users on what type of input to enter - 3/6/2021)
    End Sub

    Sub pro_in_use() 'Procedure that occurs when pump is in use
        lb_in_use.Enabled = True 'Enables label lb_in_use (makes font colour green)
        lb_not_in_use.Enabled = False 'Disables label lb_not_in_use (makes font colour grey)
    End Sub

    Sub pro_not_in_use() 'Procedure that occurs when pump is not in use
        lb_in_use.Enabled = False 'Disables label lb_in_use (makes font colour grey)
        lb_not_in_use.Enabled = True 'Enables label lb_not_in_use (makes font colour red)
    End Sub

    Sub pro_enter_price() 'Procedure that occurs when variable var_price_per_litre is storing a value from text box
        var_price_per_litre = tb_price_per_litre.Text 'Assign the value of var_price_per_litre to text box
    End Sub

    Sub pro_update() 'Procedure that occurs when the text of the labels need updating
        lb_fuel_dispensed_value.Text = var_fuel_dispensed 'Set the text of label lb_fuel_dispensed_value to var_fuel_dispensed
        lb_amount_to_pay_value.Text = var_amount_to_pay 'Set the text of label lb_amount_to_pay_value to var_amount_to_pay
        lb_2dp_value.Text = var_2_dp 'Set the text of label lb_2_dp_value to var_2_dp
        lb_total_fuel_value.Text = var_total_fuel 'Set the text of label lb_total_fuel_value to var_total_fuel
        lb_total_money_value.Text = var_total_money 'Set the text of lb_total_money_value to var_total_money
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pro_default() 'Trigger default value procedure when form loads
    End Sub

    Private Sub tim_dispense_Tick(sender As Object, e As EventArgs) Handles tim_dispense.Tick
        var_fuel_dispensed = var_fuel_dispensed + 0.01 'Increase the value of var_fuel_dispensed by 0.01 when timer starts
        lb_fuel_dispensed_value.Text = var_fuel_dispensed 'Set the text of the label lb_fuel_dispensed_value to the value of var_fuel_dispensed
        pro_enter_price() 'Triggers procedure to assign the value of var_price_per_litre to text box
        var_amount_to_pay = var_fuel_dispensed * var_price_per_litre 'Work out the amount to pay by multiplying the values of var_fuel_dispense and var_price_per_litre
        lb_amount_to_pay_value.Text = var_amount_to_pay 'Set the text of lb_amount_to_pay_value to var_amount_to_pay
        var_fuel_remaining = var_fuel_remaining - 0.01   'Decrease the value of var_fuel_remaining by 0.01
        lb_fuel_remaining_value.Text = var_fuel_remaining 'Set the text of label lb_fuel_remaining_value to the value of var_fuel_remaining
        pb_fuel_remaining.PerformStep() 'Trigger a step of progress bar by decrementing by 10000
        If var_fuel_remaining = 0 Then 'If the value of var_fuel_remaining is 0
            pro_stop() 'Triggers procedure to stop refuelling
            pro_zero() 'Triggers procedure to prevent further transactions
        End If
        var_2_dp = Decimal.Round(var_amount_to_pay, 2, MidpointRounding.AwayFromZero) 'Set the value of var_2_dp to the value of var_amount_to_pay to 2 decimal places
        lb_2dp_value.Text = var_2_dp 'Set the text of label lb_2dp_value to the value of var_2_dp
    End Sub

    Private Sub bt_stop_Click(sender As Object, e As EventArgs) Handles bt_stop.Click
        pro_stop() 'Triggers procedure to stop refuelling
    End Sub

    Private Sub bt_dispense_Click(sender As Object, e As EventArgs) Handles bt_dispense.Click
        pro_dispense() 'Triggers procedure to start refuelling
    End Sub

    Private Sub bt_add_Click(sender As Object, e As EventArgs) Handles bt_add.Click
        pro_add() 'Triggers procedure to add current transaction to totals
    End Sub

    Private Sub bt_reset_Click(sender As Object, e As EventArgs) Handles bt_reset.Click
        pro_default() 'Triggers procedure for default values
    End Sub

    Private Sub bt_help_Click(sender As Object, e As EventArgs) Handles bt_help.Click
        fr_help.Show() 'Show help form
        'Me.Hide() 'Hide main form (unused - 3/6/2021)
    End Sub

    Private Sub lb_price_MouseHover(sender As Object, e As EventArgs) Handles lb_price_per_litre.MouseHover
        If lb_price_per_litre.ForeColor = Color.Black Then 'If an error didn't occur
            tip_price.SetToolTip(lb_price_per_litre, "This is the price per litre that you must set") 'Set the text of tooltip tip_price to a string when hovering over the given label
            tip_price.ToolTipIcon = ToolTipIcon.Info 'Set the icon to a blue info icon
        End If
        If lb_price_per_litre.ForeColor = Color.Red Then 'If an error occured
            tip_price.SetToolTip(lb_price_per_litre, "You haven't set a price. Enter one in the text box") 'Set the text of tooltip tip_price to a string when hovering over the given label
            tip_price.ToolTipIcon = ToolTipIcon.Error 'Set the icon to a red cross icon
        End If
    End Sub

    Private Sub lb_fuel_dispensed_MouseHover(sender As Object, e As EventArgs) Handles lb_fuel_dispensed.MouseHover
        tip_fuel_dispensed.SetToolTip(lb_fuel_dispensed, "This is the fuel dispensed 
for the current transaction") 'Set the text of tooltip tip_fuel_diapensed to a string when hovering over the given label lb_fuel_dispensed
    End Sub

    Private Sub lb_amount_to_pay_MouseHover(sender As Object, e As EventArgs) Handles lb_amount_to_pay.MouseHover
        tip_amount_to_pay.SetToolTip(lb_amount_to_pay, "This is the money to pay 
for the current transaction") 'Set the text of tooltip tip_amount_to_pay to a string when hovering over the given label lb_amount_to_pay
    End Sub

    Private Sub lb_total_fuel_MouseHover(sender As Object, e As EventArgs) Handles lb_total_fuel.MouseHover
        tip_total_fuel.SetToolTip(lb_total_fuel, "This is the total amount of fuel 
dispensed for all transactions so far") 'Set the text of tooltip tip_total_fuel to a string when hovering over the given label lb_total_fuel
    End Sub

    Private Sub lb_total_money_MouseHover(sender As Object, e As EventArgs) Handles lb_total_money.MouseHover
        tip_total_money.SetToolTip(lb_total_money, "This is the total amount of money 
paid for all transactions so far") 'Set the text of tooltip tip_total_fuel to a string when hovering over the given label lb_total_money
    End Sub

    Private Sub lb_status_MouseHover(sender As Object, e As EventArgs) Handles lb_status.MouseHover
        tip_status.SetToolTip(lb_status, "The current status will be shown to you:
In Use - customer operating pump
NOT In Use - no one is operating pump
CLOSED - pump cannot provide any more fuel") 'Set the text of tooltip tip_status to a string when hovering over the given label lb_status
    End Sub

    Private Sub pb_fuel_remaining_MouseHover(sender As Object, e As EventArgs) Handles pb_fuel_remaining.MouseHover
        tip_fuel_remaining.SetToolTip(pb_fuel_remaining, "This is the amount of fuel that 
is available for pumping at the pump. 
When this bar is empty, you'll have to 
close the pump and complete the last transaction.") 'Set the text of tooltip tip_fuel remaining to a string when hovering over the progress bar
    End Sub

    Private Sub bt_help_MouseHover(sender As Object, e As EventArgs) Handles bt_help.MouseHover
        tip_help.SetToolTip(bt_help, "Need help? Click here for assistance!") 'Set the text of tooltip tip_help to a string when hovering over the given button bt_help
    End Sub

    Private Sub bt_dispense_MouseHover(sender As Object, e As EventArgs) Handles bt_dispense.MouseHover
        tip_dispense.SetToolTip(bt_dispense, "Click here to start dispensing fuel") 'Set the text of tooltip tip_dispense to a string when hovering over the given button bt_dispense
    End Sub

    Private Sub bt_add_MouseHover(sender As Object, e As EventArgs) Handles bt_add.MouseHover
        tip_add.SetToolTip(bt_add, "Click here to add the current stats to the totals and complete the current transaction")
        'Set the text of tooltip tip_add to a string when hovering over the given button bt_add
    End Sub

    Private Sub bt_reset_MouseHover(sender As Object, e As EventArgs) Handles bt_reset.MouseHover
        tip_reset.SetToolTip(bt_reset, "Click here to reset the simulator") 'Set the text of tooltip tip_reset to a string when hovering over the given button bt_reset
    End Sub

    Private Sub bt_stop_MouseHover(sender As Object, e As EventArgs) Handles bt_stop.MouseHover
        tip_stop.SetToolTip(bt_stop, "Click here to stop refuelling") 'Set the text of tooltip tip_stop to a string when hovering over the given button bt_stop
    End Sub
End Class