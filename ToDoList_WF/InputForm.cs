using System;
using System.Windows.Forms;

namespace ToDoList_WF
{
	public partial class InputForm : Form
	{
		public string Title;
		public string Description;
		public DateTime CreatedDate;
		public bool Done;
		public bool SetAlarm;
		public DateTime AlarmDate;
		public string AlarmTime;
		public string Tags;
		public DateTime DueDate;
		//Form1 form2 = new Form1();

		public InputForm()
		{
			InitializeComponent();
			dtpAlarmDate.Enabled = false;
			dtpAlarmTime.Enabled = false;
			PassData();
		}

		/// <summary>
		/// Receive Data from DataGridView Current Cell to Textbox in InputForm
		/// </summary>
		public void PassData()
		{
			//If flag == false --> editing --> add data from current cell to input boxes
			//Form1.form1.flag
			if (!Form1.form1.flag)
			{
				txtTitle.Text = Form1.form1.dgvTaskList.CurrentRow.Cells["colTitle"].Value.ToString();
				txtDescription.Text = Form1.form1.dgvTaskList.CurrentRow.Cells["colDescription"].Value.ToString();
				dtpCreatedDate.Text = Form1.form1.dgvTaskList.CurrentRow.Cells["colCreatedDate"].Value.ToString();
				dtpDueDate.Text = Form1.form1.dgvTaskList.CurrentRow.Cells["colDueDate"].Value.ToString();
				if (Convert.IsDBNull(Form1.form1.dgvTaskList.CurrentRow.Cells["colDone"].Value))
				{
					cbDone.Checked = false;
				}
				else
				{
					cbDone.Checked = Convert.ToBoolean(Form1.form1.dgvTaskList.CurrentRow.Cells["colDone"].Value);
				}
				if (Convert.IsDBNull(Form1.form1.dgvTaskList.CurrentRow.Cells["colAlarmDate"].Value) || Convert.IsDBNull(Form1.form1.dgvTaskList.CurrentRow.Cells["colAlarmTime"].Value))
				{
				}
				else
				{
					cbAlarm.Checked = true;
					dtpAlarmDate.Text = Form1.form1.dgvTaskList.CurrentRow.Cells["colAlarmDate"].Value.ToString();
					dtpAlarmTime.Text = Form1.form1.dgvTaskList.CurrentRow.Cells["colAlarmTime"].Value.ToString();
				}
				txtTags.Text = Form1.form1.dgvTaskList.CurrentRow.Cells["colTags"].Value.ToString();
			}
		}

		/// <summary>
		/// Clear existing input data
		/// </summary>
		public void ClearForm()
		{
			txtTitle.Clear();
			txtDescription.Clear();
			dtpCreatedDate.Value = System.DateTime.Now.Date;
			dtpDueDate.Value = System.DateTime.Now.Date;
			cbAlarm.Checked = false;
			txtTags.Clear();
			cbDone.Checked = false;
		}

		/// <summary>
		/// Assign input data to variable and send to Add Data method in Form1
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSaveTask_Click(object sender, EventArgs e)
		{
			//Assign data to variable
			Title = txtTitle.Text;
			Description = txtDescription.Text;
			CreatedDate = dtpCreatedDate.Value;
			Done = cbDone.Checked;
			SetAlarm = cbAlarm.Checked;
			if (SetAlarm)
			{
				AlarmDate = dtpAlarmDate.Value;
				AlarmTime = Convert.ToString(dtpAlarmTime.Value).Split(' ')[1];
			}
			DueDate = dtpDueDate.Value;
			Tags = txtTags.Text;

			//Call AddTask Method in Form1
			Form1.form1.AddTask();
			ClearForm();
			if (!Form1.form1.flag) this.Close();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		/// <summary>
		/// Check if there is unsaved data when closing Input Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (txtTitle.Text != "" || txtDescription.Text != "")
			{
				//Show dialog to confirm
				var closeMsg = MessageBox.Show("Save before Exit", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				//Action based on choosen diaglog result
				if (closeMsg == DialogResult.Yes)
				{
					btnSaveTask_Click(sender, e);
				}
				else if (closeMsg == DialogResult.No)
				{
					e.Cancel = false;
				}
				else
				{
					e.Cancel = true;
				}
			}
		}

		private void InputForm_Load(object sender, EventArgs e)
		{
		}

		private void dtpAlarmTime_ValueChanged(object sender, EventArgs e)
		{
		}

		private void dtpAlarmDate_ValueChanged(object sender, EventArgs e)
		{
		}

		private void dtpCreatedDate_ValueChanged(object sender, EventArgs e)
		{
		}

		private void cbAlarm_CheckedChanged(object sender, EventArgs e)
		{
			if (cbAlarm.Checked)
			{
				dtpAlarmDate.Enabled = true;
				dtpAlarmTime.Enabled = true;
			}
			else
			{
				dtpAlarmDate.Enabled = false;
				dtpAlarmTime.Enabled = false;
			}
		}

		private void txtDescription_TextChanged(object sender, EventArgs e)
		{
		}

		private void label6_Click(object sender, EventArgs e)
		{
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}