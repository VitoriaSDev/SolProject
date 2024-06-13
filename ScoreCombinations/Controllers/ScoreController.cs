using Microsoft.AspNetCore.Mvc;
using FootballScoreCombinations.Models;

namespace FootballScoreCombinations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        [HttpGet("{scores}")]
        public IActionResult GetCombinations(string scores)
        {
            var scoresArray = scores.Split('x');
            if (scoresArray.Length != 2) return BadRequest("Formato inválido");

            if (!int.TryParse(scoresArray[0], out int team1Score) ||
                !int.TryParse(scoresArray[1], out int team2Score))
            {
                return BadRequest("Pontuações inválidas");
            }

            var combinationsTeam1 = ScoreCalculator.CalculateCombinations(team1Score);
            var combinationsTeam2 = ScoreCalculator.CalculateCombinations(team2Score);

            var result = new
            {
                team1Score,
                team2Score,
                combinationsTeam1,
                combinationsTeam2,
                totalCombinations = combinationsTeam1 * combinationsTeam2
            };

            return Ok(result);
        }
    }
}
