//N. Harrison Wilkins
//10-26-2022
//ODD OR EVEN - ENDPOINTS
//THIS PRGRAM CONTAINS A CONTROLLER 'OddOrEvenController' AND ALLOWS THE user to input a number via the url and have it returned a negative or postive value,  also has data valiation
//PEER REVIEW BY : 



using Microsoft.AspNetCore.Mvc;

namespace WilkinsHOddOrEven_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    [HttpGet]
    [Route ("evaluate/{userNumber}")]
    public string OddOrEvenNumber(string userNumber, bool isNumber = false, int validNumber = 0)
    {
        isNumber = Int32.TryParse(userNumber, out validNumber);
        if(isNumber == true)
        {
        if(validNumber % 2 == 0)
        {
            return $"{userNumber} is an even number";
        }else{
            return $"{userNumber} is an odd number";
        }
        }
        return "THAT IS NOT A NUMBER!!!!";
    }
}
