using Newtonsoft.Json.Linq;
using PuzzleCareerSwitch.Resolver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProject
{
    public class OrderBlocksShould
    {
        [Fact]
        public void ValidateLastItemOrderBlocks()
        {
            string token = "ed7a6c3a-5700-42a5-971d-61e89c4e0207";
            List<JToken> blocks =  new List<JToken>
            {
                "apL9B7NAmZKgEaVvNVdKFXTmCSEz4kMzVVRyqOBsWQ6GOHSY1p4Tvc6peGfOcJUCZhTHsdUgV1vN4kGXi4041iVl6wCFsErjkcV9",
                "1oEOdqKOVejtWhR1wkG7Sw0tNbzHNgIfmMOLqOkqmzWZYNQYgo9aQQVcxp9m6Lrz4Tg27CTAiRRlT3t6VanfXBpxX5RYaXn7UtWl",
                "iEerxuXl44rKgsNJLCQxq33B85ZLUxz5x3RH4RbrQRvFqO30pN9s5aKOWFhbMFABiellEPH1QCjwuIYqdRhoM95JOXf1H3Sw8TbG",
                "t7weh1cEiemb8LmwMUYKIRnjkO8PM31PMUpms7oVcpNEgLt4tBXKgdh4B2XCKFkmlQtXZ8BuzlvP2ntazJQkAWGmjuqVlJmCDvhU",
                "OZESzHxytG4eTHoBiicjfCDuPKCsYkWo7WM0zey1jFHIeswbwAlqZf1QvOZMDNEgxMFJwoUx0Q9tBddiQIM4QfOONDXcZeHeynPr",
                "TZiTOgfmXhqEelzDIR5B7fJ2lJpPmDl5jyau8YzA54xNT8A4xuGplBzkO00sDkfWMmGdP0FXd3tNRYMOvBDtwj504FvODc1AgwJn",
                "2bAKaKUcxQC9BNNvmuQENnA1teQ4WPi6K6df2nG56OiL6JG2bnq68ZBG5AzKAd2BzYmRvfqNdp74wMHW7cZnGUND7qt6DN6oWwfO",                
                "SppYY03kRSsTctDIBsuF8M1jN413dCbcK0X1nrxObINjDMk16SaakXF8URUBC3FbacJfTmhrd3TsZ6nriaPiQCFZBTDqDzo0F40p",
                "fwi78rv3FtIL7FxHmoxTzTpxeoGiU4okpvScsl5tvFn2247OpKw8xujkGY3qHWUFVQMRLR59PdpIeBDuus3lMqdUceiNgoEuG26j"
            };
            ArrayList sortedBlocks = new ArrayList
            {
                "apL9B7NAmZKgEaVvNVdKFXTmCSEz4kMzVVRyqOBsWQ6GOHSY1p4Tvc6peGfOcJUCZhTHsdUgV1vN4kGXi4041iVl6wCFsErjkcV9",
                "1oEOdqKOVejtWhR1wkG7Sw0tNbzHNgIfmMOLqOkqmzWZYNQYgo9aQQVcxp9m6Lrz4Tg27CTAiRRlT3t6VanfXBpxX5RYaXn7UtWl",
                "iEerxuXl44rKgsNJLCQxq33B85ZLUxz5x3RH4RbrQRvFqO30pN9s5aKOWFhbMFABiellEPH1QCjwuIYqdRhoM95JOXf1H3Sw8TbG",
                "t7weh1cEiemb8LmwMUYKIRnjkO8PM31PMUpms7oVcpNEgLt4tBXKgdh4B2XCKFkmlQtXZ8BuzlvP2ntazJQkAWGmjuqVlJmCDvhU",
                "OZESzHxytG4eTHoBiicjfCDuPKCsYkWo7WM0zey1jFHIeswbwAlqZf1QvOZMDNEgxMFJwoUx0Q9tBddiQIM4QfOONDXcZeHeynPr",
                "TZiTOgfmXhqEelzDIR5B7fJ2lJpPmDl5jyau8YzA54xNT8A4xuGplBzkO00sDkfWMmGdP0FXd3tNRYMOvBDtwj504FvODc1AgwJn",
                "2bAKaKUcxQC9BNNvmuQENnA1teQ4WPi6K6df2nG56OiL6JG2bnq68ZBG5AzKAd2BzYmRvfqNdp74wMHW7cZnGUND7qt6DN6oWwfO",
                "fwi78rv3FtIL7FxHmoxTzTpxeoGiU4okpvScsl5tvFn2247OpKw8xujkGY3qHWUFVQMRLR59PdpIeBDuus3lMqdUceiNgoEuG26j",
                "SppYY03kRSsTctDIBsuF8M1jN413dCbcK0X1nrxObINjDMk16SaakXF8URUBC3FbacJfTmhrd3TsZ6nriaPiQCFZBTDqDzo0F40p"
            };


            ArrayList result = ResolverOrderBlocks.OrderBlocks(token, blocks);


            Assert.True(result[8] == sortedBlocks[8]);


        }
    }
}
