using System.ComponentModel.DataAnnotations;
namespace moment2.Models;

public class DogModel
{
  //properties
  [Required(ErrorMessage = "Ange ett namn")]
  [Display(Name = "Namn: ")]
  //max längd 20
  [MaxLength(20)]
  public string? Name { get; set; }


  [Required(ErrorMessage = "Ange en ras")]
  [Display(Name = "Ras: ")]
  public string? Breed { get; set; }


  [Required(ErrorMessage = "Ange hundens ålder")]
  [Range(0, 30, ErrorMessage = "Ålder måste vara mellan 0 och 30.")]
  [Display(Name = "Ålder: ")]
  public int? Age { get; set; }

  [Required(ErrorMessage = "Ange en färg")]
  [Display(Name = "Färg: ")]
  public string? Color { get; set; }

  [Display(Name = "Vaccinerad: ")]
  //bool för att ange ja eller nej
  public bool IsVaccinated { get; set; }

  //felmeddelande
  [Required(ErrorMessage = "Ange ett födelsedatum")]
  [Display(Name = "FödelseDatum: ")]
  //Dateum proprttie
  public DateTime? BirthDate { get; set; }
}