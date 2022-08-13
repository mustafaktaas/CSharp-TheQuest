using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuestAlgoProje
{
    public class Game
    {
        public List<Düşman> Enemies;
        public Silah WeaponInRoom;

        private Oyuncu player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public Size PlayerSpriteSize { get { return player.SpriteSize; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } } //prop

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Oyuncu(this,
                new Point(boundaries.Left + 10, boundaries.Top + 70),
                new Size(30, 30));
        }

        public void Move(Yön direction, Random random)
        {
            player.Move(direction);
            foreach (Düşman enemy in Enemies)
            {
                enemy.Move(random);
            }
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public bool CheckPotionUsed(string potionName)
        {
            return player.CheckPotionUsed(potionName);
        }

        public void HitPlayer(int maxDamage, Random random)  //vurduğu hasar
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public void Attack(Yön direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Düşman enemy in Enemies)
            {
                if (!enemy.Dead)
                {
                    enemy.Move(random);
                }
            }
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(
                boundaries.Left
                    + random.Next(boundaries.Right / 10 - boundaries.Left / 10)
                    * 10,
                boundaries.Top
                    + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10)
                    * 10);
        }

        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Düşman>();
                    Enemies.Add(new Yarasa(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new Kılıç(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies.Clear();
                    Enemies.Add(new Hayalet(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new Maviİksir(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies.Clear();
                    Enemies.Add(new Hortlak(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new Yay(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies.Clear();
                    Enemies.Add(new Yarasa(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Hayalet(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = null;
                    if (CheckPlayerInventory("Bow"))
                    {
                        if (!CheckPlayerInventory("Blue Potion")
                                || (CheckPlayerInventory("Blue Potion")
                                    && CheckPotionUsed("Blue Potion")))
                        {
                            WeaponInRoom = new Maviİksir(this, GetRandomLocation(random));
                        }
                    }
                    else
                    {
                        WeaponInRoom = new Yay(this, GetRandomLocation(random));
                    }
                    break;
                case 5:
                    Enemies.Clear();
                    Enemies.Add(new Yarasa(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Hortlak(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new Kırmızıİksir(this, GetRandomLocation(random));
                    break;
                case 6:
                    Enemies.Clear();
                    Enemies.Add(new Hayalet(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Hortlak(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = new Topuz(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies.Clear();
                    Enemies.Add(new Yarasa(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Hayalet(this, GetRandomLocation(random), new Size(30, 30)));
                    Enemies.Add(new Hortlak(this, GetRandomLocation(random), new Size(30, 30)));
                    WeaponInRoom = null;
                    if (CheckPlayerInventory("Mace"))
                    {
                        if (!CheckPlayerInventory("Red Potion")
                                || (CheckPlayerInventory("Red Potion")
                                    && CheckPotionUsed("Red Potion")))
                        {
                            WeaponInRoom = new Kırmızıİksir(this, GetRandomLocation(random));
                        }
                    }
                    else
                    {
                        WeaponInRoom = new Topuz(this, GetRandomLocation(random));
                    }
                    break;
                case 8:
                    Application.Exit();
                    break;
            }
        }
    }
}
