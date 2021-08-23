namespace ExercMembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double vlrDolar(double cot, double qtdeDol)
        {
            double total = cot * qtdeDol;
            return total + total * Iof / 100;
        }
    }
}
