<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolhadePagamento
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FuToolStripMenuItem = New ToolStripMenuItem()
        CadastrarToolStripMenuItem = New ToolStripMenuItem()
        AtualizarToolStripMenuItem = New ToolStripMenuItem()
        PagamentosToolStripMenuItem = New ToolStripMenuItem()
        CadastrarToolStripMenuItem1 = New ToolStripMenuItem()
        AtualizarToolStripMenuItem1 = New ToolStripMenuItem()
        DeduToolStripMenuItem = New ToolStripMenuItem()
        CadastrarToolStripMenuItem2 = New ToolStripMenuItem()
        AtualizarToolStripMenuItem2 = New ToolStripMenuItem()
        BeneficioToolStripMenuItem = New ToolStripMenuItem()
        CadastrarToolStripMenuItem3 = New ToolStripMenuItem()
        AtualizarToolStripMenuItem3 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FuToolStripMenuItem, PagamentosToolStripMenuItem, DeduToolStripMenuItem, BeneficioToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1495, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FuToolStripMenuItem
        ' 
        FuToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CadastrarToolStripMenuItem, AtualizarToolStripMenuItem})
        FuToolStripMenuItem.Name = "FuToolStripMenuItem"
        FuToolStripMenuItem.Size = New Size(90, 20)
        FuToolStripMenuItem.Text = " Funcionários"
        ' 
        ' CadastrarToolStripMenuItem
        ' 
        CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem"
        CadastrarToolStripMenuItem.Size = New Size(180, 22)
        CadastrarToolStripMenuItem.Text = "Cadastrar"
        ' 
        ' AtualizarToolStripMenuItem
        ' 
        AtualizarToolStripMenuItem.Name = "AtualizarToolStripMenuItem"
        AtualizarToolStripMenuItem.Size = New Size(180, 22)
        AtualizarToolStripMenuItem.Text = "Atualizar"
        ' 
        ' PagamentosToolStripMenuItem
        ' 
        PagamentosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CadastrarToolStripMenuItem1, AtualizarToolStripMenuItem1})
        PagamentosToolStripMenuItem.Name = "PagamentosToolStripMenuItem"
        PagamentosToolStripMenuItem.Size = New Size(80, 20)
        PagamentosToolStripMenuItem.Text = "Pagamento"
        ' 
        ' CadastrarToolStripMenuItem1
        ' 
        CadastrarToolStripMenuItem1.Name = "CadastrarToolStripMenuItem1"
        CadastrarToolStripMenuItem1.Size = New Size(180, 22)
        CadastrarToolStripMenuItem1.Text = "Cadastrar"
        ' 
        ' AtualizarToolStripMenuItem1
        ' 
        AtualizarToolStripMenuItem1.Name = "AtualizarToolStripMenuItem1"
        AtualizarToolStripMenuItem1.Size = New Size(180, 22)
        AtualizarToolStripMenuItem1.Text = "Atualizar"
        ' 
        ' DeduToolStripMenuItem
        ' 
        DeduToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CadastrarToolStripMenuItem2, AtualizarToolStripMenuItem2})
        DeduToolStripMenuItem.Name = "DeduToolStripMenuItem"
        DeduToolStripMenuItem.Size = New Size(71, 20)
        DeduToolStripMenuItem.Text = "Deduções"
        ' 
        ' CadastrarToolStripMenuItem2
        ' 
        CadastrarToolStripMenuItem2.Name = "CadastrarToolStripMenuItem2"
        CadastrarToolStripMenuItem2.Size = New Size(124, 22)
        CadastrarToolStripMenuItem2.Text = "Cadastrar"
        ' 
        ' AtualizarToolStripMenuItem2
        ' 
        AtualizarToolStripMenuItem2.Name = "AtualizarToolStripMenuItem2"
        AtualizarToolStripMenuItem2.Size = New Size(124, 22)
        AtualizarToolStripMenuItem2.Text = "Atualizar"
        ' 
        ' BeneficioToolStripMenuItem
        ' 
        BeneficioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CadastrarToolStripMenuItem3, AtualizarToolStripMenuItem3})
        BeneficioToolStripMenuItem.Name = "BeneficioToolStripMenuItem"
        BeneficioToolStripMenuItem.Size = New Size(73, 20)
        BeneficioToolStripMenuItem.Text = "Benefícios"
        ' 
        ' CadastrarToolStripMenuItem3
        ' 
        CadastrarToolStripMenuItem3.Name = "CadastrarToolStripMenuItem3"
        CadastrarToolStripMenuItem3.Size = New Size(124, 22)
        CadastrarToolStripMenuItem3.Text = "Cadastrar"
        ' 
        ' AtualizarToolStripMenuItem3
        ' 
        AtualizarToolStripMenuItem3.Name = "AtualizarToolStripMenuItem3"
        AtualizarToolStripMenuItem3.Size = New Size(124, 22)
        AtualizarToolStripMenuItem3.Text = "Atualizar"
        ' 
        ' FolhadePagamento
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1495, 650)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FolhadePagamento"
        Text = "FolhadePagamento"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AtualizarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeduToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AtualizarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BeneficioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CadastrarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents AtualizarToolStripMenuItem3 As ToolStripMenuItem
End Class
