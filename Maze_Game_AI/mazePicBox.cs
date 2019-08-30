using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;

namespace Maze_Game_AI
{
	public class myPictureBox : System.Windows.Forms.UserControl
	{
		private System.ComponentModel.Container components = null;

		public myPictureBox()
		{
			SetStyle(ControlStyles.UserPaint, true);  
			SetStyle(ControlStyles.AllPaintingInWmPaint, true); 
			SetStyle(ControlStyles.DoubleBuffer, true); 
 
			InitializeComponent();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		
		private void InitializeComponent()
		{
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(0, 139);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(136, 16);
            this.hScrollBar1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(141, -2);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 112);
            this.vScrollBar1.TabIndex = 1;
            // 
            // myPictureBox
            // 
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "myPictureBox";
            this.SizeChanged += new System.EventHandler(this.myPictureBox_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.myPictureBox_Paint);
            this.ResumeLayout(false);

		}
		#endregion

        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;


        private Image TheImage = null;

        private void myPictureBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {			
            Graphics g = e.Graphics;
           
			Brush b = new SolidBrush( SystemColors.Control );
			g.FillRectangle(b,this.ClientRectangle);

            if (TheImage != null)
            {
                g.DrawImageUnscaled(TheImage, -OffsetX, -OffsetY, TheImage.Width, TheImage.Height);
                g.FillRectangle(b, ClientRectangle.Width - vScrollBar1.Width, ClientRectangle.Height - hScrollBar1.Height, vScrollBar1.Width, hScrollBar1.Height);
			}
			b.Dispose();
		}
    
        public Image Image
        {
            get 
            {
                return TheImage;
            }
            set
            {
                TheImage = value;
            	iOffsetX = 0;
            	iOffsetY = 0;
                SizeScrollBars();
            }
        }
       
        private int iOffsetX = 0;
        public int OffsetX
        {
            get
            {
                return iOffsetX;
            }
            set
            {
              iOffsetX = value;
              Invalidate();
            }
        }

        private int iOffsetY = 0;
		public int OffsetY
		{
			get
			{
				return iOffsetY;
			}
			set
			{
				iOffsetY = value;
				Invalidate();
			}
		}

        private void hScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            OffsetX = e.NewValue;
        }

        private void vScrollBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            OffsetY = e.NewValue;
        }

        private void SizeScrollBars()
        {
            hScrollBar1.Minimum = 0;
            vScrollBar1.Minimum = 0;
            hScrollBar1.SetBounds(0, ClientRectangle.Height - hScrollBar1.Height, ClientRectangle.Width - vScrollBar1.Width, hScrollBar1.Height);
            vScrollBar1.SetBounds(ClientRectangle.Right - vScrollBar1.Width, 0, vScrollBar1.Width, ClientRectangle.Height - hScrollBar1.Height);  

            if (TheImage != null)
            {
                hScrollBar1.Maximum = TheImage.Width  + 2*vScrollBar1.Width  - ClientRectangle.Width;
                vScrollBar1.Maximum = TheImage.Height + 2*hScrollBar1.Height - ClientRectangle.Height;
			}
            else
            {
                hScrollBar1.Maximum =  0;
                vScrollBar1.Maximum = 0;
            }

            Invalidate();
        }

        private void myPictureBox_SizeChanged(object sender, System.EventArgs e)
        {
            SizeScrollBars();
        }
    
	}


}
