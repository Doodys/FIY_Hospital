namespace FIY_Hospital
{
    partial class Client
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialisationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardiologistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urologistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neurologistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laryngologistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cardiologistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.urologistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.laryngologistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nurseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(173, 605);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(969, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel.Text = "Stan";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.specialisationsToolStripMenuItem,
            this.shiftsToolStripMenuItem,
            this.administratorPanelToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(173, 627);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.employeesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorsToolStripMenuItem,
            this.nursesToolStripMenuItem,
            this.administratorsToolStripMenuItem});
            this.employeesToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Employees__Copy_;
            this.employeesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.employeesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(155, 154);
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorsToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Doctors__Copy_;
            this.doctorsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(201, 156);
            this.doctorsToolStripMenuItem.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);
            // 
            // nursesToolStripMenuItem
            // 
            this.nursesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nursesToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Nurses__Copy_;
            this.nursesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nursesToolStripMenuItem.Name = "nursesToolStripMenuItem";
            this.nursesToolStripMenuItem.Size = new System.Drawing.Size(201, 156);
            this.nursesToolStripMenuItem.Click += new System.EventHandler(this.nursesToolStripMenuItem_Click);
            // 
            // administratorsToolStripMenuItem
            // 
            this.administratorsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.administratorsToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Administrators__Copy_;
            this.administratorsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administratorsToolStripMenuItem.Name = "administratorsToolStripMenuItem";
            this.administratorsToolStripMenuItem.Size = new System.Drawing.Size(201, 156);
            this.administratorsToolStripMenuItem.Click += new System.EventHandler(this.administratorsToolStripMenuItem_Click);
            // 
            // specialisationsToolStripMenuItem
            // 
            this.specialisationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.specialisationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardiologistToolStripMenuItem,
            this.urologistToolStripMenuItem,
            this.neurologistToolStripMenuItem,
            this.laryngologistToolStripMenuItem,
            this.nurseToolStripMenuItem});
            this.specialisationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.specialisationsToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Specialization__Copy_;
            this.specialisationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.specialisationsToolStripMenuItem.Name = "specialisationsToolStripMenuItem";
            this.specialisationsToolStripMenuItem.Size = new System.Drawing.Size(160, 154);
            // 
            // cardiologistToolStripMenuItem
            // 
            this.cardiologistToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Cardiologist__Copy_;
            this.cardiologistToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cardiologistToolStripMenuItem.Name = "cardiologistToolStripMenuItem";
            this.cardiologistToolStripMenuItem.Size = new System.Drawing.Size(204, 156);
            this.cardiologistToolStripMenuItem.Click += new System.EventHandler(this.cardiologistToolStripMenuItem_Click);
            // 
            // urologistToolStripMenuItem
            // 
            this.urologistToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Urologist__Copy_;
            this.urologistToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.urologistToolStripMenuItem.Name = "urologistToolStripMenuItem";
            this.urologistToolStripMenuItem.Size = new System.Drawing.Size(204, 156);
            this.urologistToolStripMenuItem.Click += new System.EventHandler(this.urologistToolStripMenuItem_Click);
            // 
            // neurologistToolStripMenuItem
            // 
            this.neurologistToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Neurologist__Copy_;
            this.neurologistToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.neurologistToolStripMenuItem.Name = "neurologistToolStripMenuItem";
            this.neurologistToolStripMenuItem.Size = new System.Drawing.Size(204, 156);
            this.neurologistToolStripMenuItem.Click += new System.EventHandler(this.neurologistToolStripMenuItem_Click);
            // 
            // laryngologistToolStripMenuItem
            // 
            this.laryngologistToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Laryngologist__Copy_;
            this.laryngologistToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.laryngologistToolStripMenuItem.Name = "laryngologistToolStripMenuItem";
            this.laryngologistToolStripMenuItem.Size = new System.Drawing.Size(204, 156);
            this.laryngologistToolStripMenuItem.Click += new System.EventHandler(this.laryngologistToolStripMenuItem_Click);
            // 
            // nurseToolStripMenuItem
            // 
            this.nurseToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Nurses__Copy_;
            this.nurseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nurseToolStripMenuItem.Name = "nurseToolStripMenuItem";
            this.nurseToolStripMenuItem.Size = new System.Drawing.Size(204, 156);
            this.nurseToolStripMenuItem.Click += new System.EventHandler(this.nurseToolStripMenuItem_Click);
            // 
            // shiftsToolStripMenuItem
            // 
            this.shiftsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.shiftsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.cardiologistToolStripMenuItem1,
            this.urologistToolStripMenuItem1,
            this.laryngologistToolStripMenuItem1,
            this.nurseToolStripMenuItem1,
            this.administratorsToolStripMenuItem1});
            this.shiftsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.shiftsToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Shifts__Copy_;
            this.shiftsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.shiftsToolStripMenuItem.Name = "shiftsToolStripMenuItem";
            this.shiftsToolStripMenuItem.Size = new System.Drawing.Size(160, 154);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Neurologist__Copy_;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(204, 156);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // cardiologistToolStripMenuItem1
            // 
            this.cardiologistToolStripMenuItem1.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Cardiologist__Copy_;
            this.cardiologistToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cardiologistToolStripMenuItem1.Name = "cardiologistToolStripMenuItem1";
            this.cardiologistToolStripMenuItem1.Size = new System.Drawing.Size(204, 156);
            this.cardiologistToolStripMenuItem1.Click += new System.EventHandler(this.cardiologistToolStripMenuItem1_Click);
            // 
            // urologistToolStripMenuItem1
            // 
            this.urologistToolStripMenuItem1.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Urologist__Copy_;
            this.urologistToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.urologistToolStripMenuItem1.Name = "urologistToolStripMenuItem1";
            this.urologistToolStripMenuItem1.Size = new System.Drawing.Size(204, 156);
            this.urologistToolStripMenuItem1.Click += new System.EventHandler(this.urologistToolStripMenuItem1_Click);
            // 
            // laryngologistToolStripMenuItem1
            // 
            this.laryngologistToolStripMenuItem1.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Laryngologist__Copy_;
            this.laryngologistToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.laryngologistToolStripMenuItem1.Name = "laryngologistToolStripMenuItem1";
            this.laryngologistToolStripMenuItem1.Size = new System.Drawing.Size(204, 156);
            this.laryngologistToolStripMenuItem1.Click += new System.EventHandler(this.laryngologistToolStripMenuItem1_Click);
            // 
            // nurseToolStripMenuItem1
            // 
            this.nurseToolStripMenuItem1.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Nurses__Copy_;
            this.nurseToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nurseToolStripMenuItem1.Name = "nurseToolStripMenuItem1";
            this.nurseToolStripMenuItem1.Size = new System.Drawing.Size(204, 156);
            this.nurseToolStripMenuItem1.Click += new System.EventHandler(this.nurseToolStripMenuItem1_Click);
            // 
            // administratorsToolStripMenuItem1
            // 
            this.administratorsToolStripMenuItem1.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_Administrators__Copy_;
            this.administratorsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administratorsToolStripMenuItem1.Name = "administratorsToolStripMenuItem1";
            this.administratorsToolStripMenuItem1.Size = new System.Drawing.Size(204, 156);
            this.administratorsToolStripMenuItem1.Click += new System.EventHandler(this.administratorsToolStripMenuItem1_Click);
            // 
            // administratorPanelToolStripMenuItem
            // 
            this.administratorPanelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.administratorPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEmployeeDataToolStripMenuItem,
            this.addEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.administratorPanelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.administratorPanelToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_AdminPanel__Copy_;
            this.administratorPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.administratorPanelToolStripMenuItem.Name = "administratorPanelToolStripMenuItem";
            this.administratorPanelToolStripMenuItem.Size = new System.Drawing.Size(160, 154);
            // 
            // editEmployeeDataToolStripMenuItem
            // 
            this.editEmployeeDataToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_EditEmployee__Copy_;
            this.editEmployeeDataToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editEmployeeDataToolStripMenuItem.Name = "editEmployeeDataToolStripMenuItem";
            this.editEmployeeDataToolStripMenuItem.Size = new System.Drawing.Size(314, 156);
            this.editEmployeeDataToolStripMenuItem.Click += new System.EventHandler(this.editEmployeeDataToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_AddEmployee__Copy_;
            this.addEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(314, 156);
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Image = global::FIY_Hospital.Properties.Resources.FIY_Hospital_DeleteEmployee__Copy_;
            this.deleteEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(314, 156);
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = global::FIY_Hospital.Properties.Resources.FYI_Hospital_Welcome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 627);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIY Hospital";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_FormClosing);
            this.Load += new System.EventHandler(this.Client_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialisationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardiologistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urologistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neurologistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laryngologistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardiologistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem urologistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem laryngologistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nurseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administratorsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}



