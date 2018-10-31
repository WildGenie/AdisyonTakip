namespace AdisyonTakip
{
    partial class Form1
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.verilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdi1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrup1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltGrup1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardView1
            // 
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl2;
            this.cardView1.Name = "cardView1";
            // 
            // gridControl2
            // 
            this.gridControl2.DataMember = "Fisler";
            this.gridControl2.DataSource = this.verilerBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Adisyonlar";
            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(471, 245);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.cardView1});
            // 
            // verilerBindingSource
            // 
            this.verilerBindingSource.DataSource = typeof(AdisyonTakip.Veriler);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi1,
            this.colGrup1,
            this.colAltGrup1,
            this.colFiyat1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colAdi1
            // 
            this.colAdi1.FieldName = "Adi";
            this.colAdi1.Name = "colAdi1";
            this.colAdi1.Visible = true;
            this.colAdi1.VisibleIndex = 0;
            // 
            // colGrup1
            // 
            this.colGrup1.FieldName = "Grup";
            this.colGrup1.Name = "colGrup1";
            this.colGrup1.Visible = true;
            this.colGrup1.VisibleIndex = 1;
            // 
            // colAltGrup1
            // 
            this.colAltGrup1.FieldName = "AltGrup";
            this.colAltGrup1.Name = "colAltGrup1";
            this.colAltGrup1.Visible = true;
            this.colAltGrup1.VisibleIndex = 2;
            // 
            // colFiyat1
            // 
            this.colFiyat1.FieldName = "Fiyat";
            this.colFiyat1.Name = "colFiyat1";
            this.colFiyat1.Visible = true;
            this.colFiyat1.VisibleIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Urunler";
            this.gridControl1.DataSource = this.verilerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(442, 245);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi,
            this.colGrup,
            this.colAltGrup,
            this.colFiyat});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // colAdi
            // 
            this.colAdi.FieldName = "Adi";
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            // 
            // colGrup
            // 
            this.colGrup.FieldName = "Grup";
            this.colGrup.Name = "colGrup";
            this.colGrup.Visible = true;
            this.colGrup.VisibleIndex = 1;
            // 
            // colAltGrup
            // 
            this.colAltGrup.FieldName = "AltGrup";
            this.colAltGrup.Name = "colAltGrup";
            this.colAltGrup.Visible = true;
            this.colAltGrup.VisibleIndex = 2;
            // 
            // colFiyat
            // 
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Form2\'yi Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 44);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(918, 245);
            this.splitContainerControl1.SplitterPosition = 442;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 301);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource verilerBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colGrup;
        private DevExpress.XtraGrid.Columns.GridColumn colAltGrup;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi1;
        private DevExpress.XtraGrid.Columns.GridColumn colGrup1;
        private DevExpress.XtraGrid.Columns.GridColumn colAltGrup1;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
    }
}

