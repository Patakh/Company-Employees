using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects.Employee;

[Serializable]
public class EmployeeForCreationDto
{
    [Required(ErrorMessage = "Имя сотрудника обязателен.")]
    [MaxLength(30, ErrorMessage = "Максимальная длина имени сотрудника 30 букв.")]
    string? Name { get; set; }

    [Required(ErrorMessage = "Возраст сотрудника обязателен.")]
    int Age { get; set; }

    [Required(ErrorMessage = "Позиция сотрудника обязателен")]
    [MaxLength(20, ErrorMessage = "Максимальная длина позиции сотрудника 30 букв.")]
    string? Position { get; set; }
}