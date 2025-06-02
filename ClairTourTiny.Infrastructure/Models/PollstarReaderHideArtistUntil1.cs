using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarReaderHideArtistUntil1
{
    public int PollstarArtistId { get; set; }

    public string UserName { get; set; } = null!;

    public DateOnly HideUntilDate { get; set; }

    public int SongkickArtistId { get; set; }

    public virtual PollstarArtist PollstarArtist { get; set; } = null!;

    public virtual Pjtfrusr UserNameNavigation { get; set; } = null!;
}
