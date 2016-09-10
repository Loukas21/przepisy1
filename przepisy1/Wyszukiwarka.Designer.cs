namespace przepisy1
{
    partial class Wyszukiwarka
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label tagiLabel;
            System.Windows.Forms.Label skladnikiLabel;
            System.Windows.Forms.Label przygotowanieLabel;
            System.Windows.Forms.Label zdjecieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wyszukiwarka));
            this.button1 = new System.Windows.Forms.Button();
            this.przepisy1DataSet1 = new przepisy1.przepisy1DataSet1();
            this.przepisy1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przepisy1TableAdapter = new przepisy1.przepisy1DataSet1TableAdapters.przepisy1TableAdapter();
            this.tableAdapterManager = new przepisy1.przepisy1DataSet1TableAdapters.TableAdapterManager();
            this.przepisy1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.przepisy1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.przepisy1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.tagiTextBox = new System.Windows.Forms.TextBox();
            this.skladnikiTextBox = new System.Windows.Forms.TextBox();
            this.przygotowanieTextBox = new System.Windows.Forms.TextBox();
            this.zdjecieTextBox = new System.Windows.Forms.TextBox();
            this.searchNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.nazwaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nazwaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            tagiLabel = new System.Windows.Forms.Label();
            skladnikiLabel = new System.Windows.Forms.Label();
            przygotowanieLabel = new System.Windows.Forms.Label();
            zdjecieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1BindingNavigator)).BeginInit();
            this.przepisy1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1DataGridView)).BeginInit();
            this.searchNameToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(79, 134);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "id:";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(79, 160);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(41, 13);
            nazwaLabel.TabIndex = 5;
            nazwaLabel.Text = "nazwa:";
            // 
            // tagiLabel
            // 
            tagiLabel.AutoSize = true;
            tagiLabel.Location = new System.Drawing.Point(79, 186);
            tagiLabel.Name = "tagiLabel";
            tagiLabel.Size = new System.Drawing.Size(27, 13);
            tagiLabel.TabIndex = 7;
            tagiLabel.Text = "tagi:";
            // 
            // skladnikiLabel
            // 
            skladnikiLabel.AutoSize = true;
            skladnikiLabel.Location = new System.Drawing.Point(303, 138);
            skladnikiLabel.Name = "skladnikiLabel";
            skladnikiLabel.Size = new System.Drawing.Size(51, 13);
            skladnikiLabel.TabIndex = 9;
            skladnikiLabel.Text = "skladniki:";
            // 
            // przygotowanieLabel
            // 
            przygotowanieLabel.AutoSize = true;
            przygotowanieLabel.Location = new System.Drawing.Point(303, 164);
            przygotowanieLabel.Name = "przygotowanieLabel";
            przygotowanieLabel.Size = new System.Drawing.Size(78, 13);
            przygotowanieLabel.TabIndex = 11;
            przygotowanieLabel.Text = "przygotowanie:";
            // 
            // zdjecieLabel
            // 
            zdjecieLabel.AutoSize = true;
            zdjecieLabel.Location = new System.Drawing.Point(303, 190);
            zdjecieLabel.Name = "zdjecieLabel";
            zdjecieLabel.Size = new System.Drawing.Size(43, 13);
            zdjecieLabel.TabIndex = 13;
            zdjecieLabel.Text = "zdjecie:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Powrót do menu głównego";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // przepisy1DataSet1
            // 
            this.przepisy1DataSet1.DataSetName = "przepisy1DataSet1";
            this.przepisy1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // przepisy1BindingSource
            // 
            this.przepisy1BindingSource.DataMember = "przepisy1";
            this.przepisy1BindingSource.DataSource = this.przepisy1DataSet1;
            // 
            // przepisy1TableAdapter
            // 
            this.przepisy1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.przepisy1TableAdapter = this.przepisy1TableAdapter;
            this.tableAdapterManager.UpdateOrder = przepisy1.przepisy1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // przepisy1BindingNavigator
            // 
            this.przepisy1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.przepisy1BindingNavigator.BindingSource = this.przepisy1BindingSource;
            this.przepisy1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.przepisy1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.przepisy1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.przepisy1BindingNavigatorSaveItem});
            this.przepisy1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.przepisy1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.przepisy1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.przepisy1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.przepisy1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.przepisy1BindingNavigator.Name = "przepisy1BindingNavigator";
            this.przepisy1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.przepisy1BindingNavigator.Size = new System.Drawing.Size(858, 25);
            this.przepisy1BindingNavigator.TabIndex = 1;
            this.przepisy1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // przepisy1BindingNavigatorSaveItem
            // 
            this.przepisy1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.przepisy1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("przepisy1BindingNavigatorSaveItem.Image")));
            this.przepisy1BindingNavigatorSaveItem.Name = "przepisy1BindingNavigatorSaveItem";
            this.przepisy1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.przepisy1BindingNavigatorSaveItem.Text = "Save Data";
            this.przepisy1BindingNavigatorSaveItem.Click += new System.EventHandler(this.przepisy1BindingNavigatorSaveItem_Click);
            // 
            // przepisy1DataGridView
            // 
            this.przepisy1DataGridView.AutoGenerateColumns = false;
            this.przepisy1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.przepisy1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.przepisy1DataGridView.DataSource = this.przepisy1BindingSource;
            this.przepisy1DataGridView.Location = new System.Drawing.Point(82, 222);
            this.przepisy1DataGridView.Name = "przepisy1DataGridView";
            this.przepisy1DataGridView.Size = new System.Drawing.Size(644, 87);
            this.przepisy1DataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nazwa";
            this.dataGridViewTextBoxColumn2.HeaderText = "nazwa";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tagi";
            this.dataGridViewTextBoxColumn3.HeaderText = "tagi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "skladniki";
            this.dataGridViewTextBoxColumn4.HeaderText = "skladniki";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "przygotowanie";
            this.dataGridViewTextBoxColumn5.HeaderText = "przygotowanie";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "zdjecie";
            this.dataGridViewTextBoxColumn6.HeaderText = "zdjecie";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisy1BindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(163, 131);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisy1BindingSource, "nazwa", true));
            this.nazwaTextBox.Location = new System.Drawing.Point(163, 157);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaTextBox.TabIndex = 6;
            // 
            // tagiTextBox
            // 
            this.tagiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisy1BindingSource, "tagi", true));
            this.tagiTextBox.Location = new System.Drawing.Point(163, 183);
            this.tagiTextBox.Name = "tagiTextBox";
            this.tagiTextBox.Size = new System.Drawing.Size(100, 20);
            this.tagiTextBox.TabIndex = 8;
            // 
            // skladnikiTextBox
            // 
            this.skladnikiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisy1BindingSource, "skladniki", true));
            this.skladnikiTextBox.Location = new System.Drawing.Point(387, 135);
            this.skladnikiTextBox.Name = "skladnikiTextBox";
            this.skladnikiTextBox.Size = new System.Drawing.Size(100, 20);
            this.skladnikiTextBox.TabIndex = 10;
            // 
            // przygotowanieTextBox
            // 
            this.przygotowanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisy1BindingSource, "przygotowanie", true));
            this.przygotowanieTextBox.Location = new System.Drawing.Point(387, 161);
            this.przygotowanieTextBox.Name = "przygotowanieTextBox";
            this.przygotowanieTextBox.Size = new System.Drawing.Size(100, 20);
            this.przygotowanieTextBox.TabIndex = 12;
            // 
            // zdjecieTextBox
            // 
            this.zdjecieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisy1BindingSource, "zdjecie", true));
            this.zdjecieTextBox.Location = new System.Drawing.Point(387, 187);
            this.zdjecieTextBox.Name = "zdjecieTextBox";
            this.zdjecieTextBox.Size = new System.Drawing.Size(100, 20);
            this.zdjecieTextBox.TabIndex = 14;
            // 
            // searchNameToolStrip
            // 
            this.searchNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazwaToolStripLabel,
            this.nazwaToolStripTextBox,
            this.searchNameToolStripButton});
            this.searchNameToolStrip.Location = new System.Drawing.Point(0, 25);
            this.searchNameToolStrip.Name = "searchNameToolStrip";
            this.searchNameToolStrip.Size = new System.Drawing.Size(858, 25);
            this.searchNameToolStrip.TabIndex = 15;
            this.searchNameToolStrip.Text = "searchNameToolStrip";
            // 
            // nazwaToolStripLabel
            // 
            this.nazwaToolStripLabel.Name = "nazwaToolStripLabel";
            this.nazwaToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.nazwaToolStripLabel.Text = "nazwa:";
            // 
            // nazwaToolStripTextBox
            // 
            this.nazwaToolStripTextBox.Name = "nazwaToolStripTextBox";
            this.nazwaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // searchNameToolStripButton
            // 
            this.searchNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchNameToolStripButton.Name = "searchNameToolStripButton";
            this.searchNameToolStripButton.Size = new System.Drawing.Size(71, 22);
            this.searchNameToolStripButton.Text = "SearchName";
            this.searchNameToolStripButton.Click += new System.EventHandler(this.searchNameToolStripButton_Click);
            // 
            // Wyszukiwarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 350);
            this.Controls.Add(this.przepisy1DataGridView);
            this.Controls.Add(this.searchNameToolStrip);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(tagiLabel);
            this.Controls.Add(this.tagiTextBox);
            this.Controls.Add(skladnikiLabel);
            this.Controls.Add(this.skladnikiTextBox);
            this.Controls.Add(przygotowanieLabel);
            this.Controls.Add(this.przygotowanieTextBox);
            this.Controls.Add(zdjecieLabel);
            this.Controls.Add(this.zdjecieTextBox);
            this.Controls.Add(this.przepisy1BindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Wyszukiwarka";
            this.Text = "Wyszukiwarka";
            this.Load += new System.EventHandler(this.Wyszukiwarka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1BindingNavigator)).EndInit();
            this.przepisy1BindingNavigator.ResumeLayout(false);
            this.przepisy1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1DataGridView)).EndInit();
            this.searchNameToolStrip.ResumeLayout(false);
            this.searchNameToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private przepisy1DataSet1 przepisy1DataSet1;
        private System.Windows.Forms.BindingSource przepisy1BindingSource;
        private przepisy1DataSet1TableAdapters.przepisy1TableAdapter przepisy1TableAdapter;
        private przepisy1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator przepisy1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton przepisy1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView przepisy1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox tagiTextBox;
        private System.Windows.Forms.TextBox skladnikiTextBox;
        private System.Windows.Forms.TextBox przygotowanieTextBox;
        private System.Windows.Forms.TextBox zdjecieTextBox;
        private System.Windows.Forms.ToolStrip searchNameToolStrip;
        private System.Windows.Forms.ToolStripLabel nazwaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nazwaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchNameToolStripButton;
    }
}