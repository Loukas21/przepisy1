namespace przepisy1
{
    partial class Edytor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edytor));
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label tagiLabel;
            System.Windows.Forms.Label skladnikiLabel;
            System.Windows.Forms.Label przygotowanieLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.przepisy1DataSet1 = new przepisy1.przepisy1DataSet1();
            this.przepisy1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przepisy1TableAdapter = new przepisy1.przepisy1DataSet1TableAdapters.przepisy1TableAdapter();
            this.tableAdapterManager = new przepisy1.przepisy1DataSet1TableAdapters.TableAdapterManager();
            this.przepisy1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.przepisy1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.tagiTextBox = new System.Windows.Forms.TextBox();
            this.skladnikiTextBox = new System.Windows.Forms.TextBox();
            this.przygotowanieTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            nazwaLabel = new System.Windows.Forms.Label();
            tagiLabel = new System.Windows.Forms.Label();
            skladnikiLabel = new System.Windows.Forms.Label();
            przygotowanieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1BindingNavigator)).BeginInit();
            this.przepisy1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
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
            this.przepisy1BindingNavigator.Size = new System.Drawing.Size(706, 25);
            this.przepisy1BindingNavigator.TabIndex = 1;
            this.przepisy1BindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 13);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // przepisy1BindingNavigatorSaveItem
            // 
            this.przepisy1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.przepisy1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("przepisy1BindingNavigatorSaveItem.Image")));
            this.przepisy1BindingNavigatorSaveItem.Name = "przepisy1BindingNavigatorSaveItem";
            this.przepisy1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.przepisy1BindingNavigatorSaveItem.Text = "Save Data";
            this.przepisy1BindingNavigatorSaveItem.Click += new System.EventHandler(this.przepisy1BindingNavigatorSaveItem_Click);
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(34, 48);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(41, 13);
            nazwaLabel.TabIndex = 4;
            nazwaLabel.Text = "nazwa:";
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisy1BindingSource, "nazwa", true));
            this.nazwaTextBox.Location = new System.Drawing.Point(33, 64);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwaTextBox.TabIndex = 5;
            // 
            // tagiLabel
            // 
            tagiLabel.AutoSize = true;
            tagiLabel.Location = new System.Drawing.Point(34, 108);
            tagiLabel.Name = "tagiLabel";
            tagiLabel.Size = new System.Drawing.Size(27, 13);
            tagiLabel.TabIndex = 6;
            tagiLabel.Text = "tagi:";
            // 
            // tagiTextBox
            // 
            this.tagiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisy1BindingSource, "tagi", true));
            this.tagiTextBox.Location = new System.Drawing.Point(33, 124);
            this.tagiTextBox.Name = "tagiTextBox";
            this.tagiTextBox.Size = new System.Drawing.Size(100, 20);
            this.tagiTextBox.TabIndex = 7;
            // 
            // skladnikiLabel
            // 
            skladnikiLabel.AutoSize = true;
            skladnikiLabel.Location = new System.Drawing.Point(240, 48);
            skladnikiLabel.Name = "skladnikiLabel";
            skladnikiLabel.Size = new System.Drawing.Size(51, 13);
            skladnikiLabel.TabIndex = 8;
            skladnikiLabel.Text = "skladniki:";
            // 
            // skladnikiTextBox
            // 
            this.skladnikiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisy1BindingSource, "skladniki", true));
            this.skladnikiTextBox.Location = new System.Drawing.Point(201, 77);
            this.skladnikiTextBox.Name = "skladnikiTextBox";
            this.skladnikiTextBox.Size = new System.Drawing.Size(177, 20);
            this.skladnikiTextBox.TabIndex = 9;
            // 
            // przygotowanieLabel
            // 
            przygotowanieLabel.AutoSize = true;
            przygotowanieLabel.Location = new System.Drawing.Point(495, 48);
            przygotowanieLabel.Name = "przygotowanieLabel";
            przygotowanieLabel.Size = new System.Drawing.Size(78, 13);
            przygotowanieLabel.TabIndex = 10;
            przygotowanieLabel.Text = "przygotowanie:";
            // 
            // przygotowanieTextBox
            // 
            this.przygotowanieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.przepisy1BindingSource, "przygotowanie", true));
            this.przygotowanieTextBox.Location = new System.Drawing.Point(404, 77);
            this.przygotowanieTextBox.Name = "przygotowanieTextBox";
            this.przygotowanieTextBox.Size = new System.Drawing.Size(290, 20);
            this.przygotowanieTextBox.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(201, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(177, 184);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(404, 108);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(290, 184);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // Edytor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 358);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(tagiLabel);
            this.Controls.Add(this.tagiTextBox);
            this.Controls.Add(skladnikiLabel);
            this.Controls.Add(this.skladnikiTextBox);
            this.Controls.Add(przygotowanieLabel);
            this.Controls.Add(this.przygotowanieTextBox);
            this.Controls.Add(this.przepisy1BindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Edytor";
            this.Text = "Edytor";
            this.Load += new System.EventHandler(this.Edytor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przepisy1BindingNavigator)).EndInit();
            this.przepisy1BindingNavigator.ResumeLayout(false);
            this.przepisy1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox tagiTextBox;
        private System.Windows.Forms.TextBox skladnikiTextBox;
        private System.Windows.Forms.TextBox przygotowanieTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}