
namespace AnalizadorLexico1_17_0167
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultadoDgv = new System.Windows.Forms.DataGridView();
            this.TOKEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEXEMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalizarBtn = new System.Windows.Forms.Button();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.textBox_codigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // resultadoDgv
            // 
            this.resultadoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadoDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TOKEN,
            this.LEXEMA});
            this.resultadoDgv.Location = new System.Drawing.Point(524, 12);
            this.resultadoDgv.Name = "resultadoDgv";
            this.resultadoDgv.Size = new System.Drawing.Size(245, 389);
            this.resultadoDgv.TabIndex = 1;
            // 
            // TOKEN
            // 
            this.TOKEN.HeaderText = "TOKEN";
            this.TOKEN.Name = "TOKEN";
            // 
            // LEXEMA
            // 
            this.LEXEMA.HeaderText = "LEXEMA";
            this.LEXEMA.Name = "LEXEMA";
            // 
            // AnalizarBtn
            // 
            this.AnalizarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalizarBtn.Location = new System.Drawing.Point(165, 412);
            this.AnalizarBtn.Name = "AnalizarBtn";
            this.AnalizarBtn.Size = new System.Drawing.Size(115, 42);
            this.AnalizarBtn.TabIndex = 2;
            this.AnalizarBtn.Text = "ANALIZAR";
            this.AnalizarBtn.UseVisualStyleBackColor = true;
            this.AnalizarBtn.Click += new System.EventHandler(this.AnalizarBtn_Click);
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarBtn.Location = new System.Drawing.Point(617, 412);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(152, 42);
            this.LimpiarBtn.TabIndex = 3;
            this.LimpiarBtn.Text = "LIMPIAR TABLA";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // textBox_codigo
            // 
            this.textBox_codigo.Location = new System.Drawing.Point(12, 12);
            this.textBox_codigo.Multiline = true;
            this.textBox_codigo.Name = "textBox_codigo";
            this.textBox_codigo.Size = new System.Drawing.Size(491, 389);
            this.textBox_codigo.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.textBox_codigo);
            this.Controls.Add(this.LimpiarBtn);
            this.Controls.Add(this.AnalizarBtn);
            this.Controls.Add(this.resultadoDgv);
            this.Name = "MainForm";
            this.Text = "Analizador léxico 1-17-0167";
            ((System.ComponentModel.ISupportInitialize)(this.resultadoDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView resultadoDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOKEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEXEMA;
        private System.Windows.Forms.Button AnalizarBtn;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.TextBox textBox_codigo;
    }
}

