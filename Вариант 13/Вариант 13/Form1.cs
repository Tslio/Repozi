using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вариант_13
{
    public partial class Form1 : Form
    {
        private GameState game;
        private Label[,] labels;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += Form1_KeyDown;
            this.KeyPreview = true;
            game = new GameState();
            labels = new Label[4, 4];

            CreateLabels();
            DisplayGame();
        }

        private void CreateLabels()
        {
            int size = 80;
            int startX = 20;
            int startY = 40;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Label label = new Label();

                    label.Width = size;
                    label.Height = size;

                    label.Left = startX + j * size;
                    label.Top = startY + i * size;

                    label.BorderStyle = BorderStyle.FixedSingle;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Font = new Font("Arial", 20, FontStyle.Bold);

                    Controls.Add(label);

                    labels[i, j] = label;
                }
            }
        }

        private void DisplayGame()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (game.Field[i, j] == 0)
                        labels[i, j].Text = "";
                    else
                        labels[i, j].Text = game.Field[i, j].ToString();
                }
            }

            scoreStatusLabel.Text = "Счёт: " + game.Score;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                game.Move(Direction.Left);

            if (e.KeyCode == Keys.Right)
                game.Move(Direction.Right);

            if (e.KeyCode == Keys.Up)
                game.Move(Direction.Up);

            if (e.KeyCode == Keys.Down)
                game.Move(Direction.Down);

            DisplayGame();
            if (!game.CanMove())
            {
                MessageBox.Show(
                    "Вы проиграли.\nСчёт: " + game.Score,
                    "Поражение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.NewGame();
            DisplayGame();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Undo();
            DisplayGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
