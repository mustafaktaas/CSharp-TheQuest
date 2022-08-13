using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuestAlgoProje
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        int second;
        int minute;
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            game = new Game(new Rectangle(50, 82, 720, 400));
            game.NewLevel(random);
            UpdateCharacters();
            
        }

        private void SwordSprite_Click(object sender, EventArgs e)
        {

        }

        private void RedPotionSprite_Click(object sender, EventArgs e)
        {

        }

        private void BowInvSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(BowInvSprite, "Bow", "weapon");
        }

        private void RedPotionInvSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(RedPotionInvSprite, "Red Potion", "potion");
        }

        private void SwordInvSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(SwordInvSprite, "Sword", "weapon");
        }

        private void MaceInvSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(MaceInvSprite, "Mace", "weapon");
        }

        private void BluePotionInvSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(BluePotionInvSprite, "Blue Potion", "potion");
        }

        private void SelectInventoryItem(PictureBox itemSprite, string itemName, string weaponType)
        {
            if (game.CheckPlayerInventory(itemName))
            {
                game.Equip(itemName);
                RemoveInventorySpriteBorders();
                itemSprite.BorderStyle = BorderStyle.FixedSingle;
                SetupAttackButtons(weaponType);
            }
        }

        private void RemoveInventorySpriteBorders()
        {
            SwordInvSprite.BorderStyle = BorderStyle.None;
            RedPotionInvSprite.BorderStyle = BorderStyle.None;
            BowInvSprite.BorderStyle = BorderStyle.None;
            BluePotionInvSprite.BorderStyle = BorderStyle.None;
            MaceInvSprite.BorderStyle = BorderStyle.None;
        }

        private void SetupAttackButtons(string weaponType)
        {
            switch (weaponType.ToLower())
            {
                case "weapon":
                    AttackUp.Text = "U";
                    AttackRight.Visible = true;
                    AttackDown.Visible = true;
                    AttackLeft.Visible = true;
                    break;
                case "potion":
                    AttackUp.Text = "Drink";
                    AttackRight.Visible = false;
                    AttackDown.Visible = false;
                    AttackLeft.Visible = false;
                    break;
            }
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Yön.Up, random);
            UpdateCharacters();
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Yön.Right, random);
            UpdateCharacters();
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Yön.Down, random);
            UpdateCharacters();
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Yön.Left, random);
            UpdateCharacters();
        }

        private void AttackUp_Click(object sender, EventArgs e)
        {
            if(AttackUp.Text == "Drink")
            {
                SetupAttackButtons("weapon");
            }
            game.Attack(Yön.Up, random);
            UpdateCharacters();
        }

        private void AttackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Yön.Right, random);
            UpdateCharacters();
        }

        private void AttackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Yön.Down, random);
            UpdateCharacters();
        }

        private void AttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Yön.Left, random);
            UpdateCharacters();
        }

        public bool UpdateEnemySprite(Düşman enemy, PictureBox enemySprite, Label enemyHitPoints)
        {
            bool enemySpriteUpdated = false;

            enemyHitPoints.Text = enemy.HitPoints.ToString();

            if (enemy.HitPoints > 0)
            {
                enemySprite.Location = enemy.Location;
                enemySprite.Visible = true;
                enemySpriteUpdated = true;
            }
            else
            {
                enemySprite.Visible = false;
            }

            return enemySpriteUpdated;
        }

        public void UpdateCharacters()
        {
            PlayerSprite.Location = game.PlayerLocation;
            PlayerHitPoints.Text = game.PlayerHitPoints.ToString();

            int enemiesShown = 0;

            foreach (Düşman enemy in game.Enemies)
            {
                if (enemy is Yarasa)
                {
                    if (UpdateEnemySprite(enemy, BatSprite, BatHitPoints))
                    {
                        enemiesShown++;
                    }
                }
                if (enemy is Hayalet)
                {
                    if (UpdateEnemySprite(enemy, GhostSprite, GhostHitPoints))
                    {
                        enemiesShown++;
                    }
                }
                if (enemy is Hortlak)
                {
                    if (UpdateEnemySprite(enemy, GhoulSprite, GhoulHitPoints))
                    {
                        enemiesShown++;
                    }
                }
            }

            SwordSprite.Visible = false;
            BowSprite.Visible = false;
            MaceSprite.Visible = false;
            RedPotionSprite.Visible = false;
            BluePotionSprite.Visible = false;

            if (game.WeaponInRoom != null)
            {
                Control weaponControl = null;
                switch (game.WeaponInRoom.Name)
                {
                    case "Sword":
                        weaponControl = SwordSprite;
                        break;
                    case "Bow":
                        weaponControl = BowSprite;
                        break;
                    case "Mace":
                        weaponControl = MaceSprite;
                        break;
                    case "Red Potion":
                        weaponControl = RedPotionSprite;
                        break;
                    case "Blue Potion":
                        weaponControl = BluePotionSprite;
                        break;
                }

                if (game.WeaponInRoom.PickedUp)
                {
                    weaponControl.Visible = false;
                }
                else
                {
                    weaponControl.Visible = true;
                    weaponControl.Location = game.WeaponInRoom.Location;
                }
            }
            SwordInvSprite.Visible = false;
            BowInvSprite.Visible = false;
            MaceInvSprite.Visible = false;
            RedPotionInvSprite.Visible = false;
            BluePotionInvSprite.Visible = false;



            if (game.CheckPlayerInventory("Sword"))
            {
                SwordInvSprite.Visible = true;
            }

            if (game.CheckPlayerInventory("Bow"))
            {
                BowInvSprite.Visible = true;
            }

            if (game.CheckPlayerInventory("Mace"))
            {
                MaceInvSprite.Visible = true;
            }

            if (game.CheckPlayerInventory("Red Potion"))
            {
                if (!game.CheckPotionUsed("Red Potion"))
                {
                    RedPotionInvSprite.Visible = true;
                }
            }

            if (game.CheckPlayerInventory("Blue Potion"))
            {
                if (!game.CheckPotionUsed("Blue Potion"))
                {
                    BluePotionInvSprite.Visible = true;
                }
            }

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("Öldün!!!");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("Bu leveldeki düşmanları yendin!!!");                
                game.NewLevel(random);
                UpdateCharacters();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            second++;
            Second.Text = Convert.ToString(second);
            if(second == 60)
            {
                second = 0;
                minute++;
                Minute.Text = Convert.ToString(minute);

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                game.Move(Yön.Up, random);
                UpdateCharacters();

            }
            if (e.KeyCode == Keys.A)
            {
                game.Move(Yön.Left, random);
                UpdateCharacters();

            }
            if (e.KeyCode == Keys.D)
            {
                game.Move(Yön.Right, random);
                UpdateCharacters();

            }
            if (e.KeyCode == Keys.S)
            {
                game.Move(Yön.Down, random);
                UpdateCharacters();

            }
           
            
            if (e.KeyCode == Keys.U)
            {
                game.Attack(Yön.Up, random);
                UpdateCharacters();

            }
            if (e.KeyCode == Keys.H)
            {
                game.Attack(Yön.Left, random);
                UpdateCharacters();

            }
            if (e.KeyCode == Keys.K)
            {
                game.Attack(Yön.Right, random);
                UpdateCharacters();

            }
            if (e.KeyCode == Keys.J)
            {
                game.Attack(Yön.Down, random);
                UpdateCharacters();

            }
        }
    }
}
