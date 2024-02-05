using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesNET.Models;
using System.Collections.Generic;

namespace MoviesNET.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}