using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administradorTareas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        #region funcionalidades del formulario 

        //Constructor
        //RESIZE METODO PARA REDIMENCIONAR
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //CAPTURAR POSICION Y TAMAÑO ANTES DE MAXIMIZAR PARA RESTAURAR

        int lx, ly;
        int sw, sh;

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;

            this.Size = new Size(sw,sh);
            this.Location = new Point(lx, ly);
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void button1_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form1>();
            Process p = Process.Start("Winver.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form2>();
            // btnHardware.BackColor = Color.FromArgb(12, 61, 92);
            Process p = Process.Start("Dxdiag.exe");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form3>();
            //btnMonitorear.BackColor = Color.FromArgb(12, 61, 92);
            Process p = Process.Start("Dxdiag.exe");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("netstat.exe");
            //btnRedes.BackColor = Color.FromArgb(12, 61, 92);
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button6_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form6>();
           Process.Start("appwiz.cpl");
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("resmon.exe");
        }

        private void btnConcurrencia_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form3>();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Form4>();
        }

        private void panelFormularios_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnWindowss_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form1>();
            //Process p = Process.Start("Winver.exe");
        }

        private void btnHardwaree_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form2>();
            // btnHardware.BackColor = Color.FromArgb(12, 61, 92);
            //Process p = Process.Start("Dxdiag.exe");

        }

        private void btnMonitorearr_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form3>();
            //btnMonitorear.BackColor = Color.FromArgb(12, 61, 92);
            Process p = Process.Start("Dxdiag.exe");
        }

        private void btnRedess_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("netstat.exe");
            //btnRedes.BackColor = Color.FromArgb(12, 61, 92);
        }

        private void btnProcesoss_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("resmon.exe");
        }

        private void btnSoftwaree_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<Form6>();
            Process.Start("appwiz.cpl");
        }

        private void btnConcurrenciaa_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form3>();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form4>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        #endregion

        //METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>()where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//BUSCA EN LA COLECCION EL FORMULARIO 
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else {
                formulario.BringToFront();

            }

        }

        private void CloseForms(object sender,FormClosedEventArgs e)
        {
            //if (Application.OpenForms["Form1"]== null)
            //btnWindowss.BackColor = Color.FromArgb(4,41,68);

            //if (Application.OpenForms["Form2"] == null)
            //    btnHardwaree.BackColor = Color.FromArgb(4, 41, 68);

            //if (Application.OpenForms["Form3"] == null)
            //    btnMonitorearr.BackColor = Color.FromArgb(4, 41, 68);

            //if (Application.OpenForms["Form1"] == null)
            //    btnRedess.BackColor = Color.FromArgb(4, 41, 68);

            //if (Application.OpenForms["Form1"] == null)
            //    btnProcesoss.BackColor = Color.FromArgb(4, 41, 68);

            //if (Application.OpenForms["Form1"] == null)
            //    btnSoftwaree.BackColor = Color.FromArgb(4, 41, 68);

            //if (Application.OpenForms["Form1"] == null)
            //    btnConcurrenciaa.BackColor = Color.FromArgb(4, 41, 68);

            //if (Application.OpenForms["Form1"] == null)
            //    Interbloqueo.BackColor = Color.FromArgb(4, 41, 68);


        }
    }
}
