using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;
        private Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(53, 40, 310, 115));
            game.NewLevel(random);
            UpdateCharacters();
        }

        public void UpdateCharacters()
        {
            Player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            if (!showBat)
            {
                bat.Visible = false;
                batHitPoints.Text = "";
            }
            else
                bat.Visible = true;

            if (!showGhost)
            {
                ghost.Visible = false;
                ghostHitPoints.Text = "";
            }
            else
                ghost.Visible = true;

            if (!showGhoul)
            {
                ghoul.Visible = false;
                ghoulHitPoints.Text = "";
            }
            else
                ghoul.Visible = true;

            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword; break;
                case "Blue Potion":
                    weaponControl = bluePotion; break;
                case "Bow":
                    weaponControl = bow; break;
                case "Red Potion":
                    weaponControl = redPotion; break;
                case "Mace":
                    weaponControl = mace; break;
                default:
                    break;
            }
            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
            else
            {
                weaponControl.Visible = true;
            }

            if (game.CheckPlayerInventory("Sword"))
            {
                swordIcon.Visible = true;
                if (!game.IsEquippedWeaponNull())
                {
                    if (game.GetEquippedWeaponName() == "Sword")
                    {
                        swordIcon.BorderStyle = BorderStyle.FixedSingle;
                    }
                }
            }

            if (game.CheckPlayerInventory("Blue Potion"))
            {
                bluePotionIcon.Visible = true;
            }
            else
            {
                bluePotionIcon.Visible = false;
            }

            if (game.CheckPlayerInventory("Bow"))
            {
                bowIcon.Visible = true;
            }

            if (game.CheckPlayerInventory("Red Potion"))
            {
                redPotionIcon.Visible = true;
            }
            else
            {
                redPotionIcon.Visible = false;
            }

            if (game.CheckPlayerInventory("Mace"))
            {
                maceIcon.Visible = true;
            }

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                if (game.Level > 6)
                    Application.Exit();
                else
                {
                    game.NewLevel(random);
                    UpdateCharacters();
                }
            }
        }

        private void leftMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void upMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void rightMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void downMove_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void leftAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void upAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void rightAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void downAttack_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void swordIcon_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword"))
            {
                hideIconBorders();
                game.Equip("Sword");
                swordIcon.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void bluePotionIcon_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                hideIconBorders();
                game.Equip("Blue Potion");
                bluePotionIcon.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void bowIcon_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                hideIconBorders();
                game.Equip("Bow");
                bowIcon.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void redPotionIcon_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                hideIconBorders();
                game.Equip("Red Potion");
                redPotionIcon.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void maceIcon_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                hideIconBorders();
                game.Equip("Mace");
                maceIcon.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void hideIconBorders()
        {
            swordIcon.BorderStyle = BorderStyle.None;
            bluePotionIcon.BorderStyle = BorderStyle.None;
            bowIcon.BorderStyle = BorderStyle.None;
            redPotionIcon.BorderStyle = BorderStyle.None;
            maceIcon.BorderStyle = BorderStyle.None;
        }
    }
}
