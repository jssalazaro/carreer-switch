using Newtonsoft.Json.Linq;
using PuzzleCareerSwitch.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleCareerSwitch.Resolver
{
    public static class ResolverOrderBlocks
    {
        public static ArrayList OrderBlocks(string token, List<JToken> blocks)
        {
            ArrayList orderBlocks = new ArrayList();
            bool orderEnd = true, foundSequence;
            string currentValue = blocks[0].ToString();
            blocks.Remove(blocks[0]);
            orderBlocks.Add(currentValue);
            do
            {
                foundSequence = false;
                foreach (JToken data in blocks)
                {
                    if (RequestHandler.GetIssequence(token, currentValue, data.ToString()))//webservice con currentvalue y d.string()
                    {
                        currentValue = data.ToString();
                        foundSequence = true;
                        blocks.Remove(data);
                        orderBlocks.Add(data.ToString());
                        break;
                    }
                }
                if (!foundSequence)
                    throw new ArgumentOutOfRangeException("Invalid sequence.");

                if (blocks.Count() == 0)
                {
                    orderEnd = false;
                }

            } while (orderEnd);

            return orderBlocks;
        }
    }
}
