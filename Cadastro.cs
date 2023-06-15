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

        valor += valor * (pis / 100);
        valor += valor * (icms / 100);
        valor += valor * (confins / 100);
        valor += valor * (lucro / 100);
        return valor;

    }
}
