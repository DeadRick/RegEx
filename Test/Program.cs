using System;
using System.Threading; //Для создания пауз в мелодии
class Program
{
    static void Main(string[] args)
    {
        refrenSolo();
        coupleSolo();
        refrenSolo();
    }
    //Jingle Bells
    static void refrenSolo()
    {
        Console.Beep(659, 300);
        Console.Beep(659, 300);
        Console.Beep(659, 300);
        Thread.Sleep(300);
        Console.Beep(659, 300);
        Console.Beep(659, 300);
        Console.Beep(659, 300);
        Thread.Sleep(300);
        Console.Beep(659, 300);
        Console.Beep(783, 300);
        Console.Beep(523, 300);
        Console.Beep(587, 300);
        Console.Beep(659, 300);
        Console.Beep(261, 300);
        Console.Beep(293, 300);
        Console.Beep(329, 300);
        Console.Beep(698, 300);
        Console.Beep(698, 300);
        Console.Beep(698, 300);
        Thread.Sleep(300);
        Console.Beep(698, 300);
        Console.Beep(659, 300);
        Console.Beep(659, 300);
        Thread.Sleep(300);
        Console.Beep(659, 300);
        Console.Beep(587, 300);
        Console.Beep(587, 300);
        Console.Beep(659, 300);
        Console.Beep(587, 300);
        Thread.Sleep(300);
        Console.Beep(783, 300);
        Thread.Sleep(300);
        Console.Beep(659, 300);
        Console.Beep(659, 300);
        Console.Beep(659, 300);
        Thread.Sleep(300);
        Console.Beep(659, 300);
        Console.Beep(659, 300);
        Console.Beep(659, 300);
        Thread.Sleep(300);
        Console.Beep(659, 300);
        Console.Beep(783, 300);
        Console.Beep(523, 300);
        Console.Beep(587, 300);
        Console.Beep(659, 300);
        Console.Beep(261, 300);
        Console.Beep(293, 300);
        Console.Beep(329, 300);
        Console.Beep(698, 300);
        Console.Beep(698, 300);
        Console.Beep(698, 300);
        Thread.Sleep(300);
        Console.Beep(698, 300);
        Console.Beep(659, 300);
        Console.Beep(659, 300);
        Thread.Sleep(300);
        Console.Beep(783, 300);
        Console.Beep(783, 300);
        Console.Beep(698, 300);
        Console.Beep(587, 300);
        Console.Beep(523, 600);
        Thread.Sleep(600);
    }
    static void coupleSolo()
    {
        Console.Beep(392, 300);
        Console.Beep(659, 300);
        Console.Beep(587, 300);
        Console.Beep(523, 300);
        Console.Beep(392, 600);
        Thread.Sleep(300 * 2);
        Console.Beep(392, 300);
        Console.Beep(659, 300);
        Console.Beep(587, 300);
        Console.Beep(523, 300);
        Console.Beep(440, 600);
        Thread.Sleep(600);
        Console.Beep(440, 300);
        Console.Beep(698, 300);
        Console.Beep(659, 300);
        Console.Beep(587, 300);
        Console.Beep(783, 600);
        Thread.Sleep(600);
        Console.Beep(880, 300);
        Console.Beep(880, 300);
        Console.Beep(783, 300);
        Console.Beep(622, 300);
        Console.Beep(659, 600);
        Thread.Sleep(600);
        Console.Beep(392, 300);
        Console.Beep(659, 300);
        Console.Beep(587, 300);
        Console.Beep(523, 300);
        Console.Beep(392, 600);
        Thread.Sleep(600);
        Console.Beep(392, 300);
        Console.Beep(659, 300);
        Console.Beep(587, 300);
        Console.Beep(523, 300);
        Console.Beep(440, 600);
        Thread.Sleep(600);
        Console.Beep(440, 300);
        Console.Beep(698, 300);
        Console.Beep(659, 300);
        Console.Beep(587, 300);
        Console.Beep(783, 600);
        Thread.Sleep(600);
        Console.Beep(880, 300);
        Console.Beep(783, 300);
        Console.Beep(698, 300);
        Console.Beep(587, 300);
        Console.Beep(523, 600);
        Thread.Sleep(600);
    }
}