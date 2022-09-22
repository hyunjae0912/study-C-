using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp1
{
    public class player
    {
        public int att=10;
        public int hp=100;

        public int AddAt(int a)
        {
            //공격력 증가
            a = 10;
            //att up
            att += a;
            return (att);
        }


        public void fight(int monsteratt)
        {
            //player의hp가 선언 되있으니 player 생략
            hp -= monsteratt;
        }
    }
}