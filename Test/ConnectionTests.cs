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
using EFantasySports.Controllers; 


namespace EFantasySports.Test  
{
    public class ConnectionTests {
        [Fact]
        public void ConnectTest() {
            bool result = false; 
            string connetionString = null; 
            SqlConnection cnn ; 
            connetionString = "Data Source=192.168.1.17;Initial Catalog=Leagues;User ID=SA;Password=Linux01?" ;
            cnn = new SqlConnection(connetionString); 
            try { 
                cnn.Open(); 
                cnn.Close(); 
                result=true;  
            } 
            catch (Exception ex) { 
                Console.WriteLine(ex); 
                result=false; 
            }
            Assert.Equal(result,true);
        }
    }
}