using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Ex1;

[Index(nameof(Codi), IsUnique = true)] 
public class Xip
{
    [Required]
    public int XipID { get; set; }
    
    [Required]
    [MaxLength(15)]
    [MinLength(15)]
    public string Codi { get; set; }
    
    [Required]
    public DateTime DataImplantacio { get; set; }
    public virtual Animal Animal { get; set; }
    
    public Xip(){}

    public Xip(String codi)
    {
        this.Codi = codi;
        this.DataImplantacio = DateTime.Now;
    }
}