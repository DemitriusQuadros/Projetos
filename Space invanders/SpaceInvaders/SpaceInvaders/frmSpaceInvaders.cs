using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvaders
{
    public partial class frmSpaceInvaders : Form
    {

        private Spaceship spaceship;

        public frmSpaceInvaders()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is responsable for read the keys and submit the actions
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Keys arguments</param>
        private void frmSpaceInvaders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                spaceship.MoveSpaceship(e.KeyCode);
            }
            else if (e.KeyCode == Keys.Space)
            {
                List<PictureBox> alvos = new List<PictureBox>();
                foreach (Control c in this.Controls)
                {
                    if (c.Name.IndexOf("pictureBox") >= 0)
                    {
                        alvos.Add((PictureBox)c);
                    }
                }
                if (alvos.Count == 0)
                { 
                    MessageBox.Show("FIM DO JOGO ","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                System.Threading.Thread t = new System.Threading.Thread(spaceship.GiveShot);
                t.Start(alvos);
            }
        }

        private void frmSpaceInvaders_Load(object sender, EventArgs e)
        {
            spaceship = new Spaceship(pbNave, pbTiro);
            pbTiro.Visible = false;
        }

    
    }
}
