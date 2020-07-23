namespace DataViewer_D_v._001
{
    partial class startWindow
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
            this.components = new System.ComponentModel.Container();
            this.таблица1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD1DataSet = new DataViewer_D_v._001.BD1DataSet();
            this.bD1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.таблица1TableAdapter = new DataViewer_D_v._001.BD1DataSetTableAdapters.Таблица1TableAdapter();
            this.registratorButton = new System.Windows.Forms.Button();
            this.secretaryButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.ansamblButton = new System.Windows.Forms.Button();
            this.duetButton = new System.Windows.Forms.Button();
            this.sekwayButton = new System.Windows.Forms.Button();
            this.solistButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD1DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // таблица1BindingSource
            // 
            this.таблица1BindingSource.DataMember = "Таблица1";
            this.таблица1BindingSource.DataSource = this.bD1DataSetBindingSource;
            // 
            // bD1DataSetBindingSource
            // 
            this.bD1DataSetBindingSource.DataSource = this.bD1DataSet;
            this.bD1DataSetBindingSource.Position = 0;
            // 
            // bD1DataSet
            // 
            this.bD1DataSet.DataSetName = "BD1DataSet";
            this.bD1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bD1DataSetBindingSource1
            // 
            this.bD1DataSetBindingSource1.DataSource = this.bD1DataSet;
            this.bD1DataSetBindingSource1.Position = 0;
            // 
            // таблица1TableAdapter
            // 
            this.таблица1TableAdapter.ClearBeforeFill = true;
            // 
            // registratorButton
            // 
            this.registratorButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registratorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registratorButton.Location = new System.Drawing.Point(38, 46);
            this.registratorButton.Name = "registratorButton";
            this.registratorButton.Size = new System.Drawing.Size(229, 203);
            this.registratorButton.TabIndex = 0;
            this.registratorButton.Text = "Регистратор";
            this.registratorButton.UseVisualStyleBackColor = false;
            this.registratorButton.Click += new System.EventHandler(this.registratorButton_Click);
            // 
            // secretaryButton
            // 
            this.secretaryButton.BackColor = System.Drawing.Color.Coral;
            this.secretaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secretaryButton.Location = new System.Drawing.Point(273, 46);
            this.secretaryButton.Name = "secretaryButton";
            this.secretaryButton.Size = new System.Drawing.Size(229, 203);
            this.secretaryButton.TabIndex = 1;
            this.secretaryButton.Text = "Секретарь";
            this.secretaryButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(437, 154);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 136);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "назад";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ansamblButton
            // 
            this.ansamblButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ansamblButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ansamblButton.Location = new System.Drawing.Point(231, 154);
            this.ansamblButton.Name = "ansamblButton";
            this.ansamblButton.Size = new System.Drawing.Size(200, 136);
            this.ansamblButton.TabIndex = 8;
            this.ansamblButton.Text = "Ансамбль";
            this.ansamblButton.UseVisualStyleBackColor = false;
            // 
            // duetButton
            // 
            this.duetButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.duetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.duetButton.Location = new System.Drawing.Point(231, 12);
            this.duetButton.Name = "duetButton";
            this.duetButton.Size = new System.Drawing.Size(200, 136);
            this.duetButton.TabIndex = 7;
            this.duetButton.Text = "Пара";
            this.duetButton.UseVisualStyleBackColor = false;
            this.duetButton.Click += new System.EventHandler(this.duetButton_Click);
            // 
            // sekwayButton
            // 
            this.sekwayButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sekwayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sekwayButton.Location = new System.Drawing.Point(25, 154);
            this.sekwayButton.Name = "sekwayButton";
            this.sekwayButton.Size = new System.Drawing.Size(200, 136);
            this.sekwayButton.TabIndex = 6;
            this.sekwayButton.Text = "Секвей";
            this.sekwayButton.UseVisualStyleBackColor = false;
            // 
            // solistButton
            // 
            this.solistButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.solistButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.solistButton.Location = new System.Drawing.Point(25, 12);
            this.solistButton.Name = "solistButton";
            this.solistButton.Size = new System.Drawing.Size(200, 136);
            this.solistButton.TabIndex = 5;
            this.solistButton.Text = "Солист";
            this.solistButton.UseVisualStyleBackColor = false;
            this.solistButton.Click += new System.EventHandler(this.solistButton_Click);
            // 
            // startWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ansamblButton);
            this.Controls.Add(this.duetButton);
            this.Controls.Add(this.sekwayButton);
            this.Controls.Add(this.solistButton);
            this.Controls.Add(this.secretaryButton);
            this.Controls.Add(this.registratorButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "startWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "startWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.startWindow_FormClosing);
            this.Load += new System.EventHandler(this.startForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD1DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bD1DataSetBindingSource;
        private BD1DataSet bD1DataSet;
        private System.Windows.Forms.BindingSource bD1DataSetBindingSource1;
        private System.Windows.Forms.BindingSource таблица1BindingSource;
        private BD1DataSetTableAdapters.Таблица1TableAdapter таблица1TableAdapter;
        private System.Windows.Forms.Button registratorButton;
        private System.Windows.Forms.Button secretaryButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button ansamblButton;
        private System.Windows.Forms.Button duetButton;
        private System.Windows.Forms.Button sekwayButton;
        private System.Windows.Forms.Button solistButton;
    }
}

