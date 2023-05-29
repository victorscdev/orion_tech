<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        usuario = New Label()
        senha = New Label()
        entrar = New Button()
        cadastrar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.IMG_PIM_2_1
        PictureBox1.Location = New Point(-55, -141)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(530, 526)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(167, 206)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(250, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(167, 245)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(250, 23)
        TextBox2.TabIndex = 2
        ' 
        ' usuario
        ' 
        usuario.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        usuario.AutoSize = True
        usuario.BackColor = SystemColors.ControlLightLight
        usuario.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        usuario.ForeColor = SystemColors.MenuHighlight
        usuario.Location = New Point(73, 199)
        usuario.Name = "usuario"
        usuario.Size = New Size(88, 30)
        usuario.TabIndex = 3
        usuario.Tag = ""
        usuario.Text = "Usuário"
        ' 
        ' senha
        ' 
        senha.AutoSize = True
        senha.BackColor = SystemColors.ControlLightLight
        senha.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        senha.ForeColor = SystemColors.MenuHighlight
        senha.Location = New Point(88, 236)
        senha.Name = "senha"
        senha.Size = New Size(73, 30)
        senha.TabIndex = 4
        senha.Tag = ""
        senha.Text = "Senha"
        ' 
        ' entrar
        ' 
        entrar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        entrar.ForeColor = SystemColors.HotTrack
        entrar.Location = New Point(337, 288)
        entrar.Name = "entrar"
        entrar.Size = New Size(80, 35)
        entrar.TabIndex = 5
        entrar.Text = "Entrar"
        entrar.UseVisualStyleBackColor = True
        ' 
        ' cadastrar
        ' 
        cadastrar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cadastrar.ForeColor = SystemColors.HotTrack
        cadastrar.Location = New Point(217, 288)
        cadastrar.Name = "cadastrar"
        cadastrar.Size = New Size(94, 35)
        cadastrar.TabIndex = 6
        cadastrar.Text = "Cadastrar"
        cadastrar.UseVisualStyleBackColor = True
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(467, 380)
        Controls.Add(cadastrar)
        Controls.Add(entrar)
        Controls.Add(senha)
        Controls.Add(usuario)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Name = "form1"
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents usuario As Label
    Friend WithEvents senha As Label
    Friend WithEvents entrar As Button
    Friend WithEvents cadastrar As Button
End Class
