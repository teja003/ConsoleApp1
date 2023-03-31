using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class EventAsyncProgram
    {
        public static void main(string[] args)
        {
            ChiefGuest();
            StartDecorateStage();
            StartTransportRawMaterials();
            Food();
            Prizes();
            StartReviewSpeech();
            Console.ReadLine();
        }
        public static async Task StartDecorateStage()
        {

            Console.WriteLine("stage decotated");
            await Task.Delay(1000);
            Console.WriteLine("Venue has been checked by security team");

        }
        public static async Task Food()
        {

            Console.WriteLine("catering team preparing the food");
            await Task.Delay(11000);
            Console.WriteLine("Food is provided to all particepents");

        }
        public static async Task Prizes()
        {
            Console.WriteLine("Prizes at Venue");
            await Task.Delay(7000);
            Console.WriteLine("Prize Distribution");
        }
        public static async Task StartTransportRawMaterials()
        {

                Console.WriteLine("raw materials for food dropped at venue");

        }
        public static async Task StartReviewSpeech()
        {

                Console.WriteLine("chief guest's speech has been reviewed by PA");

        }
        public static async Task ChiefGuest()
        {
            Console.WriteLine("Pick Up the chief guest");
            await Task.Delay(5000);
            Console.WriteLine("Chief guest Started the speech");
            await Task.Delay(5000);
            Console.WriteLine("Chief guest Completed the speech");
        }
    }
    
}
