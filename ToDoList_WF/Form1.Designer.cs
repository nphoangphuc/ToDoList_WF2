using System.Windows.Forms;

namespace ToDoList_WF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lbTitleName = new System.Windows.Forms.Label();
			this.btnNewTask = new System.Windows.Forms.Button();
			this.btnDoneTask = new System.Windows.Forms.Button();
			this.btnDeleteTask = new System.Windows.Forms.Button();
			this.btnSaveList = new System.Windows.Forms.Button();
			this.btnLoadList = new System.Windows.Forms.Button();
			this.dgvTaskList = new System.Windows.Forms.DataGridView();
			this.colSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAlarmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAlarmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.btnUndoneTask = new System.Windows.Forms.Button();
			this.btnEditTask = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
			this.SuspendLayout();
			// 
			// lbTitleName
			// 
			this.lbTitleName.AutoSize = true;
			this.lbTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitleName.Location = new System.Drawing.Point(475, 8);
			this.lbTitleName.Name = "lbTitleName";
			this.lbTitleName.Size = new System.Drawing.Size(208, 39);
			this.lbTitleName.TabIndex = 0;
			this.lbTitleName.Text = "TO-DO LIST";
			// 
			// btnNewTask
			// 
			this.btnNewTask.AutoSize = true;
			this.btnNewTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewTask.BackgroundImage")));
			this.btnNewTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewTask.Location = new System.Drawing.Point(1053, 83);
			this.btnNewTask.Name = "btnNewTask";
			this.btnNewTask.Size = new System.Drawing.Size(46, 46);
			this.btnNewTask.TabIndex = 9;
			this.btnNewTask.UseVisualStyleBackColor = true;
			this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
			// 
			// btnDoneTask
			// 
			this.btnDoneTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoneTask.Location = new System.Drawing.Point(952, 8);
			this.btnDoneTask.Name = "btnDoneTask";
			this.btnDoneTask.Size = new System.Drawing.Size(101, 33);
			this.btnDoneTask.TabIndex = 11;
			this.btnDoneTask.Text = "Done";
			this.btnDoneTask.UseVisualStyleBackColor = true;
			this.btnDoneTask.Click += new System.EventHandler(this.btnDoneTask_Click);
			// 
			// btnDeleteTask
			// 
			this.btnDeleteTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteTask.BackgroundImage")));
			this.btnDeleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteTask.Location = new System.Drawing.Point(992, 83);
			this.btnDeleteTask.Name = "btnDeleteTask";
			this.btnDeleteTask.Size = new System.Drawing.Size(46, 46);
			this.btnDeleteTask.TabIndex = 12;
			this.btnDeleteTask.UseVisualStyleBackColor = true;
			this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
			// 
			// btnSaveList
			// 
			this.btnSaveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveList.Location = new System.Drawing.Point(12, 8);
			this.btnSaveList.Name = "btnSaveList";
			this.btnSaveList.Size = new System.Drawing.Size(101, 33);
			this.btnSaveList.TabIndex = 13;
			this.btnSaveList.Text = "Save List";
			this.btnSaveList.UseVisualStyleBackColor = true;
			this.btnSaveList.Click += new System.EventHandler(this.btnSaveList_Click);
			// 
			// btnLoadList
			// 
			this.btnLoadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoadList.Location = new System.Drawing.Point(119, 8);
			this.btnLoadList.Name = "btnLoadList";
			this.btnLoadList.Size = new System.Drawing.Size(101, 33);
			this.btnLoadList.TabIndex = 14;
			this.btnLoadList.Text = "Load List";
			this.btnLoadList.UseVisualStyleBackColor = true;
			this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click);
			// 
			// dgvTaskList
			// 
			this.dgvTaskList.AllowUserToAddRows = false;
			this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.colID,
            this.colTitle,
            this.colDescription,
            this.colCreatedDate,
            this.colDueDate,
            this.colAlarmDate,
            this.colAlarmTime,
            this.colTags,
            this.colDone});
			this.dgvTaskList.Location = new System.Drawing.Point(12, 135);
			this.dgvTaskList.Name = "dgvTaskList";
			this.dgvTaskList.RowHeadersWidth = 51;
			this.dgvTaskList.RowTemplate.Height = 24;
			this.dgvTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTaskList.Size = new System.Drawing.Size(1148, 420);
			this.dgvTaskList.TabIndex = 15;
			this.dgvTaskList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaskList_CellClick);
			this.dgvTaskList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaskList_CellValueChanged);
			// 
			// colSelected
			// 
			this.colSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.colSelected.DataPropertyName = "Selected";
			this.colSelected.HeaderText = "";
			this.colSelected.MinimumWidth = 6;
			this.colSelected.Name = "colSelected";
			this.colSelected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colSelected.Width = 23;
			// 
			// colID
			// 
			this.colID.DataPropertyName = "ID";
			this.colID.HeaderText = "ID";
			this.colID.MinimumWidth = 6;
			this.colID.Name = "colID";
			this.colID.ReadOnly = true;
			this.colID.Width = 62;
			// 
			// colTitle
			// 
			this.colTitle.DataPropertyName = "Title";
			this.colTitle.HeaderText = "Title";
			this.colTitle.MinimumWidth = 6;
			this.colTitle.Name = "colTitle";
			this.colTitle.ReadOnly = true;
			this.colTitle.Width = 125;
			// 
			// colDescription
			// 
			this.colDescription.DataPropertyName = "Description";
			this.colDescription.HeaderText = "Description";
			this.colDescription.MinimumWidth = 6;
			this.colDescription.Name = "colDescription";
			this.colDescription.ReadOnly = true;
			this.colDescription.Width = 150;
			// 
			// colCreatedDate
			// 
			this.colCreatedDate.DataPropertyName = "CreatedDate";
			dataGridViewCellStyle1.Format = "dd/MM/yyyy";
			this.colCreatedDate.DefaultCellStyle = dataGridViewCellStyle1;
			this.colCreatedDate.HeaderText = "Created Date";
			this.colCreatedDate.MinimumWidth = 6;
			this.colCreatedDate.Name = "colCreatedDate";
			this.colCreatedDate.ReadOnly = true;
			this.colCreatedDate.Width = 80;
			// 
			// colDueDate
			// 
			this.colDueDate.DataPropertyName = "DueDate";
			this.colDueDate.HeaderText = "Due Date";
			this.colDueDate.MinimumWidth = 6;
			this.colDueDate.Name = "colDueDate";
			this.colDueDate.ReadOnly = true;
			this.colDueDate.Width = 80;
			// 
			// colAlarmDate
			// 
			this.colAlarmDate.DataPropertyName = "AlarmDate";
			dataGridViewCellStyle2.Format = "dd/MM/yyyy";
			this.colAlarmDate.DefaultCellStyle = dataGridViewCellStyle2;
			this.colAlarmDate.HeaderText = "Alarm Date";
			this.colAlarmDate.MinimumWidth = 6;
			this.colAlarmDate.Name = "colAlarmDate";
			this.colAlarmDate.ReadOnly = true;
			this.colAlarmDate.Width = 80;
			// 
			// colAlarmTime
			// 
			this.colAlarmTime.DataPropertyName = "AlarmTime";
			dataGridViewCellStyle3.Format = "HH:mm:ss";
			this.colAlarmTime.DefaultCellStyle = dataGridViewCellStyle3;
			this.colAlarmTime.HeaderText = "Alarm Time";
			this.colAlarmTime.MinimumWidth = 6;
			this.colAlarmTime.Name = "colAlarmTime";
			this.colAlarmTime.ReadOnly = true;
			this.colAlarmTime.Width = 80;
			// 
			// colTags
			// 
			this.colTags.DataPropertyName = "Tags";
			this.colTags.HeaderText = "Tags";
			this.colTags.MinimumWidth = 6;
			this.colTags.Name = "colTags";
			this.colTags.ReadOnly = true;
			this.colTags.Width = 80;
			// 
			// colDone
			// 
			this.colDone.DataPropertyName = "Done";
			this.colDone.HeaderText = "Done";
			this.colDone.MinimumWidth = 6;
			this.colDone.Name = "colDone";
			this.colDone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colDone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colDone.Width = 50;
			// 
			// btnUndoneTask
			// 
			this.btnUndoneTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUndoneTask.Location = new System.Drawing.Point(1059, 8);
			this.btnUndoneTask.Name = "btnUndoneTask";
			this.btnUndoneTask.Size = new System.Drawing.Size(101, 33);
			this.btnUndoneTask.TabIndex = 11;
			this.btnUndoneTask.Text = "Undone";
			this.btnUndoneTask.UseVisualStyleBackColor = true;
			this.btnUndoneTask.Click += new System.EventHandler(this.btnUndoneTask_Click);
			// 
			// btnEditTask
			// 
			this.btnEditTask.AutoSize = true;
			this.btnEditTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditTask.BackgroundImage")));
			this.btnEditTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnEditTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditTask.Location = new System.Drawing.Point(1114, 83);
			this.btnEditTask.Name = "btnEditTask";
			this.btnEditTask.Size = new System.Drawing.Size(46, 46);
			this.btnEditTask.TabIndex = 16;
			this.btnEditTask.UseVisualStyleBackColor = true;
			this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.AccessibleDescription = "Search by tags";
			this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.txtSearch.Location = new System.Drawing.Point(12, 97);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(208, 32);
			this.txtSearch.TabIndex = 17;
			this.txtSearch.Text = "Search by tag";
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
			this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1178, 558);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.btnEditTask);
			this.Controls.Add(this.dgvTaskList);
			this.Controls.Add(this.btnLoadList);
			this.Controls.Add(this.btnSaveList);
			this.Controls.Add(this.btnDeleteTask);
			this.Controls.Add(this.btnUndoneTask);
			this.Controls.Add(this.btnDoneTask);
			this.Controls.Add(this.btnNewTask);
			this.Controls.Add(this.lbTitleName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbTitleName;
		private System.Windows.Forms.Button btnNewTask;
		private System.Windows.Forms.Button btnDoneTask;
		private System.Windows.Forms.Button btnDeleteTask;
		private System.Windows.Forms.Button btnSaveList;
		private System.Windows.Forms.Button btnLoadList;
		internal System.Windows.Forms.DataGridView dgvTaskList;
		private System.Windows.Forms.Button btnUndoneTask;
		private System.Windows.Forms.Button btnEditTask;
		private DataGridViewCheckBoxColumn colSelected;
		private DataGridViewTextBoxColumn colID;
		private DataGridViewTextBoxColumn colTitle;
		private DataGridViewTextBoxColumn colDescription;
		private DataGridViewTextBoxColumn colCreatedDate;
		private DataGridViewTextBoxColumn colDueDate;
		private DataGridViewTextBoxColumn colAlarmDate;
		private DataGridViewTextBoxColumn colAlarmTime;
		private DataGridViewTextBoxColumn colTags;
		private DataGridViewCheckBoxColumn colDone;
		private TextBox txtSearch;
	}
}

