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
            this.tB_annealingAlg = new System.Windows.Forms.TextBox();
            this.tb_antAlg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_ant = new System.Windows.Forms.RadioButton();
            this.rbtn_annealingAlg = new System.Windows.Forms.RadioButton();
            this.rbtn_nearestNeighbourAlg = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_adjacMatrix)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_adjacMatrix
            // 
            this.dGV_adjacMatrix.AllowUserToAddRows = false;
            this.dGV_adjacMatrix.AllowUserToDeleteRows = false;
            this.dGV_adjacMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_adjacMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_adjacMatrix.Location = new System.Drawing.Point(569, 15);
            this.dGV_adjacMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.dGV_adjacMatrix.Name = "dGV_adjacMatrix";
            this.dGV_adjacMatrix.RowHeadersWidth = 60;
            this.dGV_adjacMatrix.Size = new System.Drawing.Size(855, 756);
            this.dGV_adjacMatrix.TabIndex = 0;
            // 
            // button_addVertex
            // 
            this.button_addVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addVertex.Location = new System.Drawing.Point(259, 135);
            this.button_addVertex.Margin = new System.Windows.Forms.Padding(4);
            this.button_addVertex.Name = "button_addVertex";
            this.button_addVertex.Size = new System.Drawing.Size(220, 92);
            this.button_addVertex.TabIndex = 1;
            this.button_addVertex.Text = "Добавить вершину";
            this.button_addVertex.UseVisualStyleBackColor = true;
            this.button_addVertex.Click += new System.EventHandler(this.button_addVertex_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(31, 135);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(220, 92);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_loadExample
            // 
            this.button_loadExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_loadExample.Location = new System.Drawing.Point(259, 36);
            this.button_loadExample.Margin = new System.Windows.Forms.Padding(4);
            this.button_loadExample.Name = "button_loadExample";
            this.button_loadExample.Size = new System.Drawing.Size(220, 92);
            this.button_loadExample.TabIndex = 3;
            this.button_loadExample.Text = "Загрузить пример";
            this.button_loadExample.UseVisualStyleBackColor = true;
            this.button_loadExample.Click += new System.EventHandler(this.button_loadExample_Click);
            // 
            // button_run
            // 
            this.button_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_run.Location = new System.Drawing.Point(31, 36);
            this.button_run.Margin = new System.Windows.Forms.Padding(4);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(220, 92);
            this.button_run.TabIndex = 4;
            this.button_run.Text = "Запуск";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 534);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пар-ры алгоритма имитации отжига";
            // 
            // tB_annealingAlg
            // 
            this.tB_annealingAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_annealingAlg.Location = new System.Drawing.Point(32, 581);
            this.tB_annealingAlg.Margin = new System.Windows.Forms.Padding(4);
            this.tB_annealingAlg.Name = "tB_annealingAlg";
            this.tB_annealingAlg.Size = new System.Drawing.Size(484, 37);
            this.tB_annealingAlg.TabIndex = 6;
            // 
            // tb_antAlg
            // 
            this.tb_antAlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_antAlg.Location = new System.Drawing.Point(32, 476);
            this.tb_antAlg.Margin = new System.Windows.Forms.Padding(4);
            this.tb_antAlg.Name = "tb_antAlg";
            this.tb_antAlg.Size = new System.Drawing.Size(484, 37);
            this.tb_antAlg.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 430);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Пар-ры муравьиного алгоритма";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_nearestNeighbourAlg);
            this.groupBox1.Controls.Add(this.rbtn_annealingAlg);
            this.groupBox1.Controls.Add(this.rbtn_ant);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(31, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 153);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Используемый алгоритм";
            // 
            // rbtn_ant
            // 
            this.rbtn_ant.AutoSize = true;
            this.rbtn_ant.Location = new System.Drawing.Point(25, 38);
            this.rbtn_ant.Name = "rbtn_ant";
            this.rbtn_ant.Size = new System.Drawing.Size(243, 29);
            this.rbtn_ant.TabIndex = 0;
            this.rbtn_ant.TabStop = true;
            this.rbtn_ant.Text = "Муравьиный алгоритм";
            this.rbtn_ant.UseVisualStyleBackColor = true;
            // 
            // rbtn_annealingAlg
            // 
            this.rbtn_annealingAlg.AutoSize = true;
            this.rbtn_annealingAlg.Location = new System.Drawing.Point(25, 73);
            this.rbtn_annealingAlg.Name = "rbtn_annealingAlg";
            this.rbtn_annealingAlg.Size = new System.Drawing.Size(302, 29);
            this.rbtn_annealingAlg.TabIndex = 1;
            this.rbtn_annealingAlg.TabStop = true;
            this.rbtn_annealingAlg.Text = "Алгоритм имитации отжига";
            this.rbtn_annealingAlg.UseVisualStyleBackColor = true;
            // 
            // rbtn_nearestNeighbourAlg
            // 
            this.rbtn_nearestNeighbourAlg.AutoSize = true;
            this.rbtn_nearestNeighbourAlg.Location = new System.Drawing.Point(25, 108);
            this.rbtn_nearestNeighbourAlg.Name = "rbtn_nearestNeighbourAlg";
            this.rbtn_nearestNeighbourAlg.Size = new System.Drawing.Size(320, 29);
            this.rbtn_nearestNeighbourAlg.TabIndex = 2;
            this.rbtn_nearestNeighbourAlg.TabStop = true;
            this.rbtn_nearestNeighbourAlg.Text = "Алгоритм ближайшего соседа";
            this.rbtn_nearestNeighbourAlg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 785);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_antAlg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_annealingAlg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.button_loadExample);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_addVertex);
            this.Controls.Add(this.dGV_adjacMatrix);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Минимальный гамильтонов цикл";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_adjacMatrix)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox tB_annealingAlg;
        private System.Windows.Forms.TextBox tb_antAlg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_annealingAlg;
        private System.Windows.Forms.RadioButton rbtn_ant;
        private System.Windows.Forms.RadioButton rbtn_nearestNeighbourAlg;
    }
}

