﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_Day2_OOP_Project_MudGame.Scenes;

namespace Week4_Day2_OOP_Project_MudGame
{
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*          레전드 RPG            *");
            Console.WriteLine("**********************************");
        }

        public override void Result() { }

        public override void Choice()
        {
            Console.WriteLine("1. 게임시작");
            Console.WriteLine("2. 불러오기(미구현)");
            Console.WriteLine("3. 게임종료");
        }

        public override void Wait() { }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    SceneManager.SceneLoad("Town");
                    break;
            }
        }
    }
}
