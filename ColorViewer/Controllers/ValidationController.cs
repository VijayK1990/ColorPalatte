using ColorViewer.Models;
using System.IO;
using System.Text.RegularExpressions;

namespace ColorViewer.Controllers
{
    public static class ValidationController
    {
        private const string HEX_VALIDATOR = "([A-Fa-f0-9]{8})$";

        /// <summary>
        ///Validates the Color Code
        /// </summary>
        /// <param name="ColorCode">Color Code string</param>
        /// <returns>Status of Color validation</returns>
        public static Match ValidateColorCode(string ColorCode)
        {
            return Regex.Match(ColorCode, HEX_VALIDATOR);
        }

        /// <summary>
        ///Verifies the existance of SQLite Database
        /// </summary>
        /// <returns>Current file status</returns>
        public static bool ValidateSQLiteDbExist()
        {
            //return File.Exists(string.Concat(Application.ExecutablePath, ));
            return File.Exists(new SQLiteConnectionDetails().DataSource);
        }
    }
}
