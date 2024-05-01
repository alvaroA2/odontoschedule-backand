using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odontoschedule_backand.Models
{

    [Table("Consumos")]
    public class Consumo

    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a quilometragem!")]
        public int km { get; set; }

        [Display(Name ="Tipo combustivel")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name ="Veículo")]
        [Required(ErrorMessage = "Obrigatorio informar o veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo veiculo { get; set; }

       

    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol

    }

}
