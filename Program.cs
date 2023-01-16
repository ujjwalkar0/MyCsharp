namespace Clinisys
{
    public class Q{

        // public int a = 9;

        public static void newMethode(params int[] a){
            // Q d = new Q();
            Console.WriteLine("Your static value: "+ a);
        }
    }
    class Hello
    {
        public static void Main(String[] args){
            Q s = new Q();
            // s.a = 5;
            Q.newMethode(new int[] {1,5,8});
            Console.Write("Enter a Number: ");
            int n = Int16.Parse(Console.ReadLine());
            Console.WriteLine("You have entered: "+ n);
        }
    }
}