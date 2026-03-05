using RecipeCost.Shared;
using System.Net.Http.Json;

public class IngredientService
{
    private readonly HttpClient _http;

    public IngredientService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<IngredientDto>> GetIngredientsAsync()
    {
        // This hits your .NET API endpoint
        return await _http.GetFromJsonAsync<List<IngredientDto>>("api/ingredients") ?? new();
    }

    public async Task CreateIngredientAsync(IngredientDto ingredient)
    {
        await _http.PostAsJsonAsync("api/ingredients", ingredient);
    }
}