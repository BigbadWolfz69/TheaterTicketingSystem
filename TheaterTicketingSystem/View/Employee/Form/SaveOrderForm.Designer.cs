namespace TheaterTicketingSystem.View.Employee.Form
{
    partial class SaveOrderForm
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
            panelMain = new System.Windows.Forms.Panel();
            simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            simpleButtonConfirmOrder = new DevExpress.XtraEditors.SimpleButton();
            labelControlTotalPrice = new DevExpress.XtraEditors.LabelControl();
            labelControlTotalPriceTag = new DevExpress.XtraEditors.LabelControl();
            panelLineTwo = new System.Windows.Forms.Panel();
            labelControlSelectedSeatsOrder = new DevExpress.XtraEditors.LabelControl();
            labelControlSelectedSeats = new DevExpress.XtraEditors.LabelControl();
            panelLineOne = new System.Windows.Forms.Panel();
            labelControlInProgress = new DevExpress.XtraEditors.LabelControl();
            labelControlIncompleteOrder = new DevExpress.XtraEditors.LabelControl();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);
            panelMain.Controls.Add(simpleButtonCancel);
            panelMain.Controls.Add(simpleButtonConfirmOrder);
            panelMain.Controls.Add(labelControlTotalPrice);
            panelMain.Controls.Add(labelControlTotalPriceTag);
            panelMain.Controls.Add(panelLineTwo);
            panelMain.Controls.Add(labelControlSelectedSeatsOrder);
            panelMain.Controls.Add(labelControlSelectedSeats);
            panelMain.Controls.Add(panelLineOne);
            panelMain.Controls.Add(labelControlInProgress);
            panelMain.Controls.Add(labelControlIncompleteOrder);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(409, 428);
            panelMain.TabIndex = 0;
            // 
            // simpleButtonCancel
            // 
            simpleButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            simpleButtonCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(255, 49, 49);
            simpleButtonCancel.Appearance.Font = new System.Drawing.Font("Dubai", 9.649484F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            simpleButtonCancel.Appearance.ForeColor = System.Drawing.Color.White;
            simpleButtonCancel.Appearance.Options.UseBackColor = true;
            simpleButtonCancel.Appearance.Options.UseFont = true;
            simpleButtonCancel.Appearance.Options.UseForeColor = true;
            simpleButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            simpleButtonCancel.Location = new System.Drawing.Point(215, 331);
            simpleButtonCancel.Name = "simpleButtonCancel";
            simpleButtonCancel.Size = new System.Drawing.Size(166, 34);
            simpleButtonCancel.TabIndex = 26;
            simpleButtonCancel.Text = "CANCEL";
            simpleButtonCancel.Click += simpleButtonCancel_Click;
            // 
            // simpleButtonConfirmOrder
            // 
            simpleButtonConfirmOrder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            simpleButtonConfirmOrder.Appearance.BackColor = System.Drawing.Color.FromArgb(0, 191, 99);
            simpleButtonConfirmOrder.Appearance.Font = new System.Drawing.Font("Dubai", 9.649484F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            simpleButtonConfirmOrder.Appearance.ForeColor = System.Drawing.Color.White;
            simpleButtonConfirmOrder.Appearance.Options.UseBackColor = true;
            simpleButtonConfirmOrder.Appearance.Options.UseFont = true;
            simpleButtonConfirmOrder.Appearance.Options.UseForeColor = true;
            simpleButtonConfirmOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            simpleButtonConfirmOrder.Location = new System.Drawing.Point(31, 331);
            simpleButtonConfirmOrder.Name = "simpleButtonConfirmOrder";
            simpleButtonConfirmOrder.Size = new System.Drawing.Size(166, 34);
            simpleButtonConfirmOrder.TabIndex = 25;
            simpleButtonConfirmOrder.Text = "CONFIRM";
            simpleButtonConfirmOrder.Click += simpleButtonConfirmOrder_Click;
            // 
            // labelControlTotalPrice
            // 
            labelControlTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelControlTotalPrice.Appearance.BackColor = System.Drawing.Color.Transparent;
            labelControlTotalPrice.Appearance.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControlTotalPrice.Appearance.ForeColor = System.Drawing.Color.White;
            labelControlTotalPrice.Appearance.Options.UseBackColor = true;
            labelControlTotalPrice.Appearance.Options.UseFont = true;
            labelControlTotalPrice.Appearance.Options.UseForeColor = true;
            labelControlTotalPrice.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            labelControlTotalPrice.AppearanceDisabled.Options.UseBackColor = true;
            labelControlTotalPrice.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            labelControlTotalPrice.AppearanceHovered.Options.UseBackColor = true;
            labelControlTotalPrice.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            labelControlTotalPrice.AppearancePressed.Options.UseBackColor = true;
            labelControlTotalPrice.Location = new System.Drawing.Point(160, 227);
            labelControlTotalPrice.Name = "labelControlTotalPrice";
            labelControlTotalPrice.Size = new System.Drawing.Size(27, 27);
            labelControlTotalPrice.TabIndex = 24;
            labelControlTotalPrice.Text = "420";
            // 
            // labelControlTotalPriceTag
            // 
            labelControlTotalPriceTag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelControlTotalPriceTag.Appearance.BackColor = System.Drawing.Color.Transparent;
            labelControlTotalPriceTag.Appearance.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControlTotalPriceTag.Appearance.ForeColor = System.Drawing.Color.White;
            labelControlTotalPriceTag.Appearance.Options.UseBackColor = true;
            labelControlTotalPriceTag.Appearance.Options.UseFont = true;
            labelControlTotalPriceTag.Appearance.Options.UseForeColor = true;
            labelControlTotalPriceTag.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            labelControlTotalPriceTag.AppearanceDisabled.Options.UseBackColor = true;
            labelControlTotalPriceTag.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            labelControlTotalPriceTag.AppearanceHovered.Options.UseBackColor = true;
            labelControlTotalPriceTag.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            labelControlTotalPriceTag.AppearancePressed.Options.UseBackColor = true;
            labelControlTotalPriceTag.Location = new System.Drawing.Point(31, 227);
            labelControlTotalPriceTag.Name = "labelControlTotalPriceTag";
            labelControlTotalPriceTag.Size = new System.Drawing.Size(123, 27);
            labelControlTotalPriceTag.TabIndex = 23;
            labelControlTotalPriceTag.Text = "TOTAL PRICE :    $";
            // 
            // panelLineTwo
            // 
            panelLineTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelLineTwo.Location = new System.Drawing.Point(31, 210);
            panelLineTwo.Name = "panelLineTwo";
            panelLineTwo.Size = new System.Drawing.Size(350, 2);
            panelLineTwo.TabIndex = 22;
            // 
            // labelControlSelectedSeatsOrder
            // 
            labelControlSelectedSeatsOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelControlSelectedSeatsOrder.Appearance.BackColor = System.Drawing.Color.Transparent;
            labelControlSelectedSeatsOrder.Appearance.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControlSelectedSeatsOrder.Appearance.ForeColor = System.Drawing.Color.White;
            labelControlSelectedSeatsOrder.Appearance.Options.UseBackColor = true;
            labelControlSelectedSeatsOrder.Appearance.Options.UseFont = true;
            labelControlSelectedSeatsOrder.Appearance.Options.UseForeColor = true;
            labelControlSelectedSeatsOrder.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            labelControlSelectedSeatsOrder.AppearanceDisabled.Options.UseBackColor = true;
            labelControlSelectedSeatsOrder.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            labelControlSelectedSeatsOrder.AppearanceHovered.Options.UseBackColor = true;
            labelControlSelectedSeatsOrder.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            labelControlSelectedSeatsOrder.AppearancePressed.Options.UseBackColor = true;
            labelControlSelectedSeatsOrder.Location = new System.Drawing.Point(48, 128);
            labelControlSelectedSeatsOrder.Name = "labelControlSelectedSeatsOrder";
            labelControlSelectedSeatsOrder.Size = new System.Drawing.Size(35, 22);
            labelControlSelectedSeatsOrder.TabIndex = 21;
            labelControlSelectedSeatsOrder.Text = "A1, A2";
            // 
            // labelControlSelectedSeats
            // 
            labelControlSelectedSeats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelControlSelectedSeats.Appearance.BackColor = System.Drawing.Color.Transparent;
            labelControlSelectedSeats.Appearance.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControlSelectedSeats.Appearance.ForeColor = System.Drawing.Color.White;
            labelControlSelectedSeats.Appearance.Options.UseBackColor = true;
            labelControlSelectedSeats.Appearance.Options.UseFont = true;
            labelControlSelectedSeats.Appearance.Options.UseForeColor = true;
            labelControlSelectedSeats.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            labelControlSelectedSeats.AppearanceDisabled.Options.UseBackColor = true;
            labelControlSelectedSeats.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            labelControlSelectedSeats.AppearanceHovered.Options.UseBackColor = true;
            labelControlSelectedSeats.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            labelControlSelectedSeats.AppearancePressed.Options.UseBackColor = true;
            labelControlSelectedSeats.Location = new System.Drawing.Point(31, 95);
            labelControlSelectedSeats.Name = "labelControlSelectedSeats";
            labelControlSelectedSeats.Size = new System.Drawing.Size(123, 27);
            labelControlSelectedSeats.TabIndex = 18;
            labelControlSelectedSeats.Text = "SELECTED SEATS";
            // 
            // panelLineOne
            // 
            panelLineOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelLineOne.Location = new System.Drawing.Point(31, 72);
            panelLineOne.Name = "panelLineOne";
            panelLineOne.Size = new System.Drawing.Size(350, 2);
            panelLineOne.TabIndex = 17;
            // 
            // labelControlInProgress
            // 
            labelControlInProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelControlInProgress.Appearance.BackColor = System.Drawing.Color.Transparent;
            labelControlInProgress.Appearance.Font = new System.Drawing.Font("Dubai", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelControlInProgress.Appearance.ForeColor = System.Drawing.Color.FromArgb(255, 222, 89);
            labelControlInProgress.Appearance.Options.UseBackColor = true;
            labelControlInProgress.Appearance.Options.UseFont = true;
            labelControlInProgress.Appearance.Options.UseForeColor = true;
            labelControlInProgress.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            labelControlInProgress.AppearanceDisabled.Options.UseBackColor = true;
            labelControlInProgress.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            labelControlInProgress.AppearanceHovered.Options.UseBackColor = true;
            labelControlInProgress.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            labelControlInProgress.AppearancePressed.Options.UseBackColor = true;
            labelControlInProgress.Location = new System.Drawing.Point(308, 41);
            labelControlInProgress.Name = "labelControlInProgress";
            labelControlInProgress.Size = new System.Drawing.Size(55, 21);
            labelControlInProgress.TabIndex = 16;
            labelControlInProgress.Text = "In Progress";
            // 
            // labelControlIncompleteOrder
            // 
            labelControlIncompleteOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelControlIncompleteOrder.Appearance.BackColor = System.Drawing.Color.Transparent;
            labelControlIncompleteOrder.Appearance.Font = new System.Drawing.Font("Dubai", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelControlIncompleteOrder.Appearance.ForeColor = System.Drawing.Color.White;
            labelControlIncompleteOrder.Appearance.Options.UseBackColor = true;
            labelControlIncompleteOrder.Appearance.Options.UseFont = true;
            labelControlIncompleteOrder.Appearance.Options.UseForeColor = true;
            labelControlIncompleteOrder.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            labelControlIncompleteOrder.AppearanceDisabled.Options.UseBackColor = true;
            labelControlIncompleteOrder.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            labelControlIncompleteOrder.AppearanceHovered.Options.UseBackColor = true;
            labelControlIncompleteOrder.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            labelControlIncompleteOrder.AppearancePressed.Options.UseBackColor = true;
            labelControlIncompleteOrder.Location = new System.Drawing.Point(31, 28);
            labelControlIncompleteOrder.Name = "labelControlIncompleteOrder";
            labelControlIncompleteOrder.Size = new System.Drawing.Size(180, 40);
            labelControlIncompleteOrder.TabIndex = 15;
            labelControlIncompleteOrder.Text = "Incomplete Order";
            // 
            // SaveOrderForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(409, 428);
            Controls.Add(panelMain);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "SaveOrderForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SaveOrderForm";
            Load += SaveOrderForm_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraEditors.LabelControl labelControlIncompleteOrder;
        private DevExpress.XtraEditors.LabelControl labelControlInProgress;
        private System.Windows.Forms.Panel panelLineOne;
        private DevExpress.XtraEditors.LabelControl labelControlSelectedSeats;
        private DevExpress.XtraEditors.LabelControl labelControlSelectedSeatsOrder;
        private DevExpress.XtraEditors.LabelControl labelControlTotalPriceTag;
        private System.Windows.Forms.Panel panelLineTwo;
        private DevExpress.XtraEditors.LabelControl labelControlTotalPrice;
        private DevExpress.XtraEditors.SimpleButton simpleButtonConfirmOrder;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
    }
}