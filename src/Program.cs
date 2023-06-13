namespace viewer;

static class Program
{
    public static string t = "Data Source=vocabulary.db;Version=3;";
    public static string database = "vocabulary.db";
    public static string version = "0.1";
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}