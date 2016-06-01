using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Player Player_One = new Player(100, 40, 5);
        Player Easy_Enemy = new Player(20, 20, 5);
        Player Medium_Enemy = new Player(50, 50, 10);

        public void btnNewPlayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your health is " + Player_One.Health.ToString() + "\n" +
                "your mana is " + Player_One.Mana.ToString() + "\n" +
                "and your damage is " + Player_One.AttackDamage.ToString());

            MessageBox.Show("If you can't beat this first enemy, you probably shouldn't be playing games...");

            btnNewPlayer.Visible = false;

            pictureEnemy.Image = Game1.Properties.Resources.EnemyOne;
            //pictureEnemy.Image = new Bitmap(@"\Users\Paul\Desktop\Game\EnemyOne.jpg");

            textEnemyHealth.Visible = true;

            progressEnemyHealth.Visible = true;
            progressEnemyHealth.Maximum = 20;
            progressEnemyHealth.Value = Easy_Enemy.Health;
            labelPlayerHealth.Visible = true;
            progressPlayerHealth.Visible = true;
            progressPlayerHealth.Value = Player_One.Health;
            labelPlayerMana.Visible = true;
            progressPlayerMana.Visible = true;
            progressPlayerMana.Value = Player_One.Mana;

            btnAttack.Visible = true;
            btnRest.Visible = true;
                  
        }

        public void btnAttack_Click(object sender, EventArgs e)
        {
            
            if (Easy_Enemy.Health > 0 && Player_One.Mana >= 20)
            {
                Easy_Enemy.Health = Easy_Enemy.Health - Player_One.AttackDamage;
                progressEnemyHealth.Value = Easy_Enemy.Health;
                Player_One.Mana = Player_One.Mana - 20;
                progressPlayerMana.Value = Player_One.Mana;
            }

            else if (Easy_Enemy.Health == 0)
            {
                MessageBox.Show("Congratulations.... you managed to kill a frog. Asshole.");
                btnAttack.Visible = false;
                btnAttackEnemyTwo.Visible = true;

                MessageBox.Show("The next enemy will be a little harder...");

                pictureEnemy.Image = Game1.Properties.Resources.EnemyTwo;
                //pictureEnemy.Image = new Bitmap(@"\Users\Paul\Desktop\Game\EnemyTwo.jpg");

                progressEnemyHealth.Maximum = 50;
                progressEnemyHealth.Value = Medium_Enemy.Health;

                Player_One.Mana = 100;
                progressPlayerMana.Value = Player_One.Mana;
                
            }
            else if (Player_One.Mana < 20)
            {
                MessageBox.Show("You don't have enough mana to attack!");
            }
            
        }

        private void btnAttackEnemyTwo_Click(object sender, EventArgs e)
        {
            Medium_Enemy.Health = Medium_Enemy.Health - Player_One.AttackDamage;
            progressEnemyHealth.Value = Medium_Enemy.Health;

            if (Medium_Enemy.Health == 0)
            {
                MessageBox.Show("The lizard was no match for your 'Attack' button clicking ability");
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (Player_One.Mana < 100)
            {
                Player_One.Mana = Player_One.Mana + 10;
                progressPlayerMana.Value = Player_One.Mana;
            }            
        }
    }
}
