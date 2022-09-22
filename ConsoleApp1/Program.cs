using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //클래스 불러옴
            player player = new player();
            monster monster = new monster();


            Console.WriteLine(monster.at);
            Console.WriteLine( player.att);

            Console.ReadLine();


            //player의 AddAt의 함수에서 10추가함
            player.AddAt(10);

            player.fight(monster.at);

            Console.WriteLine(player.att);
            Console.ReadLine();

            player.hp -= monster.at;


            

        }
      
    }

}
