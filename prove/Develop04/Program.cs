using System;

class Program
{
    static void Main(string[] args)
    {
        Activity AT = new Activity();
        ReflectionActivity ReflectA = new ReflectionActivity();
        ListingActivity ListA = new ListingActivity();
        BreathingActivity BreathA = new BreathingActivity();
        ReflectA.doIt();
        ListA.doIt();
        BreathA.doIt();
    }
}