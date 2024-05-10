using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RaceDb.Models;
using RaceDb.Data;
using System.Linq;
using System.Reflection;



namespace RaceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            InitialiseData initialiseData = new InitialiseData();
            StagingArea stagingArea = new StagingArea();
        }
    }
}
