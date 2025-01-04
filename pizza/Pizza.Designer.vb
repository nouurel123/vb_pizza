<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lstTaille = New ComboBox()
        Chk_cham = New CheckBox()
        Chk_oli = New CheckBox()
        Chk_poi = New CheckBox()
        Chk_frsupp = New CheckBox()
        Rabtnfine = New RadioButton()
        Ratnépai = New RadioButton()
        Rabtnclass = New RadioButton()
        btn_click = New Button()
        SuspendLayout()
        ' 
        ' lstTaille
        ' 
        lstTaille.FormattingEnabled = True
        lstTaille.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        lstTaille.Location = New Point(369, 152)
        lstTaille.Margin = New Padding(5)
        lstTaille.Name = "lstTaille"
        lstTaille.Size = New Size(407, 39)
        lstTaille.TabIndex = 0
        ' 
        ' Chk_cham
        ' 
        Chk_cham.AccessibleName = "Champigonos"
        Chk_cham.AutoSize = True
        Chk_cham.ForeColor = Color.DarkBlue
        Chk_cham.Location = New Point(81, 446)
        Chk_cham.Margin = New Padding(5)
        Chk_cham.Name = "Chk_cham"
        Chk_cham.Size = New Size(180, 35)
        Chk_cham.TabIndex = 1
        Chk_cham.Text = "Champigonos"
        Chk_cham.UseVisualStyleBackColor = True
        ' 
        ' Chk_oli
        ' 
        Chk_oli.AccessibleName = "Champigonos"
        Chk_oli.AutoSize = True
        Chk_oli.ForeColor = Color.DarkBlue
        Chk_oli.Location = New Point(336, 446)
        Chk_oli.Margin = New Padding(5)
        Chk_oli.Name = "Chk_oli"
        Chk_oli.Size = New Size(99, 35)
        Chk_oli.TabIndex = 2
        Chk_oli.Text = "Olives"
        Chk_oli.UseVisualStyleBackColor = True
        ' 
        ' Chk_poi
        ' 
        Chk_poi.AccessibleName = "Champigonos"
        Chk_poi.AutoSize = True
        Chk_poi.ForeColor = Color.DarkBlue
        Chk_poi.Location = New Point(593, 446)
        Chk_poi.Margin = New Padding(5)
        Chk_poi.Name = "Chk_poi"
        Chk_poi.Size = New Size(126, 35)
        Chk_poi.TabIndex = 3
        Chk_poi.Text = "Poivrons"
        Chk_poi.UseVisualStyleBackColor = True
        ' 
        ' Chk_frsupp
        ' 
        Chk_frsupp.AccessibleName = "Champigonos"
        Chk_frsupp.AutoSize = True
        Chk_frsupp.ForeColor = Color.DarkBlue
        Chk_frsupp.Location = New Point(830, 446)
        Chk_frsupp.Margin = New Padding(5)
        Chk_frsupp.Name = "Chk_frsupp"
        Chk_frsupp.Size = New Size(299, 35)
        Chk_frsupp.TabIndex = 4
        Chk_frsupp.Text = "Fromage Supplémentaire"
        Chk_frsupp.UseVisualStyleBackColor = True
        ' 
        ' Rabtnfine
        ' 
        Rabtnfine.AutoSize = True
        Rabtnfine.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Rabtnfine.ForeColor = Color.DarkBlue
        Rabtnfine.Location = New Point(125, 294)
        Rabtnfine.Margin = New Padding(5)
        Rabtnfine.Name = "Rabtnfine"
        Rabtnfine.Size = New Size(183, 42)
        Rabtnfine.TabIndex = 5
        Rabtnfine.TabStop = True
        Rabtnfine.Text = "Croute Fine"
        Rabtnfine.UseVisualStyleBackColor = True
        ' 
        ' Ratnépai
        ' 
        Ratnépai.AutoSize = True
        Ratnépai.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Ratnépai.ForeColor = Color.DarkBlue
        Ratnépai.Location = New Point(440, 294)
        Ratnépai.Margin = New Padding(5)
        Ratnépai.Name = "Ratnépai"
        Ratnépai.Size = New Size(224, 42)
        Ratnépai.TabIndex = 6
        Ratnépai.TabStop = True
        Ratnépai.Text = "Croute épaisse"
        Ratnépai.UseVisualStyleBackColor = True
        ' 
        ' Rabtnclass
        ' 
        Rabtnclass.AutoSize = True
        Rabtnclass.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold)
        Rabtnclass.ForeColor = Color.DarkBlue
        Rabtnclass.Location = New Point(791, 294)
        Rabtnclass.Margin = New Padding(5)
        Rabtnclass.Name = "Rabtnclass"
        Rabtnclass.Size = New Size(245, 42)
        Rabtnclass.TabIndex = 7
        Rabtnclass.TabStop = True
        Rabtnclass.Text = "Croute classique"
        Rabtnclass.UseVisualStyleBackColor = True
        ' 
        ' btn_click
        ' 
        btn_click.Location = New Point(494, 555)
        btn_click.Margin = New Padding(5)
        btn_click.Name = "btn_click"
        btn_click.Size = New Size(282, 70)
        btn_click.TabIndex = 8
        btn_click.Text = "Afficher"
        btn_click.UseVisualStyleBackColor = True
        ' 
        ' Form
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 31.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(1300, 698)
        Controls.Add(btn_click)
        Controls.Add(Rabtnclass)
        Controls.Add(Ratnépai)
        Controls.Add(Rabtnfine)
        Controls.Add(Chk_frsupp)
        Controls.Add(Chk_poi)
        Controls.Add(Chk_oli)
        Controls.Add(Chk_cham)
        Controls.Add(lstTaille)
        Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5)
        Name = "Form"
        Text = "Pizza"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstTaille As ComboBox
    Friend WithEvents Chk_cham As CheckBox
    Friend WithEvents Chk_oli As CheckBox
    Friend WithEvents Chk_poi As CheckBox
    Friend WithEvents Chk_frsupp As CheckBox
    Friend WithEvents Rabtnfine As RadioButton
    Friend WithEvents Ratnépai As RadioButton
    Friend WithEvents Rabtnclass As RadioButton
    Friend WithEvents btn_click As Button

End Class
