using DocumentFormat.OpenXml.Office2010.CustomUI;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList_WF
{
	public partial class Form1 : Form
	{
		private MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=task");
		private MySqlDataAdapter adapter = new MySqlDataAdapter();
		private MySqlCommand command = new MySqlCommand();
		public DataSet ds = new DataSet();

		private DataTable dt;
		private DataRow dr;
		internal bool flag; //variable used to define new or edit task
		private int ID; //ordinal of tasks
		internal static Form1 form1;
		internal static InputForm InputForm;

		public Form1()
		{
			InitializeComponent();
			form1 = this;
			dgvTaskList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvTaskList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dgvTaskList.Columns[7].DefaultCellStyle.Format = "HH:mm:ss";
			GetTaskList();
		}

		/// <summary>
		/// Call InputForm and check is it opened
		/// </summary>
		public void CallInputForm()
		{
			InputForm = new InputForm();
			bool opened = false; //variable to check if form is opened
			FormCollection fc = Application.OpenForms;
			foreach (Form frm in fc)
			{
				//Check if InputForm is opened?
				if (frm.Name == "InputForm")
				{
					opened = true;
				}
			}
			if (opened)
			{
			}
			else
			{
				InputForm.ShowDialog();
			}
		}

		/// <summary>
		/// Get Data from MySQL and send to DataGridView, reorder existing records from 1.
		/// </summary>
		public void GetTaskList()
		{
			command = new MySqlCommand("SELECT * FROM `tasklist`", conn);
			//Reorder records, only suitable for small database
			conn.Open();
			command.CommandText = "CREATE TABLE tasklist_tmp select * from tasklist";
			command.ExecuteNonQuery();
			command.CommandText = "TRUNCATE TABLE tasklist";
			command.ExecuteNonQuery();
			command.CommandText = "ALTER TABLE tasklist AUTO_INCREMENT = 1";
			command.ExecuteNonQuery();
			command.CommandText = "INSERT INTO tasklist(TITLE,DESCRIPTION,CREATEDDATE,DUEDATE,ALARMDATE,ALARMTIME,TAGS,DONE) SELECT TITLE,DESCRIPTION,CREATEDDATE,DUEDATE,ALARMDATE,ALARMTIME,TAGS,DONE FROM tasklist_tmp ORDER BY id";
			command.ExecuteNonQuery();
			command.CommandText = "DROP TABLE tasklist_tmp";
			command.ExecuteNonQuery();
			conn.Close();
			ds = new DataSet();
			command = new MySqlCommand("SELECT * FROM `tasklist`", conn);
			adapter.SelectCommand = command;
			adapter.Fill(ds, "tasklist");
			dgvTaskList.DataSource = ds;
			dgvTaskList.DataMember = "tasklist";
		}

		/// <summary>
		/// Refresh datagridview
		/// </summary>
		public void ClearForm()
		{
			dgvTaskList.ClearSelection();
			foreach (DataGridViewRow r in dgvTaskList.Rows)
			{
				r.Cells["colSelected"].Value = false;
			}
		}

		/// <summary>
		/// Save Task to MySQL
		/// </summary>
		public void AddTask()
		{
			var rows = dgvTaskList.Rows;
			command = new MySqlCommand();
			command = conn.CreateCommand();

			command.Parameters.AddWithValue("@TITLE", InputForm.Title);
			command.Parameters.AddWithValue("@DESCRIPTION", InputForm.Description);
			command.Parameters.AddWithValue("@CREATEDDATE", InputForm.CreatedDate);
			command.Parameters.AddWithValue("@DUEDATE", InputForm.DueDate);
			if (InputForm.SetAlarm)
			{
				command.Parameters.AddWithValue("@ALARMDATE", InputForm.AlarmDate);
				command.Parameters.AddWithValue("@ALARMTIME", InputForm.AlarmTime);
			}
			else
			{
				command.Parameters.AddWithValue("@ALARMDATE", null);
				command.Parameters.AddWithValue("@ALARMTIME", null);
			}

			command.Parameters.AddWithValue("@TAGS", InputForm.Tags);
			command.Parameters.AddWithValue("@DONE", InputForm.Done);
			if (flag) // Check flag == true (New Task) or false(Edit Task)
			{
				ID = rows.Count + 1;
				command.Parameters.AddWithValue("@ID", ID);
				command.CommandText = "INSERT INTO `tasklist`(`ID`, `TITLE`, `DESCRIPTION`, `CREATEDDATE`, `DUEDATE`, `ALARMDATE`, `ALARMTIME`, `TAGS`, `DONE`) VALUES (@ID,@TITLE,@DESCRIPTION,@CREATEDDATE,@DUEDATE,@ALARMDATE,@ALARMTIME,@TAGS,@DONE)";
				conn.Open();
				command.ExecuteNonQuery();
				conn.Close();
			}
			else
			{
				ID = Convert.ToInt32(dgvTaskList.CurrentRow.Cells[1].Value);
				command.CommandText = $"UPDATE `tasklist` SET `TITLE`=@TITLE,`DESCRIPTION`=@DESCRIPTION,`CREATEDDATE`=@CREATEDDATE,`DUEDATE`=@DUEDATE,`ALARMDATE`=@ALARMDATE,`ALARMTIME`=@ALARMTIME,`TAGS`=@TAGS,`DONE`=@DONE WHERE ID={ID}";
				conn.Open();
				command.ExecuteNonQuery();
				conn.Close();
			}
			GetTaskList();
			ClearForm();
		}

		private void btnDoneTask_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow r in dgvTaskList.SelectedRows)
			{
				r.Cells["colDone"].Value = true;
			}
			ClearForm();
		}

		private void btnUndoneTask_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow r in dgvTaskList.SelectedRows)
			{
				r.Cells["colDone"].Value = false;
			}
			ClearForm();
		}

		/// <summary>
		/// Highlight "Selected cells"
		/// </summary>
		private void dgvTaskList_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			flag = false;
			foreach (DataGridViewRow row in dgvTaskList.Rows)
			{
				if (e.RowIndex == 0)
				{
					if (Convert.ToBoolean(row.Cells["colSelected"].Value))// colSelected is the name of chkbox column
					{
						row.Selected = true;
						//row.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
					}
				}
			}
		}
		private void dgvTaskList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			flag = false;
			foreach (DataGridViewRow row in dgvTaskList.Rows)
			{
	
				if (e.ColumnIndex == 9)
				{
					if ((bool)row.Cells["colDone"].Value == true)
					{
						command.CommandText = $"UPDATE `tasklist` SET `DONE`=1 WHERE ID={row.Cells[1].Value}";
						conn.Open();
						command.ExecuteNonQuery();
						conn.Close();
					}
					else
					{
						command.CommandText = $"UPDATE `tasklist` SET `DONE`=0 WHERE ID={row.Cells[1].Value}";
						conn.Open();
						command.ExecuteNonQuery();
						conn.Close();
					}
				}
			}
		}

		private void btnNewTask_Click(object sender, EventArgs e)
		{
			ClearForm();
			flag = true;
			CallInputForm();
		}

		private void btnEditTask_Click(object sender, EventArgs e)
		{
			flag = false;
			CallInputForm();
		}

		private void btnDeleteTask_Click(object sender, EventArgs e)
		{
			//If datagridview has data, Remove button Enabled
			if (dgvTaskList.Rows.Count > 0)
			{
				btnDeleteTask.Enabled = true;
				//Show dialog to confirm
				var DeleteMsg = MessageBox.Show("Delete Selected Rows: " + dgvTaskList.SelectedRows.Count, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				//Action based on choosen diaglog result
				if (DeleteMsg == DialogResult.Yes)
				{
					foreach (DataGridViewRow r in dgvTaskList.SelectedRows)
					{
						conn.Open();
						command.CommandText = $"DELETE FROM TASKLIST WHERE ID={r.Cells[1].Value}";
						command.ExecuteNonQuery();
						conn.Close();
					}
					GetTaskList();
				}
				else
				{
				}
			}
			//If datagridview dont have any data, Remove button Disable
			else
			{
				btnDeleteTask.Enabled = false;
			}
			dgvTaskList.RefreshEdit();
		}

		/// <summary>
		/// Export current list to Excel file -- Need improve, show save diaglog to set name file and save location
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSaveList_Click(object sender, EventArgs e)
		{
			// creating Excel Application
			Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
			// creating new WorkBook within Excel application
			Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
			// creating new Excelsheet in workbook
			Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
			// see the excel sheet behind the program
			app.Visible = true;
			// get the reference of first sheet. By default its name is Sheet1.
			// store its reference to worksheet
			worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
			worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.ActiveSheet;
			// changing the name of active sheet
			worksheet.Name = "Sheet279";
			// storing header part in Excel
			for (int i = 1; i < dgvTaskList.Columns.Count + 1; i++)
			{
				worksheet.Cells[1, i] = dgvTaskList.Columns[i - 1].HeaderText;
			}
			// storing Each row and column value to excel sheet
			for (int i = 0; i < dgvTaskList.Rows.Count - 1; i++)
			{
				for (int j = 0; j < dgvTaskList.Columns.Count; j++)
				{
					worksheet.Cells[i + 2, j + 1] = dgvTaskList.Rows[i].Cells[j].Value.ToString();
				}
			}
			// save the application
			workbook.SaveAs("d:\\output.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
		}

		/// <summary>
		/// Load To-Do List from excel file -- Not need after link with MySQL
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnLoadList_Click(object sender, EventArgs e)
		{
			/*try
			{
				OpenFileDialog OpenDataList = new OpenFileDialog();// Create an OpenFileDialog object
				OpenDataList.Title = "Open data list"; // Initializes the name of the window
				OpenDataList.InitialDirectory = @"C:\Users\AdministratorOSMO\Desktop\Testordner"; // Defines the default file path
				OpenDataList.Filter = "Excel Files|*.xls;*.xlsx"; // Filters for the available file types
				OpenDataList.FilterIndex = 2;// Defines the default filter when opening

				if (OpenDataList.ShowDialog() == DialogResult.OK)//Query whether the ShowDialog was confirmed with OK
				{
					string PathName = OpenDataList.FileName;// the variable pathName is initialized with the content of Filename

					using (XLWorkbook workBook = new XLWorkbook(PathName))//Workbook is created
					{
						IXLWorksheet workSheet = workBook.Worksheet(1);//Table 1 of the Excel file is written in workSheet
						dt.Reset();// new DataTable dt is created
						bool firstRow = true;// Boolean variable for first row?
						foreach (IXLRow row in workSheet.Rows())
						{
							if (firstRow)//FirstRow of excel file will be Column Name
							{
								dt = NewTable();
								firstRow = false;
								continue;  // go to next row
							}

							dt.Rows.Add();

							int i = 0;
							foreach (IXLCell cell in row.Cells())
							{
								dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
								i++;
							}
						}
						dgvTaskList.DataSource = dt;
						//dgvTaskList.ReadOnly = true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}*/
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			conn.Open();
			adapter = new MySqlDataAdapter($"SELECT * FROM `tasklist` where Tags like '%{txtSearch.Text}%'", conn);
			dt = new DataTable();
			adapter.Fill(dt);
			dgvTaskList.DataSource = dt;
			conn.Close();
		}
	}
}