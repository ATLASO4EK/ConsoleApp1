namespace ConsoleApp1{
    public class Product{
        public string name { get { return name; } set { name = value; }}
        public int cost{ get { return cost; } set { cost = value; }}
        public int quanity{ get { return quanity; } set { quanity = value; } }


        public Product() { }
        public Product(string name, int cost, int quanity){
            this.name = name;
            this.cost = cost;
            this.quanity = quanity;
        }

    }

}