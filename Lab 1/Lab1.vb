
''' Program Name : Lab 1 - Average Units Shipped
''' Author: Spence McComb
''' Student ID: 100426427
''' Last Edited: January 30, 2018
''' Course Code: NETD 2202-04
''' 
''' Description: The purpose of this program is to accept seven user inputs and calculate an average.
'''              Afterward, the user has the option to reset or exit the form.

Public Class frmLab1

    'Declare the maximum array size.
    Const MAXIMUM_ARRAY_SIZE = 6

    'Declare the globally-used variables.
    Dim entryArray(MAXIMUM_ARRAY_SIZE) As Integer
    Dim counter As Integer = 0


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Lets the user exit the form by clicking the exit button.
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Reset the variables for a new set of data entry.
        counter = 0

        'Reset the form controls.
        txtUserInput.Focus()
        txtUserInput.Text = ""
        lblDay.Text = "Day 1"
        txtUnitsShipped.Text = ""
        lblAverage.Text = ""

        'Enable the data entry textbox and give it the focus.
        txtUserInput.Enabled = True
        btnEnter.Enabled = True
        txtUserInput.Focus()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'Declare the locally-used variables.
        Dim entryAverage As Double
        Dim isInteger As Integer
        Dim entrySum As Integer = 0

        'Data validation for blank text and non-numeric values.
        'This ensures that the data entered by the user can be processed.
        If (txtUserInput.Text = "") Then
            MessageBox.Show("No information entered! Please enter a whole number between 0 and 1,000, inclusive.")
            txtUserInput.SelectAll()

        ElseIf Int32.TryParse(txtUserInput.Text, isInteger) = False Then
            'Data entered is non-numerical.
            MessageBox.Show("Invalid entry. Please enter a whole number between 0 and 1,000, inclusive.")
            txtUserInput.SelectAll()

        ElseIf Int(txtUserInput.Text) > 1000 Or Int(txtUserInput.Text) < 0 Then
            'Data entered is numerical, but outside of specified range.
            MessageBox.Show("Entry outside of range. Please enter a whole number between 0 and 1,000, inclusive.")
            txtUserInput.SelectAll()

        Else
            'Data is sound. Proceed with the calculations.
            'Collect user input from the appropriate textbox.
            entryArray(counter) = txtUserInput.Text

            'Output the collected data to the appropriate textbox.
            txtUnitsShipped.Text += (entryArray(counter).ToString)
            txtUnitsShipped.Text &= Environment.NewLine

            'Reset the user input textbox and give it the focus.
            txtUserInput.Text = ""
            txtUserInput.Focus()

            'Increment the counter and update the day label.
            counter = counter + 1
            lblDay.Text = "Day " + (counter + 1).ToString

            'Perform the average calculation when the counter reaches 7 numbers inputted.
            'Declare a counter to determine when the stop accepting numbers into the sum.
            If (counter = 7) Then
                For i As Integer = 0 To (counter - 1)
                    entrySum += entryArray(i)
                Next

                'Ensure the day label does not increment to 8.
                lblDay.Text = "Day " + (counter).ToString

                'Perform the average calculation and output the result.
                'Disable the input textbox so that no new numbers can be entered.
                'Disable the enter button until the user resets the form.
                entryAverage = (entrySum / counter)
                lblAverage.Text += "Average per day: " + (Math.Round(entryAverage, 2)).ToString
                txtUserInput.Enabled = False
                btnEnter.Enabled = False
            End If
        End If
    End Sub

End Class
