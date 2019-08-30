using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections;


namespace Maze_Game_AI
{
    public partial class Frm_Main : Form
    {
        const int MAX_MAZE = 100;
        int counter = 0;
        int pasue = 0;
        ArrayList solvePath;
        int x1, y1;

        int msx;
        int msy;
        int bsx;
        int bsy;
        int seed = 0;
        int smooth =0;

        Class_Maze myMaze;
        Bitmap myMazeBitmap;

        public Frm_Main()
        {
            InitializeComponent();
            MyComponent();
        }
        private void MyComponent()
        {
            this.picMaze = new myPictureBox();

            this.picMaze.Location = new System.Drawing.Point(400, 60);
            this.picMaze.Name = "picMaze";
            this.picMaze.Size = new System.Drawing.Size(520, 520);
            this.picMaze.TabIndex = 0;
            this.picMaze.TabStop = false;

            this.Controls.Add(this.picMaze);
        }



        public void Create_Maze()
        {
            try
            {
                if (!class_Variable.IsNumeric(txtMSX.Text) ||
                    !class_Variable.IsNumeric(txtMSY.Text)
                    )
                {
                    MessageBox.Show("Please Enter The Numeric Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                msx = int.Parse(txtMSX.Text);
                msy = int.Parse(txtMSY.Text);
                bsx = 513;
                bsy = 513;

                if ((msx < 2) || (msx > MAX_MAZE) ||
                    (msy < 2) || (msx > MAX_MAZE))
                {
                    MessageBox.Show("Maze Generation Range Must Be Within 2 - 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Refresh();

                // create global maze
                myMaze = new Class_Maze();

                lbstatus.Text = lbstatus.Text + "Generating Maze " + Environment.NewLine;
                lbstatus.Refresh();
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();

                seed++;
                myMaze.GenerateMaze(msx, msy, seed, smooth);

                lbstatus.Text = lbstatus.Text + "Generating the Maze Image " + Environment.NewLine;
                lbstatus.Refresh();
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();

                myMazeBitmap = myMaze.GetBitmap(bsx, bsy);

                picMaze.Image = myMazeBitmap;

                lbstatus.Text = lbstatus.Text + "Maze Generated.. " + Environment.NewLine;
                lbstatus.Refresh();
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught: " + ex.Message);
            }
        }

        public void Create_Maze_Reconfig(int mx2, int my2)
        {
            try
            {
                if (!class_Variable.IsNumeric(txtMSX.Text) ||
                    !class_Variable.IsNumeric(txtMSY.Text)
                    )
                {
                    MessageBox.Show("Please Enter The Numeric Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                msx = mx2;
                msy = my2;
                bsx = 513;
                bsy = 513;

                if ((msx < 2) || (msx > MAX_MAZE) ||
                    (msy < 2) || (msx > MAX_MAZE))
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Maze Destination Reached", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                this.Refresh();

                // create global maze
                myMaze = new Class_Maze();

                lbstatus.Text = lbstatus.Text + "Generating Maze " + Environment.NewLine;
                lbstatus.Refresh();
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();

                myMaze.GenerateMaze(msx, msy, seed, smooth);

                lbstatus.Text = lbstatus.Text + "Generating the Maze Image " + Environment.NewLine;
                lbstatus.Refresh();
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();

                myMazeBitmap = myMaze.GetBitmap(bsx, bsy);

                picMaze.Image = myMazeBitmap;

                lbstatus.Text = lbstatus.Text + "Maze Generated.. " + Environment.NewLine;
                lbstatus.Refresh();
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught: " + ex.Message);
            }
        }

        public void Get_path(int x, int y)
        {
            solvePath = myMaze.Solve(x, y, myMaze.MSIZEX - 1, myMaze.MSIZEY - 1);
            solvePath.Reverse();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            pasue = 0;
            lbstatus.Text = "";
            Create_Maze();
            textBox1.Text = txtMSX.Text;
            textBox2.Text = txtMSY.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pasue = 1;
                seed++;
                lbstatus.Text = lbstatus.Text + "Re Genaration The Maze\n";
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();

                textBox1.Text = (int.Parse(txtMSX.Text) - x1).ToString();
                textBox2.Text = (int.Parse(txtMSY.Text) - y1).ToString();

                txtMSX.Text = textBox1.Text;
                txtMSY.Text = textBox2.Text;

                Create_Maze_Reconfig(int.Parse(txtMSX.Text), int.Parse(txtMSY.Text));

                if (myMaze == null)
                {
                    MessageBox.Show("The Maze Have to Generated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Get_path(0,0);

                int xSize = myMazeBitmap.Width / myMaze.MSIZEX;
                int ySize = myMazeBitmap.Height / myMaze.MSIZEY;

                int minxSyS = (xSize > ySize ? ySize : xSize);
                int penSize = (minxSyS > 16 ? minxSyS / 16 : 1);


                lbstatus.Text = lbstatus.Text + Environment.NewLine + "Dynamic Maze Route Co-Ordinates " + Environment.NewLine;
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();

                if (solvePath != null)
                    for (int i = 1; i < solvePath.Count; i++)
                    {

                        Pen p = new Pen(Color.Red, penSize);
                        Graphics g = Graphics.FromImage((Image)myMazeBitmap);
                        System.Threading.Thread.Sleep(500);
                        Application.DoEvents();
                        cCellPosition u = (cCellPosition)solvePath[i - 1];
                        cCellPosition t = (cCellPosition)solvePath[i];
                        g.DrawLine(p,
                                   xSize * u.x + xSize / 2,
                                   ySize * u.y + ySize / 2,
                                   xSize * t.x + xSize / 2,
                                   ySize * t.y + ySize / 2);
                        p.Dispose();
                        g.Dispose();
                        this.picMaze.Image = myMazeBitmap;
                        x1 = u.x;
                        y1 = t.y;
                        lbstatus.Text = lbstatus.Text + "[" + x1 + "," + y1 + "] - ";
                    }
                
            }
            catch (Exception ex)
            {
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (myMaze == null)
                {
                    MessageBox.Show("The Maze Have to Generated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            SaveFileDialog sF = new SaveFileDialog();
            sF.OverwritePrompt = true;
            sF.Title = "Save Maze";
            sF.Filter = "Images JPEG (*.jpg)|*.jpg|Images BMP (*.bmp)|*.bmp|Images PNG (*.png)|*.png";

            sF.ShowDialog(this);

            if (sF.FileName == String.Empty) return;

            if (sF.FileName.EndsWith("jpg"))
                myMazeBitmap.Save(sF.FileName, ImageFormat.Jpeg);
            else
                if (sF.FileName.EndsWith("png"))
                    myMazeBitmap.Save(sF.FileName, ImageFormat.Png);
                else
                    if (sF.FileName.EndsWith("bmp"))
                        myMazeBitmap.Save(sF.FileName, ImageFormat.Bmp);
                    else
                        myMazeBitmap.Save(sF.FileName, ImageFormat.Bmp);
            MessageBox.Show("Maze Image Saved.");
        }

        private void btSolve_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            textBox1.Text = txtMSX.Text;
            textBox2.Text = txtMSY.Text;
            try
            {
                if (myMaze == null)
                {
                    MessageBox.Show("The maze has to be created first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Get_path(0, 0);
                lbstatus.Text = "Finding Shortest Path " + Environment.NewLine;
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();
                lbstatus.Text = lbstatus.Text  + "Dynamic Maze Route Co-Ordinates " + Environment.NewLine;

                int xSize = myMazeBitmap.Width / myMaze.MSIZEX;
                int ySize = myMazeBitmap.Height / myMaze.MSIZEY;

                int minxSyS = (xSize > ySize ? ySize : xSize);
                int penSize = (minxSyS > 16 ? minxSyS / 16 : 1);

                if (solvePath != null)
                    for (int i = 1; i < solvePath.Count; i++)
                    {
                        if (pasue == 0)
                        {
                            Pen p = new Pen(Color.Red, penSize);
                            Graphics g = Graphics.FromImage((Image)myMazeBitmap);
                            System.Threading.Thread.Sleep(500);
                            Application.DoEvents();
                            cCellPosition u = (cCellPosition)solvePath[i - 1];
                            cCellPosition t = (cCellPosition)solvePath[i];
                            g.DrawLine(p,
                                       xSize * u.x + xSize / 2,
                                       ySize * u.y + ySize / 2,
                                       xSize * t.x + xSize / 2,
                                       ySize * t.y + ySize / 2);
                            p.Dispose();
                            g.Dispose();
                            this.picMaze.Image = myMazeBitmap;
                            x1 = u.x;
                            y1 = t.y;
                            if ((x1 == (int.Parse(txtMSX.Text) - 2) || x1 == (int.Parse(txtMSX.Text) - 1)) && y1 == (int.Parse(txtMSY.Text) - 1))
                            {
                                timer1.Enabled = false;
                                MessageBox.Show("Maze Solved....");
                            }
                        }
                        else
                        {
                            return;
                        }
                        lbstatus.Text = lbstatus.Text + "[" + x1 + "," + y1 + "] - ";
                    }
            }
            catch (Exception ex)
            {
            }


        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                //pasue = 1;
                seed++;
                lbstatus.Text = lbstatus.Text + "Re Genaration The Maze " + Environment.NewLine;
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();

                //textBox1.Text = (int.Parse(textBox1.Text) - 5).ToString();
                //textBox2.Text = (int.Parse(textBox2.Text) - 5).ToString();

                Create_Maze_Reconfig(int.Parse(txtMSX.Text), int.Parse(txtMSY.Text));

                if (myMaze == null)
                {
                    MessageBox.Show("The Maze Have to Generated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Get_path(x1, y1);

                int xSize = myMazeBitmap.Width / myMaze.MSIZEX;
                int ySize = myMazeBitmap.Height / myMaze.MSIZEY;

                int minxSyS = (xSize > ySize ? ySize : xSize);
                int penSize = (minxSyS > 16 ? minxSyS / 16 : 1);

                lbstatus.Text = lbstatus.Text + Environment.NewLine + "Finding Shortest Path " + Environment.NewLine;
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();
                lbstatus.Text = lbstatus.Text + "Dynamic Maze Route Co-Ordinates " + Environment.NewLine;
                System.Threading.Thread.Sleep(1000);
                Application.DoEvents();

                if (solvePath != null)
                    for (int i = 1; i < solvePath.Count; i++)
                    {
                        if (pasue != 1)
                        {
                            Pen p = new Pen(Color.Red, penSize);
                            Graphics g = Graphics.FromImage((Image)myMazeBitmap);
                            System.Threading.Thread.Sleep(500);
                            Application.DoEvents();
                            cCellPosition u = (cCellPosition)solvePath[i - 1];
                            cCellPosition t = (cCellPosition)solvePath[i];
                            g.DrawLine(p,
                                       xSize * u.x + xSize / 2,
                                       ySize * u.y + ySize / 2,
                                       xSize * t.x + xSize / 2,
                                       ySize * t.y + ySize / 2);
                            p.Dispose();
                            g.Dispose();
                            this.picMaze.Image = myMazeBitmap;
                            x1 = u.x;
                            y1 = t.y;
                            lbstatus.Text = lbstatus.Text + "[" + x1 + "," + y1 + "] - ";
                            if ((x1 == (int.Parse(txtMSX.Text) - 2) || x1 == (int.Parse(txtMSX.Text) - 1)) && y1 == (int.Parse(txtMSY.Text) - 1))
                            {
                                timer1.Enabled = false;
                                MessageBox.Show("Maze Solved....");
                            }
                        }
                        else
                        {
                            return;
                        }
                    }

            }
            catch (Exception ex)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter++;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            try
            {
                if (myMaze == null)
                {
                    MessageBox.Show("The maze has to be created first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Get_path(0, 0);

                lbstatus.Text = "Dynamic Maze Route Co-Ordinates " + Environment.NewLine;

                int xSize = myMazeBitmap.Width / myMaze.MSIZEX;
                int ySize = myMazeBitmap.Height / myMaze.MSIZEY;

                int minxSyS = (xSize > ySize ? ySize : xSize);
                int penSize = (minxSyS > 16 ? minxSyS / 16 : 1);

                if (solvePath != null)
                    for (int i = 1; i < solvePath.Count; i++)
                    {
                        if (pasue == 0)
                        {
                            Pen p = new Pen(Color.Red, penSize);
                            Graphics g = Graphics.FromImage((Image)myMazeBitmap);
                            cCellPosition u = (cCellPosition)solvePath[i - 1];
                            cCellPosition t = (cCellPosition)solvePath[i];
                            g.DrawLine(p,
                                       xSize * u.x + xSize / 2,
                                       ySize * u.y + ySize / 2,
                                       xSize * t.x + xSize / 2,
                                       ySize * t.y + ySize / 2);
                            p.Dispose();
                            g.Dispose();
                            this.picMaze.Image = myMazeBitmap;
                            x1 = u.x;
                            y1 = t.y;
                            if ((x1 == (int.Parse(txtMSX.Text)-2) || x1 == (int.Parse(txtMSX.Text)-1)) && y1 == (int.Parse(txtMSY.Text)-1))
                            {
                                MessageBox.Show("Maze Solved....");
                            }
                        }
                        lbstatus.Text = lbstatus.Text + "[" + x1 + "," + y1 + "] - ";
                    }
            }
            catch (Exception ex)
            {
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            textBox3.Text = textBox3.Text + "Maze " + counter.ToString() + " - [" + txtMSX.Text + "," + txtMSY.Text + "] - " + elapsedMs.ToString() + "Ms" + Environment.NewLine;
            //MessageBox.Show(elapsedMs.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter = 0;
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pasue = 1;
            timer1.Enabled = false;
        }

       
        
    }
}
