using System.Diagnostics;

namespace ConsoleApp1{
    class Program
    {
        static bool isAdmin(){
            Console.Write("\nКто вы? >> ");
            string ui = Console.ReadLine();
            if (ui == "продавец") { return true; }
            return false;
        }
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
           /* products.Add("arbuz",new Product("arbuz", 100, 10));

            Console.WriteLine(products["arbuz"].cost); */

            Console.WriteLine("Магазин\n----------------");

            string ui = string.Empty;
            List<string> output = new List<string>();
            List<int> sum = new List<int>();

            while (ui.ToLower() != "выход"){

                if (isAdmin()){
                    while(ui.ToLower() != "выход продавца"){
                        Console.Write("Введите действие (добавить/изменить) >> ");
                        ui = Console.ReadLine();

                        switch (ui){
                            case "добавить": Console.Write("Введите через пробел название, стоимость, количество на складе >> ");string[] temp = Console.ReadLine().Split(' '); products.Add(temp[0],new Product(temp[0], Convert.ToInt32(temp[1]), Convert.ToInt32(temp[2]))); break;
                            case "изменить стоимость": Console.Write("Через пробел чему изменить и на какое значение >> "); string[] temp1 = Console.ReadLine().Split(' '); products[temp1[0]].cost = Convert.ToInt32(temp1[1]); break;
                            case "изменить количество": Console.Write("Через пробел чему изменить и на какое значение >> "); string[] temp2 = Console.ReadLine().Split(' '); products[temp2[0]].quanity = Convert.ToInt32(temp2[1]); break;
                            default: Console.WriteLine("Incorrect input"); break;
                        }
                        Console.Write("Если хотите выйти напишите выход продавца >> ");
                        ui = Console.ReadLine();
                    }
                } else {
                    while(ui != "выход покупателя"){
                        Console.Write("Введите товар и количество через пробел >> ");
                        string[] temp3 = Console.ReadLine().Split(' ');

                        

                        if ((Convert.ToInt32(temp3[1]) > products[temp3[0]].quanity)){
                            temp3[1] = products[temp3[0]].quanity.ToString();
                        }
                        output.Add(temp3[0]+" x "+temp3[1]+" = "+(Convert.ToInt32(temp3[1])*products[temp3[0]].cost));
                        sum.Add(Convert.ToInt32(temp3[1])*products[temp3[0]].cost);
                        products[temp3[0]].quanity -= Convert.ToInt32(temp3[1]);

                        Console.Write("Если хотите выйти - напишите выход покупателя >> ");
                        ui = Console.ReadLine();
                        
                        if(ui == "выход покупателя"){
                            Console.WriteLine("----------------");
                            foreach(string str in output){
                                Console.WriteLine(str);
                            }
                            Console.WriteLine("----------------\nИтого: "+sum.Sum()+"\n");
                        }
                    }
                }
            }
        }
    }
}
