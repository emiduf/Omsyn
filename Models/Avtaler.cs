using System; 
namespace Omsyn.Models;


public class Avtaler
{
    public int Id { get; set; } // PK 

    public string KlientId { get; set; } // FK til klient 
    public string PersonalId { get; set; } // FK til personal

    public DateTime Tid { get; set; }
    public string Oppgave { get; set; } = string.Empty;
    public string? Notat { get; set; }
}




