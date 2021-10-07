using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock__Paper__Scissors
{
    public partial class formRPS : Form
    {    
            Random generator = new Random();
            int min = 0;
            int max = 3;
            int result;
        int win = 0, loss = 0, tie = 0;
           

        public formRPS()
        {
            InitializeComponent();
        
        }

            
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
             result = generator.Next(min,max);





            if (result == 1)
            {
                picRockCPU.Visible = true;
                picPaperCPU.Visible = false;
                picScissorsCPU.Visible = false;
                lblOutcome.Text = ("TIE!");
                tie = tie + 1;
            }
            else if(result == 2)
            {
                picPaperCPU.Visible = true;
                picRockCPU.Visible = false;
                picScissorsCPU.Visible = false;
                lblOutcome.Text = ("LOSS...");
                loss = loss + 1;
            }
            else
            {
                picScissorsCPU.Visible = true;
                picPaperCPU.Visible = false;
                picRockCPU.Visible = false;
                lblOutcome.Text = ("WIN!");
                win = win + 1;

            }

            picRock.Visible = true;
            picScissor.Visible = true;
            btnScissor.Visible = true;
            btnRock.Visible = true;

            lblWin.Text = ("Wins: " + win);
            lblTie.Text = ("Ties: " + tie);
            lblLoss.Text = ("Losses: " + loss);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {

            result = generator.Next(min, max);



            if (result == 1)
            {
                picRockCPU.Visible = true;
                picPaperCPU.Visible = false;
                picScissorsCPU.Visible = false;
                lblOutcome.Text = ("WIN!");
                win = win + 1;
            }
            else if (result == 2)
            {
                picPaperCPU.Visible = true;
                picRockCPU.Visible = false;
                picScissorsCPU.Visible = false;
                lblOutcome.Text = ("TIE!");
                tie = tie + 1;
            }
            else
            {
                picScissorsCPU.Visible = true;
                picPaperCPU.Visible = false;
                picRockCPU.Visible = false;
                lblOutcome.Text = ("LOSS...");
                loss = loss + 1;

            }

            picRock.Visible = true;
            picScissor.Visible = true;
            btnScissor.Visible = true;
            btnRock.Visible = true;

            lblWin.Text = ("Wins: " + win);
            lblTie.Text = ("Ties: " + tie);
            lblLoss.Text = ("Losses: " + loss);


        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            result = generator.Next(min, max);





            if (result == 1)
            {
                picRockCPU.Visible = true;
                picPaperCPU.Visible = false;
                picScissorsCPU.Visible = false;
                lblOutcome.Text = ("LOSS...");
                loss = loss + 1;
            }
            else if (result == 2)
            {
                picPaperCPU.Visible = true;
                picRockCPU.Visible = false;
                picScissorsCPU.Visible = false;
                lblOutcome.Text = ("WIN!");
                win = win + 1;
            }
            else
            {
                picScissorsCPU.Visible = true;
                picPaperCPU.Visible = false;
                picRockCPU.Visible = false;
                lblOutcome.Text = ("TIE!");
                tie = tie + 1;

            }

            picRock.Visible = true;
            picScissor.Visible = true;
            btnScissor.Visible = true;
            btnRock.Visible = true;


            lblWin.Text = ("Wins: " + win);
            lblTie.Text = ("Ties: " + tie);
            lblLoss.Text = ("Losses: " + loss);









        }

        




        private void btnRedo_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
