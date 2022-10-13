using juros.Model;
namespace juros.Util;
public class Utils {
   public static Dictionary<string, double> jurosCompostos(Investimento invest)
    {
        double total = invest.vI;
        double juros = 0;
        for (int i = 0; i <= invest.meses; i++)
        {
            if (i != 0)
            {
                juros += total * invest.taxa;
                total += total * invest.taxa;
                total += invest.vM;
                invest.vM += juros;
            }
        }
        return new Dictionary<string, double>()
		{
            {"total", total},
            {"juros", juros}
        };
    }
}
    
