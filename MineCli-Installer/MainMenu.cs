using System;

public static class MainMenu
{
    public static void ShowOptions()
    {
        Console.WriteLine("Welcome to the MineCLI Installer");
        Console.WriteLine("\n--------------------------------");
        Console.WriteLine(@"
Type 1 if you want to add your mods to Minecraft
Type 2 if you want to add your resource packs to Minecraft
Type 3 if you want to add your shader packs to Minecraft
Type 4 if you want to add mods, resource, and shader packs to Minecraft
Type 0 if you want to exit
");
    }
}
