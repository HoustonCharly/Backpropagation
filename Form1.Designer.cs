namespace Practica_7_BackPropagation
{
    partial class Backpropagation
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBCapas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GridCapOcu = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBAprendizaje = new System.Windows.Forms.TextBox();
            this.tBEpocas = new System.Windows.Forms.TextBox();
            this.tBError = new System.Windows.Forms.TextBox();
            this.Problema = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.GridResultado = new System.Windows.Forms.DataGridView();
            this.lBsalida = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCapOcu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capas Ocultas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tBCapas
            // 
            this.tBCapas.Location = new System.Drawing.Point(117, 31);
            this.tBCapas.Name = "tBCapas";
            this.tBCapas.Size = new System.Drawing.Size(69, 20);
            this.tBCapas.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(193, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridCapOcu
            // 
            this.GridCapOcu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCapOcu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridCapOcu.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GridCapOcu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCapOcu.Location = new System.Drawing.Point(13, 60);
            this.GridCapOcu.Name = "GridCapOcu";
            this.GridCapOcu.Size = new System.Drawing.Size(260, 129);
            this.GridCapOcu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Razon de Aprendizaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Epocas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Error";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Problema";
            // 
            // tBAprendizaje
            // 
            this.tBAprendizaje.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBAprendizaje.Location = new System.Drawing.Point(454, 31);
            this.tBAprendizaje.Name = "tBAprendizaje";
            this.tBAprendizaje.Size = new System.Drawing.Size(69, 22);
            this.tBAprendizaje.TabIndex = 9;
            // 
            // tBEpocas
            // 
            this.tBEpocas.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEpocas.Location = new System.Drawing.Point(350, 74);
            this.tBEpocas.Name = "tBEpocas";
            this.tBEpocas.Size = new System.Drawing.Size(69, 22);
            this.tBEpocas.TabIndex = 10;
            // 
            // tBError
            // 
            this.tBError.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBError.Location = new System.Drawing.Point(611, 30);
            this.tBError.Name = "tBError";
            this.tBError.Size = new System.Drawing.Size(69, 22);
            this.tBError.TabIndex = 11;
            // 
            // Problema
            // 
            this.Problema.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Problema.FormattingEnabled = true;
            this.Problema.Items.AddRange(new object[] {
            "AND",
            "OR",
            "XOR",
            "EJERCICIO",
            "MAYORIA SIMPLE",
            "PARIDAD"});
            this.Problema.Location = new System.Drawing.Point(300, 117);
            this.Problema.Name = "Problema";
            this.Problema.Size = new System.Drawing.Size(121, 22);
            this.Problema.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(385, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Backpropagation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GridResultado
            // 
            this.GridResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridResultado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridResultado.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResultado.Location = new System.Drawing.Point(13, 217);
            this.GridResultado.Name = "GridResultado";
            this.GridResultado.Size = new System.Drawing.Size(539, 211);
            this.GridResultado.TabIndex = 14;
            // 
            // lBsalida
            // 
            this.lBsalida.FormattingEnabled = true;
            this.lBsalida.Items.AddRange(new object[] {
            " "});
            this.lBsalida.Location = new System.Drawing.Point(562, 88);
            this.lBsalida.Name = "lBsalida";
            this.lBsalida.Size = new System.Drawing.Size(213, 303);
            this.lBsalida.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(596, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 25);
            this.button3.TabIndex = 16;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Resultado";
            // 
            // Backpropagation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lBsalida);
            this.Controls.Add(this.GridResultado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Problema);
            this.Controls.Add(this.tBError);
            this.Controls.Add(this.tBEpocas);
            this.Controls.Add(this.tBAprendizaje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridCapOcu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBCapas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Backpropagation";
            this.Text = "Bakcpropagation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCapOcu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox tBCapas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridCapOcu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBAprendizaje;
        private System.Windows.Forms.TextBox tBEpocas;
        private System.Windows.Forms.TextBox tBError;
        private System.Windows.Forms.ComboBox Problema;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView GridResultado;
        private System.Windows.Forms.ListBox lBsalida;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
    }
}

