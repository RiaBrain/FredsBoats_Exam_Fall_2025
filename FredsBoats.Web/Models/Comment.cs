using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FredsBoats.Web.Models
{
    [Table("Comment")]
    public class Comment
    {
    [Key]
    [Column("commentID")]
    public int CommentId {get;set;}

    [Column("content")]
    [StringLength(100)]
    public string Content {get;set;}

    [Column("author")]
    [StringLength(20)]
    public string Author {get;set;} 

    [Column("created_At")]
    public DateTime CreatedAt{get;set;}

    [Column("fkboatid")]
    public int boatId {get;set;}

    [ForeignKey("BoatId")]
    public Boat Boat{get;set;}

    }

    
}