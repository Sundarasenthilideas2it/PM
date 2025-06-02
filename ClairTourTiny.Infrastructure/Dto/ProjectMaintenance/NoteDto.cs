using System.ComponentModel.DataAnnotations.Schema;

public class NoteDto
{
    [Column("entityno")]
    public string EntityNo { get; set; } = string.Empty;

    [Column("Notes")]
    public string? Notes { get; set; }
}
