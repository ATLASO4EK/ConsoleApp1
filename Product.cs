namespace ConsoleApp1{
    public class Product{
        public string name { get; set; }
        public int cost { get; set; }
        public int quanity { get; set; }
        public Product(string name, int cost, int quanity){
            this.name = name;
            this.cost = cost;
            this.quanity = quanity;
        }
        public Product() { }
    }

}