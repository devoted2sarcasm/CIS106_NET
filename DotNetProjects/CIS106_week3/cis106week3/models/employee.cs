namespace WeekThree.models {

    public class Employee {
        public string FirstName {get; set;}
        public string MiddleName {get; set;}
        public string LastName {get; set;}
        public string Id {get; set;}

        public string GenerateFullName() {
            return $"{FirstName} {MiddleName} {LastName}"
        }

        /// <summary>
        /// Generate a full name from the given parts
        /// </summary>
        /// <param name="firstName">Employee's First Name</param>
        /// <param name="middleName">Employee's Middle Name</param>
        /// <param name="lastName">Employee's Last Name</param>
        /// <returns>The full name as a string</returns>
        public static string GenerateFullName(string firstName, string middleName, string lastName) {
            return $"{firstName} {middleName} {lastName}"
        }
    }
}