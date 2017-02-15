using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FightClub2
{
    public partial class Form1 : Form
    {
        Fighter you = new Fighter();
        Fighter foe = new Fighter();

        public Form1()
        {
            InitializeComponent();
        }

        static int Randomizer(Fighter target, int count)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, count);
            return number;
        }

        private void buttonHitBlock_Click(object sender, EventArgs e)
        {
            if (buttonHitBlock.Text == "Hit")
            {
                int count = 0;
                foreach (BodyPartType type in Enum.GetValues(typeof(BodyPartType)))
                {
                    count++;
                }

                int number;
                if (radioButtonHead.Checked)
                    number = 0;
                else if (radioButtonTorso.Checked)
                    number = 1;
                else
                    number = 2;

                int number2 = Randomizer(foe, count);
                textBoxHeChose.Text = foe.parts[number2].name;

                foe.Block((BodyPartType)number2);
                you.Hit(foe, (BodyPartType)number);

                if (foe.HP == 0)
                {
                    MessageBox.Show("You win!", "Battle is over", MessageBoxButtons.OK);
                    this.Close();
                }
                textBoxHisHP.Text = foe.HP.ToString();
                buttonHitBlock.Text = "Block";
            }
            else
            {
                int count = 0;
                foreach (BodyPartType type in Enum.GetValues(typeof(BodyPartType)))
                {
                    count++;
                }

                int number;
                if (radioButtonHead.Checked)
                    number = 0;
                else if (radioButtonTorso.Checked)
                    number = 1;
                else
                    number = 2;

                int number2 = Randomizer(you, count);
                textBoxHeChose.Text = you.parts[number2].name;

                you.Block((BodyPartType)number);
                foe.Hit(you, (BodyPartType)number2);

                if (you.HP == 0)
                {
                    MessageBox.Show("You lose!", "Battle is over", MessageBoxButtons.OK);
                    this.Close();
                }
                textBoxYourHP.Text = you.HP.ToString();
                buttonHitBlock.Text = "Hit";
            }
        }
    }
}
