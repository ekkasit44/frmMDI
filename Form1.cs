using static System.Windows.Forms.DataFormats;

namespace frmMDI
{
    public partial class Form1 : Form
    {
        private Form2 _form2;
        private Form3 _form3;
        private Form4 _form4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuFormA_Click(object sender, EventArgs e)
        {
            // Show Once Instance of FormA
            if (_form2 == null || _form2.IsDisposed)
            {
                _form2 = new Form2();
                _form2.MdiParent = this;
                _form2.Show();
            }
            else
            {
                _form2.Activate();
            }
            return;
        }

        private void mnuFormB_Click(object sender, EventArgs e)
        {
            if (_form3 == null || _form3.IsDisposed)
            {
                _form3 = new Form3();
                _form3.MdiParent = this;
                _form3.Show();
            }
            else
            {
                _form3.Activate();
            }
        }

        private void mnuFormC_Click(object sender, EventArgs e)
        {
            if (_form4 == null || _form4.IsDisposed)
            {
                _form4 = new Form4();
                _form4.MdiParent = this;
                _form4.Show();
            }
            else
            {
                _form4.Activate();
            }
        }

        private void mnuFromMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void mnuFormMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mnuFormExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void mnuCloseForm_Click(object sender, EventArgs e)
        {
            // Close Active MDI Child Form
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }

        private void mnuCloseAllForm_Click(object sender, EventArgs e)
        {
            // Close All MDI Child Forms
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mnuFormatVertical_Click(object sender, EventArgs e)
        {
            // Tile MDI Child Forms Vertically
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuFormatHorizontal_Click(object sender, EventArgs e)
        {
            // Tile MDI Child Forms Horizontally   
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuFormatNarmal_Click(object sender, EventArgs e)
        {
            // Cascade MDI Child Forms
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void OpenChildForm(Form formName)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formName.GetType())
                {
                    f.Activate();
                    return;
                }
            }

            formName.MdiParent = this;
            formName.WindowState = FormWindowState.Normal;
            formName.Show();
        }
    }
}