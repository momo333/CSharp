using System;


namespace FighterAttack
{
    class FighterAttack
    {
        static void Main()
        {
            int Px1 = int.Parse(Console.ReadLine());
            int Py1 = int.Parse(Console.ReadLine());
            int Px2 = int.Parse(Console.ReadLine());
            int Py2 = int.Parse(Console.ReadLine());
            int Fx = int.Parse(Console.ReadLine());
            int Fy = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            if(Px1>Px2)
            {
                int temp = Py1;
                Py1 = Py2;
                Py2 = temp;
            }

            int damage = 0;
            Fx += D;
            if(Px1<Fx && Fx<Px2)
            {
                if(Py1<=Fy && Fy<=Py2)
                {
                    damage += 100;
                }
            }
            if(Py1-1<=Fy && Fy-1<=Py2)
            {
                damage += 50;
            }
            if(Px1<=Fx +1  && Fx+1 <=Px2)
            {
                if(Py1<=Fy && Fy<=Py2)
                {
                    damage += 75;
                }
            }
            Console.WriteLine("{0}%", damage);

        }
    }
}
