namespace oop_module4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProcessorFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();

            // dataGridView1
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Size = new System.Drawing.Size(600, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Processor", HeaderText = "Процессор" });
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RAM", HeaderText = "ОЗУ (ГБ)" });
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Storage", HeaderText = "Память (ГБ)" });
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "GraphicsCard", HeaderText = "Видеокарта" });
            this.dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Цена ($)" });

            // txtProcessorFilter
            this.txtProcessorFilter.Location = new System.Drawing.Point(12, 330);
            this.txtProcessorFilter.Size = new System.Drawing.Size(200, 23);
            this.txtProcessorFilter.Name = "txtProcessorFilter";
            this.txtProcessorFilter.PlaceholderText = "Фильтр по процессору";

            // btnFilter
            this.btnFilter.Location = new System.Drawing.Point(220, 330);
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Text = "Фильтр";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);

            // btnSort
            this.btnSort.Location = new System.Drawing.Point(300, 330);
            this.btnSort.Size = new System.Drawing.Size(140, 23);
            this.btnSort.Name = "btnSort";
            this.btnSort.Text = "Сортировка по цене";
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);

            // btnGroup
            this.btnGroup.Location = new System.Drawing.Point(450, 330);
            this.btnGroup.Size = new System.Drawing.Size(140, 23);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Text = "Группировка по ОЗУ";
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);

            // Form1
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtProcessorFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnGroup);
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Text = "Конфигуратор ПК";
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProcessorFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnGroup;
    }
}
