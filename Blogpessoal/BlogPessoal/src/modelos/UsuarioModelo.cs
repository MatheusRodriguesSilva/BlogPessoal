using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blogpessoal.src.modelos
{
    [Table("tb_usuario")]
    public class UsuarioModelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,StringLength(50)]
        public string Nome { get; set; }

        [Required,StringLength(30)]
        public string Email { get; set; }
        [Required, StringLength(30)]
        public string Senha { get; set; }

        public string Foto { get; set; }

        public void NovoUsuarioDTO(string nome, string email, string senha, string foto)
        {   Nome = nome;
            Email = email;
            Senha = senha;
            Foto = foto;
        }
    }
}
