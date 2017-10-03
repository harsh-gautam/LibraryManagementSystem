using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{

    public partial class LMS : Form
    {

        StudentInfo stdinfo = new StudentInfo();
        IssueBook ib = new IssueBook();
        Section sec = new Section();
        Books b = new Books();
        Users user = new Users();
        ViewReport vr = new ViewReport();

        FormCollection fc = Application.OpenForms;
        bool FormFound = false;

        public LMS()
        {
            InitializeComponent();
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

       

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
			stdinfo.MdiParent = this;
			
            foreach(Form frm in fc)
			{
				if(frm.Name == "StudentInfo")
				{
					frm.Focus();
                    frm.WindowState = FormWindowState.Maximized;
					FormFound = true;
				}
			}
			if(FormFound == false)
			{
			    stdinfo.Show();
			}
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ib.MdiParent = this;
			
			foreach(Form frm in fc)
			{
				if(frm.Name == "IssueBook")
				{
					frm.Focus();
                    frm.WindowState = FormWindowState.Maximized;
					FormFound = true;
				}
			}
			if(FormFound == false)
			{
			    ib.Show();
			}
            
        }

        private void SectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            sec.MdiParent = this;
			
			foreach(Form frm in fc)
			{
				if(frm.Name == "Section")
				{
					frm.Focus();
                    frm.WindowState = FormWindowState.Maximized;
					FormFound = true;
				}
			}
			if(FormFound == false)
			{
			    sec.Show();
			}
        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            b.MdiParent = this;
			
			foreach(Form frm in fc)
			{
				if(frm.Name == "Books")
				{
					frm.Focus();
                    frm.WindowState = FormWindowState.Maximized;
					FormFound = true;
				}
			}
			if(FormFound == false)
			{
			    b.Show();
			}
        }

        private void deleteBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user.MdiParent = this;

            foreach (Form frm in fc)
            {
                if (frm.Name == "Users")
                {
                    frm.Focus();
                    frm.WindowState = FormWindowState.Maximized;
                    FormFound = true;
                }
            }
            if (FormFound == false)
            {
                user.Show();
            }

        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vr.MdiParent = this;

            foreach (Form frm in fc)
            {
                if (frm.Name == "ViewReport")
                {
                    frm.Focus();
                    frm.WindowState = FormWindowState.Maximized;
                    FormFound = true;
                }
            }
            if (FormFound == false)
            {
                vr.Show();
            }
        }

        
    }
}
