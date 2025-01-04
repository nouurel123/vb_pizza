Imports System.Net.NetworkInformation

Public Class Form
    Private Sub ch_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_cham.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Rabtnfine.CheckedChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTaille.SelectedIndexChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Rabtnclass.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_oli.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_poi.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Ratnépai.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_click.Click
        Dim taille = lstTaille.SelectedItem.ToString()
        Dim ingredient As String = ""
        If Rabtnfine.Checked Then
            ingredient = "Crout Fine"
        ElseIf Rabtnclass.Checked Then
            ingredient = "Croute classique"
        ElseIf Ratnépai.Checked Then
            ingredient = "Croute épaisse"
        End If
        Dim Ingrsupp As String = ""
        If Chk_cham.Checked Then
            Ingrsupp = Ingrsupp + "Champignion"
        ElseIf Chk_oli.Checked Then
            Ingrsupp = Ingrsupp + "Olive"
        ElseIf Chk_poi.Checked Then
            Ingrsupp = Ingrsupp + "Poivrins"
        ElseIf Chk_frsupp.Checked Then
            Ingrsupp = Ingrsupp + "Fromage supplimentaire"
        End If
        Dim msg As String = "Taille :" + taille + "Type de croute:" + ingredient + "Ingredient"

    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
