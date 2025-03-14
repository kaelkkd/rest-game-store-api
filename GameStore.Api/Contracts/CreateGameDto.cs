using System.ComponentModel.DataAnnotations;
namespace GameStore.Api.Contracts;

public record class CreateGameDto(
    [Required]
    [MaxLength(50)]
    string Name, 
    
    int GenreId,

    [Range(1, 100)]
    decimal Price,
    DateOnly ReleaseDate
);
