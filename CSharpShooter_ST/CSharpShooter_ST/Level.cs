﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpShooter_ST.GameObjects;
using System.Drawing;

namespace CSharpShooter_ST
{
    public class Level
    {
        protected const int cWidth = 50;
        protected const int cHeight = 50;
        public static int scale = 1;

        public static void loadLevel(String s)
        {
            initList();
            string[] file = System.IO.File.ReadAllText("Levels/" + s + ".txt").Split('\n');
            List<String[]> level = new List<String[]>();

            for (int i = 0; i < file.Length; i++)
            {
                level.Add(file[i].Split('|'));
            }

            for (int i = 0; i < level.Count; i++)
            {
                for (int o = 0; o < level[i].Length; o++)
                {
                    switch (level[i][o].Replace("[", "").Replace("]", "").Trim())
                        case "D":
                        case "WAR":
                        case "WSR":
                        case "WSB":
                        case "WSG":

                }
            }
        }

        public static void initList()
        {
            MainForm.bulletList = new List<Bullet>();
            MainForm.enemyList = new List<Enemy>();
            MainForm.wallList = new List<Wall>();
            MainForm.explosionList = new List<Explosion>();
            MainForm.weaponList = new List<Weapon>();
        }

        public static void createBorders(int x, int y)
        {
            Wall w = new Wall("Green", x, y, cWidth, cHeight);
        }

        public static void createWalls(int x, int y)
        {
            Wall w = new Wall("Red", x, y, cWidth, cHeight);
        }

        public static void createDoor(int x, int y)
        {
            Wall w = new Wall("Blue", x, y, cWidth, cHeight);
        }

        public static void createEnemies(int x, int y)
        {
            Enemy e = new Enemy(new PointF(x, y));
        }

        //public static void createKey(int x, int y)
        //{
        //    Key k = new Key(new PointF(x, y));
        //}

        public static void createWeapons(String type, int x, int y)
        {
            switch (type)

        }
    }
}