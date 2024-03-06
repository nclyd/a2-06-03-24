
namespace booking_a2.gui
{
    partial class BookingForm
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
            this.txtbForename = new System.Windows.Forms.TextBox();
            this.txtbSurname = new System.Windows.Forms.TextBox();
            this.txtbTelNo = new System.Windows.Forms.TextBox();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.calEnd = new System.Windows.Forms.MonthCalendar();
            this.calStart = new System.Windows.Forms.MonthCalendar();
            this.dgvAvaillablePods = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBookingPods = new System.Windows.Forms.DataGridView();
            this.ChooseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberStaying = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cboxSelectCustomer = new System.Windows.Forms.ComboBox();
            this.lblSelectCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaillablePods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingPods)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbForename
            // 
            this.txtbForename.Location = new System.Drawing.Point(936, 246);
            this.txtbForename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbForename.Name = "txtbForename";
            this.txtbForename.Size = new System.Drawing.Size(148, 26);
            this.txtbForename.TabIndex = 0;
            // 
            // txtbSurname
            // 
            this.txtbSurname.Location = new System.Drawing.Point(936, 346);
            this.txtbSurname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbSurname.Name = "txtbSurname";
            this.txtbSurname.Size = new System.Drawing.Size(148, 26);
            this.txtbSurname.TabIndex = 1;
            // 
            // txtbTelNo
            // 
            this.txtbTelNo.Location = new System.Drawing.Point(936, 446);
            this.txtbTelNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbTelNo.Name = "txtbTelNo";
            this.txtbTelNo.Size = new System.Drawing.Size(148, 26);
            this.txtbTelNo.TabIndex = 2;
            // 
            // txtbAddress
            // 
            this.txtbAddress.Location = new System.Drawing.Point(936, 548);
            this.txtbAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(148, 26);
            this.txtbAddress.TabIndex = 3;
            // 
            // calEnd
            // 
            this.calEnd.Location = new System.Drawing.Point(429, 63);
            this.calEnd.Margin = new System.Windows.Forms.Padding(14);
            this.calEnd.Name = "calEnd";
            this.calEnd.TabIndex = 15;
            // 
            // calStart
            // 
            this.calStart.Location = new System.Drawing.Point(27, 63);
            this.calStart.Margin = new System.Windows.Forms.Padding(14);
            this.calStart.Name = "calStart";
            this.calStart.ShowToday = false;
            this.calStart.TabIndex = 14;
            // 
            // dgvAvaillablePods
            // 
            this.dgvAvaillablePods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvaillablePods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Type,
            this.Capacity});
            this.dgvAvaillablePods.Location = new System.Drawing.Point(27, 346);
            this.dgvAvaillablePods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAvaillablePods.Name = "dgvAvaillablePods";
            this.dgvAvaillablePods.RowHeadersWidth = 62;
            this.dgvAvaillablePods.Size = new System.Drawing.Size(742, 300);
            this.dgvAvaillablePods.TabIndex = 16;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.Width = 150;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 8;
            this.Capacity.Name = "Capacity";
            this.Capacity.Width = 150;
            // 
            // dgvBookingPods
            // 
            this.dgvBookingPods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingPods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChooseID,
            this.NumberStaying});
            this.dgvBookingPods.Location = new System.Drawing.Point(27, 671);
            this.dgvBookingPods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBookingPods.Name = "dgvBookingPods";
            this.dgvBookingPods.RowHeadersWidth = 62;
            this.dgvBookingPods.Size = new System.Drawing.Size(367, 231);
            this.dgvBookingPods.TabIndex = 17;
            // 
            // ChooseID
            // 
            this.ChooseID.HeaderText = "Choose ID";
            this.ChooseID.MinimumWidth = 8;
            this.ChooseID.Name = "ChooseID";
            this.ChooseID.Width = 150;
            // 
            // NumberStaying
            // 
            this.NumberStaying.HeaderText = "How many staying?";
            this.NumberStaying.MinimumWidth = 8;
            this.NumberStaying.Name = "NumberStaying";
            this.NumberStaying.Width = 150;
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(1016, 832);
            this.btnConfirmBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(112, 35);
            this.btnConfirmBooking.TabIndex = 18;
            this.btnConfirmBooking.Text = "Confirm";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Location = new System.Drawing.Point(852, 832);
            this.btnCancelBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(112, 35);
            this.btnCancelBooking.TabIndex = 19;
            this.btnCancelBooking.Text = "Cancel";
            this.btnCancelBooking.UseVisualStyleBackColor = true;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Location = new System.Drawing.Point(825, 251);
            this.lblForename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(86, 20);
            this.lblForename.TabIndex = 20;
            this.lblForename.Text = "Forename:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(825, 357);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(78, 20);
            this.lblSurname.TabIndex = 21;
            this.lblSurname.Text = "Surname:";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(825, 457);
            this.lblTelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(54, 20);
            this.lblTelNo.TabIndex = 22;
            this.lblTelNo.Text = "TelNo:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(825, 548);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 23;
            this.lblAddress.Text = "Address:";
            // 
            // cboxSelectCustomer
            // 
            this.cboxSelectCustomer.FormattingEnabled = true;
            this.cboxSelectCustomer.Location = new System.Drawing.Point(805, 115);
            this.cboxSelectCustomer.Name = "cboxSelectCustomer";
            this.cboxSelectCustomer.Size = new System.Drawing.Size(336, 28);
            this.cboxSelectCustomer.TabIndex = 24;
            // 
            // lblSelectCustomer
            // 
            this.lblSelectCustomer.AutoSize = true;
            this.lblSelectCustomer.Location = new System.Drawing.Point(801, 72);
            this.lblSelectCustomer.Name = "lblSelectCustomer";
            this.lblSelectCustomer.Size = new System.Drawing.Size(131, 20);
            this.lblSelectCustomer.TabIndex = 25;
            this.lblSelectCustomer.Text = "Select Customer:";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 940);
            this.Controls.Add(this.lblSelectCustomer);
            this.Controls.Add(this.cboxSelectCustomer);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblForename);
            this.Controls.Add(this.btnCancelBooking);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.dgvBookingPods);
            this.Controls.Add(this.dgvAvaillablePods);
            this.Controls.Add(this.calEnd);
            this.Controls.Add(this.calStart);
            this.Controls.Add(this.txtbAddress);
            this.Controls.Add(this.txtbTelNo);
            this.Controls.Add(this.txtbSurname);
            this.Controls.Add(this.txtbForename);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookingForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvaillablePods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingPods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbForename;
        private System.Windows.Forms.TextBox txtbSurname;
        private System.Windows.Forms.TextBox txtbTelNo;
        private System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.MonthCalendar calEnd;
        private System.Windows.Forms.MonthCalendar calStart;
        private System.Windows.Forms.DataGridView dgvAvaillablePods;
        private System.Windows.Forms.DataGridView dgvBookingPods;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChooseID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NumberStaying;
        private System.Windows.Forms.ComboBox cboxSelectCustomer;
        private System.Windows.Forms.Label lblSelectCustomer;
    }
}