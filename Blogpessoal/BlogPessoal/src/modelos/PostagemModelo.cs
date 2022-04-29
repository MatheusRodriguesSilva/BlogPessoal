using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blogpessoal.src.modelos
{
    [Table("tb_postagens")]
    public class PostagemModelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Titulo { get; set; }

        [Required, StringLength(100)]
        public string Descricao { get; set; }

        public string foto { get; set; }
        public string emailCriador { get; set; }
        public int idTema { get; set; }

        [ForeignKey("fk_usuario")]

        public UsuarioModelo Criador { get; set; }

        [ForeignKey("fk_tema")]

    public TemaModelo Tema { get; set; }
    }
}