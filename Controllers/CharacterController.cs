using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace CodingInterview3.Controllers;

public class CharacterController : ControllerBase
{

    // @todo fix code
    // @todo make it return array of character
    // @todo add error in case we cannot connect
    // @todo add new field isTheLordSnow that checks if it's alias is "Lord Snow" using CharacterClassification

    // for now we want only the first 10 of page 59
    [HttpGet]
    public Task<string> RetrieveAll(HttpClient httpClient)
    {

        var response = await httpClient.GetAsync("https://anapioficeandfire.com/api/characters?page=59&pageSize=10");

        var jsonResponse = await response.Content.ReadAsStringAsync();

        return jsonResponse;
    }
}
