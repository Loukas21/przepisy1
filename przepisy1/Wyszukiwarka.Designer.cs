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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wyszukiwarka));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label tagiLabel;
            System.Windows.Forms.Label skladnikiLabel;
            System.Windows.Forms.Label przygotowanieLabel;
            System.Windows.Forms.Label obrazLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.przepisyDataSet1 = new przepisy1.przepisyDataSet1();
            this.przepisyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przepisyTableAdapter = new przepisy1.przepisyDataSet1TableAdapters.przepisyTableAdapter();
            this.tableAdapterManager = new przepisy1.przepisyDataSet1TableAdapters.TableAdapterManager();
            this.przepisyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.przepisyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.przepisyDataGridView = new System.Windows.Forms.DataGridView();
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
            this.obrazTextBox = new System.Windows.Forms.TextBox();
            this.searchQueryToolStrip = new System.Windows.Forms.ToolStrip();
            this.nazwaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nazwaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchQueryToolStripButton = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            tagiLabel = new System.Windows.Forms.Label();
            skladnikiLabel = new System.Windows.Forms.Label();
            przygotowanieLabel = new System.Windows.Forms.Label();
            obrazLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.przepisyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisyBindingNavigator)).BeginInit();
            this.przepisyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przepisyDataGridView)).BeginInit();
            this.searchQueryToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Powrót do menu głównego";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // przepisyDataSet1
            // 
            this.przepisyDataSet1.DataSetName = "przepisyDataSet1";
            this.przepisyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // przepisyBindingSource
            // 
            this.przepisyBindingSource.DataMember = "przepisy";
            this.przepisyBindingSource.DataSource = this.przepisyDataSet1;
            // 
            // przepisyTableAdapter
            // 
            this.przepisyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.przepisyTableAdapter = this.przepisyTableAdapter;
            this.tableAdapterManager.UpdateOrder = przepisy1.przepisyDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // przepisyBindingNavigator
            // 
            this.przepisyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.przepisyBindingNavigator.BindingSource = this.przepisyBindingSource;
            this.przepisyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.przepisyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.przepisyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.przepisyBindingNavigatorSaveItem});
            this.przepisyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.przepisyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.przepisyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.przepisyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.przepisyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.przepisyBindingNavigator.Name = "przepisyBindingNavigator";
            this.przepisyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.przepisyBindingNavigator.Size = new System.Drawing.Size(746, 25);
            this.przepisyBindingNavigator.TabIndex = 1;
            this.przepisyBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // przepisyBindingNavigatorSaveItem
            // 
            this.przepisyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.przepisyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("przepisyBindingNavigatorSaveItem.Image")));
            this.przepisyBindingNavigatorSaveItem.Name = "przepisyBindingNavigatorSaveItem";
            this.przepisyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.przepisyBindingNavigatorSaveItem.Text = "Save Data";
            this.przepisyBindingNavigatorSaveItem.Click += new System.EventHandler(this.przepisyBindingNavigatorSaveItem_Click);
            // 
            // przepisyDataGridView
            // 
            this.przepisyDataGridView.AutoGenerateColumns = false;
            this.przepisyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.przepisyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.przepisyDataGridView.DataSource = this.przepisyBindingSource;
            this.przepisyDataGridView.Location = new System.Drawing.Point(44, 207);
            this.przepisyDataGridView.Name = "przepisyDataGridView";
            this.przepisyDataGridView.Size = new System.Drawing.Size(643, 69);
            this.przepisyDataGridView.TabIndex = 2;
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
            this.dataGridViewTextBoxColumn6.DataPropertyName = "obraz";
            this.dataGridViewTextBoxColumn6.HeaderText = "obraz";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(48, 128);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 3;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisyBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(132, 125);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(48, 154);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(41, 13);
            nazwaLabel.TabIndex = 5;
            nazwaLabel.Text = "nazwa:";
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisyBindingSource, "nazwa", true));
            this.nazwaTextBox.Location = new System.Drawing.Point(132, 151);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaTextBox.TabIndex = 6;
            // 
            // tagiLabel
            // 
            tagiLabel.AutoSize = true;
            tagiLabel.Location = new System.Drawing.Point(48, 180);
            tagiLabel.Name = "tagiLabel";
            tagiLabel.Size = new System.Drawing.Size(27, 13);
            tagiLabel.TabIndex = 7;
            tagiLabel.Text = "tagi:";
            // 
            // tagiTextBox
            // 
            this.tagiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisyBindingSource, "tagi", true));
            this.tagiTextBox.Location = new System.Drawing.Point(132, 177);
            this.tagiTextBox.Name = "tagiTextBox";
            this.tagiTextBox.Size = new System.Drawing.Size(100, 20);
            this.tagiTextBox.TabIndex = 8;
            // 
            // skladnikiLabel
            // 
            skladnikiLabel.AutoSize = true;
            skladnikiLabel.Location = new System.Drawing.Point(262, 128);
            skladnikiLabel.Name = "skladnikiLabel";
            skladnikiLabel.Size = new System.Drawing.Size(51, 13);
            skladnikiLabel.TabIndex = 9;
            skladnikiLabel.Text = "skladniki:";
            // 
            // skladnikiTextBox
            // 
            this.skladnikiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisyBindingSource, "skladniki", true));
            this.skladnikiTextBox.Location = new System.Drawing.Point(346, 125);
            this.skladnikiTextBox.Name = "skladnikiTextBox";
            this.skladnikiTextBox.Size = new System.Drawing.Size(100, 20);
            this.skladnikiTextBox.TabIndex = 10;
            // 
            // przygotowanieLabel
            // 
            przygotowanieLabel.AutoSize = true;
            przygotowanieLabel.Location = new System.Drawing.Point(262, 154);
            przygotowanieLabel.Name = "przygotowanieLabel";
            przygotowanieLabel.Size = new System.Drawing.Size(78, 13);
            przygotowanieLabel.TabIndex = 11;
            przygotowanieLabel.Text = "przygotowanie:";
            // 
            // przygotowanieTextBox
            // 
            this.przygotowanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisyBindingSource, "przygotowanie", true));
            this.przygotowanieTextBox.Location = new System.Drawing.Point(346, 151);
            this.przygotowanieTextBox.Name = "przygotowanieTextBox";
            this.przygotowanieTextBox.Size = new System.Drawing.Size(100, 20);
            this.przygotowanieTextBox.TabIndex = 12;
            // 
            // obrazLabel
            // 
            obrazLabel.AutoSize = true;
            obrazLabel.Location = new System.Drawing.Point(262, 180);
            obrazLabel.Name = "obrazLabel";
            obrazLabel.Size = new System.Drawing.Size(36, 13);
            obrazLabel.TabIndex = 13;
            obrazLabel.Text = "obraz:";
            // 
            // obrazTextBox
            // 
            this.obrazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisyBindingSource, "obraz", true));
            this.obrazTextBox.Location = new System.Drawing.Point(346, 177);
            this.obrazTextBox.Name = "obrazTextBox";
            this.obrazTextBox.Size = new System.Drawing.Size(100, 20);
            this.obrazTextBox.TabIndex = 14;
            // 
            // searchQueryToolStrip
            // 
            this.searchQueryToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazwaToolStripLabel,
            this.nazwaToolStripTextBox,
            this.searchQueryToolStripButton});
            this.searchQueryToolStrip.Location = new System.Drawing.Point(0, 25);
            this.searchQueryToolStrip.Name = "searchQueryToolStrip";
            this.searchQueryToolStrip.Size = new System.Drawing.Size(746, 25);
            this.searchQueryToolStrip.TabIndex = 15;
            this.searchQueryToolStrip.Text = "searchQueryToolStrip";
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
            this.nazwaToolStripTextBox.Size = new System.Drawing.Size(100, 21);
            // 
            // searchQueryToolStripButton
            // 
            this.searchQueryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchQueryToolStripButton.Name = "searchQueryToolStripButton";
            this.searchQueryToolStripButton.Size = new System.Drawing.Size(74, 17);
            this.searchQueryToolStripButton.Text = "SearchQuery";
            this.searchQueryToolStripButton.Click += new System.EventHandler(this.searchQueryToolStripButton_Click);
            // 
            // Wyszukiwarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 297);
            this.Controls.Add(this.searchQueryToolStrip);
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
            this.Controls.Add(obrazLabel);
            this.Controls.Add(this.obrazTextBox);
            this.Controls.Add(this.przepisyDataGridView);
            this.Controls.Add(this.przepisyBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Wyszukiwarka";
            this.Text = "Wyszukiwarka";
            this.Load += new System.EventHandler(this.Wyszukiwarka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.przepisyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisyBindingNavigator)).EndInit();
            this.przepisyBindingNavigator.ResumeLayout(false);
            this.przepisyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przepisyDataGridView)).EndInit();
            this.searchQueryToolStrip.ResumeLayout(false);
            this.searchQueryToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private przepisyDataSet1 przepisyDataSet1;
        private System.Windows.Forms.BindingSource przepisyBindingSource;
        private przepisyDataSet1TableAdapters.przepisyTableAdapter przepisyTableAdapter;
        private przepisyDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator przepisyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton przepisyBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView przepisyDataGridView;
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
        private System.Windows.Forms.TextBox obrazTextBox;
        private System.Windows.Forms.ToolStrip searchQueryToolStrip;
        private System.Windows.Forms.ToolStripLabel nazwaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nazwaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchQueryToolStripButton;
    }
}