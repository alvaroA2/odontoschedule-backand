using System.ComponentModel.DataAnnotations;

namespace odontoschedule_backand.Models
{
    public class Usuario
    {
        [Key]

        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o nome")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a senha")]
        [DataType(DataType.Password)]  
        public string senha { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a senha")]

        public Perfil perfil { get; set; }  
    }
    public enum Perfil
    {
        Admin,
        User

    }
    
}
