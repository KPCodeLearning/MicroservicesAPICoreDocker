namespace APICoreDocker.Models
{
    public class Student : StudentID
    {
        public int Age { get; set; }
        public int Roll { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public string Section { get; set; }
    }
}
