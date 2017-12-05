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
            ((System.ComponentModel.ISupportInitialize)(this.dGV_adjacMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_adjacMatrix
            // 
            this.dGV_adjacMatrix.AllowUserToAddRows = false;
            this.dGV_adjacMatrix.AllowUserToDeleteRows = false;
            this.dGV_adjacMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_adjacMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_adjacMatrix.Location = new System.Drawing.Point(398, 12);
            this.dGV_adjacMatrix.Name = "dGV_adjacMatrix";
            this.dGV_adjacMatrix.RowHeadersWidth = 60;
            this.dGV_adjacMatrix.Size = new System.Drawing.Size(670, 614);
            this.dGV_adjacMatrix.TabIndex = 0;
            // 
            // button_addVertex
            // 
            this.button_addVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addVertex.Location = new System.Drawing.Point(194, 110);
            this.button_addVertex.Name = "button_addVertex";
            this.button_addVertex.Size = new System.Drawing.Size(165, 75);
            this.button_addVertex.TabIndex = 1;
            this.button_addVertex.Text = "Add vertex";
            this.button_addVertex.UseVisualStyleBackColor = true;
            this.button_addVertex.Click += new System.EventHandler(this.button_addVertex_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(23, 110);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(165, 75);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_loadExample
            // 
            this.button_loadExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_loadExample.Location = new System.Drawing.Point(194, 29);
            this.button_loadExample.Name = "button_loadExample";
            this.button_loadExample.Size = new System.Drawing.Size(165, 75);
            this.button_loadExample.TabIndex = 3;
            this.button_loadExample.Text = "Load example";
            this.button_loadExample.UseVisualStyleBackColor = true;
            this.button_loadExample.Click += new System.EventHandler(this.button_loadExample_Click);
            // 
            // button_run
            // 
            this.button_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_run.Location = new System.Drawing.Point(23, 29);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(165, 75);
            this.button_run.TabIndex = 4;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 638);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.button_loadExample);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_addVertex);
            this.Controls.Add(this.dGV_adjacMatrix);
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
    }
}

