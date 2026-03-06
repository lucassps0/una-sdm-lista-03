using System.Text.Json.Serialization;
public class livro
{
  [JsonPropertyName("titulo")]
  public string Titulo { get; set; }

  [JsonPropertyName("autor")]
  public string Autor { get; set; }

  [JsonPropertyName("ano")]
  public int Ano { get; set; }

  [JsonPropertyName("genero")]
  public string Genero { get; set; }

  [JsonPropertyName("editora")]
  public string Editora { get; set; }

  [JsonPropertyName("paginas")]
  public int Paginas { get; set; }



}