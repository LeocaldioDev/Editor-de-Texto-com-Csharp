namespace Editor_de_Texto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ts_btn_novo = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_abrir = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_imprimir = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_salvar = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_copiar = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_colar = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_negrito = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_italico = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_sublinhado = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_esquerda = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_centro = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_direita = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.refazerToolStripMenuItem.Text = "Refazer";
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizarToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_btn_novo,
            this.ts_btn_abrir,
            this.ts_btn_imprimir,
            this.ts_btn_salvar,
            this.toolStripSeparator1,
            this.ts_btn_copiar,
            this.ts_btn_colar,
            this.toolStripSeparator2,
            this.ts_btn_negrito,
            this.ts_btn_italico,
            this.ts_btn_sublinhado,
            this.toolStripSeparator3,
            this.ts_btn_esquerda,
            this.ts_btn_centro,
            this.ts_btn_direita});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(616, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(616, 346);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.TXT) | *.TXT";
            this.openFileDialog1.Title = "Abrir Arquivo";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ts_btn_novo
            // 
            this.ts_btn_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_novo.Image = global::Editor_de_Texto.Properties.Resources.novo;
            this.ts_btn_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_novo.Name = "ts_btn_novo";
            this.ts_btn_novo.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_novo.Text = "Novo";
            this.ts_btn_novo.Click += new System.EventHandler(this.ts_btn_novo_Click);
            // 
            // ts_btn_abrir
            // 
            this.ts_btn_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_abrir.Image = global::Editor_de_Texto.Properties.Resources.abrir;
            this.ts_btn_abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_abrir.Name = "ts_btn_abrir";
            this.ts_btn_abrir.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_abrir.Text = "Abrir";
            this.ts_btn_abrir.Click += new System.EventHandler(this.ts_btn_abrir_Click);
            // 
            // ts_btn_imprimir
            // 
            this.ts_btn_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_imprimir.Image = global::Editor_de_Texto.Properties.Resources.impressora;
            this.ts_btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_imprimir.Name = "ts_btn_imprimir";
            this.ts_btn_imprimir.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_imprimir.Text = "Imprimir";
            this.ts_btn_imprimir.Click += new System.EventHandler(this.ts_btn_imprimir_Click);
            // 
            // ts_btn_salvar
            // 
            this.ts_btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_salvar.Image = global::Editor_de_Texto.Properties.Resources.salvar;
            this.ts_btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_salvar.Name = "ts_btn_salvar";
            this.ts_btn_salvar.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_salvar.Text = "Salvar";
            this.ts_btn_salvar.Click += new System.EventHandler(this.ts_btn_salvar_Click);
            // 
            // ts_btn_copiar
            // 
            this.ts_btn_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_copiar.Image = global::Editor_de_Texto.Properties.Resources.copiar;
            this.ts_btn_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_copiar.Name = "ts_btn_copiar";
            this.ts_btn_copiar.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_copiar.Text = "Copiar";
            this.ts_btn_copiar.Click += new System.EventHandler(this.ts_btn_copiar_Click);
            // 
            // ts_btn_colar
            // 
            this.ts_btn_colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_colar.Image = global::Editor_de_Texto.Properties.Resources.Colar;
            this.ts_btn_colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_colar.Name = "ts_btn_colar";
            this.ts_btn_colar.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_colar.Text = "Colar";
            this.ts_btn_colar.Click += new System.EventHandler(this.ts_btn_colar_Click);
            // 
            // ts_btn_negrito
            // 
            this.ts_btn_negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_negrito.Image = global::Editor_de_Texto.Properties.Resources.negrito;
            this.ts_btn_negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_negrito.Name = "ts_btn_negrito";
            this.ts_btn_negrito.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_negrito.Text = "Negrito";
            this.ts_btn_negrito.Click += new System.EventHandler(this.ts_btn_negrito_Click);
            // 
            // ts_btn_italico
            // 
            this.ts_btn_italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_italico.Image = global::Editor_de_Texto.Properties.Resources.italico;
            this.ts_btn_italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_italico.Name = "ts_btn_italico";
            this.ts_btn_italico.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_italico.Text = "Itálico";
            this.ts_btn_italico.Click += new System.EventHandler(this.ts_btn_italico_Click);
            // 
            // ts_btn_sublinhado
            // 
            this.ts_btn_sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_sublinhado.Image = global::Editor_de_Texto.Properties.Resources.sublinhado;
            this.ts_btn_sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_sublinhado.Name = "ts_btn_sublinhado";
            this.ts_btn_sublinhado.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_sublinhado.Text = "Sublinhado";
            this.ts_btn_sublinhado.Click += new System.EventHandler(this.ts_btn_sublinhado_Click);
            // 
            // ts_btn_esquerda
            // 
            this.ts_btn_esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_esquerda.Image = global::Editor_de_Texto.Properties.Resources.esquerda;
            this.ts_btn_esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_esquerda.Name = "ts_btn_esquerda";
            this.ts_btn_esquerda.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_esquerda.Text = "Alinhar esquerda";
            this.ts_btn_esquerda.Click += new System.EventHandler(this.ts_btn_esquerda_Click);
            // 
            // ts_btn_centro
            // 
            this.ts_btn_centro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_centro.Image = global::Editor_de_Texto.Properties.Resources.centro;
            this.ts_btn_centro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_centro.Name = "ts_btn_centro";
            this.ts_btn_centro.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_centro.Text = "Centro";
            this.ts_btn_centro.Click += new System.EventHandler(this.ts_btn_centro_Click);
            // 
            // ts_btn_direita
            // 
            this.ts_btn_direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btn_direita.Image = global::Editor_de_Texto.Properties.Resources.direita;
            this.ts_btn_direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_direita.Name = "ts_btn_direita";
            this.ts_btn_direita.Size = new System.Drawing.Size(23, 22);
            this.ts_btn_direita.Text = "Alinhar Direita";
            this.ts_btn_direita.Click += new System.EventHandler(this.ts_btn_direita_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 396);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Texto/Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton ts_btn_novo;
        private System.Windows.Forms.ToolStripButton ts_btn_abrir;
        private System.Windows.Forms.ToolStripButton ts_btn_salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ts_btn_copiar;
        private System.Windows.Forms.ToolStripButton ts_btn_colar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_btn_negrito;
        private System.Windows.Forms.ToolStripButton ts_btn_italico;
        private System.Windows.Forms.ToolStripButton ts_btn_sublinhado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ts_btn_esquerda;
        private System.Windows.Forms.ToolStripButton ts_btn_centro;
        private System.Windows.Forms.ToolStripButton ts_btn_direita;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripButton ts_btn_imprimir;
    }
}

