namespace OOP.ADONET

{
    public class Empolyee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }

        public override string ToString()
        {
            return $"{EmployeeId,-5}" +
                $"{FirstName,-25}" +
                $"{LastName,-10}";
        }
    }
}
