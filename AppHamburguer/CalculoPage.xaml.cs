namespace AppHamburguer;

public partial class CalculoPage : ContentPage
{
	public CalculoPage()
	{
		InitializeComponent();
	}

    private void OnLimparClicked(object sender, EventArgs e)
    {
        txtGasolina.Text = "";
        txtEtanol.Text = "";    
    }

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        //1: Declaração prévia das variáveis
        double etanol;
        double gasolina;

        //2. Validação dos campos de texto
        if (double.TryParse(txtEtanol.Text, out etanol) && etanol > 0 &&
            double.TryParse(txtGasolina.Text, out gasolina) && gasolina > 0)
        {
            //3. Cálculo da razão/proporção entre Etanol e Gasolina
            //Regra dos 70%: Se o preço do etanol for até 70% do preço da gasolina, vale a pena usar
            double proporcao = etanol / gasolina;

            //4. Verificação de qual combustível compensa mais
            if (proporcao <= 0.70)
            {
                //Exibe a proporção em formato percentual e com uam casa decimal
                lblResultado.Text = $"Vale a pena abestecer com ETANOL!\n(Proporção: {proporcao:P1})";
                lblResultado.TextColor = Colors.Green;
            }
            else
            {
                lblResultado.Text = $"Vale a pena abastecer com GASOLINA!\n(Proporção: {proporcao:P1})";
                lblResultado.TextColor = Colors.Blue;
            }
        }
        else
        {
            //Mensagem de erro caso algum campo esteja vazio ou inválido
            lblResultado.Text = "Por favor, digite os valores válidos e maiores que zero para o etanol e a gasolina,";      
            lblResultado.TextColor = Colors.Red;

        }
    }
 }