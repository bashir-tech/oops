namespace oops.inheritence
{
    public class shape
    {
        public int x { get; set; }

        public int y { get; set; }
        public int hight { get; set; }
        public int MyProperty { get; set; }

        public  virtual void draw()
        {
             System.Console.WriteLine("base class drawing task....");
        }
    }
}
