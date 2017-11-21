using GameOfLife.Calculations;
using GameOfLife.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Grid : Form
    {

        private System.Timers.Timer aTimer;
        private Game game;
        private bool GameIsOn = false;


      


        public Grid()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            game = new Factories.GameFactory().Get();
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            game.CreateUniverse(this.ClientRectangle.Width / Consts.CellSize, this.ClientRectangle.Height / Consts.CellSize);

            this.BackColor = Consts.Colors.SetupForm;
            this.Text = "Game of Life - R:Fill Random, S:Start: E:End, MouseClick:Set Alive";
            

            aTimer = new System.Timers.Timer(1000 / Consts.FPS);
            aTimer.Elapsed += aTimer_Elapsed;

        }
        void aTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (GameIsOn)
                this.Invalidate();
        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {
            if (GameIsOn)
                this.BackColor = Consts.Colors.GameForm;
            else
                this.BackColor = Consts.Colors.SetupForm;

            if (GameIsOn)
                game.CalculateTomorrow();


            foreach (var cell in game.Universe)
            {
                if (GameIsOn)
                {
                    var color = cell.IsAlive ? new SolidBrush(Consts.Colors.AliveCell) : new SolidBrush(Consts.Colors.DeadCell);
                    e.Graphics.FillRectangle(color, cell.X * Consts.CellSize, cell.Y * Consts.CellSize, Consts.CellSize - 1, Consts.CellSize - 1);
                }
                else
                {
                    var color = cell.IsAlive ? new SolidBrush(Consts.Colors.SetupAliveCell) : new SolidBrush(Consts.Colors.SetupDeadCell);
                    e.Graphics.FillRectangle(color, cell.X * Consts.CellSize, cell.Y * Consts.CellSize, Consts.CellSize - 1, Consts.CellSize - 1);

                }

            }

        }

        private void Grid_MouseClick(object sender, MouseEventArgs e)
        {
            var cell = game.LocateCell(e.X / Consts.CellSize, e.Y / Consts.CellSize);
            cell.IsAlive = true;
            this.Invalidate();
        }

        private void Grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().ToLower() == "r")
            {
                game.ResetUniverse();
                game.SetRandomAlive();
                this.Invalidate();
            }
            if (e.KeyChar.ToString().ToLower() == "s")
            {
                aTimer.Start();
                GameIsOn = true;
            }
            if (e.KeyChar.ToString().ToLower() == "e")
            {
                aTimer.Stop();
                GameIsOn = false;

                game.ResetUniverse();

                this.Invalidate();
            }

        }
    }

}
