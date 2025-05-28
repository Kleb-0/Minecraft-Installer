using System;
using System.IO;
public static class DirectoryManager
{
    private static readonly string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    private static readonly string basePath = Path.Combine(desktopPath, "MinecraftFolders");

    private static readonly string ModsPath = Path.Combine(basePath, "mods");
    private static readonly string ShadersPath = Path.Combine(basePath, "shaderpacks");
    private static readonly string ResourcePacksPath = Path.Combine(basePath, "resourcepacks");
    public static void CreateDesktopDir()
    {
        Console.WriteLine("Creating directories in the workspace...");
        Directory.CreateDirectory(ModsPath);
        Directory.CreateDirectory(ShadersPath);
        Directory.CreateDirectory(ResourcePacksPath);
        Console.WriteLine("Created directories sucesfully!");
    }

    public static void VerifyDesktopDir()
    {
        if (!Directory.Exists(basePath)) CreateDesktopDir();
    }

    public static void MoveDirectories()
    {
        string option = Console.ReadLine()!;
        int intOption = int.Parse(option);

        string userProfilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string minecraftPath = Path.Combine(userProfilePath, "AppData", "Roaming", ".minecraft");

        switch (intOption)
        {
            case 1:
                Console.WriteLine($"\nMoving mods from {ModsPath} to {Path.Combine(minecraftPath, "mods")}");
                VerifyDesktopDir();

                string[] mods = Directory.GetFiles(ModsPath, "*.jar");

                foreach (string mod in mods) File.Move(mod, Path.Combine(minecraftPath, "mods", Path.GetFileName(mod)));

                Console.WriteLine("\nMods moved sucessfully! Enjoy :D");

                break;
            case 2:
                Console.WriteLine($"\nMoving resource packs from {ResourcePacksPath} to {Path.Combine(minecraftPath, "resourcepacks")} ...");
                VerifyDesktopDir();

                string[] resourcepacks = Directory.GetFiles(ResourcePacksPath, "*.zip");

                foreach (string resourcepack in resourcepacks) File.Move(resourcepack, Path.Combine(minecraftPath, "resourcepacks"));

                Console.WriteLine("\nResource packs moved sucessfully! Enjoy :D");

                break;
            case 3:
                Console.WriteLine($"\nMoving shaderpacks from {ShadersPath} to {Path.Combine(minecraftPath, "shaderpacks")} ...");
                VerifyDesktopDir();

                string[] shaders = Directory.GetFiles(ShadersPath, "*.zip");

                foreach (string shader in shaders) File.Move(shader, Path.Combine(minecraftPath, "shaderpacks"));

                Console.WriteLine("\nShader packs moved sucessfully! Enjoy :D");

                break;
            case 0:
                Console.WriteLine("\nExiting...");
                break;
            default:
                Console.WriteLine("\nInvalid option");
                MainMenu.ShowOptions();
                break;
        }
    }
}

