using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PuzzleCareerSwitch.Model;
using PuzzleCareerSwitch.Resolver;

namespace PuzzleCareerSwitch
{
    class Program
    {       
        static void Main(string[] args)
        {
            //string token = "ed7a6c3a-5700-42a5-971d-61e89c4e0207";
            string token = RequestHandler.GetToken();
            var blocks = RequestHandler.GetBlocks(token).Children().ToList();
            
            ArrayList sortedBlocks = ResolverOrderBlocks.OrderBlocks(token, blocks);

            foreach(string block in sortedBlocks)
            {
                Console.WriteLine(block);
            }
            Console.ReadKey();
        }        
    }
}
