public class Cadastro
{
    public double valor;
    public double pis;
    public double icms;
    public double confins;
    public double lucro;
    public Cadastro(double valor, double pis, double icms, double confins, double lucro)
    { 
        this.valor = valor;
        this.pis = pis;
        this.icms = icms;
        this.confins = confins;
        this.lucro = lucro;
    }
    public double CalculaTudo(double valor, double pis, double icms, double confins, double lucro)
    {
        double lucro2 = 0;
        pis = valor * (pis / 100);
        icms = valor * (icms / 100);
        confins = valor * (confins / 100);
        valor = valor + pis + icms + confins;
        lucro2 = valor * (lucro / 100);
        valor += lucro2;
        return valor;

    }
}
