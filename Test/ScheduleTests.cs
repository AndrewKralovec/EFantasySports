using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer; 
using System.Data.SqlClient;
using EFantasySports.Data; 
using EFantasySports.Models; 
using EFantasySports.Models.Game; 
using EFantasySports.Controllers; 


namespace EFantasySports.Test  
{
    public class ScheduleTests {
        private readonly GameDbContext context ; 
        public ScheduleTests(){
        }
        [Fact]
        public void ReadTest()
        {
            string connetionString = null; 
            connetionString = "Data Source=192.168.1.17;Initial Catalog=Leagues;User ID=SA;Password=Linux01?" ;
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Players", con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int weight = reader.GetInt32(0); 
                        string name = reader.GetString(1);
                        string breed = reader.GetString(2);
                        string car = reader.GetString(3);

                        Console.WriteLine(new Player() { PlayerID = weight, LastName = name, FirstName = breed, Postion = car });
                    }
                }
            }
            Assert.Equal(1,1);
        }
        [Fact]
        public void ScheduleLeague() {
            Assert.Equal(1,1); 
        }
    }
}