<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaInicial
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
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        ArquivoToolStripMenuItem = New ToolStripMenuItem()
        EditarToolStripMenuItem = New ToolStripMenuItem()
        ExibirToolStripMenuItem = New ToolStripMenuItem()
        ProjetosToolStripMenuItem = New ToolStripMenuItem()
        RelatoriosToolStripMenuItem = New ToolStripMenuItem()
        DepartamentoPessoalToolStripMenuItem = New ToolStripMenuItem()
        FolhaDePagamentoToolStripMenuItem = New ToolStripMenuItem()
        FinanceiroToolStripMenuItem = New ToolStripMenuItem()
        AjudaToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.IMG_PIM_2_1
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1257, 661)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArquivoToolStripMenuItem, EditarToolStripMenuItem, ExibirToolStripMenuItem, ProjetosToolStripMenuItem, RelatoriosToolStripMenuItem, DepartamentoPessoalToolStripMenuItem, FinanceiroToolStripMenuItem, AjudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1255, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArquivoToolStripMenuItem
        ' 
        ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        ArquivoToolStripMenuItem.Size = New Size(61, 20)
        ArquivoToolStripMenuItem.Text = "Arquivo"
        ' 
        ' EditarToolStripMenuItem
        ' 
        EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        EditarToolStripMenuItem.Size = New Size(49, 20)
        EditarToolStripMenuItem.Text = "Editar"
        ' 
        ' ExibirToolStripMenuItem
        ' 
        ExibirToolStripMenuItem.Name = "ExibirToolStripMenuItem"
        ExibirToolStripMenuItem.Size = New Size(48, 20)
        ExibirToolStripMenuItem.Text = "Exibir"
        ' 
        ' ProjetosToolStripMenuItem
        ' 
        ProjetosToolStripMenuItem.Name = "ProjetosToolStripMenuItem"
        ProjetosToolStripMenuItem.Size = New Size(62, 20)
        ProjetosToolStripMenuItem.Text = "Projetos"
        ' 
        ' RelatoriosToolStripMenuItem
        ' 
        RelatoriosToolStripMenuItem.Name = "RelatoriosToolStripMenuItem"
        RelatoriosToolStripMenuItem.Size = New Size(71, 20)
        RelatoriosToolStripMenuItem.Text = "Relatórios"
        ' 
        ' DepartamentoPessoalToolStripMenuItem
        ' 
        DepartamentoPessoalToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FolhaDePagamentoToolStripMenuItem})
        DepartamentoPessoalToolStripMenuItem.Name = "DepartamentoPessoalToolStripMenuItem"
        DepartamentoPessoalToolStripMenuItem.Size = New Size(137, 20)
        DepartamentoPessoalToolStripMenuItem.Text = "Departamento Pessoal"
        ' 
        ' FolhaDePagamentoToolStripMenuItem
        ' 
        FolhaDePagamentoToolStripMenuItem.Name = "FolhaDePagamentoToolStripMenuItem"
        FolhaDePagamentoToolStripMenuItem.Size = New Size(183, 22)
        FolhaDePagamentoToolStripMenuItem.Text = "Folha de Pagamento"
        ' 
        ' FinanceiroToolStripMenuItem
        ' 
        FinanceiroToolStripMenuItem.Name = "FinanceiroToolStripMenuItem"
        FinanceiroToolStripMenuItem.Size = New Size(74, 20)
        FinanceiroToolStripMenuItem.Text = "Financeiro"
        ' 
        ' AjudaToolStripMenuItem
        ' 
        AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        AjudaToolStripMenuItem.Size = New Size(50, 20)
        AjudaToolStripMenuItem.Text = "Ajuda"
        ' 
        ' TelaInicial
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1255, 657)
        Controls.Add(MenuStrip1)
        Controls.Add(PictureBox1)
        Name = "TelaInicial"
        Text = "TelaInicial"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExibirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProjetosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatoriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentoPessoalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FolhaDePagamentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinanceiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
End Class
