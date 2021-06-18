Public Class Form1

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Call PrimaryB40()
        Call SecondaryB40()
        Call IPTB40()

        Call PrimaryM40()
        Call SecondaryM40()
        Call IPTM40()

        Call PrimaryT20()
        Call SecondaryT20()
        Call IPTT20()
    End Sub

    Private Function PrimaryB40()
        'start b40 primary no parents and yes bantuan'
        If rbPrimary.Checked And rbB40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            gbSalary.Enabled = False
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and yes bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and yes bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbFather.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'no parents and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Enabled And cbNoParents.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'Both Parents and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and salary1 and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and salary1 and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 1 and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            'no parents and yes bantuan'
        ElseIf rbPrimary.Checked And rbB40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'end b40 primary both parents and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
        End If
        Return PrimaryB40
    End Function

    Private Function SecondaryB40()
        'start b40 secondary no parents and yes bantuan'
        If rbSecondary.Checked And rbB40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            gbSalary.Enabled = False
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and yes bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and yes bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbFather.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'no parents and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Enabled And cbNoParents.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'Both Parents and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and salary1 and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and salary 1 and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 1 and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            'no parents and yes bantuan'
        ElseIf rbSecondary.Checked And rbB40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'end b40 secondary both parents and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
        End If
        Return SecondaryB40
    End Function
    Private Function IPTB40()
        'start b40 IPT no parents and yes bantuan'
        If rbIPT.Checked And rbB40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            gbSalary.Enabled = False
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and yes bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and yes bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbFather.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'no parents and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Enabled And cbNoParents.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'Both Parents and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary1 only and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only  and salary1  and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 1 and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and yes bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary2 and yes bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and yes bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            'no parents and yes bantuan'
        ElseIf rbIPT.Checked And rbB40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary2 and yes bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'end b40 IPT both parents and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbB40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
        End If
        Return IPTB40
    End Function

    Private Function PrimaryM40()
        'start m40 primary no parents and yes bantuan'
        If rbPrimary.Checked And rbM40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            gbSalary.Enabled = False
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbFather.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'no parents and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Enabled And cbNoParents.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'Both Parents and no bantuan
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and salary1 and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and salary1 and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 1 and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            'no parents and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'end M40 primary both parents and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
        End If
        Return PrimaryM40
    End Function

    Private Function SecondaryM40()
        'start b40 secondary no parents and yes bantuan'
        If rbSecondary.Checked And rbM40.Checked And cbNoParents.Checked And rbYes.Checked Then
            gbSalary.Enabled = False
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbFather.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'no parents and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Enabled And cbNoParents.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'Both Parents and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and salary1 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and salary 1 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 1 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            'no parents and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'end M40 secondary both parents and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
        End If
        Return SecondaryM40
    End Function

    Private Function IPTM40()
        'start m40 IPT no parents and yes bantuan'
        If rbIPT.Checked And rbM40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            gbSalary.Enabled = False
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbFather.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineigible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'no parents and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Enabled And cbNoParents.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'Both Parents and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary1 only and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only  and salary1  and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 1 and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary2 and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            'no parents and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary2 and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'end b40 IPT both parents and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
        End If
        Return IPTB40()
    End Function

    Private Function PrimaryT20()
        'start m40 primary no parents and yes bantuan'
        If rbPrimary.Checked And RbT20.Enabled And cbNoParents.Checked And rbYes.Checked Then
            gbSalary.Enabled = False
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and yes bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and yes bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbFather.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'no parents and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Enabled And cbNoParents.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'Both Parents and no bantuan
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and salary1 and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and salary1 and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 1 and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            'no parents and yes bantuan'
        ElseIf rbPrimary.Checked And rbM40.Enabled And cbNoParents.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary2 and yes bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'end M40 primary both parents and salary3 and yes bantuan'
        ElseIf rbPrimary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
        End If
        Return PrimaryT20
    End Function

    Private Function SecondaryT20()
        'start b40 secondary no parents and yes bantuan'
        If rbSecondary.Checked And RbT20.Checked And cbNoParents.Checked And rbYes.Checked Then
            gbSalary.Enabled = False
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and yes bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and yes bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbFather.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'no parents and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Enabled And cbNoParents.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'Both Parents and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and salary1 and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and salary 1 and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 1 and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbM40.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            'no parents and yes bantuan'
        ElseIf rbSecondary.Checked And rbT20.Enabled And cbNoParents.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary2 and yes bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'end M40 secondary both parents and salary3 and yes bantuan'
        ElseIf rbSecondary.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
        End If
        Return SecondaryT20
    End Function

    Private Function IPTT20()
        'start m40 IPT no parents and yes bantuan'
        If rbIPT.Checked And RbT20.Enabled And cbNoParents.Checked And rbYes.Checked Then
            gbSalary.Enabled = False
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother only and yes bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only and yes bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbFather.Checked And rbSalary1.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'no parents and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Enabled And cbNoParents.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eliligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'Both Parents and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary1 only and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father only  and salary1  and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 1 and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary1.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and no bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbMother.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 3 and no bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbNo.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary 2 and yes bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary2 and yes bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary 2 and yes bantuan'
        ElseIf rbIPT.Checked And rbM40.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            'no parents and yes bantuan'
        ElseIf rbIPT.Checked And rbT20.Enabled And cbNoParents.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary2 and yes bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary2.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Ineligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'both parents and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'mother and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'father and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
            'end b40 IPT both parents and salary3 and yes bantuan'
        ElseIf rbIPT.Checked And rbT20.Checked And cbMother.Checked And cbFather.Checked And rbSalary3.Checked And rbYes.Checked Then
            MessageBox.Show(txtName.Text & vbCrLf & vbCrLf & txtNRIC.Text & vbCrLf & vbCrLf & "You Are Eligible ", "PERMOHANAN BANTUAN TELEFON PINTAR", MessageBoxButtons.OK)
            Me.Close()
        End If
        Return IPTT20
    End Function

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim exitBorang As DialogResult = MessageBox.Show("Are you sure?", "BORANG PERMOHONAN",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If exitBorang = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
