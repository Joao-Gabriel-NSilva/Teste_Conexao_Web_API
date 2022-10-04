using System.Windows.Forms;

namespace View_Cotacao
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
            this.components = new System.ComponentModel.Container();
            this.tbMoedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sATKTREINAMENTOFIN2022DataSet = new View_Cotacao.SATKTREINAMENTOFIN2022DataSet();
            this.tbMoedaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.tbMoedaTableAdapter = new View_Cotacao.SATKTREINAMENTOFIN2022DataSetTableAdapters.tbMoedaTableAdapter();
            textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            comboBoxOrigem = new System.Windows.Forms.ComboBox();
            comboBoxDestino = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbMoedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATKTREINAMENTOFIN2022DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMoedaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.Cursor = System.Windows.Forms.Cursors.Arrow;
            comboBoxOrigem.DataSource = this.tbMoedaBindingSource;
            comboBoxOrigem.DisplayMember = "Cod_moeda_API";
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new System.Drawing.Point(257, 49);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new System.Drawing.Size(77, 21);
            comboBoxOrigem.TabIndex = 0;
            comboBoxOrigem.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrigem_SelectedIndexChanged);
            // 
            // tbMoedaBindingSource
            // 
            this.tbMoedaBindingSource.DataMember = "tbMoeda";
            this.tbMoedaBindingSource.DataSource = this.sATKTREINAMENTOFIN2022DataSet;
            // 
            // sATKTREINAMENTOFIN2022DataSet
            // 
            this.sATKTREINAMENTOFIN2022DataSet.DataSetName = "SATKTREINAMENTOFIN2022DataSet";
            this.sATKTREINAMENTOFIN2022DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.Cursor = System.Windows.Forms.Cursors.Arrow;
            comboBoxDestino.DataSource = this.tbMoedaBindingSource1;
            comboBoxDestino.DisplayMember = "Cod_moeda_API";
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new System.Drawing.Point(257, 96);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new System.Drawing.Size(77, 21);
            comboBoxDestino.TabIndex = 2;
            comboBoxDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestino_SelectedIndexChanged);
            // 
            // tbMoedaBindingSource1
            // 
            this.tbMoedaBindingSource1.DataMember = "tbMoeda";
            this.tbMoedaBindingSource1.DataSource = this.sATKTREINAMENTOFIN2022DataSet;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moeda origem:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moeda destino:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(141, 141);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(98, 24);
            this.buttonConsultar.TabIndex = 4;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // tbMoedaTableAdapter
            // 
            this.tbMoedaTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxResultado
            // 
            textBoxResultado.BackColor = System.Drawing.SystemColors.Window;
            textBoxResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxResultado.Location = new System.Drawing.Point(257, 144);
            textBoxResultado.MinimumSize = new System.Drawing.Size(77, 21);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.ReadOnly = true;
            textBoxResultado.Size = new System.Drawing.Size(77, 21);
            textBoxResultado.TabIndex = 5;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSalvar.Image = global::View_Cotacao.Properties.Resources.Salvar;
            this.buttonSalvar.Location = new System.Drawing.Point(220, 185);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(31, 28);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 262);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(textBoxResultado);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(comboBoxDestino);
            this.Controls.Add(this.label1);
            this.Controls.Add(comboBoxOrigem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbMoedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sATKTREINAMENTOFIN2022DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMoedaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConsultar;
        private SATKTREINAMENTOFIN2022DataSet sATKTREINAMENTOFIN2022DataSet;
        private System.Windows.Forms.BindingSource tbMoedaBindingSource;
        private SATKTREINAMENTOFIN2022DataSetTableAdapters.tbMoedaTableAdapter tbMoedaTableAdapter;
        private System.Windows.Forms.BindingSource tbMoedaBindingSource1;
        private static System.Windows.Forms.ComboBox comboBoxOrigem;
        private static System.Windows.Forms.ComboBox comboBoxDestino;
        private static TextBox textBoxResultado;
        private Button buttonSalvar;
    }
}

