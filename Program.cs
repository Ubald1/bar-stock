int ore = 120;
int paga = 8;

int guadagno = euroMese(ore, paga);

Console.WriteLine($"Questo mese hai guadagnato: {guadagno}");

static int euroMese(int ore, int paga)
{
    Console.WriteLine($"Questo mese prendi:  {ore * paga}");
    return ore * paga;
}
