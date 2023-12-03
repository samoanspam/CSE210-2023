using System;

class Activity
{
    private string _name = "";
    private int _duration = 0;
    private string _description = "";
    private string _welcomeMessage = "";
    private string _goodbyeMessage = "";

    public Activity()
    {
        // Nothing
    }
    public Activity(string name, int duration, string description, string welcomeMessge, string goodbyeMessage)
    {
        _name = name;
        _duration = duration;
        _description = description;
        _welcomeMessage = welcomeMessge;
        _goodbyeMessage = goodbyeMessage;
    }

    public void Display()
    {
        System.Console.WriteLine(_name);
        System.Console.WriteLine (_description);
        System.Console.WriteLine(_welcomeMessage);
        System.Console.WriteLine(_goodbyeMessage);
        System.Console.WriteLine(_duration);  
    }

    public void PauseAnimation(int delay)
    {
        int timer = 1;
        double time = delay;
        while (time > 0)
        {
            Console.Write("\\");
            
            Thread.Sleep(500);

            time -= timer;
            Console.Write("\b\b");
            Console.Write("/");

            Thread.Sleep(500);

            Console.Write("\b\b"); // Erase the + character  
        }
    }
}