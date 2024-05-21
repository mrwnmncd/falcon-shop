namespace App.Environment;

internal abstract class Constants {
    public const string DatabaseUrl = "falcons.sqlite";

    public const string StaffType = "Staff"; /* TODO: create a class for this */
    public const string StudentType = "Student"; /* TODO: create a class for this */

    internal abstract class Assets {
        public static string Products(string file) => $"Assets/Products/{file}";
        public const string BackdropUI = "Assets/GUI";
    }
}