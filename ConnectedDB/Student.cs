using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ConnectedStu
{
    public partial class Student : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Student()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultConn"].ConnectionString);
            //LoadBranches();
        }
        public void ClearFormFields()
        {
            textRollno.Clear();
            textName.Clear();
            textPercentage.Clear();
            dropBox.SelectedIndex = -1;
        }
        private void LoadBranches()
        {
            try
            {
                string qry = "select branch from student"; // Fetch distinct branches
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                dropBox.Items.Clear(); // Clear previous items
                while (dr.Read())
                {
                    dropBox.Items.Add(dr["branch"].ToString()); // Add branches to ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into student values(@name,@branch,@percentage)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", textName.Text);
                cmd.Parameters.AddWithValue("@branch", dropBox.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@percentage", textPercentage.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Student added successfully!");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select name,branch,percentage from student where rollno=@rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(rollno.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Student deleted successfully");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update student set name=@name,branch=@branch,percentage=@percentage";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", textName.Text);
                cmd.Parameters.AddWithValue("@branch", dropBox.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@percentage", Convert.ToInt32(textPercentage.Text));
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(textRollno.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Student updated successfully");
                    ClearFormFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select name,branch,percentage from student where rollno=@rollno";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@rollno", Convert.ToInt32(rollno.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        textName.Text = dr["name"].ToString();
                        dropBox.SelectedItem = dr["branch"].ToString();
                        textPercentage.Text = dr["percentage"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShowAllStu_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from student";
                cmd = new SqlCommand(qry, con);

                con.Open();
                dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}




