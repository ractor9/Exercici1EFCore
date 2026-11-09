using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace Ex1;

[Index(nameof(XipID), IsUnique = true)] 
public class Animal
{
    [Required]
    public int AnimalID { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Nom { get; set; }
    
    [Required]
    public Especie Especie { get; set; }
    
    [Required]
    public bool EsFemella { get; set; }
    
    [Required]
    public DateTime DataNaixement { get; set; }

    [Required] 
    public DateTime DataEntrada { get; set; }
    
    [Range(0.1, 100)]
    public double Pes { get; set; }
    
    public bool EstaAdoptat { get; set; } = false;
    
    public DateTime? DataAdopcio { get; set; }

    [Precision(8, 2)] 
    public decimal? QuotaAdopcio { get; set; }
    
    [Required] 
    public int XipID { get; set; }

    public override string ToString()
    {
        return $"Professor {{AnimalID = {AnimalID}, Nom = {Nom}, Especie = {Especie}, EsFemella = {EsFemella}, DataNaixement = {DataNaixement}, DataEntrada = {DataEntrada}, Pes = {Pes}, EstaAdoptat = {EstaAdoptat}, DataAdopcio = {DataAdopcio}, QuotaAdopcio = {QuotaAdopcio}, XipID = {XipID}}}";
    }
    
    public Animal(){}
    public Animal(string nom, Especie especie, bool esFemella, DateTime dataNaixement, double pes, bool estaAdoptat, DateTime? dataAdopcio, decimal? quotaAdopcio, int xipId)
    {
        this.Nom = nom;
        this.Especie = especie;
        this.EsFemella = esFemella;
        this.DataNaixement = dataNaixement;
        this.DataEntrada = DateTime.Now;
        this.Pes = pes;
        this.EstaAdoptat = estaAdoptat;
        if (dataAdopcio is not null)
        {
            this.DataAdopcio = dataAdopcio;
        }
        this.QuotaAdopcio = 0;
        if (quotaAdopcio is not null)
        {
            this.QuotaAdopcio = quotaAdopcio;
        }

        this.XipID = xipId;
    }
}