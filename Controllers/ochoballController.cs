//chris Martinez
//10/27/22
//Eight Ball End Point 
//
//Peer Review: ARELY MARTINEZ -- THE PROGRAM WORKS AS INTENDED. WHEN I PRESS SEND IT RANDOMIZES DIFFERENT REPONSES. CHRIS'S CODE ALSO LOOKS NEAT AND ITS EASY TO READ. TO CHALLANGE YOURSELF TRY SPITING BACK TO RESPONSE THAT THE USER ENTERED. 

using Microsoft.AspNetCore.Mvc;

namespace MartinezC8BallEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ochoballController : ControllerBase
{
 [HttpGet]
 [Route("{PressLuck}")]

 public string luckyEight()
 {
 string [] magicResponses = {"Yes", "No", "Maybe", "Don't count on it", "Ask me Later", "Could be", "Absolutely" };

 Random rnd = new Random();

 int index = rnd.Next(magicResponses.Length);
 return magicResponses[index];

}
}
