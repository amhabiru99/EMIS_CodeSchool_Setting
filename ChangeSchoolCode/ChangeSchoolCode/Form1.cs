using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ChangeSchoolCode
{
    public partial class Form1 : Form
    {
        String connString =null;// "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\wamp\\www\\StatEduc2_2009_New\\server-side\\db\\Amhara_2009.accdb;Jet OLEDB:Database Password=scr-1806";
        OleDbConnection conn;
        OleDbDataAdapter adapter1;
        OleDbCommandBuilder builder1;

        StreamReader file = null;
        string line;


        public Form1()
        {
            InitializeComponent();
            //file = new System.IO.StreamReader("C:\\WinSchoolCode2\\1.txt");
            //line = file.ReadLine();
            //connString = line;
            //conn = new OleDbConnection(connString);
        }


        private void update_school_code(int start_value, int increment_value, int current_value)
        {

             string sql = "Update School set [CODE_SCHOOL]=@code_school";
               
                sql += " where [CODE_SCHOOL]= " + current_value + " ";
                OleDbCommand cmd = new OleDbCommand(sql, conn);

                cmd.Parameters.AddWithValue("@code_school", start_value+increment_value);
               
                try
                {
                    //conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    //MessageBox.Show(current_value.ToString());
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                   // conn.Close();
                    
                }
        }


        private void cmdChangeSchoolCode_Click(object sender, EventArgs e)
        {

            string str = "SELECT [Code_school] from School";
            int schoolCode = 0;
            OleDbCommand cmd = new OleDbCommand(str, conn);
            int m =Convert.ToInt32(txtstart.Text);
             conn.Open();
            //create the datareader object to connect to table
            int k=1;
              try
                {
                    OleDbDataReader Reader = cmd.ExecuteReader();
                    while (Reader.Read())
                    {
                        schoolCode =  Convert.ToInt32(Reader.GetValue(0).ToString());
                        //MessageBox.Show(schoolCode.ToString());
                        update_school_code(m, k,schoolCode);
                        k++;
                    }

                   }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);

                }
              finally
              {
                   conn.Close();

              }

            MessageBox.Show("Done");
            // conn.Close();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "SELECT [ID_Staff] from Staff";
            int staffID = 0;
            OleDbCommand cmd = new OleDbCommand(str, conn);
            int m = Convert.ToInt32(txtStartStaffID.Text);
            conn.Open();
            //create the datareader object to connect to table
            int k = 1;
            OleDbDataReader Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                staffID = Convert.ToInt32(Reader.GetValue(0).ToString());
                // MessageBox.Show(schoolCode.ToString());
                update_staff_id(m, k, staffID);
                k++;
            }

            MessageBox.Show("Done");
        }

        private void update_staff_id(int start_value, int increment_value, int current_value)
        {

            string sql = "Update staff set [ID_Staff]=@id_staff";

            sql += " where [ID_Staff]= " + current_value + " ";
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id_staff", start_value + increment_value);

            try
            {
                //conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(current_value.ToString());
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // conn.Close();

            }
        }

        private void update_Any_table_id(int start_value, int increment_value, int current_value)
        {

            string sql = "Update"+" "+ txt_Any_Table.Text+" "+ "set [code_school]=@code_school";

            sql += " where [code_school]= " + current_value + " ";
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            cmd.Parameters.AddWithValue("@code_school", start_value + increment_value);

            try
            {
                //conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(current_value.ToString());
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // conn.Close();

            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string str = "SELECT [Code_School] from"+" "+txt_Any_Table.Text ;
            int code_school = 0;
            OleDbCommand cmd = new OleDbCommand(str, conn);
            int m = Convert.ToInt32(txtAnytable_Start.Text);
          
        
            //create the datareader object to connect to table
            int k = 1;
            try
            {
                conn.Open();
                OleDbDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    code_school = Convert.ToInt32(Reader.GetValue(0).ToString());
                    // MessageBox.Show(schoolCode.ToString());
                    update_Any_table_id(m, k, code_school);
                    k++;
                }
                MessageBox.Show("Done");
            }
            catch (OleDbException ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            finally
            {
                 conn.Close();

            }
         
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();

            //opDialog.ShowDialog();
            opDialog.Title = "Browse Text Files";
            opDialog.Filter = "All files (*.accdb)|*.accdb";




            opDialog.CheckFileExists = true;

            opDialog.CheckPathExists = true;

            opDialog.DefaultExt = "accdb";



            opDialog.FilterIndex = 2;

            opDialog.RestoreDirectory = true;



            opDialog.ReadOnlyChecked = true;

            opDialog.ShowReadOnly = true;



            if (opDialog.ShowDialog() == DialogResult.OK)
            {



                txtDatabase.Text = opDialog.FileName;
                connString = "Provider=Microsoft.ACE.OLEDB.12.0;";
                connString += "Data Source=";
                connString += txtDatabase.Text;
                connString += ";Jet OLEDB:Database Password=scr-1806";
                conn = new OleDbConnection(connString);
                //MessageBox.Show(connString);
                // txtS1.Text = System.IO.Path.GetFileName(txtSource_db.Text);



            }
        }

        private void cmdEnrolmentSchools_Click(object sender, EventArgs e)
        {
            string sql = "Delete from school where code_school not in(select code_school from enrolment_grade)";

         
            OleDbCommand cmd = new OleDbCommand(sql, conn);

         
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done");
            }
            catch (OleDbException ex)
            {
                //MessageBox.Show(current_value.ToString());
                MessageBox.Show(ex.Message);
            }
            finally
            {
                 conn.Close();

            }
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str = "SELECT * from Admin1 where [Admin_Code]='" + txtAdminCode.Text+ "' ";
            int schoolCode = 0;
            OleDbCommand cmd = new OleDbCommand(str, conn);
         
            conn.Open();
            //create the datareader object to connect to table
          
            try
            {
                OleDbDataReader Reader = cmd.ExecuteReader();
                if (Reader.Read())
                {
                   
                    MessageBox.Show("Not Available");
                    
                }
                else
                    MessageBox.Show("Available");

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();

            }
        }
    }
}
