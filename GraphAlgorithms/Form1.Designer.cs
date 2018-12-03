namespace GraphAlgorithms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGV_adjacMatrix = new System.Windows.Forms.DataGridView();
            this.button_addVertex = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_loadExample = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_evapFactor = new System.Windows.Forms.TextBox();
            this.tB_alfa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_beta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_lengthFactor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_adjacMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_adjacMatrix
            // 
            this.dGV_adjacMatrix.AllowUserToAddRows = false;
            this.dGV_adjacMatrix.AllowUserToDeleteRows = false;
            this.dGV_adjacMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_adjacMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_adjacMatrix.Location = new System.Drawing.Point(531, 15);
            this.dGV_adjacMatrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGV_adjacMatrix.Name = "dGV_adjacMatrix";
            this.dGV_adjacMatrix.RowHeadersWidth = 60;
            this.dGV_adjacMatrix.Size = new System.Drawing.Size(893, 756);
            this.dGV_adjacMatrix.TabIndex = 0;
            // 
            // button_addVertex
            // 
            this.button_addVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addVertex.Location = new System.Drawing.Point(259, 135);
            this.button_addVertex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_addVertex.Name = "button_addVertex";
            this.button_addVertex.Size = new System.Drawing.Size(220, 92);
            this.button_addVertex.TabIndex = 1;
            this.button_addVertex.Text = "Add vertex";
            this.button_addVertex.UseVisualStyleBackColor = true;
            this.button_addVertex.Click += new System.EventHandler(this.button_addVertex_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(31, 135);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(220, 92);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_loadExample
            // 
            this.button_loadExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_loadExample.Location = new System.Drawing.Point(259, 36);
            this.button_loadExample.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_loadExample.Name = "button_loadExample";
            this.button_loadExample.Size = new System.Drawing.Size(220, 92);
            this.button_loadExample.TabIndex = 3;
            this.button_loadExample.Text = "Load example";
            this.button_loadExample.UseVisualStyleBackColor = true;
            this.button_loadExample.Click += new System.EventHandler(this.button_loadExample_Click);
            // 
            // button_run
            // 
            this.button_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_run.Location = new System.Drawing.Point(31, 36);
            this.button_run.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(220, 92);
            this.button_run.TabIndex = 4;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 471);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Evaporation factor";
            // 
            // tB_evapFactor
            // 
            this.tB_evapFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_evapFactor.Location = new System.Drawing.Point(47, 518);
            this.tB_evapFactor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_evapFactor.Name = "tB_evapFactor";
            this.tB_evapFactor.Size = new System.Drawing.Size(447, 37);
            this.tB_evapFactor.TabIndex = 6;
            // 
            // tB_alfa
            // 
            this.tB_alfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_alfa.Location = new System.Drawing.Point(47, 620);
            this.tB_alfa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_alfa.Name = "tB_alfa";
            this.tB_alfa.Size = new System.Drawing.Size(447, 37);
            this.tB_alfa.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 573);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alfa";
            // 
            // tB_beta
            // 
            this.tB_beta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_beta.Location = new System.Drawing.Point(47, 722);
            this.tB_beta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_beta.Name = "tB_beta";
            this.tB_beta.Size = new System.Drawing.Size(447, 37);
            this.tB_beta.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 676);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Beta";
            // 
            // tB_lengthFactor
            // 
            this.tB_lengthFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_lengthFactor.Location = new System.Drawing.Point(47, 413);
            this.tB_lengthFactor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_lengthFactor.Name = "tB_lengthFactor";
            this.tB_lengthFactor.Size = new System.Drawing.Size(447, 37);
            this.tB_lengthFactor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(40, 367);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Edge-length factor";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(47, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 123);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Используемый алгоритм";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 785);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tB_lengthFactor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_beta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_alfa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_evapFactor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.button_loadExample);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_addVertex);
            this.Controls.Add(this.dGV_adjacMatrix);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Ant colony algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_adjacMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_adjacMatrix;
        private System.Windows.Forms.Button button_addVertex;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_loadExample;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_evapFactor;
        private System.Windows.Forms.TextBox tB_alfa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_beta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_lengthFactor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

