namespace TodoBackEnd.Models
{
    public class Tarefa
    {
        public string Id { get; set; }
        public string Texto { get; set; }
        public int min { get; set; }
        public int max { get; set; }

        public float humidade { get; set; }

        public float temperatura { get; set; }
        public bool Finalizada { get; set; }


    }
}