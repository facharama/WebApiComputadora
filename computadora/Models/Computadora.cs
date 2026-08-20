namespace computadora.Models
{
    public class Computadora
    {
        public string procesador { get; set; }

        public int ram { get; set; }

        public string marca { get; set; }

        public List<string> programasInstalados { get; set; }
    }
}
