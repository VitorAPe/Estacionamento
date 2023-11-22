namespace Estacionamento
{
    partial class HomePage
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnDriverTypes = new System.Windows.Forms.ToolStripButton();
            this.tbstnCarTypes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbstnPersonRegistration = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnCheckIn = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCheckOut = new System.Windows.Forms.ToolStripButton();
            this.tsbtnHistory = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnDriverTypes,
            this.tbstnCarTypes,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbstnPersonRegistration,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.tsbtnCheckIn,
            this.tsbtnCheckOut,
            this.tsbtnHistory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(114, 496);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbtnDriverTypes
            // 
            this.tsbtnDriverTypes.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDriverTypes.Image")));
            this.tsbtnDriverTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDriverTypes.Name = "tsbtnDriverTypes";
            this.tsbtnDriverTypes.Size = new System.Drawing.Size(111, 51);
            this.tsbtnDriverTypes.Text = "Driver Types";
            this.tsbtnDriverTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnDriverTypes.Click += new System.EventHandler(this.tsbtnDriverTypes_Click);
            // 
            // tbstnCarTypes
            // 
            this.tbstnCarTypes.Image = ((System.Drawing.Image)(resources.GetObject("tbstnCarTypes.Image")));
            this.tbstnCarTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbstnCarTypes.Name = "tbstnCarTypes";
            this.tbstnCarTypes.Size = new System.Drawing.Size(111, 51);
            this.tbstnCarTypes.Text = "Auto Types";
            this.tbstnCarTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbstnCarTypes.Click += new System.EventHandler(this.tbstnCarTypes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(101, 21);
            this.toolStripLabel1.Text = "Registration";
            // 
            // tbstnPersonRegistration
            // 
            this.tbstnPersonRegistration.Image = ((System.Drawing.Image)(resources.GetObject("tbstnPersonRegistration.Image")));
            this.tbstnPersonRegistration.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbstnPersonRegistration.Name = "tbstnPersonRegistration";
            this.tbstnPersonRegistration.Size = new System.Drawing.Size(111, 51);
            this.tbstnPersonRegistration.Text = "Registration";
            this.tbstnPersonRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(111, 51);
            this.toolStripButton1.Text = "All Vehicles";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(101, 21);
            this.toolStripLabel2.Text = "Parking";
            // 
            // tsbtnCheckIn
            // 
            this.tsbtnCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCheckIn.Image")));
            this.tsbtnCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCheckIn.Name = "tsbtnCheckIn";
            this.tsbtnCheckIn.Size = new System.Drawing.Size(111, 51);
            this.tsbtnCheckIn.Text = "Check In";
            this.tsbtnCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCheckIn.ToolTipText = "Check In";
            // 
            // tsbtnCheckOut
            // 
            this.tsbtnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCheckOut.Image")));
            this.tsbtnCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCheckOut.Name = "tsbtnCheckOut";
            this.tsbtnCheckOut.Size = new System.Drawing.Size(111, 51);
            this.tsbtnCheckOut.Text = "Check Out";
            this.tsbtnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnCheckOut.ToolTipText = "Check In";
            // 
            // tsbtnHistory
            // 
            this.tsbtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnHistory.Image")));
            this.tsbtnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHistory.Name = "tsbtnHistory";
            this.tsbtnHistory.Size = new System.Drawing.Size(111, 51);
            this.tsbtnHistory.Text = "Parking History";
            this.tsbtnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnHistory.ToolTipText = "History";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(114, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 496);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnDriverTypes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton tbstnCarTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tbstnPersonRegistration;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbtnCheckIn;
        private System.Windows.Forms.ToolStripButton tsbtnCheckOut;
        private System.Windows.Forms.ToolStripButton tsbtnHistory;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

