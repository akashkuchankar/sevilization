using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;


namespace sevilization
{
    public partial class Form1 : Form
    {
        FileStream fs;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslathink\dept.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Department dept = new Department();
                dept.deptId = Convert.ToInt32(txtId.Text);
                dept.deptname = txtname.Text;
                dept.departmentlocation = txtlocation.Text;
                binaryFormatter.Serialize(fs, dept);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslathink\dept.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Department dept = new Department();
                dept = (Department)binaryFormatter.Deserialize(fs);
                txtId.Text = dept.deptId.ToString();
                txtname.Text = dept.deptname;
                txtlocation.Text = dept.departmentlocation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnXMLwrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslathink\dept.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
                Department dept = new Department();
                dept.deptId = Convert.ToInt32(txtId.Text);
                dept.deptname = txtname.Text;
                dept.departmentlocation = txtlocation.Text;
                xmlSerializer.Serialize(fs, dept);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnXMLread_Click(object sender, EventArgs e)
        {

            try
            {
                fs = new FileStream(@"F:\Teslathink\dept.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
                Department dept = new Department();
                dept = (Department)xmlSerializer.Deserialize(fs);
                txtId.Text = dept.deptId.ToString();
                txtname.Text = dept.deptname;
                txtlocation.Text = dept.departmentlocation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslathink\dept.soap", FileMode.Create, FileAccess.Write);
               SoapFormatter formatter = new SoapFormatter();
                Department dept = new Department();
                dept.deptId = Convert.ToInt32(txtId.Text);
                dept.deptname = txtname.Text;
                dept.departmentlocation = txtlocation.Text;
                formatter.Serialize(fs, dept);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnsoapread_Click(object sender, EventArgs e)
        {

            try
            {
                fs = new FileStream(@"F:\Teslathink\dept.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter formatter = new SoapFormatter();
                Department dept = new Department();
                dept = (Department)formatter.Deserialize(fs);
                txtId.Text = dept.deptId.ToString();
                txtname.Text = dept.deptname;
                txtlocation.Text = dept.departmentlocation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslathink\dept.json", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.deptId = Convert.ToInt32(txtId.Text);
                dept.deptname = txtname.Text;
                dept.departmentlocation = txtlocation.Text;
                JsonSerializer.Serialize<Department>(fs, dept);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void btnjsonread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Teslathink\dept.json", FileMode.Create, FileAccess.Read );
                Department dept = new Department();
                dept.deptId = Convert.ToInt32(txtId.Text);
                dept.deptname = txtname.Text;
                dept.departmentlocation = txtlocation.Text;
                JsonSerializer.Serialize<Department>(fs, dept);
                MessageBox.Show("Done !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }
    }
}
