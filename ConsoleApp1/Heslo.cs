namespace SpravceHesel
{

    interface IHeslo
    {
        int DelkaHesla();
        int MaxDelkaHesla();
        int MinDelkaHesla();
    }

    class Heslo: IHeslo
    {
        private String heslo;
        public static int maxDelkaHesla = 20;
        private static int minDelkaHesla = 8;
        public int DelkaHesla(){
            return 0;
        }
        public int MaxDelkaHesla(){
            return maxDelkaHesla;
        }
        public int MinDelkaHesla(){
            return minDelkaHesla;
        }

    }




}