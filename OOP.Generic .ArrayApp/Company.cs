namespace OOP.Generic_.ArrayApp
{
    public struct Company
    {
       

        public int İD { get; set; }
        public string name { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"{İD,-5}" +
                $" {name,-25}" +
                $"{Country,-10}";
        }

    }

}
