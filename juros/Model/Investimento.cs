namespace juros.Model;

public class Investimento
{
    public double taxa { get; set; }
    public double vM { get; set; }
    public double vI { get; set; }
    public int meses { get; set; }

    public Investimento(double taxa, double vM, double vI, int meses)
    {
        this.taxa = taxa;
        this.vM = vM;
        this.vI = vI;
        this.meses = meses;
    }
}