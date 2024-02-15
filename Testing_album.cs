//Written by Software Engineer @Devflovv
using NUnit.Framework;
using System;
using System.IO;

namespace PhotoAlbumApp.Tests
{
    public class ProgramTests
    {
        [Test]
        public void Main_ValidInput_AlbumIdIsSet()
        {
           
            var input = "3"; 
            var reader = new StringReader(input);
            Console.SetIn(reader);

            
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main(null);
                var output = sw.ToString().Trim();

               
                Assert.IsTrue(output.Contains("Photo-Album 3:")); 
            }
        }

        [Test]
        public void Main_InvalidInput_RetryPrompted()
        {
            
            var input = "invalid\n3"; 
            var reader = new StringReader(input);
            Console.SetIn(reader);

            
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main(null);
                var output = sw.ToString().Trim();

                
                Assert.IsTrue(output.Contains("Invalid input.")); // Check if retry prompt is shown
                Assert.IsTrue(output.Contains("Photo-Album 3:")); // Check if output contains the album ID after valid input
            }
        }
    }
}
