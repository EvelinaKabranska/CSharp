namespace Cars
{
    using System;
    using System.Text;
    public class Seat : ICar
    {
        
        private string model;
        private string color;


        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        

        public string  Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaak!";
        }
        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine($"{Color} Seat { Model}")
                .AppendLine(this.Start())
                .Append(this.Stop());

            return builder.ToString();
        }
    }
}
