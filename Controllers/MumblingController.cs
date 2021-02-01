using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        [HttpGet]
        public String Accum(string s)
        {
            // make a new answer string
            string answer = "";

            // for each letter (and index) in the string
            for (var index = 0; index < s.Length; index++)
            {
                var letter = s[index];

                //   loop counter index plus one times
                for (var counter = 0; counter < index + 1; counter++)
                {
                    //     if counter is zero
                    if (counter == 0)
                    {
                        //       add the capital version of the letter to the answer 
                        answer += $"{letter}".ToUpper();
                    }
                    //     else
                    else
                    {
                        //       add the lower case version of the letter ot the anser
                        answer += $"{letter}".ToLower();
                    }
                    //   end of the loop
                }

                //   if we are not at the last letter (the index equals the length of the string - 1)
                if (index != s.Length - 1)
                {
                    //     add a '-' to the answer
                    answer += "-";

                }
                // done with the loop 
            }

            return answer;
        }
    }
}