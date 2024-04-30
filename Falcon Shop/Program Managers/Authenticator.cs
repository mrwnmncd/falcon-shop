using System.Diagnostics;

public class Authenticator {
    public static bool Authenticate(string username, string password) {
        var loginCredentials = FileManager.ReadFromFile(CONSTANTS.LOGIN_CREDENTIALS);
        foreach (var line in loginCredentials) {
            var credentials = line.Split(";");
            if (
                (credentials[1] == username || credentials[0] == username) // username can be username or id
                && credentials[2] == password
            ) return true;
        }

        return false;
    }
}