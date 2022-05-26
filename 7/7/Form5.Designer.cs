namespace _7
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label длительностьLabel;
            System.Windows.Forms.Label клиентLabel;
            System.Windows.Forms.Label времяLabel;
            System.Windows.Forms.Label датаLabel;
            this.uslugiDataSet3 = new _7.uslugiDataSet3();
            this.sipazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sipazTableAdapter = new _7.uslugiDataSet3TableAdapters.sipazTableAdapter();
            this.tableAdapterManager = new _7.uslugiDataSet3TableAdapters.TableAdapterManager();
            this.sipazDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.длительностьTextBox = new System.Windows.Forms.TextBox();
            this.клиентTextBox = new System.Windows.Forms.TextBox();
            this.времяTextBox = new System.Windows.Forms.TextBox();
            this.датаTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            названиеLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            длительностьLabel = new System.Windows.Forms.Label();
            клиентLabel = new System.Windows.Forms.Label();
            времяLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipazDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uslugiDataSet3
            // 
            this.uslugiDataSet3.DataSetName = "uslugiDataSet3";
            this.uslugiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sipazBindingSource
            // 
            this.sipazBindingSource.DataMember = "sipaz";
            this.sipazBindingSource.DataSource = this.uslugiDataSet3;
            // 
            // sipazTableAdapter
            // 
            this.sipazTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.sipazTableAdapter = this.sipazTableAdapter;
            this.tableAdapterManager.UpdateOrder = _7.uslugiDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sipazDataGridView
            // 
            this.sipazDataGridView.AutoGenerateColumns = false;
            this.sipazDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sipazDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.sipazDataGridView.DataSource = this.sipazBindingSource;
            this.sipazDataGridView.Location = new System.Drawing.Point(12, 29);
            this.sipazDataGridView.Name = "sipazDataGridView";
            this.sipazDataGridView.Size = new System.Drawing.Size(644, 251);
            this.sipazDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn2.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Длительность";
            this.dataGridViewTextBoxColumn3.HeaderText = "Длительность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Клиент";
            this.dataGridViewTextBoxColumn4.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Время";
            this.dataGridViewTextBoxColumn5.HeaderText = "Время";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(27, 289);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 1;
            названиеLabel.Text = "Название:";
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sipazBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(116, 286);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.названиеTextBox.TabIndex = 2;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(27, 315);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 3;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sipazBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(116, 312);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(100, 20);
            this.стоимостьTextBox.TabIndex = 4;
            // 
            // длительностьLabel
            // 
            длительностьLabel.AutoSize = true;
            длительностьLabel.Location = new System.Drawing.Point(27, 341);
            длительностьLabel.Name = "длительностьLabel";
            длительностьLabel.Size = new System.Drawing.Size(83, 13);
            длительностьLabel.TabIndex = 5;
            длительностьLabel.Text = "Длительность:";
            // 
            // длительностьTextBox
            // 
            this.длительностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sipazBindingSource, "Длительность", true));
            this.длительностьTextBox.Location = new System.Drawing.Point(116, 338);
            this.длительностьTextBox.Name = "длительностьTextBox";
            this.длительностьTextBox.Size = new System.Drawing.Size(100, 20);
            this.длительностьTextBox.TabIndex = 6;
            // 
            // клиентLabel
            // 
            клиентLabel.AutoSize = true;
            клиентLabel.Location = new System.Drawing.Point(27, 367);
            клиентLabel.Name = "клиентLabel";
            клиентLabel.Size = new System.Drawing.Size(46, 13);
            клиентLabel.TabIndex = 7;
            клиентLabel.Text = "Клиент:";
            // 
            // клиентTextBox
            // 
            this.клиентTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sipazBindingSource, "Клиент", true));
            this.клиентTextBox.Location = new System.Drawing.Point(116, 364);
            this.клиентTextBox.Name = "клиентTextBox";
            this.клиентTextBox.Size = new System.Drawing.Size(100, 20);
            this.клиентTextBox.TabIndex = 8;
            // 
            // времяLabel
            // 
            времяLabel.AutoSize = true;
            времяLabel.Location = new System.Drawing.Point(27, 393);
            времяLabel.Name = "времяLabel";
            времяLabel.Size = new System.Drawing.Size(43, 13);
            времяLabel.TabIndex = 9;
            времяLabel.Text = "Время:";
            // 
            // времяTextBox
            // 
            this.времяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sipazBindingSource, "Время", true));
            this.времяTextBox.Location = new System.Drawing.Point(116, 390);
            this.времяTextBox.Name = "времяTextBox";
            this.времяTextBox.Size = new System.Drawing.Size(100, 20);
            this.времяTextBox.TabIndex = 10;
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(27, 419);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(36, 13);
            датаLabel.TabIndex = 11;
            датаLabel.Text = "Дата:";
            // 
            // датаTextBox
            // 
            this.датаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sipazBindingSource, "Дата", true));
            this.датаTextBox.Location = new System.Drawing.Point(116, 416);
            this.датаTextBox.Name = "датаTextBox";
            this.датаTextBox.Size = new System.Drawing.Size(100, 20);
            this.датаTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(длительностьLabel);
            this.Controls.Add(this.длительностьTextBox);
            this.Controls.Add(клиентLabel);
            this.Controls.Add(this.клиентTextBox);
            this.Controls.Add(времяLabel);
            this.Controls.Add(this.времяTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаTextBox);
            this.Controls.Add(this.sipazDataGridView);
            this.Name = "Form5";
            this.Text = "История записи клиентов";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uslugiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sipazDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private uslugiDataSet3 uslugiDataSet3;
        private System.Windows.Forms.BindingSource sipazBindingSource;
        private uslugiDataSet3TableAdapters.sipazTableAdapter sipazTableAdapter;
        private uslugiDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sipazDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.TextBox длительностьTextBox;
        private System.Windows.Forms.TextBox клиентTextBox;
        private System.Windows.Forms.TextBox времяTextBox;
        private System.Windows.Forms.TextBox датаTextBox;
        private System.Windows.Forms.Button button1;
    }
}