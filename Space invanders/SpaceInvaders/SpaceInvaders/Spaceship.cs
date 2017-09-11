using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SpaceInvaders
{
    class Spaceship
    {
        private PictureBox pbNave;
        private PictureBox pbTiro;

        public Spaceship(PictureBox _pbNave, PictureBox _pbTiro)
        {
            pbNave = _pbNave;
            pbTiro = _pbTiro;
            pbTiro.Visible = false;
        }

        /// <summary>
        /// This method is responsable for give a shot with the space
        /// </summary>
        public void GiveShot(object obj)
        {
            List<PictureBox> _alvos = (List<PictureBox>)obj;
            PictureBox shot = new PictureBox
            {
                Location = new Point(pbNave.Location.X + 30, pbNave.Location.Y),
                Size = pbTiro.Size,
                Image = pbTiro.Image,
                Visible = true
            };
            frmSpaceInvaders.ActiveForm.Invoke(new MethodInvoker(delegate { frmSpaceInvaders.ActiveForm.Controls.Add(shot); }));
            while (shot.Location.Y > 1)
            {
                shot.Invoke(new MethodInvoker(delegate { shot.Location = new Point(shot.Location.X, shot.Location.Y - 10); }));
                if (hit(shot,_alvos)) break;
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }
            shot.Invoke(new MethodInvoker(delegate { shot.Dispose(); }));

        }

        private Boolean hit(PictureBox shot, List<PictureBox> alvos)
        {
            var r = false;
            try
            {
                foreach (PictureBox alvo in alvos)
                {
                    if ((alvo.Location.Y >= shot.Location.Y) && (alvo.Location.X <= shot.Location.X))
                    {
                        alvos.Remove(alvo);
                        alvo.Invoke(new MethodInvoker(delegate { alvo.Dispose(); }));
                        Application.DoEvents();
                        r = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                r = false;
            }
            return r;
        }

        /// <summary>
        /// This method is responsable for move the spaceship into the game form
        /// </summary>
        /// <param name="key">Key pressed</param>
        public void MoveSpaceship(Keys key)
        {
            var rightLimit = frmSpaceInvaders.ActiveForm.Width - pbNave.Size.Width - 5;
            var leftLimit = 1;
            
            if (key == Keys.Left)
            {
                if (pbNave.Left > leftLimit) pbNave.Left -= 20;
            }
            else if (key == Keys.Right)
            {
                if (pbNave.Left < rightLimit) pbNave.Left += 20;
            }
        }

    }
}
