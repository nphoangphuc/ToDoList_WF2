using System;
using System.Windows.Forms;

namespace ToDoList_WF
{
	partial class InputForm
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
			this.btnClear = new System.Windows.Forms.Button();
			this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
			this.cbDone = new System.Windows.Forms.CheckBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbDescription = new System.Windows.Forms.Label();
			this.lbTitle = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSaveTask = new System.Windows.Forms.Button();
			this.cbAlarm = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			//this.dtpAlarmTime = new System.Windows.Forms.DateTimePicker();
			this.dtpAlarmDate = new System.Windows.Forms.DateTimePicker();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.txtTags = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(397, 517);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(95, 45);
			this.btnClear.TabIndex = 18;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// dtpCreatedDate
			// 
			this.dtpCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpCreatedDate.Location = new System.Drawing.Point(221, 233);
			this.dtpCreatedDate.Name = "dtpCreatedDate";
			this.dtpCreatedDate.Size = new System.Drawing.Size(129, 22);
			this.dtpCreatedDate.TabIndex = 16;
			this.dtpCreatedDate.Value = new System.DateTime(2020, 5, 8, 16, 6, 6, 5);
			this.dtpCreatedDate.ValueChanged += new System.EventHandler(this.dtpCreatedDate_ValueChanged);
			// 
			// cbDone
			// 
			this.cbDone.AutoSize = true;
			this.cbDone.Location = new System.Drawing.Point(221, 482);
			this.cbDone.Name = "cbDone";
			this.cbDone.Size = new System.Drawing.Size(18, 17);
			this.cbDone.TabIndex = 17;
			this.cbDone.UseVisualStyleBackColor = true;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(221, 100);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(271, 106);
			this.txtDescription.TabIndex = 15;
			this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(221, 51);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(271, 22);
			this.txtTitle.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(93, 482);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "Done";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(93, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "Created Date";
			// 
			// lbDescription
			// 
			this.lbDescription.AutoSize = true;
			this.lbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDescription.Location = new System.Drawing.Point(93, 100);
			this.lbDescription.Name = "lbDescription";
			this.lbDescription.Size = new System.Drawing.Size(95, 20);
			this.lbDescription.TabIndex = 11;
			this.lbDescription.Text = "Description";
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(93, 51);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(41, 20);
			this.lbTitle.TabIndex = 10;
			this.lbTitle.Text = "Title";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(214, -1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(278, 39);
			this.label3.TabIndex = 19;
			this.label3.Text = "ADD NEW TASK";
			// 
			// btnSaveTask
			// 
			this.btnSaveTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveTask.Location = new System.Drawing.Point(221, 517);
			this.btnSaveTask.Name = "btnSaveTask";
			this.btnSaveTask.Size = new System.Drawing.Size(91, 45);
			this.btnSaveTask.TabIndex = 20;
			this.btnSaveTask.Text = "Save";
			this.btnSaveTask.UseVisualStyleBackColor = true;
			this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
			// 
			// cbAlarm
			// 
			this.cbAlarm.AutoSize = true;
			this.cbAlarm.Location = new System.Drawing.Point(221, 340);
			this.cbAlarm.Name = "cbAlarm";
			this.cbAlarm.Size = new System.Drawing.Size(18, 17);
			this.cbAlarm.TabIndex = 22;
			this.cbAlarm.UseVisualStyleBackColor = true;
			this.cbAlarm.CheckedChanged += new System.EventHandler(this.cbAlarm_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(93, 340);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 20);
			this.label4.TabIndex = 21;
			this.label4.Text = "Set Alarm";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(93, 384);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 20);
			this.label5.TabIndex = 21;
			this.label5.Text = "Alarm Time";
			// 
			// dtpAlarmTime
			// 
			this.dtpAlarmTime = new DateTimePicker();
			this.dtpAlarmTime.ShowUpDown = true;
			this.dtpAlarmTime.Format = DateTimePickerFormat.Custom;
			this.dtpAlarmTime.CustomFormat = "HH:mm:ss";
			this.dtpAlarmTime.Location = new System.Drawing.Point(397, 384);
			this.dtpAlarmTime.Name = "dtpAlarmTime";
			this.dtpAlarmTime.Size = new System.Drawing.Size(95, 22);
			this.dtpAlarmTime.TabIndex = 23;
			this.dtpAlarmTime.ValueChanged += new System.EventHandler(this.dtpAlarmTime_ValueChanged);
			// 
			// dtpAlarmDate
			// 
			this.dtpAlarmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpAlarmDate.Location = new System.Drawing.Point(221, 384);
			this.dtpAlarmDate.Name = "dtpAlarmDate";
			this.dtpAlarmDate.Size = new System.Drawing.Size(129, 22);
			this.dtpAlarmDate.TabIndex = 24;
			this.dtpAlarmDate.Value = new System.DateTime(2020, 5, 8, 16, 29, 31, 235);
			this.dtpAlarmDate.ValueChanged += new System.EventHandler(this.dtpAlarmDate_ValueChanged);	
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(93, 430);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 20);
			this.label6.TabIndex = 10;
			this.label6.Text = "Tags";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// txtTags
			// 
			this.txtTags.Location = new System.Drawing.Point(221, 430);
			this.txtTags.Name = "txtTags";
			this.txtTags.Size = new System.Drawing.Size(271, 22);
			this.txtTags.TabIndex = 14;
			this.txtTags.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(93, 284);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "Due Date";
			// 
			// dtpDueDate
			// 
			this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDueDate.Location = new System.Drawing.Point(221, 284);
			this.dtpDueDate.Name = "dtpDueDate";
			this.dtpDueDate.Size = new System.Drawing.Size(129, 22);
			this.dtpDueDate.TabIndex = 16;
			this.dtpDueDate.Value = new System.DateTime(2020, 5, 8, 16, 6, 6, 5);
			this.dtpDueDate.ValueChanged += new System.EventHandler(this.dtpCreatedDate_ValueChanged);
			// 
			// InputForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 562);
			this.Controls.Add(this.dtpAlarmDate);
			this.Controls.Add(this.dtpAlarmTime);
			this.Controls.Add(this.cbAlarm);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnSaveTask);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.dtpDueDate);
			this.Controls.Add(this.dtpCreatedDate);
			this.Controls.Add(this.cbDone);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtTags);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbDescription);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lbTitle);
			this.Name = "InputForm";
			this.Text = "InputForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InputForm_FormClosing);
			this.Load += new System.EventHandler(this.InputForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DateTimePicker dtpCreatedDate;
		private System.Windows.Forms.CheckBox cbDone;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbDescription;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSaveTask;
		private CheckBox cbAlarm;
		private Label label4;
		private Label label5;
		private DateTimePicker dtpAlarmTime;
		private DateTimePicker dtpAlarmDate;
		private ErrorProvider errorProvider1;
		private TextBox txtTags;
		private Label label6;
		private DateTimePicker dtpDueDate;
		private Label label7;
	}
}