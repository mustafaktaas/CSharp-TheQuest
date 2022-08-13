using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuestAlgoProje
{
    public class Oyuncu : Hareket, IFSprite
    {
        private Silah equippedWeapon;
        private int hitPoints;

        public int HitPoints { get { return hitPoints; } }
        public Size SpriteSize { get; private set; }

        private List<Silah> inventory = new List<Silah>();
        public List<string> Weapons  //prop
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Silah weapon in inventory)
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
        }

        public Oyuncu(Game game, Point location, Size spriteSize)
                : base(game, location)
        {
            hitPoints = 20;                    
            SpriteSize = spriteSize;
        }

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);    
        }

        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach (Silah weapon in inventory)
            {
                if (weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        public void Move(Yön direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, 40))             
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                }
            }
        }

        public void Attack(Yön direction, Random random)            
        {
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
            }
        }

        public bool CheckPotionUsed(string potionName)
        {
            IFIksir potion;
            bool potionUsed = true;

            foreach (Silah weapon in inventory)
            {
                if (weapon.Name == potionName && weapon is IFIksir)
                {
                    potion = weapon as IFIksir;
                    potionUsed = potion.Used;
                }
            }

            return potionUsed;
        }
    }
}
