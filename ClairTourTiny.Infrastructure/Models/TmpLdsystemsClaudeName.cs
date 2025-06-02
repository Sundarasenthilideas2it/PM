using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpLdsystemsClaudeName
{
    public string Id { get; set; } = null!;

    public string ClaudeDescription { get; set; } = null!;

    public string? ClaudeConfidence { get; set; }

    public bool ClaudeWantsMoreDetail { get; set; }

    public string ClaudeReasoningSteps { get; set; } = null!;

    public byte? Iteration { get; set; }
}
